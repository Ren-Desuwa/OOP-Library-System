Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System.Exception
Imports System.Linq ' Needed for GetPendingAccounts().Where()
Imports System.Threading.Tasks ' Needed for IsAccountActive()

Public Class AccountService
    Private ReadOnly _dbcon As DBcon

    Public Sub New(dbcon As DBcon)
        If dbcon Is Nothing Then Throw New ArgumentNullException("dbcon")
        Me._dbcon = dbcon
    End Sub

    ' ##################################################################
    ' --- 1. USER ACCOUNT FEATURES (Original Content) ---
    ' ##################################################################

    ''' <summary>
    ''' Retrieves the list of books marked as "displayed" for a specific account.
    ''' </summary>
    Public Function GetDisplayedBooksForAccount(accountId As Integer) As List(Of Book)
        ' 1. Manually open the connection using the DBcon method
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        ' 2. Start a transaction on the now-open connection
        Dim transaction As MySqlTransaction = Nothing

        Try
            ' Get the connection object and start the transaction
            transaction = _dbcon.GetConnection().BeginTransaction()

            ' 3. Instantiate the DAO with the transaction
            Dim accountDao As New AccountDAO(transaction)

            ' 4. Call the DAO method

            Dim books = accountDao.GetDisplayedBooks(accountId)

            ' 5. Commit the transaction
            transaction.Commit()

            Return books

        Catch ex As Exception
            ' 6. Rollback on error
            If transaction IsNot Nothing Then transaction.Rollback()

            Throw New Exception("Failed to load displayed books for the user.
See inner exception for details.", ex)
        Finally
            ' 7. Manually close the connection managed by DBcon
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Retrieves a list of book IDs currently marked as favorites/displayed by the account.
    ''' </summary>
    Public Function GetUsersDisplayedBookIds(accountId As Integer) As HashSet(Of Integer)

        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDao As New AccountDAO(transaction)
            Dim bookIds = accountDao.GetFavoriteBookIds(accountId)

            transaction.Commit()
            Return bookIds

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to load user's favorite book IDs.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Saves the user's new list of displayed books using a transactional DELETE/INSERT.
    ''' </summary>
    Public Sub SaveDisplayedBooks(accountId As Integer, bookIds As List(Of Integer))
        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDao As New AccountDAO(transaction)

            ' Delegate the transactional work (DELETE and INSERT) to the DAO

            accountDao.UpdateDisplayedBooks(accountId, bookIds)

            transaction.Commit()

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to save displayed books.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub

    ' ##################################################################
    ' --- 2. ADMIN/LIBRARIAN ACCOUNT MANAGEMENT (Moved from AuthService) ---
    ' ##################################################################

    ''' <summary>
    ''' Retrieves a complete list of all user accounts from the database.
    ''' </summary>
    Public Function GetAllAccounts() As List(Of Account)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim accounts = accountDAO.GetAll()
            transaction.Commit()
            Return accounts

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to retrieve all accounts: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Deletes a user account from the database by its ID.
    ''' (Used by Admin Panel and RejectAccount)
    ''' </summary>
    Public Sub DeleteAccount(accountId As Integer)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' Optional: Get the account before deleting to log its name
            Dim accountToDelete = accountDAO.GetById(accountId)
            Dim username = "Unknown"
            If accountToDelete IsNot Nothing Then
                username = accountToDelete.Username
            End If

            ' 1. Call the DAO's Delete method
            accountDAO.Delete(accountId)

            ' 2. Log the admin action
            logDAO.Create(Log.RecordAction(Nothing, "Account Deleted", $"Admin deleted account ID {accountId} ({username})."))

            ' 3. Commit the changes
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to delete account: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' Updates an existing user's information in the database.
    ''' </summary>
    Public Sub UpdateAccount(account As Account)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Call the DAO's Update method
            accountDAO.Update(account)

            ' 2. Log the admin action
            logDAO.Create(Log.RecordAction(account.AccountID, "Account Updated", $"Admin updated details for account '{account.Username}'."))

            ' 3. Commit the changes
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to update account: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' Creates a new user account as an administrator.
    ''' </summary>
    Public Function CreateAccount(account As Account, plainTextPassword As String) As Integer
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Check for duplicate username
            If accountDAO.GetByUsername(account.Username) IsNot Nothing Then
                Throw New Exception("This username is already taken.")
            End If

            ' 2. Check for duplicate email (if provided)
            If Not String.IsNullOrEmpty(account.Email) AndAlso accountDAO.GetByEmail(account.Email) IsNot Nothing Then
                Throw New Exception("This email address is already in use.")
            End If

            ' 3. Hash the plain-text password
            account.PasswordHash = Account.HashPassword(plainTextPassword)

            ' 4. Call the DAO's Create method
            Dim newAccountId As Integer = accountDAO.Create(account)

            ' 5. Log the admin action
            logDAO.Create(Log.RecordAction(newAccountId, "Account Created", $"Admin created new account '{account.Username}'."))

            ' 6. Commit the changes
            transaction.Commit()

            ' 7. Return the new ID
            Return newAccountId

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to create account: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Checks if a single account is active.
    ''' </summary>
    Public Async Function IsAccountActive(accountId As Integer) As Task(Of Boolean)
        ' Use Task.Run to avoid blocking the UI thread
        Return Await Task.Run(Function()
                                  If Not _dbcon.OpenConnection() Then
                                      Return False
                                  End If

                                  Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()
                                  Try
                                      Dim accountDAO As New AccountDAO(transaction)
                                      Dim userAccount = accountDAO.GetById(accountId)

                                      transaction.Commit() ' Commit the read

                                      If userAccount IsNot Nothing Then
                                          Return userAccount.IsActive
                                      Else
                                          Return False
                                      End If
                                  Catch ex As Exception
                                      transaction.Rollback()
                                      Return False ' Return false on error
                                  Finally
                                      _dbcon.CloseConnection()
                                  End Try
                              End Function)
    End Function

    ''' <summary>
    ''' Retrieves all inactive student accounts ("Pending").
    ''' </summary>
    Public Function GetPendingAccounts() As List(Of Account)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()
        Try
            Dim accountDAO As New AccountDAO(transaction)
            ' We re-use the GetAll() method and filter here
            Dim allAccounts = accountDAO.GetAll()
            Dim pendingAccounts = allAccounts.Where(Function(acc)
                                                        Return acc.Role = "Student" AndAlso Not acc.IsActive
                                                    End Function).ToList()

            transaction.Commit()
            Return pendingAccounts
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to retrieve pending accounts: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Approves a user account by setting IsActive = True.
    ''' </summary>
    Public Sub ApproveAccount(accountId As Integer)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()
        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)
            Dim userAccount = accountDAO.GetById(accountId)

            If userAccount IsNot Nothing Then
                userAccount.IsActive = True
                accountDAO.Update(userAccount)
                logDAO.Create(Log.RecordAction(userAccount.AccountID, "Account Approved", $"Account '{userAccount.Username}' approved by admin."))
                transaction.Commit()
            Else
                Throw New Exception("Account not found.")
            End If
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to approve account: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub




    ' SHAN CHANGES FOR GETTING LIBRARIAN ACCOUNTS

    ''' <summary>
    ''' Retrieves all librarian accounts.
    ''' </summary>
    Public Function GetLibrarianAccounts() As List(Of Account)
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim allAccounts = accountDAO.GetAll()
            Dim librarianAccounts = allAccounts.Where(Function(acc)
                                                          Return acc.Role = "Librarian"
                                                      End Function).ToList()
            transaction.Commit()
            Return librarianAccounts
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to retrieve librarian accounts: " & ex.Message)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function



    ' END CHANGES

    ''' <summary>
    ''' Rejects (deletes) a user account.
    ''' </summary>
    Public Sub RejectAccount(accountId As Integer)
        ' This now calls the local DeleteAccount method
        DeleteAccount(accountId)
    End Sub

End Class