Imports System.Net
Imports System.Net.Mail
Imports System.Text
Imports System.Net.Http
Imports System.Threading.Tasks

Public Class NotificationService

    ' You don't need DBcon here, as this service only talks to external APIs.
    Public Sub New()
        ' Constructor
    End Sub

    ''' <summary>
    ''' Sends an OTP for a new user registration.
    ''' </summary>
    Public Sub SendRegistrationOtp(targetEmail As String, otpCode As String)
        ' You can add more logic here (e.g., HTML templates)
        Dim subject As String = "Verify Your Library Account"
        Dim body As String = $"Your one-time password is: {otpCode}. It will expire in 5 minutes."

        ' Call the private helper
        SendEmail(targetEmail, subject, body)
    End Sub

    ''' <summary>
    ''' Sends an OTP for a password reset.
    ''' </summary>
    Public Sub SendPasswordResetOtp(targetEmail As String, otpCode As String)
        Dim subject As String = "Your Password Reset Code"
        Dim body As String = $"Your password reset code is: {otpCode}. If you did not request this, please ignore it."

        ' Call the private helper
        SendEmail(targetEmail, subject, body)
    End Sub

    ''' <summary>
    ''' Sends an SMS using a provider (e.g., Twilio).
    ''' </summary>
    Public Async Function SendSms(mobileNumber As String, message As String) As Task(Of Boolean)
        ' --- CONFIGURATION ---
        Dim accountSid As String = "YOUR_TWILIO_ACCOUNT_SID"
        Dim authToken As String = "YOUR_TWILIO_AUTH_TOKEN"
        Dim twilioNumber As String = "YOUR_TWILIO_PHONE_NUMBER"
        ' ---------------------

        Dim formattedNumber As String = mobileNumber
        If formattedNumber.StartsWith("09") Then
            formattedNumber = "+63" & formattedNumber.Substring(1)
        End If

        Dim apiUrl As String = $"https://api.twilio.com/2010-04-01/Accounts/{accountSid}/Messages.json"
        Using client As New HttpClient()
            Dim authHeader As String = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{accountSid}:{authToken}"))
            client.DefaultRequestHeaders.Authorization = New Headers.AuthenticationHeaderValue("Basic", authHeader)

            Dim messageContent = New Dictionary(Of String, String)()
            messageContent.Add("To", formattedNumber)
            messageContent.Add("From", twilioNumber)
            messageContent.Add("Body", message)

            Try
                Dim response = Await client.PostAsync(apiUrl, New FormUrlEncodedContent(messageContent))
                Return response.IsSuccessStatusCode
            Catch ex As Exception
                Debug.WriteLine("SMS Send Error: " & ex.Message)
                Return False
            End Try
        End Using
    End Function

    ' --- Private Email Helper ---

    Private Sub SendEmail(recipientEmail As String, subject As String, body As String)
        ' --- CONFIGURATION ---
        ' !! Store these in App.config, not hard-coded !!
        Dim senderEmail As String = "ucclibrarymanagement@gmail.com"
        Dim senderPassword As String = "ccez eveh bfqz swhw"
        Dim senderName As String = "Library System"

        Dim smtpHost As String = "smtp.gmail.com"
        Dim smtpPort As Integer = 587
        ' ---------------------

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
                smtp.Send(mail)
            End Using

        Catch ex As Exception
            ' In a real app, you should log this error
            Debug.WriteLine("Email Send Error: " & ex.Message)
            ' We throw the exception so the calling service knows it failed.
            Throw New Exception("Failed to send email. " & ex.Message)
        End Try
    End Sub
End Class