Imports Guna.UI2.WinForms

Public Class EditProfile

    ' Assuming Program.currentAccount is a globally available Account object
    ' and Program.AccountSvc is a globally available AccountService instance.

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_confirmchanges.Click

        ' *** 1. Get user input and correct the original bug ***
        ' NOTE: Assuming there is a control for the Nickname/Name, 
        ' I will call it 'txtbox_name'. If your control is named differently, adjust this line.
        Dim name As String = txtbox_username.Text.Trim() ' Corrected to get the name/nickname
        Dim birthday As Date = Guna2DateTimePicker1.Value

        ' *** 2. Basic validations ***

        If String.IsNullOrEmpty(name) Then
            MessageBox.Show("Please enter your nickname/name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' *** 3. Age validation ***
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then
            age -= 1
        End If

        If age < 7 Then
            MessageBox.Show("Sorry, only children 7 years old or older can have a library account.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' *** 4. Save Logic: Update the in-memory model ***
        Try
            ' Ensure the currentAccount object is available and populated
            If Program.currentAccount Is Nothing Then
                MessageBox.Show("User session not found. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Update the in-memory Account object
            Program.currentAccount.Email = email         ' Update Email
            Program.currentAccount.Name = name           ' Update Name/Nickname
            Program.currentAccount.Birthday = birthday   ' Update Birthday

            ' *** 5. Call the AccountService to persist the changes ***
            Program.AccountSvc.UpdateAccount(Program.currentAccount)

            ' If saving is successful
            MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show($"Failed to update profile. Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_editavatar.LinkClicked
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openFile.ShowDialog() = DialogResult.OK Then
            picBox_profile.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub
End Class
