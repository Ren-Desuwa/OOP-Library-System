' Import all your DAOs and Models
Imports MySql.Data.MySqlClient

Public Class registrationService
    ' The service needs your DBcon class to manage connections
    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Registers a new user in the system.
    ''' </summary>
    ''' <param name="username"></param>
    ''' <param name="password">The plain-text password, will be hashed here.</param>
    ''' <param name="name"></param>
    ''' <param name="email"></param>
    ''' <returns>The AccountID of the new user.</returns>
    ''' <exception cref="Exception">Throws an exception if the username/email is taken or on DB error.</exception>
    Public Function RegisterNewUser(username As String, password As String, name As String, email As String) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Create the DAOs, passing the same transaction
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 2. --- Business Logic ---
            ' Check if username is already taken
            If accountDAO.GetByUsername(username) IsNot Nothing Then
                Throw New Exception("Username is already taken.")
            End If

            ' (You could add a check for email uniqueness here too)

            ' 3. --- Perform Actions ---
            ' Hash the password
            Dim passwordHash = Account.HashPassword(password)

            ' Create the new account object
            Dim newAccount As New Account With {
                .Username = username,
                .PasswordHash = passwordHash,
                .Name = name,
                .Email = email,
                .Role = "Member" ' Default role
            }

            ' Create the account in the DB
            Dim newAccountId As Integer = accountDAO.Create(newAccount)

            ' Create a log entry for this action
            Dim logEntry As New Log With {
                .AccountID = newAccountId,
                .Action = "User Registration",
                .Details = $"New user '{username}' registered.",
                .Severity = "Info"
            }
            logDAO.Create(logEntry)

            ' 4. --- Commit ---
            ' If both actions succeeded, commit the changes
            transaction.Commit()

            Return newAccountId

        Catch ex As Exception
            ' 5. --- Rollback ---
            ' If anything failed, roll back all changes
            transaction.Rollback()
            ' Re-throw the exception so the UI layer knows about it
            Throw New Exception("Registration failed: " & ex.Message)
        Finally
            ' 6. --- Close Connection ---
            _dbCon.CloseConnection()
        End Try
    End Function
End Class