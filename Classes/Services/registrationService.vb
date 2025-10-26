Imports MySql.Data.MySqlClient

Public Class registrationService
    Private ReadOnly _dbCon As DBcon

    ' The RegistrationService "owns" the other services it needs
    Private ReadOnly _otpService As OtpService
    Private ReadOnly _notificationService As NotificationService

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector

        ' Initialize the services it depends on
        _otpService = New OtpService(dbConnector)
        _notificationService = New NotificationService()
    End Sub

    ''' <summary>
    ''' STEP 1: Called when user provides email and asks for a verification code.
    ''' </summary>
    ''' <param name="email">The email to verify.</param>
    ''' <exception cref="Exception">Throws if email is already in use or if sending fails.</exception>
    Public Sub RequestRegistrationOtp(email As String)
        ' --- We need a quick DB check *before* sending the OTP ---
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Dim accountDAO As New AccountDAO(transaction)

        Try
            ' --- Business Logic: Check if email is already taken ---
            ' (This requires you to add a "GetByEmail" method to your AccountDAO)
            If accountDAO.GetByEmail(email) IsNot Nothing Then
                Throw New Exception("This email address is already in use.")
            End If

            ' (Assuming GetByEmail exists)
            ' For now, we'll just check username as per your existing code
            ' This part is tricky if email *is* the username. 
            ' We'll assume email is unique.

            ' Rollback since we were just reading
            transaction.Rollback()

        Catch ex As Exception
            transaction.Rollback()
            Throw ex ' Re-throw "Email is already in use"
        Finally
            _dbCon.CloseConnection()
        End Try


        ' --- If email is not taken, proceed to generate and send ---
        Try
            ' 1. Call OtpService to CREATE the code in the DB
            Dim otpCode As String = _otpService.GenerateOtpForRegistration(email)

            If String.IsNullOrEmpty(otpCode) Then
                Throw New Exception("Failed to generate a verification code. Please try again.")
            End If

            ' 2. Call NotificationService to SEND the code
            _notificationService.SendRegistrationOtp(email, otpCode)

        Catch ex As Exception
            ' This will catch DB errors from OtpService or sending errors from NotificationService
            Throw New Exception("Could not send verification code: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' STEP 2: Called after user has received OTP and submitted the full form.
    ''' </summary>
    ''' <returns>The AccountID of the new user.</returns>
    ''' <exception cref="Exception">Throws if OTP is wrong or on DB error.</exception>
    Public Function CompleteRegistration(username As String, password As String, name As String, email As String, otpInput As String) As Integer

        ' 1. --- Verify the OTP first ---
        Dim isOtpValid As Boolean = _otpService.VerifyOtpForRegistration(email, otpInput)

        If Not isOtpValid Then
            Throw New Exception("The verification code is incorrect or has expired.")
        End If

        ' 2. --- If OTP is valid, proceed with your original registration logic ---
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' Check if username is already taken
            If accountDAO.GetByUsername(username) IsNot Nothing Then
                Throw New Exception("Username is already taken.")
            End If

            Dim passwordHash = Account.HashPassword(password)

            Dim newAccount As New Account With {
                .Username = username,
                .PasswordHash = passwordHash,
                .Name = name,
                .Email = email,
                .Role = "Member"
            }

            ' Create the account
            Dim newAccountId As Integer = accountDAO.Create(newAccount)

            ' Create a log entry
            logDAO.Create(Log.RecordAction(newAccountId, "User Registration", $"New user '{username}' registered after email verification.", "Info"))

            transaction.Commit()
            Return newAccountId

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Registration failed: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function
End Class