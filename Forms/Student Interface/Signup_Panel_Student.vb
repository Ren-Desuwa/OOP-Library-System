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
    ' 
    ' This event runs when the FORM loads
    Private Sub Signup_Panel_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- Fix for the SLIDE animation (Guna2Transition1) ---
        Guna2Transition1.DefaultAnimation.SlideCoeff = New System.Drawing.PointF(1.0F, 0F)

        ' --- 2. Connect to Step 1 Control (UC_signup_step1_student1) ---
        AddHandler UC_signup_step1_student1.ValidationPassed, AddressOf HandleValidationPassed
        AddHandler UC_signup_step1_student1.LoginClicked, AddressOf HandleLoginClicked

        ' --- 3. Connect to Step 2 Control (UC_signup_step2_student1) ---
        AddHandler UC_signup_step2_student1.BackClicked, AddressOf HandleBackClicked
        ' Connect the UC's "Confirm" button to our handler
        AddHandler UC_signup_step2_student1.ConfirmClicked, AddressOf HandleConfirmClicked
        ' Connect the UC's "Send Code" button to our new handler
        AddHandler UC_signup_step2_student1.SendCodeClicked, AddressOf HandleSendCodeClicked

        ' --- 4. Set Initial State ---
        UC_signup_step1_student1.Visible = True ' Show Step 1 first

        UC_signup_step1_student1.BringToFront()
        UC_signup_step2_student1.Visible = False ' Hide Step 2

    End Sub

    ' Runs when Step 1's "Next" button is clicked
    Private Sub HandleValidationPassed(sender As Object, e As EventArgs)

        ' --- 5. Get and Store Data from Step 1 ---
        studentUsername = UC_signup_step1_student1.txtBox_username.Text
        studentID = UC_signup_step1_student1.txtBox_studentid.Text
        studentPassword = UC_signup_step1_student1.txtBox_password.Text


        ' --- 6. Run the "Next" Animation ---
        Guna2Transition2.Show(UC_signup_step2_student1) ' Starts fading in
        Guna2Transition1.Hide(UC_signup_step1_student1) ' Starts sliding out
        UC_signup_step2_student1.SendToBack()
    End Sub

    ' Runs when Step 2's "Back" button is clicked
    Private Sub HandleBackClicked(sender As Object, e As EventArgs)

        ' --- 7. Run the "Back" Animation ---
        Guna2Transition1.Show(UC_signup_step1_student1) ' Starts sliding in

        UC_signup_step1_student1.BringToFront()
        Guna2Transition2.Hide(UC_signup_step2_student1) ' Starts fading out
    End Sub

    ' Runs when the "Back to Login" link is clicked
    Private Sub HandleLoginClicked(sender As Object, e As EventArgs)
        ' Raise the event to tell Program.vb to handle it.
        RaiseEvent BackToLoginClicked(Me, EventArgs.Empty)
    End Sub

    ' Runs when Step 2's "Send Code" button is clicked
    Private Async Sub HandleSendCodeClicked(sender As Object, e As EventArgs)
        Dim contactInfo As String = UC_signup_step2_student1.ContactInfo

        ' --- START OF MODIFIED LOGIC ---

        ' --- NEW VALIDATION ---
        ' Check if the contact info field is empty, just like in ForgotPass.vb
        If String.IsNullOrWhiteSpace(contactInfo) Then
            MessageBox.Show("Please enter your email or mobile number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop execution
        End If
        ' --- END NEW VALIDATION ---

        ' 1. Set button to "Sending..." state
        UC_signup_step2_student1.SetSendingState(True)

        Try
            ' 2. Call the service to request the OTP
            If Await Program.AuthSvc.RequestRegistrationOtp(contactInfo) Then
                ' 3. Success
                MessageBox.Show("Verification code sent! Please check your email or phone.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 4. Tell the UC to start its countdown
                UC_signup_step2_student1.StartOtpCountdown()
                UC_signup_step2_student1.SetContactInfoValid()
            Else
                ' 5. Handle a "false" return from the service
                MessageBox.Show("Verification code could not be sent. Please check the email or phone number.", "Code Not Sent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                ' Reset the button to its normal state
                UC_signup_step2_student1.SetSendingState(False)
            End If

        Catch ex As Exception
            ' 6. Handle any unexpected errors
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Reset the button to its normal state
            UC_signup_step2_student1.SetSendingState(False)
            UC_signup_step2_student1.SetContactInfoInvalid()
        End Try
        ' --- END OF MODIFIED LOGIC ---
    End Sub

    ' --- THIS SUB IS NOW FIXED ---
    ' Runs when Step 2's "Verify" (Confirm) button is clicked
    Private Sub HandleConfirmClicked(sender As Object, e As EventArgs)
        ' 1. Get data from Step 2
        Dim contactInfo As String =
        UC_signup_step2_student1.ContactInfo
        Dim otpInput As String = UC_signup_step2_student1.OtpCode

        Try
            ' 2. Call the registration service to create the account
            Dim newAccountId As Integer = Program.AuthSvc.CompleteRegistration(studentUsername, studentPassword, studentID, contactInfo, otpInput)

            ' 3. Success!
            ' 3a. Instantiate the dialog
            Dim pendingDialog As New PendingApprovalDialog()

            ' 3b. Pass the new account ID to it
            pendingDialog.StudentAccountID = newAccountId

            ' 3c. Show it as a modal dialog. The code will PAUSE here
            ' until the user clicks "Confirm" (after being approved)
            pendingDialog.ShowDialog()

            ' --- 3d. (Original code) Runs AFTER the dialog is closed ---
            MessageBox.Show("Thank you! You can now log in.", "Account Approved", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- 4. CLEAR ALL FIELDS ---
            UC_signup_step1_student1.txtBox_username.Clear()
            UC_signup_step1_student1.txtBox_studentid.Clear()
            UC_signup_step1_student1.txtBox_password.Clear()
            UC_signup_step1_student1.txtBox_confirmpassword.Clear()
            UC_signup_step2_student1.txtBox_contactInfo.Clear()
            UC_signup_step2_student1.txtbox_otp.Clear()

            UC_signup_step2_student1.ResetTimer() ' Reset the "Resend in..." button

            ' 5. RESET THE VIEW TO STEP 1
            UC_signup_step1_student1.Visible = True
            UC_signup_step1_student1.BringToFront()
            UC_signup_step2_student1.Visible = False

            ' 6. NAVIGATE BACK TO LOGIN

            RaiseEvent BackToLoginClicked(Me, EventArgs.Empty)
            ' --- END OF FIX ---

        Catch ex As Exception
            ' 7. Failure
            MessageBox.Show(ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Tell the UC to show the error state
            UC_signup_step2_student1.SetOtpInvalid()

        End Try
    End Sub
End Class