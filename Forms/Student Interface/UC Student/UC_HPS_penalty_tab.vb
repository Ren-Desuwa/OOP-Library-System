Imports System.Data ' <-- ADDED THIS IMPORT

Public Class UC_HPS_penalty_tab

    ' This is the original Load event you had. It's fine to leave it.
    Private Sub UC_HPS_penalty_tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' You can add code here if you need to set up anything when the form first loads
    End Sub

    ' --- START OF NEW CODE ---

    ''' <summary>
    ''' Public method called by the main form to load all real data for the logged-in user.
    ''' </summary>
    Public Sub LoadData(ByVal currentUser As Account)
        ' Get the AccountID, which our services use
        Dim accountId As Integer = currentUser.AccountID

        ' --- 1. Call the new service to get all data at once ---
        Dim summaryData As PenaltyService.PenaltyTabSummary
        Try
            ' Use the PenaltySvc we created in Program.vb
            summaryData = Program.PenaltySvc.GetPenaltyTabData(accountId)
        Catch ex As Exception
            MessageBox.Show("Failed to load penalty data: " & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try

        ' --- 2. Populate Score Summary ---
        Dim currentScore As Integer = summaryData.CurrentScore
        lblScoreValue.Text = $"{currentScore} / 100"
        pbScore.Value = currentScore

        ' --- 3. Populate Penalty History Grid ---
        ' We convert the List(Of Penalty) to a DataTable for easy binding
        dgvPenalties.DataSource = CreatePenaltyDataTable(summaryData.PenaltyHistory)

        ' Optional: Format the grid columns
        FormatPenaltyGrid()

        ' --- 4. Populate Actionable Advice ---
        Dim outstandingFines As Decimal = summaryData.OutstandingFines
        Dim overdueBooks As Integer = summaryData.OverdueBooksCount

        If outstandingFines > 0 Or overdueBooks > 0 Then
            lblActionSummary.Text = $"Total Fines: {outstandingFines:C}. Overdue Books: {overdueBooks}."
            lblActionSummary.ForeColor = Color.Red

            Dim advice As New System.Text.StringBuilder()
            advice.AppendLine("To improve your score:")
            If outstandingFines > 0 Then
                advice.AppendLine("• Pay all outstanding fines at the front desk.")
            End If
            If overdueBooks > 0 Then
                advice.AppendLine($"• Return your {overdueBooks} overdue book(s) immediately.")
            End If
            advice.AppendLine("• Maintain a good record for 30 days to regain 5 points.")

            rtbActions.Text = advice.ToString()
        Else
            ' No penalties!
            lblActionSummary.Text = "You have no outstanding penalties."
            lblActionSummary.ForeColor = Color.DarkGreen
            rtbActions.Text = "Keep up the great work! Continue to return books on time to maintain your perfect score."
        End If
    End Sub

    ''' <summary>
    ''' Helper function to convert the List(Of Penalty) into a DataTable for the grid.
    ''' </summary>
    Private Function CreatePenaltyDataTable(penalties As List(Of Penalty)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("Date", GetType(String))
        dt.Columns.Add("Violation", GetType(String))
        dt.Columns.Add("Book Title", GetType(String))
        dt.Columns.Add("Fine", GetType(String))
        dt.Columns.Add("Score Change", GetType(String))
        dt.Columns.Add("Status", GetType(String))

        ' Check if there are any penalties before looping
        If penalties IsNot Nothing Then
            For Each p In penalties
                dt.Rows.Add(
                    p.PenaltyDate.ToString("MM-dd-yyyy"),
                    p.ViolationType,
                    p.BookTitle,
                    p.FineAmount.ToString("C"), ' Format as currency
                    p.ScoreDeduction.ToString(),
                    p.Status
                )
            Next
        End If

        Return dt
    End Function

    ''' <summary>
    ''' Helper function to make the grid look nice.
    ''' </summary>
    Private Sub FormatPenaltyGrid()
        ' Add checks to prevent errors if grid or columns are missing
        If dgvPenalties.DataSource Is Nothing Then Return

        If dgvPenalties.Columns.Contains("Fine") Then
            dgvPenalties.Columns("Fine").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End If
        If dgvPenalties.Columns.Contains("Score Change") Then
            dgvPenalties.Columns("Score Change").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
        If dgvPenalties.Columns.Contains("Book Title") Then
            dgvPenalties.Columns("Book Title").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        End If
    End Sub

    ' --- END OF NEW CODE ---


    ' These are your original, empty click events. They are harmless.
    Private Sub gbSummary_Click(sender As Object, e As EventArgs) Handles gbSummary.Click

    End Sub

    Private Sub lblScoreTitle_Click(sender As Object, e As EventArgs) Handles lblScoreTitle.Click

    End Sub
End Class