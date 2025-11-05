' Import all your DAOs and Models
Imports MySql.Data.MySqlClient
Imports System.Linq
Imports System.Threading.Tasks

Public Class LibrarianService
    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ' #################### READ (Getters) ####################

    ''' <summary>
    ''' Gets a list of all accounts with the role 'Librarian'.
    ''' This is based on the 'accounts' table in sample.md/schema.md.
    ''' </summary>
    Public Function GetAllLibrarians() As List(Of Account)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Initialize the DAO needed for this operation
            Dim accountDAO As New AccountDAO(transaction) '

            ' 2. Get ALL accounts from the database
            Dim allAccounts = accountDAO.GetAll() '

            ' 3. Filter the list in the service layer to find only librarians
            '    (Based on the 'role' column in schema.md)
            Dim librarians = allAccounts.Where(
                Function(acc) acc.Role.Equals("Librarian", StringComparison.OrdinalIgnoreCase)
            ).ToList()

            ' 4. This was a read-only operation, so we can roll back.
            transaction.Rollback()
            Return librarians

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting all librarians: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets a single account by its ID.
    ''' </summary>
    Public Function GetAccountById(accountId As Integer) As Account
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction) '
            Dim account = accountDAO.GetById(accountId) '

            transaction.Rollback() ' Read-only operation
            Return account

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting account by ID: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function


    ' #################### WRITE (Management) ####################

    ''' <summary>
    ''' Adds a new account (Librarian or Admin) to the database.
    ''' </summary>
    ''' <returns>The AccountID of the newly created account.</returns>
    Public Function AddAccount(account As Account, adminAccountId As Integer?) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction) '
            Dim logDAO As New LogDAO(transaction) '

            ' 1. Hash the password before saving (assuming password is sent plain)
            account.PasswordHash = Account.HashPassword(account.PasswordHash) '

            ' 2. Create the main account entry
            Dim newAccountId As Integer = accountDAO.Create(account) '
            account.AccountID = newAccountId

            ' 3. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Account Add", $"New account '{account.Username}' (Role: {account.Role}) created.", "Info")) '

            ' 4. Commit
            transaction.Commit()

            Return newAccountId
        Catch ex As Exception
            transaction.Rollback()
            ' Check for specific MySQL duplicate entry error
            If ex.Message.Contains("Duplicate entry") Then
                If ex.Message.Contains("UK_username") Then
                    Throw New Exception("This username is already taken.")
                ElseIf ex.Message.Contains("UK_email") Then
                    Throw New Exception("This email address is already in use.")
                ElseIf ex.Message.Contains("UK_student_id") Then
                    Throw New Exception("This Student ID is already registered.")
                End If
            End If
            Throw New Exception("Error adding new account: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Removes an account from the database.
    ''' </summary>
    Public Sub RemoveAccount(accountIdToRemove As Integer, adminAccountId As Integer?)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction) '
            Dim logDAO As New LogDAO(transaction) '

            ' (Optional) Get account details for logging before deleting
            Dim accToDelete = accountDAO.GetById(accountIdToRemove) '
            If accToDelete Is Nothing Then
                Throw New Exception("Account not found. Cannot remove.")
            End If

            ' 1. Delete the account
            accountDAO.Delete(accountIdToRemove) '

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Account Remove", $"Account '{accToDelete.Username}' (ID: {accountIdToRemove}) was removed.", "Warning")) '

            ' 3. Commit
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error removing account: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
        End Function

End Class