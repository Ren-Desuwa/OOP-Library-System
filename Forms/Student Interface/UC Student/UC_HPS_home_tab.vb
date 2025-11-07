Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class UC_HPS_home_tab
    ' This event tells the parent form (Home_Panel_Students) that we are done loading.
    Public Event AsyncLoadComplete As EventHandler

    Public Sub New()
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Public method to start loading announcements and other data asynchronously.
    ''' </summary>
    Public Async Sub LoadDataAsync()
        ' This is called by the parent form (Home_Panel_Students)
        Try
            ' 1. Load Announcements
            Dim announcements As List(Of Announcement) = Nothing
            Await Task.Run(Sub()
                               announcements = Program.AnnounceSvc.GetActiveAnnouncements()
                           End Sub)

            ' 2. Populate Announcements Flow Panel
            ' --- FIX: Use the correct designer name 'TableLayoutPanel6' ---
            TableLayoutPanel6.Controls.Clear()
            If announcements IsNot Nothing AndAlso announcements.Any() Then
                For Each ann As Announcement In announcements
                    Dim card As New UC_announcementBox()
                    card.Populate(ann)
                    ' --- FIX: Use the correct designer name 'TableLayoutPanel6' ---
                    TableLayoutPanel6.Controls.Add(card)
                Next
            Else
                ' Show a friendly message if no announcements
                Dim lbl As New Label()
                lbl.Text = "No announcements at this time."
                lbl.Font = New Font("Segoe UI", 12, FontStyle.Italic)
                lbl.ForeColor = Color.Gray
                lbl.AutoSize = True
                ' --- FIX: Use the correct designer name 'TableLayoutPanel6' ---
                TableLayoutPanel6.Controls.Add(lbl)
            End If

            ' 3. Load other data for the home tab (e.g., recommended books)
            ' (Add any other async loading here)

        Catch ex As Exception
            MessageBox.Show("Error loading home dashboard: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' 4. Signal the parent form that we are done
            RaiseEvent AsyncLoadComplete(Me, EventArgs.Empty)
        End Try
    End Sub

    ' --- *** THIS IS THE CORRECTED FUNCTION *** ---
    ''' <summary>
    ''' Updates the Credit Score UI elements with the user's current score.
    ''' Called by the parent form (Home_Panel_Students).
    ''' </summary>
    ''' <param name="score">The user's credit score (0-100).</param>
    Public Sub UpdateCreditScoreUI(score As Short)
        ' Use the correct control names from your .Designer.vb file

        ' --- 1. Update the Progress Bar ---
        ' This is the correct name from your designer: Guna2CircleProgressBar1
        Guna2CircleProgressBar1.Minimum = 0
        Guna2CircleProgressBar1.Maximum = 100
        Guna2CircleProgressBar1.Value = score

        ' The Guna2CircleProgressBar shows text automatically when ShowText = True
        ' so the 'lbl_creditScore.Text' line is not needed.

        ' --- 2. (Optional) Change color based on score ---
        If score >= CreditScoreService.SCORE_MIN_ALLOWED_BORROW Then
            ' Good score
            Guna2CircleProgressBar1.ProgressColor = Color.FromArgb(0, 192, 0) ' Green
            Guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(0, 192, 0)
        ElseIf score > 50 Then
            ' Medium score
            Guna2CircleProgressBar1.ProgressColor = Color.FromArgb(255, 193, 7) ' Yellow
            Guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(255, 193, 7)
        Else
            ' Low score
            Guna2CircleProgressBar1.ProgressColor = Color.FromArgb(211, 47, 47) ' Red
            Guna2CircleProgressBar1.ProgressColor2 = Color.FromArgb(211, 47, 47)
        End If
    End Sub
    ' --- *** END OF CORRECTED FUNCTION *** ---

End Class