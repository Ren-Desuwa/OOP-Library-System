Imports System.IO
Imports System.Windows.Forms

' NEW - Add the "Public" keyword
Partial Public Class Home_Panel_Students
    ' This helper function will hide all panels, then show the one you want.
    Private Sub ShowTabPanel(ByVal tabToShow As UserControl)
        ' 1. Hide ALL your tab panels
        UC_HPS_home_tab1.Visible = False
        UC_HPS_catalouge_tab1.Visible = False
        UC_HPS_borrowed_books_tab1.Visible = False  ' <-- ADD THIS LINE
        UC_HPS_penalty_tab1.Visible = False         ' <-- ADD THIS LINE

        ' 2. Show only the one we passed into the function
        If tabToShow IsNot Nothing Then
            tabToShow.Visible = True
        End If
    End Sub
    ' Note: We MUST make this event "Async Sub"
    Private Async Sub Home_Panel_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. This shows the Home tab by default, as you wanted.
        ShowTabPanel(UC_HPS_home_tab1)

        ' 2. THIS IS THE FIX:
        ' We "await" a tiny delay. This forces the Load event to pause,
        ' giving the UI thread time to finish all its other jobs
        ' (like maximizing, centering, and drawing the form).
        Await Task.Delay(50) ' 50 milliseconds is plenty

        ' 3. NOW that the form is maximized and visible,
        ' we tell the catalogue tab to start its loading process.
        ' NEW - Pass a reference of the form itself
        UC_HPS_catalouge_tab1.BeginLoading(Me)
    End Sub
    ' This is your button named btn_Home_tab 
    Private Sub btn_Home_tab_Click(sender As Object, e As EventArgs) Handles btn_Home_tab.Click
        ShowTabPanel(UC_HPS_home_tab1)
    End Sub

    ' This is your button named btn_Catalouge_tab 
    Private Sub btn_Catalouge_tab_Click(sender As Object, e As EventArgs) Handles btn_Catalouge_tab.Click
        ShowTabPanel(UC_HPS_catalouge_tab1)
    End Sub

    Private Sub btn_Borrowed_Books_tab_Click(sender As Object, e As EventArgs) Handles btn_Borrowed_Books_tab.Click
        ShowTabPanel(UC_HPS_borrowed_books_tab1)
    End Sub

    Private Sub btn_Penalty_tab_Click(sender As Object, e As EventArgs) Handles btn_Penalty_tab.Click
        ShowTabPanel(UC_HPS_penalty_tab1)
    End Sub
    ''' <summary>
    ''' Public method to control the new loading panel from any UserControl.
    ''' </summary>
    Public Sub ToggleLoading(isLoading As Boolean, Optional message As String = "Loading...")
        If isLoading Then
            ' Set the message on the new panel
            UC_Loading_Panel1.SetMessage(message)
            ' Show the panel
            UC_Loading_Panel1.Visible = True
            ' Ensure it's on top of all other controls
            UC_Loading_Panel1.BringToFront()
        Else
            ' Hide the panel
            UC_Loading_Panel1.Visible = False
        End If
    End Sub
End Class