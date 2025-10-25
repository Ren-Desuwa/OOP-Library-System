Public Class Home_Panel_Librarian_Admin_

    ' --- UPDATED CONSTRUCTOR ---
    ' It no longer accepts the login form as a parameter
    Public Sub New(username As String, userRole As String)

        ' This call is required to build the form's controls
        InitializeComponent()

        ' Set the title label text as requested
        lbl_title.Text = $"Welcome {username} - {userRole}"

        ' Check the role and hide buttons
        If userRole = "Librarian" Then
            ' Librarians should only see "Books" and "User"
            ' So, we hide the other two buttons.
            btn_Librarian.Visible = False
            btn_Logs.Visible = False

            ' (Admins will see all buttons by default)
        End If

    End Sub

    Private Sub btn_Books_Click(sender As Object, e As EventArgs) Handles btn_Books.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    ' --- UPDATED: Logout Functionality with Confirmation ---
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click

        ' 1. Ask the user for confirmation
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to log out?",
                                 "Log Out Confirmation",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question)

        ' 2. Check if the user clicked "Yes"
        If result = DialogResult.Yes Then

            ' --- NEW LOGOUT LOGIC ---
            ' 1. Create a NEW instance of the login form
            Dim newLoginForm As New Login_Panel_Librarian_Admin_()

            ' 2. Show the new login form
            newLoginForm.Show()

            ' 3. Close this Home Panel
            Me.Close()
        End If
        ' If the user clicks "No", nothing happens.
    End Sub
End Class