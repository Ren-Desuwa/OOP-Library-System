Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Public Class Signup_Panel_Student

    Public Event BackToLoginClicked As EventHandler

    ' --- 1. Variables to store data from all steps ---
    Private studentUsername As String
    Private studentID As String
    Private studentPassword As String

    ' --- 1. For Asynchronous Loading ---
    Private _loadingTcs As TaskCompletionSource(Of Boolean)

    ' --- 2. NEW: This event runs every time the form is SHOWN ---
    Private Async Sub Signup_Panel_Student_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Re-create the "signal" each time the form is shown
        _loadingTcs = New TaskCompletionSource(Of Boolean)()

        ' --- Simulate loading ---
        Await Task.Delay(50)
        ' --- End simulation ---

        ' Signal that loading is complete!
        _loadingTcs.SetResult(True)
    End Sub

    ' --- 3. NEW: Public function for Program.vb to "wait" on ---
    Public Function AwaitLoadingAsync() As Task
        ' If the signal hasn't been created yet, return a completed task
        If _loadingTcs Is Nothing Then
            Return Task.CompletedTask
        End If
        Return _loadingTcs.Task
    End Function
    ' This event runs when the FORM loads
    Private Sub Signup_Panel_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- Fix for the SLIDE animation (Guna2Transition1) ---
        Guna2Transition1.DefaultAnimation.SlideCoeff = New System.Drawing.PointF(1.0F, 0F)

        ' --- 2. Connect to Step 1 Control (UC_Signup_student2) ---
        AddHandler UC_Signup_student2.ValidationPassed, AddressOf HandleValidationPassed
        AddHandler UC_Signup_student2.LoginClicked, AddressOf HandleLoginClicked

        ' --- 3. Connect to Step 2 Control (UC_Signup2_student2) ---
        AddHandler UC_Signup2_student2.BackClicked, AddressOf HandleBackClicked
        ' Connect the UC's "Confirm" button to our handler
        AddHandler UC_Signup2_student2.ConfirmClicked, AddressOf HandleConfirmClicked
        ' Connect the UC's "Send Code" button to our new handler
        AddHandler UC_Signup2_student2.SendCodeClicked, AddressOf HandleSendCodeClicked

        ' --- 4. Set Initial State ---
        UC_Signup_student2.Visible = True ' Show Step 1 first
        UC_Signup_student2.BringToFront()
        UC_Signup2_student2.Visible = False ' Hide Step 2

    End Sub

    ' Runs when Step 1's "Next" button is clicked
    Private Sub HandleValidationPassed(sender As Object, e As EventArgs)

        ' --- 5. Get and Store Data from Step 1 ---
        studentUsername = UC_Signup_student2.txtBox_username.Text
        studentID = UC_Signup_student2.txtBox_studentid.Text
        studentPassword = UC_Signup_student2.txtBox_password.Text

        ' --- 6. Run the "Next" Animation ---
        Guna2Transition2.Show(UC_Signup2_student2) ' Starts fading in
        Guna2Transition1.Hide(UC_Signup_student2) ' Starts sliding out
        UC_Signup2_student2.SendToBack()
    End Sub

    ' Runs when Step 2's "Back" button is clicked
    Private Sub HandleBackClicked(sender As Object, e As EventArgs)

        ' --- 7. Run the "Back" Animation ---
        Guna2Transition1.Show(UC_Signup_student2) ' Starts sliding in
        UC_Signup_student2.BringToFront()
        Guna2Transition2.Hide(UC_Signup2_student2) ' Starts fading out
    End Sub

    ' Runs when the "Back to Login" link is clicked
    Private Sub HandleLoginClicked(sender As Object, e As EventArgs)
        ' Raise the event to tell Program.vb to handle it.
        RaiseEvent BackToLoginClicked(Me, EventArgs.Empty)
    End Sub

    ' Runs when Step 2's "Send Code" button is clicked
    Private Async Sub HandleSendCodeClicked(sender As Object, e As EventArgs)
        Dim contactInfo As String = UC_Signup2_student2.ContactInfo
        Try
            ' 1. Call the service to request the OTP
            If Await Program.AuthSvc.RequestRegistrationOtp(contactInfo) Then
                MessageBox.Show("Verification code sent! Please check your email or phone.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Verification code not sent.", "Code Not Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' 2. If successful, tell the UC to start its countdown
            UC_Signup2_student2.StartOtpCountdown()
            UC_Signup2_student2.SetContactInfoValid()
        Catch ex As Exception
            ' 3. If it fails, show an error
            Dim errorDetails As String = $"Message: {ex.Message}" & vbCrLf & vbCrLf
            If ex.InnerException IsNot Nothing Then
                errorDetails &= $"Inner Exception: {ex.InnerException.Message}"
            End If
            UC_Signup2_student2.SetContactInfoInvalid()
        End Try
    End Sub

    ' --- THIS SUB IS NOW FIXED ---
    ' Runs when Step 2's "Verify" (Confirm) button is clicked
    Private Sub HandleConfirmClicked(sender As Object, e As EventArgs)
        ' 1. Get data from Step 2
        Dim contactInfo As String = UC_Signup2_student2.ContactInfo
        Dim otpInput As String = UC_Signup2_student2.OtpCode

        Try
            ' 2. Call the registration service to create the account
            Dim newAccountId As Integer = Program.AuthSvc.CompleteRegistration(studentUsername, studentPassword, studentID, contactInfo, otpInput)

            ' 3. Success!
            MessageBox.Show("Registration Successful! You can now log in.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- 4. CLEAR ALL FIELDS ---
            UC_Signup_student2.txtBox_username.Clear()
            UC_Signup_student2.txtBox_studentid.Clear()
            UC_Signup_student2.txtBox_password.Clear()
            UC_Signup_student2.txtBox_confirmpassword.Clear()
            UC_Signup2_student2.txtBox_contactInfo.Clear()
            UC_Signup2_student2.txtbox_otp.Clear()
            UC_Signup2_student2.ResetTimer() ' Reset the "Resend in..." button

            ' 5. RESET THE VIEW TO STEP 1
            UC_Signup_student2.Visible = True
            UC_Signup_student2.BringToFront()
            UC_Signup2_student2.Visible = False

            ' 6. NAVIGATE BACK TO LOGIN
            RaiseEvent BackToLoginClicked(Me, EventArgs.Empty)
            ' --- END OF FIX ---

        Catch ex As Exception
            ' 7. Failure
            MessageBox.Show(ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Tell the UC to show the error state
            UC_Signup2_student2.SetOtpInvalid()
        End Try
    End Sub
End Class