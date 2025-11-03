Public Class Login_Panel_Librarian_Admin

    ' This event runs when the form first loads
    Private Sub Login_Panel_Librarian_Admin__Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False

    End Sub

    ' REQUIREMENT: Login logic and confirmation
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Method for the first account
        CheckLogin()
    End Sub

    ' This is the method for your account (Requirement 3)
    Private Sub CheckLogin()
        ' Get input from textboxes
        Dim inputUserOrID As String = txtBox_username.Text
        Dim inputPassword As String = txtBox_password.Text

        Dim userRole As String = "" ' To store the role
        Dim loggedInUsername As String = "" ' To store the username

        ' --- Mockup Database Check ---

        ' Account 1: Admin
        If (inputUserOrID = "Jestine" OrElse inputUserOrID = "1456-AD") AndAlso
           inputPassword = "123" Then

            userRole = "Admin"
            loggedInUsername = "Jestine"

            ' Account 2: Librarian (NEW)
        ElseIf (inputUserOrID = "Ren" OrElse inputUserOrID = "1234-L") AndAlso
               inputPassword = "111" Then

            userRole = "Librarian"
            loggedInUsername = "Ren"

        End If
        ' -------------------------------

        ' Check if login was successful
        If Not String.IsNullOrEmpty(userRole) Then

            ' --- UPDATED LINE ---
            ' No longer passes "Me"

            'Dim homePanel As New Home_Panel_Librarian_Admin_(loggedInUsername, userRole)

            Dim homePanel As New Home_Panel_Admin_Librarian(loggedInUsername, userRole)


            'homePanel.Show()

            Me.Close()

        Else
            ' Requirement 4: Failed login
            MessageBox.Show("Invalid Username, ID, or Password")
        End If
    End Sub

    ' --- Other Events ---
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ' You might want to close the form here too
        Me.Close()
    End Sub

    Private Sub txtBox_username_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged
        ' This is handled by PlaceholderText property, no code needed
        If txtBox_username.Text.Contains("-") Then
            lbl_username.Text = "Verified ID"
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

    Private Sub login_form_container_Paint(sender As Object, e As PaintEventArgs) Handles login_form_container.Paint

    End Sub

End Class