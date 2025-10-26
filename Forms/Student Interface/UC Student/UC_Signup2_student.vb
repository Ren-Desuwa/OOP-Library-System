Imports System.Drawing
Imports System.Text.RegularExpressions

Public Class UC_Signup2_student

    ' --- 1. SIGNALS this control can send ---
    ' (Existing code...)

    ' --- NEW: Variables for OTP Countdown and Verification ---
    Private _countdownSeconds As Integer = 60
    Private Const _correctOTP As String = "123456" ' Our test OTP code
    ' New signal for the "Back" button
    Public Event BackClicked As EventHandler
    ' (You can add a "ConfirmClicked" event here later)

    ' This handles the "Back" button click
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_backstepone.Click
        ' Send the "BackClicked" signal to the parent form
        RaiseEvent BackClicked(Me, EventArgs.Empty)
    End Sub

    ' --- 2. RESTRICTS INPUT (NEW VERSION) ---
    Private Sub txtBox_contactnum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBox_contactnum.KeyPress
        ' First, always allow control characters (like Backspace, Delete)
        If Char.IsControl(e.KeyChar) Then
            Return
        End If

        ' --- LOGIC FOR THE FIRST CHARACTER ---
        If txtBox_contactnum.Text.Length = 0 Then
            ' Only allow '+', '0', or '9' as the very first character
            If e.KeyChar = "+"c OrElse e.KeyChar = "0"c OrElse e.KeyChar = "9"c Then
                Return ' Allow it
            Else
                e.Handled = True ' Block everything else (like '1', 'a', 'b', etc.)
                Return
            End If
        End If

        ' --- LOGIC FOR ALL OTHER CHARACTERS ---
        ' If it's not the first character, only allow digits
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Block all non-digits (like letters or extra '+')
        End If
    End Sub

    ' --- 3. AUTO-FORMATS (NEW VERSION) ---
    Private Sub txtBox_contactnum_TextChanged(sender As Object, e As EventArgs) Handles txtBox_contactnum.TextChanged
        ' --- A. Stop this code from running on itself ---
        RemoveHandler txtBox_contactnum.TextChanged, AddressOf txtBox_contactnum_TextChanged

        Dim currentText As String = txtBox_contactnum.Text

        ' --- B. Auto-correction for the FIRST character ---
        ' (KeyPress already ensured it's only +, 0, or 9)

        ' B1: If user types "+" OR "0", auto-insert "+63 "
        If currentText = "+" OrElse currentText = "0" Then
            txtBox_contactnum.Text = "+63 "
            GoTo Finish ' Jump to the end

            ' B2: If user types "9", auto-insert "+63 9"
        ElseIf currentText = "9" Then
            txtBox_contactnum.Text = "+63 9"
            GoTo Finish ' Jump to the end
        End If

        ' --- C. Formatting for SUBSEQUENT characters ---
        ' Only format if the text starts with the correct prefix
        If currentText.StartsWith("+63") Then
            ' Get only the digits *after* the +63 prefix
            ' e.g., "+63 917 123" -> "917123"
            Dim rawDigits As String = Regex.Replace(currentText.Substring(3), "[^\d]", "")

            ' Rebuild the string from scratch
            Dim formattedText As String = "+63"

            ' Add first space: +63 9XX
            If rawDigits.Length > 0 Then
                formattedText &= " " & rawDigits.Substring(0, Math.Min(3, rawDigits.Length))
            End If

            ' Add second space: +63 9XX XXX
            If rawDigits.Length > 3 Then
                formattedText &= " " & rawDigits.Substring(3, Math.Min(3, rawDigits.Length - 3))
            End If

            ' Add final part: +63 9XX XXX XXXX
            If rawDigits.Length > 6 Then
                formattedText &= " " & rawDigits.Substring(6, Math.Min(4, rawDigits.Length - 6))
            End If

            ' Update the textbox text
            txtBox_contactnum.Text = formattedText
        Else
            ' This is a fallback, but KeyPress should prevent this.
            txtBox_contactnum.Text = currentText
        End If

Finish:
        ' --- D. Move cursor to the end and re-enable the event ---
        txtBox_contactnum.SelectionStart = txtBox_contactnum.Text.Length
        AddHandler txtBox_contactnum.TextChanged, AddressOf txtBox_contactnum_TextChanged
    End Sub


    ' --- 4. HELPER METHODS FOR VALIDATION (No changes here) ---

    ''' <summary>
    ''' Sets the textbox border to red to show an error (e.g., OTP failed).
    ''' </summary>
    Public Sub SetContactNumberInvalid()
        ' Set border to Red
        txtBox_contactnum.BorderColor = Color.Red
        txtBox_contactnum.FocusedState.BorderColor = Color.Red
    End Sub
    ' --- 5. LOCKS THE PREFIX (NEW) ---
    Private Sub txtBox_contactnum_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBox_contactnum.KeyDown
        ' This is the prefix we want to protect.
        Dim prefix As String = "+63 "

        ' Check if the Backspace key was pressed
        If e.KeyCode = Keys.Back Then
            ' Get the current text and cursor position
            Dim currentText As String = txtBox_contactnum.Text
            Dim cursorPosition As Integer = txtBox_contactnum.SelectionStart

            ' --- BLOCK BACKSPACE ---
            ' If the text is *exactly* the prefix OR
            ' if the cursor is *anywhere inside or at the end* of the prefix (position 0 to 4)
            ' then block the backspace key press.
            If currentText = prefix OrElse cursorPosition <= prefix.Length Then
                ' Block the key press
                e.Handled = True
                e.SuppressKeyPress = True ' Stops the "ding" sound
            End If
        End If
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
    Public Sub SetContactNumberValid()
        ' Reset to original colors from your designer file
        txtBox_contactnum.BorderColor = Color.DarkGray
        txtBox_contactnum.FocusedState.BorderColor = Color.FromArgb(94, 148, 255)
    End Sub

    ' --- 6. HANDLE "SEND CODE" CLICK ---
    Private Sub btn_sendcode_Click(sender As Object, e As EventArgs) Handles btn_sendcode.Click
        ' 1. Reset the countdown
        _countdownSeconds = 60

        ' 2. Disable this button so it can't be spammed
        btn_sendcode.Enabled = False

        ' 3. Start the timer
        otpTimer.Start()

        ' 4. Enable the controls for verification
        txtbox_otp.Enabled = True
        btn_verifynum.Enabled = True

        ' --- THIS IS WHERE YOU WOULD CALL YOUR SMS API ---
        ' For testing, we just print the code to the console.
        Console.WriteLine($"Test OTP Code is: {_correctOTP}")
    End Sub

    ' --- 7. HANDLE THE TIMER COUNTDOWN ---
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

    ' --- 8. HANDLE "VERIFY" CLICK ---
    Private Sub btn_verifynum_Click(sender As Object, e As EventArgs) Handles btn_verifynum.Click
        Dim userOTP As String = txtbox_otp.Text.Trim()

        If userOTP = _correctOTP Then
            ' --- SUCCESS ---
            ' 1. Hide the Verify button
            btn_verifynum.Visible = False

            ' 2. Show the Register button
            btn_register.Visible = True

            ' 3. (Optional) Lock the verified controls
            txtbox_otp.Enabled = False
            btn_sendcode.Enabled = False
            otpTimer.Stop()

            ' 4. Ensure visuals are in the "valid" state
            SetOtpValid()
        Else
            ' --- FAILURE ---
            ' Call our new method to show the error state
            SetOtpInvalid()
        End If
    End Sub

    ' --- 9. RESET ERROR ON TYPING ---
    Private Sub txtbox_otp_TextChanged(sender As Object, e As EventArgs) Handles txtbox_otp.TextChanged
        ' As soon as the user starts typing, reset the error colors
        SetOtpValid()
    End Sub
End Class