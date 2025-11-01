Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class UC_Signup2_student

    ' --- NEW: Variables for OTP Countdown and Verification ---
    Private _countdownSeconds As Integer = 60

    ' --- 1. SIGNALS this control can send ---
    Public Event BackClicked As EventHandler
    Public Event SendCodeClicked As EventHandler
    Public Event ConfirmClicked As EventHandler

    ' --- NEW: Public properties to expose data ---

    Private Sub UC_Signup2_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This line manually forces the timer to connect to the Tick event.
        ' This fixes the bug where the designer fails to hook up the event.
        AddHandler otpTimer.Tick, AddressOf otpTimer_Tick
    End Sub
    Public ReadOnly Property ContactInfo As String
        Get
            Return txtBox_contactInfo.Text.Trim()
        End Get
    End Property

    Public ReadOnly Property OtpCode As String
        Get
            Return txtbox_otp.Text.Trim()
        End Get
    End Property

    ' This handles the "Back" button click
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_backstepone.Click
        ' Send the "BackClicked" signal to the parent form
        RaiseEvent BackClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub txtBox_contactInfo_TextChanged(sender As Object, e As EventArgs) Handles txtBox_contactInfo.TextChanged
        ' As soon as the user starts typing, reset the error colors
        SetContactInfoValid()
    End Sub

    ' --- 2. All phone formatting logic removed (KeyPress, TextChanged, KeyDown) ---
    ' Validation is now handled by the service layer.

    ' --- 3. HELPER METHODS FOR VALIDATION ---
    ''' <summary>
    ''' Sets the textbox border to red to show an error (e.g., OTP failed).
    ''' </summary>
    Public Sub SetContactInfoInvalid()
        ' Set border to Red
        txtBox_contactInfo.BorderColor = Color.Red
        txtBox_contactInfo.FocusedState.BorderColor = Color.Red
    End Sub

    Public Sub SetContactInfoValid()
        ' Reset to original colors from your designer file
        txtBox_contactInfo.BorderColor = Color.DarkGray
        txtBox_contactInfo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
    End Sub

    ''' <summary>
    ''' Sets the OTP textbox and Verify button to red to show an error.
    ''' </summary>
    Public Sub SetOtpInvalid()
        ' Set OTP textbox border to Red
        txtbox_otp.BorderColor = Color.Red
        txtbox_otp.FocusedState.BorderColor = Color.Red

        ' Set Verify button fill to Red
        btn_verifynum.FillColor = Color.Red
    End Sub

    ''' <summary>
    ''' Resets the OTP textbox and Verify button to their normal colors.
    ''' </summary>
    Public Sub SetOtpValid()
        ' Reset OTP textbox border to original colors
        txtbox_otp.BorderColor = Color.DarkGray
        txtbox_otp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)

        ' Reset Verify button fill to original color
        btn_verifynum.FillColor = Color.Tan
    End Sub


    ' --- 4. HANDLE "SEND CODE" CLICK (MODIFIED) ---
    Private Sub btn_sendcode_Click(sender As Object, e As EventArgs) Handles btn_sendcode.Click
        ' Just raise the event. The parent form will handle the logic.
        RaiseEvent SendCodeClicked(Me, EventArgs.Empty)
    End Sub

    ' --- NEW: Public method for parent to call ---
    Public Sub StartOtpCountdown()
        ' 1. Reset the countdown
        _countdownSeconds = 60

        ' 2. Disable this button so it can't be spammed
        btn_sendcode.Enabled = False

        ' 3. Start the timer
        otpTimer.Start()

        ' 4. Enable the controls for verification
        txtbox_otp.Enabled = True
        btn_verifynum.Enabled = True
    End Sub

    ' --- 5. HANDLE THE TIMER COUNTDOWN (UNCHANGED) ---
    Private Sub otpTimer_Tick(sender As Object, e As EventArgs) Handles otpTimer.Tick
        If _countdownSeconds > 0 Then
            ' Decrease time
            _countdownSeconds -= 1

            ' Format the time as "mm:ss" (e.g., "00:59")
            Dim timeRemaining = TimeSpan.FromSeconds(_countdownSeconds)
            btn_sendcode.Text = $"Resend in {timeRemaining:mm\:ss}"
        Else
            ' --- Time's up! ---
            ' 1. Stop the timer
            otpTimer.Stop()

            ' 2. Re-enable the button
            btn_sendcode.Enabled = True

            ' 3. Reset the text
            btn_sendcode.Text = "Send Code"
        End If
    End Sub

    ' --- 6. HANDLE "VERIFY" CLICK (MODIFIED) ---
    Private Sub btn_verifynum_Click(sender As Object, e As EventArgs) Handles btn_verifynum.Click
        ' This button is now the final "Confirm" button.
        ' Just raise the event. The parent form will handle all logic.
        RaiseEvent ConfirmClicked(Me, EventArgs.Empty)
    End Sub

    ' --- 7. RESET ERROR ON TYPING (UNCHANGED) ---
    Private Sub txtbox_otp_TextChanged(sender As Object, e As EventArgs) Handles txtbox_otp.TextChanged
        ' As soon as the user starts typing, reset the error colors
        SetOtpValid()
    End Sub
End Class
