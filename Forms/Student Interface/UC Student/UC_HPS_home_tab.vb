' (Modified)
Imports Classes.Models
Imports Classes.Services ' Import the service layer

Public Class UC_HPS_home_tab

    Private Sub UC_HPS_home_tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Make TableLayoutPanel always match parent width
        TableLayoutPanel6.Width = Guna2Panel1.ClientSize.Width

        ' Re-adjust width when window resizes
        AddHandler Guna2Panel1.SizeChanged, AddressOf Guna2Panel1_SizeChanged

        ' Call the new dynamic method instead of AddTestAnnouncements
        LoadAnnouncements() '

        ' --- EXAMPLE: Set an initial score ---
        ' You can now call your new method here or from the parent form
        SetCreditScore(75) ' Sets the progress bar to 75

    End Sub

    ' --- NEW PUBLIC METHOD ---
    ''' <summary>
    ''' Updates the Credit Score progress bar with a new value.
    ''' </summary>
    ''' <param name="score">The credit score value (0-100).</param>
    Public Sub SetCreditScore(ByVal score As Integer)
        ' Ensure the score is within the 0-100 range
        If score < 0 Then score = 0
        If score > 100 Then score = 100

        ' Update the progress bar's value
        Guna2CircleProgressBar1.Value = score
    End Sub
    ' --- END OF NEW METHOD ---


    ' This method replaces the static AddTestAnnouncements
    Private Sub LoadAnnouncements()
        ' Clear old controls
        TableLayoutPanel6.Controls.Clear() '
        TableLayoutPanel6.RowCount = 0
        TableLayoutPanel6.RowStyles.Clear()

        Try
            ' 1. Get data from the service
            Dim announcements As List(Of Announcement) = Program.AnnounceSvc.GetActiveAnnouncements()

            ' 2. Loop through the real announcements
            For Each announcement As Announcement In announcements
                Dim uc As New UC_announcementBox()

                uc.Dock = DockStyle.Top
                uc.Anchor = AnchorStyles.Left Or AnchorStyles.Right
                uc.Margin = New Padding(10) '

                ' 3. Populate the user control with data
                uc.Populate(announcement)

                uc.Margin = New Padding(5) '

                ' Add new row style that autosizes
                TableLayoutPanel6.RowCount += 1
                TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.AutoSize)) '

                ' Add control to the table
                TableLayoutPanel6.Controls.Add(uc, 0, TableLayoutPanel6.RowCount - 1)
            Next

        Catch ex As Exception
            ' Handle any errors (e.g., database connection failed)
            ' You can display a single announcement box with the error
            Dim errorUc As New UC_announcementBox()
            errorUc.Dock = DockStyle.Top
            errorUc.Margin = New Padding(10)
            errorUc.Title.Text = "Error"
            errorUc.Message.Text = "Could not load announcements: " & ex.Message
            errorUc.DatePosted.Text = DateTime.Now.ToShortDateString()

            TableLayoutPanel6.RowCount += 1
            TableLayoutPanel6.RowStyles.Add(New RowStyle(SizeType.AutoSize))
            TableLayoutPanel6.Controls.Add(errorUc, 0, 0)
        End Try
    End Sub


    Private Sub Guna2Panel1_SizeChanged(sender As Object, e As EventArgs)
        TableLayoutPanel6.Width = Guna2Panel1.ClientSize.Width '
    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class