Imports MySql.Data.MySqlClient

Public Class BorrowService

    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Gets a complete list of borrowed book details for a specific user.
    ''' This function joins data from Transactions, BookCopies, and Books.
    ''' </summary>
    ''' <param name="accountId">The ID of the logged-in user.</param>
    Public Function GetBorrowedBooksDetails(accountId As Integer) As List(Of BorrowedBookDetails)
        Dim detailsList As New List(Of BorrowedBookDetails)

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Initialize all DAOs needed for this operation
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)

            ' 2. Get all transactions for this user
            Dim userTransactions = transactionDAO.GetByAccountId(accountId)

            ' 3. Loop through each transaction to find the book details
            For Each tx As Transaction In userTransactions
                ' Find the copy...
                Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)

                ' Find the main book...
                Dim book As Book = Nothing
                If bookCopy IsNot Nothing Then
                    book = bookDAO.GetById(bookCopy.BookID)
                End If

                ' 4. Create the new helper object with the combined data
                Dim details As New BorrowedBookDetails(tx, book)
                detailsList.Add(details)
            Next

            ' This was a read-only operation, so we can roll back.
            transaction.Rollback()
            Return detailsList

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching borrowed books: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

End Class