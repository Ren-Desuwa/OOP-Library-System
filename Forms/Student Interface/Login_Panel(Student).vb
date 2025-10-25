Public Class Login_Panel_Student_

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
        If (inputUserOrID = "Rhea" OrElse inputUserOrID = "20240136-C") AndAlso
           inputPassword = "123" Then

            loggedInUsername = "Rhea"

        End If
        ' -------------------------------

        ' Check if login was successful (CHANGED)
        If Not String.IsNullOrEmpty(loggedInUsername) Then

            ' --- UPDATED LINE ---
            ' Passes only the username as requested.
            ' You will need to update the Home_Panel_Librarian_Admin_
            ' constructor to accept only one string.
            ' Dim homePanel As New Home_Panel_Librarian_Admin_(loggedInUsername)

            ' homePanel.Show()
            MessageBox.Show(loggedInUsername + " Logged In")
            Me.Close()

        Else
            ' Requirement 4: Failed login
            MessageBox.Show("Invalid Username, ID, or Password")
        End If
    End Sub

    ' --- Other Events ---

    ' (NAME CORRECTED)
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ' You might want to close the form here too
        Me.Close()
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

    Private Sub btn_createaccount_Click(sender As Object, e As EventArgs) Handles btn_createaccount.Click

    End Sub
End Class