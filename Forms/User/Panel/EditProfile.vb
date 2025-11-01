Imports Guna.UI2.WinForms

Public Class EditProfile
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' Get user input
        Dim email As String = Guna2TextBox2.Text.Trim()
        Dim nickname As String = Guna2TextBox2.Text.Trim()
        Dim birthday As Date = Guna2DateTimePicker1.Value

        ' Basic validations
        If String.IsNullOrEmpty(email) Then
            MessageBox.Show("Please enter your email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If String.IsNullOrEmpty(nickname) Then
            MessageBox.Show("Please enter your nickname.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Calculate age
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - birthday.Year
        If birthday > today.AddYears(-age) Then
            age -= 1
        End If

        ' Check age restriction (7 or older)
        If age < 7 Then
            MessageBox.Show("Sorry, only children 7 years old or older can have a library account.", "Age Restriction", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' If all validations pass
        MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' TODO: Add your saving logic here
        ' Example:
        ' SaveProfile(email, nickname, birthday)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close() ' Close the current form
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim openFile As New OpenFileDialog()
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If openFile.ShowDialog() = DialogResult.OK Then
            Guna2CirclePictureBox1.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Close()
    End Sub
End Class
