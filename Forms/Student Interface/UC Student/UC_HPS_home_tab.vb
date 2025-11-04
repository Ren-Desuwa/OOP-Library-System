Public Class UC_HPS_home_tab

    Private Sub UC_HPS_home_tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Make TableLayoutPanel always match parent width
        TableLayoutPanel6.Width = Guna2Panel1.ClientSize.Width

        ' Re-adjust width when window resizes
        AddHandler Guna2Panel1.SizeChanged, AddressOf Guna2Panel1_SizeChanged

        AddTestAnnouncements()
    End Sub

    Private Sub AddTestAnnouncements()
        ' Clear old controls
        TableLayoutPanel6.Controls.Clear()
        TableLayoutPanel6.RowCount = 0
        TableLayoutPanel6.RowStyles.Clear()

        ' Add test announcements
        For i As Integer = 1 To 5
            Dim uc As New UC_announcementBox()

            uc.Dock = DockStyle.Top
            uc.Anchor = AnchorStyles.Left Or AnchorStyles.Right
            uc.Margin = New Padding(10)

            uc.Title.Text = "Announcement " & i
            uc.Message.Text = "This is a sample announcement message for testing. " &
                          "Try making it long enough to see if it expands correctly. " &
                          "Each UC should resize vertically depending on its text length."
            uc.DatePosted.Text = DateTime.Now.ToShortDateString()

            ' Make the UC stretch horizontally
            uc.Dock = DockStyle.Top
            uc.Margin = New Padding(5)

            ' Add new row style that autosizes
            TableLayoutPanel6.RowCount += 1
            TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.AutoSize))

            ' Add control to the table
            TableLayoutPanel6.Controls.Add(uc, 0, TableLayoutPanel6.RowCount - 1)
        Next
    End Sub


    Private Sub Guna2Panel1_SizeChanged(sender As Object, e As EventArgs)
        TableLayoutPanel6.Width = Guna2Panel1.ClientSize.Width
    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub
End Class
