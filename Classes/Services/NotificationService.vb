Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Net.Http
Imports System.Threading.Tasks
Imports System.Configuration
Imports System.Windows.Forms ' <-- ADDED THIS to use MessageBox

Public Class NotificationService
    'Private ReadOnly _dbCon As DBcon
    ' You don't need DBcon here, as this service only talks to external APIs.
    Public Sub New() 'dbConnector As DBcon
        '_dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Sends an OTP for a new user registration.
    ''' </summary>
    ' --- MODIFIED: Changed to Async Function returning Task ---
    Public Async Function SendRegistrationOtpAsync(targetEmail As String, otpCode As String) As Task(Of Boolean)
        ' You can add more logic here (e.g., HTML templates)
        Dim subject As String = "Verify Your Library Account"
        Dim body As String = $"Your one-time password is: {otpCode}. It will expire in 5 minutes."
        ' --- MODIFIED: Await the new async email sender ---
        Return Await SendEmailAsync(targetEmail, subject, body)
    End Function

    ''' <summary>
    ''' Sends an OTP for a password reset.
    ''' </summary>
    ' --- MODIFIED: Changed to Async Function returning Task ---
    Public Async Function SendPasswordResetOtpAsync(targetEmail As String, otpCode As String) As Task
        Dim subject As String = "Your Password Reset Code"
        Dim body As String = $"Your password reset code is: {otpCode}. If you did not request this, please ignore it."

        ' Call the private helper
        ' --- MODIFIED: Await the new async email sender ---
        Await SendEmailAsync(targetEmail, subject, body)
    End Function

    ''' <summary>
    ''' Sends an SMS using a provider (e.g., Twilio).
    ''' </summary>
    'Public Async Function SendSms(mobileNumber As String, message As String) As Task(Of Boolean)
    '    ' --- CONFIGURATION (Now read from App.config) ---
    '    Dim accountSid As String = ConfigurationManager.AppSettings("TwilioAccountSid")
    '    Dim authToken As String = ConfigurationManager.AppSettings("TwilioAuthToken")
    '    Dim twilioNumber As String = ConfigurationManager.AppSettings("TwilioPhoneNumber")
    '    ' ---------------------

    '    ' --- !!! NEW DEBUG MSGBOX !!! ---
    '    Dim isAuthTokenEmpty As String = If(String.IsNullOrWhiteSpace(authToken), "YES (This is a problem!)", "NO (Loaded)")
    '    Dim debugMsg As String = $"--- Debug: SendSms ---" & vbCrLf &
    '                             $"Input Number: {mobileNumber}" & vbCrLf &
    '                             $"From Number (Config): {twilioNumber}" & vbCrLf &
    '                             $"Account SID (Config): {accountSid}" & vbCrLf &
    '                             $"Is Auth Token Empty? (Config): {isAuthTokenEmpty}"
    '    MessageBox.Show(debugMsg, "Debug: SMS Service", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    ' --- !!! END DEBUG !!! ---

    '    Dim formattedNumber As String = mobileNumber
    '    If formattedNumber.StartsWith("09") Then
    '        formattedNumber = "+63" & formattedNumber.Substring(1)
    '    End If

    '    Dim apiUrl As String = $"https://api.twilio.com/2010-04-01/Accounts/{accountSid}/Messages.json"
    '    Using client As New HttpClient()
    '        Dim authHeader As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{accountSid}:{authToken}"))
    '        client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authHeader)

    '        Dim messageContent = New Dictionary(Of String, String)()
    '        messageContent.Add("To", formattedNumber)
    '        messageContent.Add("From", twilioNumber)
    '        messageContent.Add("Body", message)

    '        Try
    '            Dim response = Await client.PostAsync(apiUrl, New FormUrlEncodedContent(messageContent))
    '            ' --- MODIFIED: Check response and throw error if not successful ---
    '            If Not response.IsSuccessStatusCode Then
    '                ' This will give us the error from Twilio (e.G., "Auth failed", "Out of funds")
    '                Dim errorContent = Await response.Content.ReadAsStringAsync()
    '                Throw New Exception($"Twilio API failed with status: {response.StatusCode}. Details: {errorContent}")
    '            End If
    '            Return response.IsSuccessStatusCode
    '        Catch ex As Exception
    '            Debug.WriteLine("SMS Send Error: ", ex.Message)
    '            ' --- MODIFIED: THROW the exception so the UI can see it ---
    '            ' Was: Return False (This was swallowing the error)
    '            ' Now:
    '            Throw New Exception("Failed to send SMS. " & ex.Message, ex)
    '        End Try
    '    End Using
    'End Function

    ' --- Private Email Helper ---
    ' --- MODIFIED: Changed to Async Function returning Task ---
    ' --- MODIFIED: Returns a Task(Of Boolean) ---
    Private Async Function SendEmailAsync(recipientEmail As String, subject As String, body As String) As Task(Of Boolean)
        ' --- CONFIGURATION ---
        Dim senderEmail As String = ConfigurationManager.AppSettings("SmtpSenderEmail")
        Dim senderPassword As String = ConfigurationManager.AppSettings("SmtpSenderPassword")
        Dim senderName As String = ConfigurationManager.AppSettings("SmtpSenderName")

        Dim smtpHost As String = "smtp.gmail.com"
        Dim smtpPort As Integer = 587
        'MessageBox.Show($"Sender Email: {senderEmail}" & vbCrLf &
        '    $"Recipient Email: {recipientEmail}" & vbCrLf &
        '    $"Subject: {subject}" & vbCrLf &
        '    $"Body: {body}" &
        '    $"password: {senderPassword}",
        '    "Debug: SendEmailAsync", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Try
            Dim mail As New MailMessage()
            mail.From = New MailAddress(senderEmail, senderName)
            mail.To.Add(recipientEmail)
            mail.Subject = subject
            mail.Body = body
            mail.IsBodyHtml = False

            Using smtp As New SmtpClient(smtpHost, smtpPort)
                smtp.Credentials = New NetworkCredential(senderEmail, senderPassword)
                smtp.EnableSsl = True

                Await smtp.SendMailAsync(mail)

                ' --- MODIFIED: If it gets here, it succeeded ---
                Return True
            End Using

        Catch ex As Exception
            ' Log the error so you can debug it
            Debug.WriteLine("Email Send Error: " & ex.Message)

            ' --- MODIFIED: Tell the caller it failed ---
            Return False
        End Try
        ' No Finally block needed
    End Function
End Class
