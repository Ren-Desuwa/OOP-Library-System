Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports System.Threading.Tasks
Public Class AuthService
    Private ReadOnly _dbCon As DBcon
    Private ReadOnly _otpService As OtpService
    Private ReadOnly _notificationService As NotificationService

    ' --- MODIFIED: Constructor now takes all required services ---
    Public Sub New(dbConnector As DBcon, otpSvc As OtpService, notifSvc As NotificationService)
        _dbCon = dbConnector
        _otpService = otpSvc
        _notificationService = notifSvc
    End Sub

    ' ##################################################################
    ' --- 1. LOGIN ---
    ' ##################################################################

    Public Function Login(usernameOrId As String, password As String) As Account
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Find the user by username
            Dim userAccount = accountDAO.GetByUsername(usernameOrId)

            If userAccount Is Nothing Then
                ' 1b. If not found, find by Student ID
                userAccount = accountDAO.GetByStudentID(usernameOrId)

                If userAccount Is Nothing Then
                    ' User not found
                    logDAO.Create(Log.RecordAction(Nothing, "Login Failure", $"Attempted login for non-existent user '{usernameOrId}'."))
                    transaction.Commit() ' Commit the log entry
                    Return Nothing
                End If
            End If

            ' 2. Verify Password
            If userAccount.VerifyPassword(password) Then
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

    ' ##################################################################
    ' --- 2. REGISTRATION (Moved from RegistrationService) ---
    ' ##################################################################

    Private Enum ContactType
        Invalid
        Email
        Phone
    End Enum

    Private Function GetContactType(contactInfo As String) As ContactType
        If Regex.IsMatch(contactInfo, "^\+63\s\d{3}\s\d{3}\s\d{4}$") Then
            Return ContactType.Phone
        End If
        If Regex.IsMatch(contactInfo, "^.+@.+\..+$") Then
            Return ContactType.Email
        End If
        Return ContactType.Invalid
    End Function

    Public Async Function RequestRegistrationOtp(contactInfo As String) As Task(Of Boolean)
        Dim contactType As ContactType = GetContactType(contactInfo)
        If contactType = ContactType.Invalid Then
            Throw New Exception("Invalid contact format. Please enter a valid email or PH phone number (e.g., +63 917 123 4567).")
        End If

        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim accountDAO As New AccountDAO(transaction)
            If contactType = ContactType.Email Then
                If accountDAO.GetByEmail(contactInfo) IsNot Nothing Then
                    Throw New Exception("This email address is already in use.")
                End If
            ElseIf contactType = ContactType.Phone Then
                ' (Phone check logic if needed)
            End If
            transaction.Rollback()
        Catch ex As Exception
            transaction.Rollback()
            Throw ex
        Finally
            _dbCon.CloseConnection()
        End Try

        Try
            Dim otpCode As String = _otpService.GenerateOtpForRegistration(contactInfo)
            If String.IsNullOrEmpty(otpCode) Then
                Throw New Exception("Failed to generate a verification code. Please try again.")
            End If

            If contactType = ContactType.Email Then
                Return Await _notificationService.SendRegistrationOtpAsync(contactInfo, otpCode)
            ElseIf contactType = ContactType.Phone Then
                MessageBox.Show("SMS not implemented yet. OTP is " & otpCode)
                Return True ' Placeholder for SMS
            End If
        Catch ex As Exception
            Throw New Exception("Could not send verification code: " & ex.Message)
        End Try
        Return False
    End Function

    Public Function CompleteRegistration(username As String, password As String, studentID As String, contactInfo As String, otpInput As String) As Integer
        Dim isOtpValid As Boolean = _otpService.VerifyOtpForRegistration(contactInfo, otpInput)
        If Not isOtpValid Then
            Throw New Exception("The verification code is incorrect or has expired.")
        End If

        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            If accountDAO.GetByUsername(username) IsNot Nothing Then
                Throw New Exception("Username is already taken.")
            End If

            Dim passwordHash = Account.HashPassword(password)
            Dim newAccount As New Account With {
            .Username = username,
            .PasswordHash = passwordHash,
            .Name = username,
            .StudentID = studentID,
            .Role = "Student",
            .DateCreated = DateTime.Now, ' Set the creation date
            .IsActive = False ' <<< THIS IS THE KEY CHANGE
        }

            Dim contactType As ContactType = GetContactType(contactInfo)
            If contactType = ContactType.Email Then
                newAccount.Email = contactInfo
            ElseIf contactType = ContactType.Phone Then
                newAccount.ContactNumber = contactInfo
            End If

            Dim newAccountId As Integer = accountDAO.Create(newAccount)
            logDAO.Create(Log.RecordAction(newAccountId, "User Registration", $"New user '{username}' registered, awaiting approval.", "Info"))
            transaction.Commit()
            Return newAccountId
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Registration failed: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' ##################################################################
    ' --- 3. PASSWORD RECOVERY (FINDS BY EMAIL) ---
    ' ##################################################################

    Private Function MaskEmail(email As String) As String
        Try
            Dim parts = email.Split("@"c)
            Dim username = parts(0)
            Dim domain = parts(1)
            Dim maskedUsername = $"{username.Substring(0, 1)}***"
            Dim maskedDomain = $"{domain.Substring(0, 1)}***{domain.Substring(domain.LastIndexOf("."c))}"
            Return $"{maskedUsername}@{maskedDomain}"
        Catch ex As Exception
            Return "a private email address"
        End Try
    End Function

    ''' <summary>
    ''' Step 1: Finds a user by EMAIL, generates an OTP, and sends it.
    ''' </summary>
    Public Async Function RequestPasswordResetOtp(email As String) As Task(Of String)
        If GetContactType(email) <> ContactType.Email Then
            Throw New Exception("Invalid email format.")
        End If

        Dim userAccount As Account
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            userAccount = accountDAO.GetByEmail(email)
            transaction.Rollback()
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Database error: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try

        If userAccount Is Nothing Then
            Throw New Exception("No account is associated with that email address.")
        End If

        Try
            ' Use the user's email as the target
            Dim otpCode As String = _otpService.GenerateOtpForRegistration(userAccount.Email)
            If String.IsNullOrEmpty(otpCode) Then
                Throw New Exception("Failed to generate a verification code.")
            End If

            ' Send the password reset email
            Await _notificationService.SendPasswordResetOtpAsync(userAccount.Email, otpCode)

            ' Return the masked email for the UI
            Return MaskEmail(userAccount.Email)

        Catch ex As Exception
            Throw New Exception("Could not send verification code: " & ex.Message)
        End Try
    End Function

    ''' <summary>
    ''' Step 2: Verifies the OTP provided by the user (using their email as the key).
    ''' </summary>
    Public Function VerifyPasswordResetOtp(email As String, otpInput As String) As Boolean
        ' This function doesn't need to access the DB, it just passes through
        ' to the OtpService.
        Return _otpService.VerifyOtpForRegistration(email, otpInput)
    End Function

    ''' <summary>
    ''' Step 3: Updates the user's password (finding them by email).
    ''' </summary>
    Public Sub CompletePasswordReset(email As String, newPassword As String)
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim userAccount = accountDAO.GetByEmail(email)

            If userAccount Is Nothing Then
                Throw New Exception("Account not found.")
            End If

            userAccount.PasswordHash = Account.HashPassword(newPassword)
            accountDAO.Update(userAccount)

            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to update password: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

    ' ##################################################################
    ' --- 4. ACCOUNT MANAGEMENT (for Admin Panel) ---
    ' ##################################################################

    ''' <summary>
    ''' (FOR UC_HPAL_User_Tab)
    ''' Retrieves a complete list of all user accounts from the database.
    ''' </summary>
    Public Function GetAllAccounts() As List(Of Account)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Instantiate the DAO with the transaction
            Dim accountDAO As New AccountDAO(transaction)

            ' 2. Call the DAO's GetAll method
            Dim accounts = accountDAO.GetAll()

            ' 3. Commit the transaction (even for reads, to close it properly)
            transaction.Commit()

            ' 4. Return the list
            Return accounts

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Failed to retrieve all accounts: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' (FOR UC_HPAL_User_Tab)
    ''' Deletes a user account from the database by its ID.
    ''' </summary>
    Public Sub DeleteAccount(accountId As Integer)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

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
            _dbCon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' (FOR EditUser Form)
    ''' Updates an existing user's information in the database.
    ''' </summary>
    Public Sub UpdateAccount(account As Account)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim accountDAO As New AccountDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' Note: This assumes the password hash is NOT changed here.
            ' If you are resetting a password, you must hash it first.
            ' userAccount.PasswordHash = Account.HashPassword(newPassword)

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
            _dbCon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' (FOR AddUser Form)
    ''' Creates a new user account as an administrator.
    ''' </summary>
    Public Function CreateAccount(account As Account, plainTextPassword As String) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

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
            _dbCon.CloseConnection()
        End Try
    End Function
    ''' <summary>
    ''' (FOR PendingApprovalDialog)
    ''' Checks if a single account is active.
    ''' </summary>
    Public Async Function IsAccountActive(accountId As Integer) As Task(Of Boolean)
        ' Use Task.Run to avoid blocking the UI thread
        Return Await Task.Run(Function()
                                  If Not _dbCon.OpenConnection() Then
                                      ' If DB fails, just return False, timer will try again
                                      Return False
                                  End If

                                  Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
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
                                      _dbCon.CloseConnection()
                                  End Try
                              End Function)
    End Function

    ''' <summary>
    ''' (FOR UC_User_Request_Tab)
    ''' Retrieves all inactive student accounts ("Pending").
    ''' </summary>
    Public Function GetPendingAccounts() As List(Of Account)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            Dim accountDAO As New AccountDAO(transaction)
            ' We can re-use the GetAll() method and filter here
            ' Or you can create a new DAO method "GetByIsActive(False)"
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
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' (FOR UC_User_Request_Tab)
    ''' Approves a user account by setting IsActive = True.
    ''' </summary>
    Public Sub ApproveAccount(accountId As Integer)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
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
            _dbCon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' (FOR UC_User_Request_Tab)
    ''' Rejects (deletes) a user account.
    ''' </summary>
    Public Sub RejectAccount(accountId As Integer)
        ' This re-uses the existing DeleteAccount method
        ' You already confirmed this method exists in your authService.vb
        DeleteAccount(accountId)
    End Sub
End Class