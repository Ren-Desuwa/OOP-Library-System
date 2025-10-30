Public Class UserProfile

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim profileUC As New BooksFromProfile()
        profileUC.Dock = DockStyle.Fill

        Panel1.Controls.Clear()         ' remove previous UC (if any)
        Panel1.Controls.Add(profileUC)  ' add the new one
        profileUC.BringToFront()

    End Sub


    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Guna2PictureBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint

    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim message As String =
    "📘 Credit Score (CP) Info" & vbCrLf & vbCrLf &
    "Your CP shows how responsible you are in borrowing and returning books." & vbCrLf & vbCrLf &
    "✅ On-time/Early Return: +5 CP" & vbCrLf &
    "⚠️ Max: 100 CP" & vbCrLf & vbCrLf &
    "Penalties:" & vbCrLf &
    "• Lost Book: -50 CP & ₱500 Fine" & vbCrLf &
    "  (Paying restores +20 CP, total 70 CP)" & vbCrLf &
    "• Damaged Book: -30 CP" & vbCrLf &
    "• Overdue Book: -10 CP" & vbCrLf & vbCrLf &
    "Keep your CP high — return books on time!"

        MessageBox.Show(message, "Credit Score Info", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Guna2ProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2ProgressBar1.ValueChanged

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub


    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub

    Private editForm As EditProfile = Nothing
    Private Sub btn_Books_Click(sender As Object, e As EventArgs) Handles btn_Books.Click
        If editForm Is Nothing OrElse editForm.IsDisposed Then
            editForm = New EditProfile()
        End If

        ' Show the form and bring it to front
        editForm.Show()
        editForm.BringToFront()

    End Sub
End Class