Imports MySql.Data.MySqlClient

Public Class UC_HPAL_Logs_Tab
    Private Sub UC_HPAL_Logs_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogs()
    End Sub

    Private Sub lbl_username_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LoadLogs()

    End Sub


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)
        'this is where the UC_announcementbox.vb should be '
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt")
        lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
