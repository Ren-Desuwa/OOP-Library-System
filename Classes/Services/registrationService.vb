Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab
Imports MySql.Data.MySqlClient

Public Class registrationService

    ' The RegistrationService "owns" the other services it needs
    Private ReadOnly _dbCon As DBcon
    Private ReadOnly _otpService As OtpService
    Private ReadOnly _notificationService As NotificationService

    Public Sub New(dbConnector As DBcon, otpSvc As OtpService, notifSvc As NotificationService)
        _dbCon = dbConnector
        _otpService = otpSvc
        _notificationService = notifSvc
    End Sub

    Private Enum ContactType
        Invalid
        Email
        Phone
    End Enum

    Private Function GetContactType(contactInfo As String) As ContactType
        ' Check for PH phone number format (e.g., +63 917 123 4567)
        ' This regex matches the format from your UC_Signup2_student.vb file
        If Regex.IsMatch(contactInfo, "^\+63\s\d{3}\s\d{3}\s\d{4}$") Then
            Return ContactType.Phone

        End If

        ' Check for basic email format
        If Regex.IsMatch(contactInfo, "^.+@.+\..+$") Then
            Return ContactType.Email
        End If

        Return ContactType.Invalid
    End Function

    ''' <summary>
    ''' STEP 1: Called when user provides email OR phone and asks for a code.
    ''' </summary>
    ''' <param name="contactInfo">The email OR phone number to verify.</param>
    Public Async Function RequestRegistrationOtp(contactInfo As String) As Task(Of Boolean)
        Dim contactType As ContactType = GetContactType(contactInfo)

        If contactType = ContactType.Invalid Then
            Throw New Exception("Invalid contact format. Please enter a valid email or PH phone number (e.g., +63 917 123 4567).")
        End If

        ' --- We need a quick DB check *before* sending the OTP ---
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try

            Dim accountDAO As New AccountDAO(transaction)

            ' --- Business Logic: Check if contact info is already taken ---
            If contactType = ContactType.Email Then
                If accountDAO.GetByEmail(contactInfo) IsNot Nothing Then

                    Throw New Exception("This email address is already in use.")
                End If
            ElseIf contactType = ContactType.Phone Then

                'If accountDAO.GetByContactNumber(contactInfo) IsNot Nothing Then
                '    Throw New Exception("This phone number is already in use.")
                'End If
            End If

            ' Rollback since we were just reading
            transaction.Rollback()


        Catch ex As Exception
            transaction.Rollback()
            Throw ex ' Re-throw "Email is already in use" or other DB errors
        Finally
            _dbCon.CloseConnection()
        End Try

        ' --- If contact info is not taken, proceed to generate and send ---
        Try

            ' 1. Call OtpService to CREATE the code in the DB
            '    This uses the generic "target" method, so it works for both

            Dim otpCode As String = _otpService.GenerateOtpForRegistration(contactInfo)

            If String.IsNullOrEmpty(otpCode) Then

                Throw New Exception("Failed to generate a verification code. Please try again.")
            End If

            ' 2. Call NotificationService to SEND the code
            If contactType = ContactType.Email Then

                ' Use the email method
                ' --- FIX: Added Await and corrected function name ---
                Return Await _notificationService.SendRegistrationOtpAsync(contactInfo, otpCode)
            ElseIf contactType = ContactType.Phone Then
                ' Use the SMS methoD
                Dim message As String = $"Your one-time password is: {otpCode}.It will expire in 5 minutes."
                'Await _notificationService.SendSms(contactInfo, message)
                MessageBox.Show("di na send di naka code")
            End If

        Catch ex As Exception
            ' This will catch DB errors from OtpService or sending errors from NotificationService
            Throw New Exception("Could not send verification code: " & ex.Message)
        End Try
    End Function



    ''' <summary>
    ''' STEP 2: Called after user has received OTP and submitted the full form.
    ''' </summary>
    ''' <returns>The AccountID of the new user.</returns>
    ''' <exception cref="Exception">Throws if OTP is wrong or on DB error.</exception>
    Public Function CompleteRegistration(username As String, password As String, studentID As String, contactInfo As String, otpInput As String) As Integer

        ' 1. --- Verify the OTP first ---

        Dim isOtpValid As Boolean = _otpService.VerifyOtpForRegistration(contactInfo, otpInput)

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
                .Name = username,
                .StudentID = studentID,
                .Role = "Member"
            }

            ' --- NEW: Determine where to save the contact info ---
            Dim contactType As ContactType = GetContactType(contactInfo)
            If contactType = ContactType.Email Then
                newAccount.Email = contactInfo
            ElseIf contactType = ContactType.Phone Then
                newAccount.ContactNumber = contactInfo
            End If
            ' (If invalid, both will be Nothing, which is fine)

            ' Create the account
            Dim newAccountId As Integer = accountDAO.Create(newAccount)

            ' Create a log entry
            logDAO.Create(Log.RecordAction(newAccountId, "User Registration", $"New user '{username}' registered after contact verification.", "Info"))

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