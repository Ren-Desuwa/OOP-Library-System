Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class ForgotPass_Student

    Private _countdownSeconds As Integer = 60
    Private _currentEmail As String = "" ' To store the verified email

    Private Sub ForgotPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This ensures the timer is connected
        AddHandler otpTimer.Tick, AddressOf otpTimer_Tick
        ' Set the initial UI state
        SetInitialState()

        ' --- NEW: Update UI to ask for Email ---
        txtBox_username.PlaceholderText = "Enter Email Address"
        lbl_username.Text = "Email"
        ' --- END NEW ---
    End Sub

    ' --- UI STATE MANAGEMENT ---

    ''' <summary>
    ''' State 1: Show only the email field.
    ''' </summary>
    Private Sub SetInitialState()
        ' Show these
        lbl_username.Visible = True
        txtBox_username.Visible = True
        btn_sendcode.Visible = True

        ' Hide these
        lbl_otp.Visible = False
        txtbox_otp.Visible = False
        btn_verifynum.Visible = False
        lbl_password.Visible = False
        txtBox_password.Visible = False
        lbl_confirmpassword.Visible = False
        txtBox_confirmpassword.Visible = False
        btn_confirm.Visible = False
        img_show.Visible = False
        img_hide.Visible = False

        ' Enable controls
        txtBox_username.Enabled = True
    End Sub

    ''' <summary>
    ''' State 2: Show the password fields after successful OTP verification.
    ''' </summary>
    Private Sub SetVerifiedState()
        ' Show these
        lbl_password.Visible = True
        txtBox_password.Visible = True
        lbl_confirmpassword.Visible = True
        txtBox_confirmpassword.Visible = True
        btn_confirm.Visible = True
        img_show.Visible = True

        ' Hide these
        lbl_username.Visible = False
        txtBox_username.Visible = False
        btn_sendcode.Visible = False
        lbl_otp.Visible = False
        txtbox_otp.Visible = False
        btn_verifynum.Visible = False
        img_hide.Visible = False

        ' Reset password fields
        txtBox_password.UseSystemPasswordChar = True
        txtBox_confirmpassword.UseSystemPasswordChar = True
    End Sub

    ' --- BUTTON CLICKS & EVENTS ---

    ''' <summary>
    ''' Step 1: User enters their email and clicks "Send Code".
    ''' </summary>
    Private Async Sub btn_sendcode_Click(sender As Object, e As EventArgs) Handles btn_sendcode.Click
        ' txtBox_username is used for email input
        Dim email As String = txtBox_username.Text.Trim()
        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        btn_sendcode.Enabled = False
        btn_sendcode.Text = "Sending..."

        Try
            ' Call the new service function
            Dim maskedEmail As String = Await Program.AuthSvc.RequestPasswordResetOtp(email)

            ' Success!
            MessageBox.Show($"Verification code sent to {maskedEmail}.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

            _currentEmail = email ' Store the email for the next steps
            StartOtpCountdown()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_sendcode.Enabled = True
            btn_sendcode.Text = "Send Code"
        End Try
    End Sub

    ''' <summary>
    ''' Step 2: User enters the OTP and clicks "Verify".
    ''' </summary>
    Private Sub btn_verifynum_Click(sender As Object, e As EventArgs) Handles btn_verifynum.Click
        Dim otp As String = txtbox_otp.Text.Trim()
        If String.IsNullOrWhiteSpace(otp) Then
            MessageBox.Show("Please enter the verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Call the service to verify using the stored email
            If Program.AuthSvc.VerifyPasswordResetOtp(_currentEmail, otp) Then
                ' Success! Move to the password reset state
                otpTimer.Stop()
                MessageBox.Show("Verification successful. Please enter your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SetVerifiedState()
            Else
                ' Failure
                MessageBox.Show("Invalid or expired verification code.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Step 3: User enters new password and clicks "Confirm".
    ''' </summary>
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim newPass As String = txtBox_password.Text
        Dim confirmPass As String = txtBox_confirmpassword.Text

        ' Validation
        If String.IsNullOrWhiteSpace(newPass) Or String.IsNullOrWhiteSpace(confirmPass) Then
            MessageBox.Show("Please fill in both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Call the service to finalize the reset
            Program.AuthSvc.CompletePasswordReset(_currentEmail, newPass)

            ' Success!
            MessageBox.Show("Password has been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close() ' Close the form

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- HELPER FUNCTIONS (TIMER & UI) ---

    Private Sub StartOtpCountdown()
        _countdownSeconds = 60
        btn_sendcode.Enabled = False
        lbl_otp.Visible = True
        txtbox_otp.Visible = True
        btn_verifynum.Visible = True
        txtBox_username.Enabled = False ' Lock the email field
        otpTimer.Start()
    End Sub

    Private Sub otpTimer_Tick(sender As Object, e As EventArgs)
        If _countdownSeconds > 0 Then
            _countdownSeconds -= 1
            Dim timeRemaining = TimeSpan.FromSeconds(_countdownSeconds)
            btn_sendcode.Text = $"Resend in {timeRemaining:mm\:ss}"
        Else
            otpTimer.Stop()
            btn_sendcode.Enabled = True
            btn_sendcode.Text = "Send Code"
        End If
    End Sub

    Private Sub img_show_Click(sender As Object, e As EventArgs) Handles img_show.Click
        txtBox_password.UseSystemPasswordChar = False
        txtBox_confirmpassword.UseSystemPasswordChar = False
        img_show.Visible = False
        img_hide.Visible = True
    End Sub

    Private Sub img_hide_Click(sender As Object, e As EventArgs) Handles img_hide.Click
        txtBox_password.UseSystemPasswordChar = True
        txtBox_confirmpassword.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint
        ' No code needed here
    End Sub
End Class