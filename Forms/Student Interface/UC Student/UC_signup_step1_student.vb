Imports System.Text.RegularExpressions

Public Class UC_signup_step1_student

    ' --- 1. SIGNALS this control can send ---
    Public Event ValidationPassed As EventHandler
    Public Event LoginClicked As EventHandler ' New signal for the "Back" button

    ' Flags to control the automatic dash and prevent loops
    Private isAddingDash As Boolean = False
    Private isDeleting As Boolean = False

    ' This event runs when the user control first loads
    Private Sub UC_Signup_student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBox_password.UseSystemPasswordChar = True
        txtBox_confirmpassword.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False
    End Sub

    ' This is the Signup Validation logic
    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click

        ' 1. Check for any empty fields
        If String.IsNullOrWhiteSpace(txtBox_username.Text) OrElse
           String.IsNullOrWhiteSpace(txtBox_studentid.Text) OrElse
           String.IsNullOrWhiteSpace(txtBox_password.Text) OrElse
           String.IsNullOrWhiteSpace(txtBox_confirmpassword.Text) Then

            MessageBox.Show("Please fill in all fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop
        End If

        ' 2. Check Student ID format (XXXXXXXX-C)
        Dim idPattern As String = "^\d{8}-[A-Z]$"

        If Not Regex.IsMatch(txtBox_studentid.Text, idPattern) Then
            MessageBox.Show("Please enter a valid Student ID in the format XXXXXXXX-C.", "Invalid ID Format", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop
        End If

        ' 3. Check if passwords match
        If txtBox_password.Text <> txtBox_confirmpassword.Text Then
            MessageBox.Show("Passwords do not match. Please try again.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop
        End If

        ' 4. Check if username is already taken
        If IsUsernameTaken(txtBox_username.Text) Then
            MessageBox.Show("This username is already taken. Please choose another.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Stop
        End If
        ' --- ALL CHECKS PASSED ---
        ' Send the "ValidationPassed" signal to the parent form.
        RaiseEvent ValidationPassed(Me, EventArgs.Empty)

    End Sub

    ' This is the placeholder function for your username check
    Private Function IsUsernameTaken(username As String) As Boolean
        ' TODO: In the future, you will add your database lookup logic here.
        Return False

    End Function

    ' This code correctly handles the txtBox_username
    Private Sub txtBox_username_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged

    End Sub

    ' --- Student ID Auto-Formatting Logic ---

    ' Event 1: Check if the user is pressing Backspace
    Private Sub txtBox_studentid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBox_studentid.KeyDown
        If e.KeyCode = Keys.Back Then
            isDeleting = True

        Else
            isDeleting = False
        End If
    End Sub

    ' Event 2: Validate the key *before* it's entered
    Private Sub txtBox_studentid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBox_studentid.KeyPress
        If e.KeyChar = ChrW(Keys.Back) Then Return ' Allow Backspace

        Dim currentLength = txtBox_studentid.TextLength

        If currentLength < 8 Then ' 1. First 8 characters (MUST be numbers)
            If Not Char.IsDigit(e.KeyChar) Then e.Handled = True ' Reject non-numbers

        ElseIf currentLength = 8 Then ' 2. Handle the 9th character (dash)
            If e.KeyChar <> "-" Then
                e.Handled = True ' Block if not a dash

            End If

        ElseIf currentLength = 9 Then ' 3. Handle the 10th character (MUST be a letter)
            If Not Char.IsLetter(e.KeyChar) Then
                e.Handled = True ' Reject non-letters
            Else
                e.KeyChar = Char.ToUpper(e.KeyChar) ' It IS a letter, so convert to uppercase
            End If

        Else ' 4. Max length is 10
            e.Handled = True ' Reject all other keys
        End If
    End Sub

    ' Event 3: Auto-format the text *after* a key is entered
    Private Sub txtBox_studentid_TextChanged(sender As Object, e As EventArgs) Handles txtBox_studentid.TextChanged

        If isAddingDash OrElse isDeleting Then Return ' Exit if we are adding the dash or deleting

        If txtBox_studentid.TextLength = 8 Then ' If 8 numbers were just typed
            isAddingDash = True ' Set flag
            txtBox_studentid.AppendText("-") ' Add dash
            txtBox_studentid.SelectionStart = txtBox_studentid.TextLength ' Move cursor to end

            isAddingDash = False ' Unset flag
        End If
    End Sub


    ' --- 3. Renamed this Sub to match the button it handles ---
    ' This handles the "Back to Login" button click
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' 1. Clear the textboxes
        txtBox_username.Clear()
        txtBox_studentid.Clear()
        txtBox_password.Clear()

        txtBox_confirmpassword.Clear()

        ' 2. Send the "LoginClicked" signal to the parent form
        RaiseEvent LoginClicked(Me, EventArgs.Empty)
    End Sub

    ' --- Show/Hide Password Logic ---
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

End Class