Public Class Login_Panel_Librarian_Admin_

    ' This event runs when the form first loads
    Private Sub Login_Panel_Librarian_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False

    End Sub

    ' REQUIREMENT: Close the form
    Private Sub btn_close_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    ' REQUIREMENT: Login logic and confirmation
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Method for the first account
        CheckLogin()
    End Sub

    ' This is the method for your account (Requirement 3)
    Private Sub CheckLogin()
        Dim username As String = "Jestine"
        Dim password As String = "123"
        Dim verifiedID As String = "1456-AD"

        ' Check if all three text boxes match the stored credentials
        If txtBox_username.Text = username AndAlso
           txtBox_password.Text = password AndAlso
           txtBox_verifiedid.Text = verifiedID Then

            ' Requirement 4: Successful login
            MessageBox.Show("Login Successful")

            ' --- TODO: ---
            ' This is where you would open your main menu form
            ' Example:
            ' Dim mainMenu = New MainMenuForm()
            ' mainMenu.Show()
            ' Me.Hide() ' Hide the login form

        Else
            ' Requirement 4: Failed login
            MessageBox.Show("Invalid Username or Password")
        End If
    End Sub

    ' --- Other Events ---
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ' You might want to close the form here too
        Me.Close()
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged
        ' This is handled by PlaceholderText property, no code needed
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