Public Class BorrowRequestList
    Private Sub Guna2CustomGradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2CustomGradientPanel1.Paint

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim brForm As New UserAccountRequestList()
        brForm.Show()
        Me.Hide()
    End Sub
End Class