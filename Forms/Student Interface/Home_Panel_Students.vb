Imports System.IO
Imports System.Windows.Forms
Imports System.Linq ' <-- Make sure this is at the top

' NEW - Add the "Public" keyword
Partial Public Class Home_Panel_Students
    Implements ILoadingContainer
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
    Private Sub Home_Panel_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. This shows the Home tab by default, as you wanted.
        ShowTabPanel(UC_HPS_home_tab1)

        ' 2. Make sure the loading panel is on top and hidden, ready for the 'Shown' event.
        UC_Loading_Panel1.Visible = False
        UC_Loading_Panel1.BringToFront()
    End Sub
    ' This new event handles the loading *after* the form is maximized and visible.
    Private Sub Home_Panel_Students_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' We no longer await. We just "fire and forget".
        ' This lets the home screen be interactive while catalogue loads in background.
        UC_HPS_catalouge_tab1.BeginLoading(Me, False) ' <-- Pass False to load silently
    End Sub
    ' This is your button named btn_Home_tab 
    Private Sub btn_Home_tab_Click(sender As Object, e As EventArgs) Handles btn_Home_tab.Click
        ShowTabPanel(UC_HPS_home_tab1)
    End Sub

    ' This is your button named btn_Catalouge_tab 
    Private Async Sub btn_Catalouge_tab_Click(sender As Object, e As EventArgs) Handles btn_Catalouge_tab.Click
        ' 1. If it's already visible, do nothing (as you requested).
        If UC_HPS_catalouge_tab1.Visible Then
            Return
        End If

        ' 2. Show the loading screen.
        ToggleLoading(True, "Loading Catalogue...")
        Await Task.Delay(5) ' Let animation start

        Try
            ' 3. AWAIT the task.
            ' If loading is already finished, this returns instantly.
            ' If it's still loading (from _Shown), this will WAIT here.
            Await UC_HPS_catalouge_tab1.AwaitInitialLoad()

            ' 4. Now that we're 100% sure it's loaded and painted, show the panel.
            ShowTabPanel(UC_HPS_catalouge_tab1)

        Catch ex As Exception
            ' If the background loading failed, show the error here.
            MessageBox.Show("Failed to load catalogue: " & ex.Message)
        Finally
            ' 5. ALWAYS hide the loading screen.
            ToggleLoading(False)
        End Try
    End Sub
    Private Async Sub txtBox_search_TextChanged(sender As Object, e As EventArgs) Handles txtBox_search.TextChanged
        ' Only search if the catalogue tab is currently visible
        If UC_HPS_catalouge_tab1.Visible Then
            Await UC_HPS_catalouge_tab1.Search(txtBox_search.Text)
        End If
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
    Public Sub ToggleLoading(isLoading As Boolean, Optional message As String = "Loading...") Implements ILoadingContainer.ToggleLoading
        If isLoading Then
            ' Set the message on the new panel
            UC_Loading_Panel1.SetMessage(message)
            ' Show the panel
            UC_Loading_Panel1.Visible = True
            ' Ensure it's on top of all other controls
            UC_Loading_Panel1.BringToFront()
            ' --- ADD THIS LINE ---
            UC_Loading_Panel1.Refresh()
            ' ---------------------
        Else
            ' Hide the panel
            UC_Loading_Panel1.Visible = False
        End If
    End Sub

    Private Sub btn_cart_Click(sender As Object, e As EventArgs) Handles btn_cart.Click

    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click

    End Sub
End Class