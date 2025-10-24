Public Class user_credit_score_view
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub

    Private Sub Guna2Panel5_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2Panel6_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub user_request_view_profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2CircleProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2CircleProgressBar1.ValueChanged

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim manageUserForm As New Manage_User()
        manageUserForm.Show()
        Me.Hide() 'change to close lat8r
    End Sub
End Class