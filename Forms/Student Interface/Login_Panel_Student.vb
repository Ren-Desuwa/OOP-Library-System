Public Class Login_Panel_Student

    ' This event runs when the form first loads
    ' (NAME CORRECTED)
    Private Sub Login_Panel_Student__Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False

    End Sub

    ' REQUIREMENT: Login logic and confirmation
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        CheckLogin()
    End Sub

    ' This is the method for your account
    Private Sub CheckLogin()
        ' Get input from textboxes
        Dim inputUserOrID As String = txtBox_username.Text
        Dim inputPassword As String = txtBox_password.Text

        ' (userRole variable removed)
        Dim loggedInUsername As String = "" ' To store the username

        ' --- Mockup Database Check (CHANGED) ---

        ' Account 1: Student
        Dim loginAccount As Account = Program.AuthSvc.Login(inputUserOrID, inputPassword)
        If Not loginAccount Is Nothing Then
            Dim StudentHomePanel As New Home_Panel_Students()
            Me.Hide()
            StudentHomePanel.ShowDialog()
            Me.Show()
            Return
        End If
        ' Requirement 4: Failed login
        MessageBox.Show("Invalid Username, ID, or Password")
    End Sub

    ' --- Other Events ---

    ' (NAME CORRECTED)
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        ' 1. Create a new instance of your signup form
        Dim signupForm As New Signup_Panel_Student()

        ' 2. Hide the current login form
        Me.Hide()

        ' 3. Show the signup form as a dialog.
        ' This pauses the code here until the signup form is closed.
        signupForm.ShowDialog()

        ' 4. After the signup form is closed (e.g., they click
        ' "Back to Login" ), show the login form again.
        Me.Show()
    End Sub

    ' (NO CHANGES - Kept as requested)
    Private Sub txtBox_username_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged
        ' This is handled by PlaceholderText property, no code needed
        If txtBox_username.Text.Contains("-") Then
            lbl_username.Text = "Student ID"
        Else
            lbl_username.Text = "Username"
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lbl_forgotpass.Click
        ' Add code for forgot password later
    End Sub

    ' REQUIREMENT: Show/Hide Password Logic
    Private Sub img_show_Click(sender As Object, e As EventArgs) Handles img_show.Click
        txtBox_password.UseSystemPasswordChar = False
        img_show.Visible = False
        img_hide.Visible = True
    End Sub

    Private Sub img_hide_Click(sender As Object, e As EventArgs) Handles img_hide.Click
        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False
    End Sub
End Class