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



    ' --- MODIFIED FUNCTION FOR THE RETURNS TAB ---
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

    ' ... (ProcessBookReturn and GetBorrowedBooksDetails remain the same) ...

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



    ' --- NEW FUNCTION FOR THE RETURNS TAB ---
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
            ' The DAO should handle the specific query (e.g., SELECT * WHERE Status <> 'Returned' AND Status <> 'Rejected')
            ' For simplicity here, we will fetch all and filter, assuming TransactionDAO.GetAll() or similar exists.
            Dim activeTransactions = transactionDAO.GetActiveLoans()
            ' NOTE: You will need to implement TransactionDAO.GetActiveLoans() to fetch transactions 
            ' where Status is not 'Returned' and DateReturned is NULL or Status is 'Overdue', 'Borrowed', or 'DueSoon'.

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
    ''' (MODIFIED) Performs the full transactional process for returning a single book,
    ''' using the manually-set fine and credit score from the librarian.
    ''' </summary>
    Public Function ProcessBookReturn(transactionId As Integer, manualFine As Decimal, creditScoreChange As Short) As Decimal
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim transactionDAO As New TransactionDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim accountDAO As New AccountDAO(transaction)

            ' (NEW) Define DAOs for logging - (Assuming these files exist in your project)
            ' Dim creditHistoryDAO As New CreditScoreHistoryDAO(transaction)
            ' Dim penaltyDAO As New PenaltyDAO(transaction)

            ' 1. Get the transaction
            Dim tx = transactionDAO.GetById(transactionId)
            If tx Is Nothing Then Throw New Exception("Transaction not found.")
            If tx.Status = "Returned" OrElse tx.DateReturned.HasValue Then
                Throw New Exception("This book has already been returned.")
            End If

            ' 2. Update the Transaction record
            tx.DateReturned = DateTime.Now
            tx.Fine = manualFine ' <-- (MODIFIED) Use manual fine
            tx.Status = If(manualFine > 0, "Overdue", "Returned")
            transactionDAO.Update(tx)

            ' 3. Update the Book Copy status
            Dim bookCopy = bookCopyDAO.GetById(tx.CopyID)
            If bookCopy IsNot Nothing Then
                bookCopy.UpdateStatus("Available") ' Return copy to shelf
                bookCopyDAO.Update(bookCopy)
            End If

            ' 4. (NEW) Update Credit Score and log history
            Dim account = accountDAO.GetById(tx.AccountID)
            If account IsNot Nothing Then
                account.CreditScore += creditScoreChange
                If account.CreditScore < 0 Then account.CreditScore = 0
                accountDAO.Update(account)

                ' (NEW) Log the credit score change (Uncomment if you have this DAO)
                'Dim creditLog = New CreditScoreHistory With {
                '    .AccountID = account.AccountID,
                '    .ChangeAmount = creditScoreChange,
                '    .ChangeDate = DateTime.Now,
                '    .Reason = $"Book Return Transaction: {tx.TransactionID}"
                '}
                'creditHistoryDAO.Create(creditLog)
            End If

            ' 5. (NEW) Create Penalty record if fine exists (Uncomment if you have this DAO)
            ' If manualFine > 0 Then
            '     Dim penalty = New Penalty() With {
            '         .TransactionID = transactionId,
            '         .Amount = manualFine,
            '         .IsPaid = False, ' <-- Assuming fine must be paid separately
            '         .Reason = "Overdue or damaged book"
            '     }
            '     penaltyDAO.Create(penalty)
            ' End If

            ' 6. Commit changes
            transaction.Commit()
            Return manualFine

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error processing book return: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
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