Imports System.Text.RegularExpressions

Public Class Signup_Panel_Student

    ' --- 1. Variables to store data from all steps ---
    Private studentUsername As String
    Private studentID As String
    Private studentPassword As String

    ' --- TODO: You must instantiate your services here ---
    ' You will need to pass the correct DBcon object
    ' Private ReadOnly _db As New DBcon("your_db_name")
    ' Private ReadOnly NotifSvc As New NotificationService()
    ' Private ReadOnly OtpSvc As New OtpService(_db)
    ' Private ReadOnly RegSvc As New registrationService(_db, OtpSvc, NotifSvc)


    ' This event runs when the FORM loads
    Private Sub Signup_Panel_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- Fix for the SLIDE animation (Guna2Transition1) ---
        Guna2Transition1.DefaultAnimation.SlideCoeff = New System.Drawing.PointF(1.0F, 0F)

        ' --- 2. Connect to Step 1 Control (UC_Signup_student2) --- [FIXED]
        AddHandler UC_Signup_student2.ValidationPassed, AddressOf HandleValidationPassed
        AddHandler UC_Signup_student2.LoginClicked, AddressOf HandleLoginClicked

        ' --- 3. Connect to Step 2 Control (UC_Signup2_student2) --- [FIXED]
        AddHandler UC_Signup2_student2.BackClicked, AddressOf HandleBackClicked
        ' Connect the UC's "Confirm" button to our handler
        AddHandler UC_Signup2_student2.ConfirmClicked, AddressOf HandleConfirmClicked
        ' Connect the UC's "Send Code" button to our new handler
        AddHandler UC_Signup2_student2.SendCodeClicked, AddressOf HandleSendCodeClicked

        ' --- 4. Set Initial State --- [FIXED]
        UC_Signup_student2.Visible = True ' Show Step 1 first
        UC_Signup_student2.BringToFront()
        UC_Signup2_student2.Visible = False ' Hide Step 2

    End Sub

    ' Runs when Step 1's "Next" button is clicked
    Private Sub HandleValidationPassed(sender As Object, e As EventArgs)

        ' --- 5. Get and Store Data from Step 1 --- [FIXED]
        studentUsername = UC_Signup_student2.txtBox_username.Text
        studentID = UC_Signup_student2.txtBox_studentid.Text
        studentPassword = UC_Signup_student2.txtBox_password.Text

        ' --- 6. Run the "Next" Animation --- [FIXED]

        ' Use .Show and .Hide to run animations at the SAME time
        Guna2Transition2.Show(UC_Signup2_student2) ' Starts fading in
        Guna2Transition1.Hide(UC_Signup_student2) ' Starts sliding out

        UC_Signup2_student2.SendToBack()

    End Sub

    ' Runs when Step 2's "Back" button is clicked
    Private Sub HandleBackClicked(sender As Object, e As EventArgs)

        ' --- 7. Run the "Back" Animation --- [FIXED]

        ' Use .Show and .Hide to run animations at the SAME time
        Guna2Transition1.Show(UC_Signup_student2) ' Starts sliding in
        UC_Signup_student2.BringToFront()
        Guna2Transition2.Hide(UC_Signup2_student2) ' Starts fading out

    End Sub

    ' Runs when Step 1's "Back to Login" button is clicked
    Private Sub HandleLoginClicked(sender As Object, e As EventArgs)
        ' Close this signup form and return to the login form
        Me.Close()
    End Sub

    ' --- NEW: Runs when Step 2's "Send Code" button is clicked ---
    Private Async Sub HandleSendCodeClicked(sender As Object, e As EventArgs)
        Dim contactInfo As String = UC_Signup2_student2.ContactInfo '[FIXED]
        Try
            ' 1. Call the service to request the OTP
            ' (Assuming RegSvc is a form-level variable you instantiated)

            If Await RegSvc.RequestRegistrationOtp(contactInfo) Then
                MessageBox.Show("Verification code sent! Please check your email or phone.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Verification code not send", "Code not Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Throw New Exception("di nag send")
            End If


            ' 2. If successful, tell the UC to start its countdown [FIXED]
            UC_Signup2_student2.StartOtpCountdown()
            UC_Signup2_student2.SetContactInfoValid()
        Catch ex As Exception
            ' 3. If it fails, show an error and mark the UC textbox as invalid
            ' --- MODIFIED: Show the FULL error message, including inner exceptions ---
            Dim errorDetails As String = $"Message: {ex.Message}" & vbCrLf & vbCrLf
            If ex.InnerException IsNot Nothing Then
                errorDetails &= $"Inner Exception: {ex.InnerException.Message}"
            End If

            ' [FIXED]
            UC_Signup2_student2.SetContactInfoInvalid()
        End Try
    End Sub

    ' --- MODIFIED: Runs when Step 2's "Verify" (Confirm) button is clicked ---
    Private Sub HandleConfirmClicked(sender As Object, e As EventArgs)
        ' 1. Get data from Step 2 [FIXED]
        Dim contactInfo As String = UC_Signup2_student2.ContactInfo
        Dim otpInput As String = UC_Signup2_student2.OtpCode

        Try
            ' 2. Get data from Step 1 (already stored in form variables)
            ' We will use the StudentID as the 'Name' for the account
            Dim studentName As String = studentID

            ' 3. Call the registration service to create the account
            ' (Assuming RegSvc is a form-level variable)
            ' This new signature is simpler and handles email/phone logic in the service
            Dim newAccountId As Integer = RegSvc.CompleteRegistration(studentUsername, studentPassword, studentName, contactInfo, otpInput)

            ' 4. Success!
            MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close() ' Close signup form and return to login

        Catch ex As Exception
            ' 5. Failure
            MessageBox.Show(ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Tell the UC to show the error state
            UC_Signup2_student2.SetOtpInvalid() '[FIXED]
        End Try
    End Sub

End Class