Imports OOP_Library_System.Models
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System.Threading.Tasks

Public Class BorrowService

    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ' --- ################################################################## ---
    ' --- NEW FUNCTION TO FIX ReturnBook.vb
    ' --- ################################################################## ---

    ''' <summary>
    ''' (NEW) Processes a book return within a single database transaction.
    ''' This is the synchronous function called by the ReturnBook form.
    ''' It updates the transaction, book copy status, and credit score.
    ''' </summary>
    ''' <param name="transactionId">The ID of the transaction being returned.</param>
    ''' <param name="manualFine">The final fine amount (either auto-calculated or manually set).</param>
    ''' <param name="creditScoreChange">The amount to change the credit score by (e.g., +1 or -10).</param>
    Public Sub ProcessBookReturn(transactionId As Integer, manualFine As Decimal, creditScoreChange As Short)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Instantiate all DAOs needed for this operation
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction)
            Dim historyDAO As New CreditScoreHistoryDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 2. Get the transaction
            Dim tx As Transaction = transactionDAO.GetById(transactionId)
            If tx Is Nothing Then Throw New Exception("Transaction not found.")

            ' 3. Get the Account
            Dim account As Account = accountDAO.GetById(tx.AccountID)
            If account Is Nothing Then Throw New Exception("Account not found.")

            ' 4. Get the Book Copy
            Dim bookCopy As BookCopy = bookCopyDAO.GetById(tx.CopyID)
            If bookCopy Is Nothing Then Throw New Exception("Book copy not found.")

            ' 5. Update the Transaction
            tx.Status = "Returned"
            tx.DateReturned = DateTime.Now
            tx.Fine = manualFine ' Update with the final fine
            transactionDAO.Update(tx)

            ' 6. Update the Book Copy
            bookCopy.UpdateStatus("Available")
            bookCopyDAO.Update(bookCopy)

            ' 7. Handle Credit Score Change (if any)
            If creditScoreChange <> 0 Then
                ' 7a. Calculate new score
                Dim oldScore As Short = account.CreditScore
                Dim newScore As Short = CShort(oldScore + creditScoreChange)

                ' Clamp score between 0 and 100
                If newScore < 0 Then newScore = 0
                If newScore > CreditScoreService.SCORE_MAX Then newScore = CreditScoreService.SCORE_MAX

                ' 7b. Update the account's score
                account.CreditScore = newScore
                accountDAO.Update(account)

                ' 7c. Log the credit score change
                Dim reason As String = "On-time return"
                If creditScoreChange < 0 Then reason = "Late return"
                If manualFine > 0 And creditScoreChange < 0 Then reason = "Late return with fine"

                Dim history = New CreditScoreHistory With {
                    .ScoredAccountID = account.AccountID,
                    .AdminID = Nothing, ' System-initiated
                    .ScoreChange = creditScoreChange,
                    .NewScore = newScore,
                    .Reason = reason,
                    .TransactionID = transactionId
                }
                historyDAO.Create(history)
            End If

            ' 8. Log the return event
            logDAO.Create(Log.RecordAction(account.AccountID, "Book Return", $"Book copy ID {tx.CopyID} returned for transaction {transactionId}.", "Info"))

            ' 9. Commit the entire operation
            transaction.Commit()

        Catch ex As Exception
            ' If anything fails, roll back everything
            transaction.Rollback()
            Throw New Exception("Failed to process book return. The operation was rolled back. Error: " & ex.Message, ex)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

    ' --- END NEW FUNCTION ---

    ''' <summary>
    ''' Gets a paginated list of active transactions, supporting a multi-field search query.
    ''' </summary>
    Public Function GetBooksCurrentlyOnLoan(Optional searchTerm As String = "", Optional pageNumber As Integer = 1, Optional pageSize As Integer = 20) As List(Of BorrowedBookDetails)
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
            Dim accountDAO As New AccountDAO(transaction)

            ' 2. Get active transactions using the NEW search DAO
            ' NOTE: Pagination is applied here at the DAO level
            Dim activeTransactions = transactionDAO.SearchActiveLoans(searchTerm, pageNumber, pageSize)

            ' 3. Loop through each active transaction to find the details
            For Each tx As Transaction In activeTransactions
                ' Find the copy...
                Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)

                ' Find the main book...
                Dim book As Book = If(bookCopy IsNot Nothing, bookDAO.GetById(bookCopy.BookID), Nothing)

                ' Get the account name...
                Dim account = accountDAO.GetById(tx.AccountID)
                Dim accountName = If(account IsNot Nothing, account.Username, "Unknown")

                ' 4. Create the new helper object with the combined data
                Dim details As New BorrowedBookDetails(tx, book)
                details.BorrowerName = accountName
                detailsList.Add(details)
            Next

            transaction.Commit()
            Return detailsList

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching books on loan for returns: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' (FOR Admin UI) Retrieves all borrow requests that are "Pending" with search and pagination.
    ''' </summary>
    Public Function GetPendingBorrowRequests(Optional searchTerm As String = "", Optional pageNumber As Integer = 1, Optional pageSize As Integer = 20) As List(Of BorrowedBookDetails)
        Dim detailsList As New List(Of BorrowedBookDetails)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction)

            ' 1. Get all *pending* transactions using the NEW search DAO with pagination
            ' NOTE: Changed this call from GetPendingRequestsPaginated to SearchPendingRequests
            Dim pendingTransactions = transactionDAO.SearchPendingRequests(searchTerm, pageNumber, pageSize)

            ' 2. Get details for each one
            For Each tx As Transaction In pendingTransactions
                Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)
                Dim book As Book = Nothing
                If bookCopy IsNot Nothing Then
                    book = bookDAO.GetById(bookCopy.BookID)
                End If

                Dim account = accountDAO.GetById(tx.AccountID)
                Dim accountName = If(account IsNot Nothing, account.Username, "Unknown")

                ' 3. Create the details object
                Dim details As New BorrowedBookDetails(tx, book)
                details.BorrowerName = accountName
                detailsList.Add(details)
            Next

            transaction.Commit()
            Return detailsList
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching pending borrow requests: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets a list of all transactions that are currently active (not Returned or Rejected).
    ''' </summary>
    Public Function GetBooksCurrentlyOnLoan() As List(Of BorrowedBookDetails)
        Dim detailsList As New List(Of BorrowedBookDetails)

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        ' Note: Using BeginTransaction() even for reads ensures snapshot isolation.
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Initialize all DAOs needed for this operation
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction) ' Needed to get borrower name

            ' 2. Get all ACTIVE transactions (Status is NOT 'Returned' and NOT 'Rejected')
            Dim activeTransactions = transactionDAO.GetActiveLoans()

            ' 3. Loop through each active transaction to find the details
            For Each tx As Transaction In activeTransactions
                ' Find the copy...
                Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)

                ' Find the main book...
                Dim book As Book = If(bookCopy IsNot Nothing, bookDAO.GetById(bookCopy.BookID), Nothing)

                ' Get the account name...
                Dim account = accountDAO.GetById(tx.AccountID)
                Dim accountName = If(account IsNot Nothing, account.Username, "Unknown")

                ' 4. Create the new helper object with the combined data
                Dim details As New BorrowedBookDetails(tx, book)
                details.BorrowerName = accountName
                detailsList.Add(details)
            Next

            transaction.Commit()
            Return detailsList

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching books on loan for returns: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets all display details for an active (un-returned) transaction.
    ''' </summary>
    ''' <param name="transactionId">The ID of the transaction to find.</param>
    ''' <returns>A BorrowedBookDetails object, or Nothing if not found.</returns>
    Public Async Function GetActiveTransactionDetails(transactionId As Integer) As Task(Of BorrowedBookDetails)
        Return Await Task.Run(Function()
                                  Return GetBorrowedBookDetailsById(transactionId)
                              End Function)
    End Function

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
    ''' </summary>
    Public Function ProcessBorrowing(accountId As Integer, booksToBorrow As List(Of Book), borrowDays As Integer) As List(Of Integer)
        ' 1. Business Logic Validation
        If booksToBorrow Is Nothing OrElse booksToBorrow.Count = 0 Then
            Throw New ArgumentException("No books provided for borrowing.")
        End If

        ' --- NEW: Validate borrowDays ---
        If borrowDays <= 0 Then
            Throw New ArgumentException("Borrowing duration must be at least 1 day.")
        End If
        If borrowDays > 30 Then
            ' You can change this business rule (e.g., 14 days)
            Throw New ArgumentException("You cannot borrow a book for more than 30 days.")
        End If
        ' --- END NEW ---

        ' 2. Transaction Management
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Dim newTransactionIds As New List(Of Integer)

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
                    .DateDue = DateTime.Now.AddDays(borrowDays), ' Was: DateTime.Now.AddDays(7)
                    .Fine = 0,
                    .Status = "Pending"
                }

                ' --- MODIFIED: Get the new ID and add it to the list ---
                Dim newId As Integer = transactionDAO.Create(newTransaction)
                newTransactionIds.Add(newId)
                ' --------------------------------------------------------
            Next

            ' 4. Commit on success (Transaction Management)
            transaction.Commit()
            Return newTransactionIds
        Catch ex As Exception
            ' 5. Rollback on failure (Transaction Management)
            If transaction IsNot Nothing Then transaction.Rollback()
            ' Re-throw the original error to the UI (e.g., if a book is unavailable)
            Throw ex
        Finally
            ' 6. Close the connection
            _dbCon.CloseConnection()
        End Try
    End Function
    ''' <summary>
    ''' (FOR Admin UI) Retrieves all borrow requests that are "Pending".
    ''' </summary>
    Public Function GetPendingBorrowRequests() As List(Of BorrowedBookDetails)
        Dim detailsList As New List(Of BorrowedBookDetails)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction)

            ' 1. Get all *pending* transactions
            Dim pendingTransactions = transactionDAO.GetByStatus("Pending")

            ' 2. Get details for each one
            For Each tx As Transaction In pendingTransactions
                Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)
                Dim book As Book = Nothing
                If bookCopy IsNot Nothing Then
                    book = bookDAO.GetById(bookCopy.BookID)
                End If

                ' --- NEW: Get the account name ---
                Dim account = accountDAO.GetById(tx.AccountID)
                Dim accountName = If(account IsNot Nothing, account.Username, "Unknown")
                ' ---------------------------------

                ' 3. Create the details object
                Dim details As New BorrowedBookDetails(tx, book)
                details.BorrowerName = accountName ' (We will add this property in the next step)
                detailsList.Add(details)
            Next

            transaction.Commit() ' Read-only, but commit to close
            Return detailsList
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching pending borrow requests: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' (FOR Admin UI) Approves a borrow request.
    ''' </summary>
    Public Sub ApproveBorrowRequest(transactionId As Integer)
        UpdateBorrowStatus(transactionId, "Approved")
    End Sub

    ''' <summary>
    ''' (FOR Admin UI) Rejects a borrow request.
    ''' </summary>
    Public Sub RejectBorrowRequest(transactionId As Integer)
        ' We also need to make the BookCopy "Available" again
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)

            ' 1. Get the transaction
            Dim tx = transactionDAO.GetById(transactionId)
            If tx Is Nothing Then Throw New Exception("Transaction not found.")

            ' 2. Get the associated book copy
            Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)
            If bookCopy IsNot Nothing Then
                bookCopy.UpdateStatus("Available") ' Return copy to shelf
                bookCopyDAO.Update(bookCopy)
            End If

            ' 3. Update the transaction status to "Rejected"
            tx.Status = "Rejected"
            transactionDAO.Update(tx)

            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error rejecting request: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

    ' --- Helper function for Admin approval ---
    Private Sub UpdateBorrowStatus(transactionId As Integer, newStatus As String)
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim tx = transactionDAO.GetById(transactionId)
            If tx IsNot Nothing Then
                tx.Status = newStatus
                transactionDAO.Update(tx)
                transaction.Commit()
            Else
                Throw New Exception("Transaction not found.")
            End If
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception($"Error updating status to {newStatus}: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' (FOR Student Pop-up) Checks if all transactions in a list are approved.
    ''' </summary>
    Public Async Function AreTransactionsApproved(transactionIds As List(Of Integer)) As Task(Of Boolean)
        Return Await Task.Run(Function()
                                  If transactionIds Is Nothing OrElse Not transactionIds.Any() Then Return False
                                  If Not _dbCon.OpenConnection() Then Return False ' Timer will retry

                                  Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
                                  Try
                                      Dim transactionDAO As New TransactionDAO(transaction)
                                      For Each id As Integer In transactionIds
                                          Dim tx = transactionDAO.GetById(id)
                                          If tx IsNot Nothing AndAlso tx.Status = "Pending" Then
                                              ' Found one that is still pending, so not all are approved/rejected
                                              transaction.Rollback()
                                              Return False
                                          End If
                                      Next

                                      ' If we loop through all and none are "Pending", then the batch is processed.
                                      transaction.Commit()
                                      Return True
                                  Catch ex As Exception
                                      transaction.Rollback()
                                      Return False
                                  Finally
                                      _dbCon.CloseConnection()
                                  End Try
                              End Function)
    End Function


    ''' <summary>
    ''' (NEW) Gets all details for a single transaction by its ID.
    ''' </summary>
    Public Function GetBorrowedBookDetailsById(transactionId As Integer) As BorrowedBookDetails
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookDAO As New BookDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction)

            ' 1. Get the transaction
            Dim tx = transactionDAO.GetById(transactionId)
            If tx Is Nothing Then
                Throw New Exception("Transaction not found.")
            End If

            ' 2. Get details
            Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)
            Dim book As Book = Nothing
            If bookCopy IsNot Nothing Then
                book = bookDAO.GetById(bookCopy.BookID)
            End If

            Dim account = accountDAO.GetById(tx.AccountID)
            Dim accountName = If(account IsNot Nothing, account.Username, "Unknown")

            ' 3. Create the details object
            Dim details As New BorrowedBookDetails(tx, book)
            details.BorrowerName = accountName

            transaction.Commit()
            Return details

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching book details by ID: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

End Class