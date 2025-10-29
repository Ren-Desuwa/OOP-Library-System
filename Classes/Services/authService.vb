' Import all your DAOs and Models
Imports MySql.Data.MySqlClient

Public Class AuthService
    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Attempts to log a user in.
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password">The plain-text password to verify.</param>
    ''' <returns>The full Account object if login is successful, or Nothing if it fails.</returns>
    Public Function Login(username As String, password As String) As Account
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        ' Use a transaction even for reads for consistency
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. --- Business Logic ---
            ' Find the user
            Dim userAccount = accountDAO.GetByUsername(username)

            If userAccount Is Nothing Then
                ' User not found
                logDAO.Create(Log.RecordAction(Nothing, "Login Failure", $"Attempted login for non-existent user '{username}'."))
                transaction.Commit() ' Commit the log entry
                Return Nothing
            End If

            ' 2. --- Verify Password ---
            If userAccount.VerifyPassword(password) Then
                ' Password is correct!
                If Not userAccount.IsActive Then
                    logDAO.Create(Log.RecordAction(userAccount.AccountID, "Login Failure", "Attempted login for inactive account."))
                    transaction.Commit()
                    Throw New Exception("This account is inactive.")
                End If

                ' Success
                logDAO.Create(Log.RecordAction(userAccount.AccountID, "Login Success", "User successfully logged in."))
                transaction.Commit()
                Return userAccount
            Else
                ' Password incorrect
                logDAO.Create(Log.RecordAction(userAccount.AccountID, "Login Failure", "Incorrect password provided."))
                transaction.Commit()
                Return Nothing
            End If

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Login failed: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function
End Class