Public Class user_req_view_profile
    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim userCreditScoreViewForm As New user_credit_score_view()
        userCreditScoreViewForm.Show()
        Me.Close()
    End Sub
End Class