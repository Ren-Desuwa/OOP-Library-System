Imports System.Threading.Tasks
Imports System.Windows.Forms

Public Class Home_Panel_Students
    ' --- This event is for Program.vb to listen to ---
    Public Event LogoutClicked As EventHandler

    ' --- This event is for the loading panel ---
    Private _loadingTaskCompletionSource As TaskCompletionSource(Of Boolean)

    Public Sub New()
        InitializeComponent()
        ' We want to be notified when the Home tab finishes its async loading
        AddHandler UC_HPS_home_tab1.AsyncLoadComplete, AddressOf OnHomeTabLoaded
    End Sub

    ''' <summary>
    ''' Hides all panels except the one specified.
    ''' </summary>
    Private Sub ShowPanel(panel As Control)
        ' Hide all panels first
        UC_HPS_home_tab1.Hide()
        UC_HPS_catalouge_tab1.Hide()
        UC_HPS_borrowed_books_tab1.Hide()
        UC_HPS_penalty_tab1.Hide()

        ' Show the one we want
        panel.Show()
        panel.BringToFront()
    End Sub

#Region "Navigation Button Handlers"

    ' --- THIS IS A GUESS, as your provided file cut off btn_home ---
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_Home_tab.Click
        ShowPanel(UC_HPS_home_tab1)
    End Sub

    Private Sub btn_catalouge_Click(sender As Object, e As EventArgs) Handles btn_Catalouge_tab.Click
        ShowPanel(UC_HPS_catalouge_tab1)
    End Sub

    ' --- *** THIS IS THE FIXED SUBROUTINE *** ---
    Private Sub btn_borrowed_Click(sender As Object, e As EventArgs) Handles btn_Borrowed_Books_tab.Click
        ShowPanel(UC_HPS_borrowed_books_tab1)
        ' Refresh the borrowed books tab every time it's clicked
        ' --- FIX: Changed 'LoadBorrowedBooksAsync' to 'LoadData' ---
        UC_HPS_borrowed_books_tab1.LoadData()
    End Sub
    ' --- *** END OF FIX *** ---

    Private Sub btn_penalty_Click(sender As Object, e As EventArgs) Handles btn_Penalty_tab.Click
        ShowPanel(UC_HPS_penalty_tab1)
    End Sub
    ' --- END GUESS ---


    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        ' Raise the event for Program.vb to catch
        RaiseEvent LogoutClicked(Me, EventArgs.Empty)
    End Sub

#End Region

#Region "Async Loading and Welcome Message"

    ''' <summary>
    ''' Called by Program.vb AFTER login to set the user's name and credit score.
    ''' </summary>
    ' --- *** MODIFIED METHOD *** ---
    Public Sub SetStudentInfo(account As Account)
        If account Is Nothing Then Return

        ' 1. Set the name on the main panel
        ' 'lbl_user' is the correct name from your .Designer.vb file
        lbl_user.Text = account.Name

        ' 2. Pass the score to the Home tab to update its UI
        ' This is the fix for the protection level error.
        UC_HPS_home_tab1.UpdateCreditScoreUI(account.CreditScore)
    End Sub
    ' --- *** END MODIFICATION *** ---

    ''' <summary>
    ''' This runs when the form is first shown. It starts the async loading.
    ''' </summary>
    Private Sub Home_Panel_Students_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ' Show the loading panel
        ToggleLoading(True, "Loading Student Dashboard...")

        ' --- START FIX ---

        ' 1. Set the catalogue to "Student Mode" (not Guest)
        UC_HPS_catalouge_tab1.IsGuestMode = False

        ' 2. Tell the catalogue to start loading its data in the background.
        '    We pass 'Me' as the ILoadingContainer and 'False' because
        '    we don't want it to show its *own* loading screen.
        UC_HPS_catalouge_tab1.BeginLoading()

        ' --- END FIX ---

        ' Start the home tab's async loading
        ' (The HomeTabLoaded event will fire when this is done)
        UC_HPS_home_tab1.LoadDataAsync()
    End Sub

    ''' <summary>
    ''' Event handler for when the Home tab signals it's done loading.
    ''' </summary>
    Private Sub OnHomeTabLoaded(sender As Object, e As EventArgs)
        ' Hide the loading panel
        ToggleLoading(False)
    End Sub

    ''' <summary>
    ''' Toggles the visibility of the loading panel.
    ''' </summary>
    Public Sub ToggleLoading(show As Boolean, Optional message As String = "Loading...")
        If show Then
            UC_Loading_Panel1.SetMessage(message)
            UC_Loading_Panel1.BringToFront()
            UC_Loading_Panel1.Show()
        Else
            UC_Loading_Panel1.Hide()
        End If
    End Sub
#End Region

    ' This event is often better than the Load event, as it runs *after* the UI is visible.


    ' --- OR, if you use the Load event ---



End Class