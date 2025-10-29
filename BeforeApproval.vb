Imports System.Windows.Forms

Public Class BeforeApproval



    Private Sub BeforeApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm tt")
    End Sub

End Class
