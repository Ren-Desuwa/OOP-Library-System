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
    ''' <summary>
    ''' Performs the full transactional process for borrowing multiple books.
    ''' This is the inventory-aware replacement for the old simplified borrowing.
    ''' It validates availability, updates BookCopy status, and creates a Transaction record.
    ''' </summary>
    Public Sub ProcessBorrowing(accountId As Integer, booksToBorrow As List(Of Book))
        ' 1. Business Logic Validation
        If booksToBorrow Is Nothing OrElse booksToBorrow.Count = 0 Then
            Throw New ArgumentException("No books provided for borrowing.")
        End If

        ' 2. Transaction Management
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' Instantiate all necessary DAOs
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)

            For Each book As Book In booksToBorrow
                ' A. RE-READ THE BOOK: Get the most accurate count within this transaction
                Dim currentBook = bookDAO.GetById(book.BookID)

                If currentBook Is Nothing Then
                    Throw New Exception($"Book not found for ID: {book.BookID}.")
                End If

                ' B. INVENTORY CHECK (Business Logic)
                If Not currentBook.IsAvailable() Then
                    Throw New Exception($"Book '{currentBook.Title}' is currently not available for borrowing (0 copies left).")
                End If

                ' C. FIND AVAILABLE COPY (Delegation to DAO)
                Dim availableCopy = bookCopyDAO.GetAvailableCopyByBookId(currentBook.BookID)

                If availableCopy Is Nothing Then
                    ' This is a safeguard against inconsistent inventory data
                    Throw New Exception($"Could not find an available copy for book '{currentBook.Title}'. Inventory data inconsistent.")
                End If

                ' D. UPDATE BOOK COPY STATUS (Business Logic & Delegation to DAO)
                availableCopy.UpdateStatus("Borrowed")
                bookCopyDAO.Update(availableCopy) ' Updates the copy status to 'Borrowed'

                ' E. CREATE NEW TRANSACTION (Business Logic & Delegation to DAO)
                Dim newTransaction As New Transaction With {
                    .AccountID = accountId,
                    .CopyID = availableCopy.CopyID,
                    .TransactionType = "Borrow",
                    .DateBorrowed = DateTime.Now,
                    .DateDue = DateTime.Now.AddDays(7), ' 7-day period as per BeforeApproval.vb's original logic
                    .Fine = 0,
                    .Status = "Active"
                }

                transactionDAO.Create(newTransaction) ' Creates the new transaction record
            Next

            ' 4. Commit on success (Transaction Management)
            transaction.Commit()

        Catch ex As Exception
            ' 5. Rollback on failure (Transaction Management)
            If transaction IsNot Nothing Then transaction.Rollback()
            ' Re-throw the original error to the UI (e.g., if a book is unavailable)
            Throw ex
        Finally
            ' 6. Close the connection
            _dbCon.CloseConnection()
        End Try
    End Sub
End Class