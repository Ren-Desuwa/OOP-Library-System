Imports System.Threading.Tasks

Public Class Home_Panel_Admin_Librarian
    Implements ILoadingContainer
    Public logsTab As UC_HPAL_Logs_Tab
    Public pendingLogs As New List(Of String)
    Public Event LogoutClicked As EventHandler

    ' Change 'Private' to 'Friend' so the User Controls can set this flag
    Friend _isDataLoading As Boolean = False

    ' --- NEW VARIABLES FOR RESIZING ---
    Private _isFormLoaded As Boolean = False
    ' This will store the *last* state of the window
    Private _lastWindowState As FormWindowState = Me.WindowState
    ' --- END NEW VARIABLES ---

    Private Sub Home_Panel_Admin_Librarian_Load(sender As Object, e As EventArgs) Handles Me.Load
        _isFormLoaded = True
    End Sub

    ' This is the function required by the ILoadingContainer interface.
    Public Sub ToggleLoading(show As Boolean, Optional message As String = "Loading...") Implements ILoadingContainer.ToggleLoading
        If Me.InvokeRequired Then
            ' Handle calls from other threads if necessary
            Me.Invoke(New Action(Of Boolean, String)(AddressOf ToggleLoading), show, message)
            Return
        End If

        If show Then
            ' Set the message, make it visible, and bring it to the very front
            UC_Loading_Panel1.SetMessage(message)
            UC_Loading_Panel1.Visible = True
            UC_Loading_Panel1.BringToFront()
            UC_Loading_Panel1.Refresh()
        Else
            ' Hide it and send it back
            UC_Loading_Panel1.Visible = False
            UC_Loading_Panel1.SendToBack()
        End If
    End Sub

    ' --- RESIZE FUNCTION ---
    Private Async Sub Home_Panel_Admin_Librarian_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ' Get the current state
        Dim currentState As FormWindowState = Me.WindowState

        ' --- SAFETY CHECKS ---
        If Not _isFormLoaded OrElse UC_HPAL_Book_Tab1 Is Nothing Then
            _lastWindowState = currentState ' Keep this updated
            Return ' Do nothing if the form or control isn't ready
        End If
        ' --- END OF CHECKS ---


        ' Check if the window state has *changed*
        If currentState <> _lastWindowState Then

            ' We will run the loading logic if the new state is
            ' Maximized (going up) OR Normal (coming down).
            If currentState = FormWindowState.Maximized OrElse currentState = FormWindowState.Normal Then

                ' 1. Show the loading panel FIRST.
                ToggleLoading(True, "Please wait...")

                ' 2. Wait 1ms to make SURE the loading panel is visible
                Await Task.Delay(1)

                ' 3. NOW, tell the VISIBLE tab to do its resize.
                If UC_HPAL_Book_Tab1.Visible Then
                    Await UC_HPAL_Book_Tab1.DoResize()
                ElseIf UC_HPAL_User_Tab1.Visible Then
                    Await UC_HPAL_User_Tab1.DoResize()
                End If
                ' (Add ElseIf for other tabs as needed)

                ' 4. Hide the loading panel immediately after.
                ToggleLoading(False)
            End If
        End If

        ' IMPORTANT: Update the last state for the next event
        _lastWindowState = currentState
    End Sub
    ' --- END OF RESIZE FUNCTION ---


    ''' <summary>
    ''' Brings the specified UserControl to the front of the container panel.
    ''' </summary>
    ''' <param name="controlToShow">The UserControl to display.</param>
    Private Sub ShowTab(ByVal controlToShow As UserControl)
        ' This ensures only the selected tab is visible
        UC_HPAL_Book_Tab1.Visible = (controlToShow Is UC_HPAL_Book_Tab1)
        UC_HPAL_User_Tab1.Visible = (controlToShow Is UC_HPAL_User_Tab1)
        UC_HPAL_Librarian_Tab1.Visible = (controlToShow Is UC_HPAL_Librarian_Tab1)
        UC_HPAL_Request_Tab1.Visible = (controlToShow Is UC_HPAL_Request_Tab1)
        UC_HPAL_Logs_Tab1.Visible = (controlToShow Is UC_HPAL_Logs_Tab1)

        ' Bring the correct one to the front
        controlToShow.BringToFront()
    End Sub

    ' We now use the _isDataLoading flag and re-order the 'ShowTab' call
    Private Async Sub btn_Books_Click(sender As Object, e As EventArgs) Handles btn_Books.Click
        If _isDataLoading Then Return ' Prevent double-clicks
        _isDataLoading = True ' Set the flag
        Try
            ' 1. Show the loading panel BEFORE doing any work
            ToggleLoading(True, "Loading Books...")

            ' 2. Give the UI thread 1ms to "breathe" and draw the loading panel
            Await Task.Delay(1)

            ' 3. AWAIT the data loading *while the tab is still INVISIBLE*.
            Await UC_HPAL_Book_Tab1.RefreshBookData()

            ' 4. NOW that all the data is loaded, show the tab.
            ShowTab(UC_HPAL_Book_Tab1)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' 5. ALWAYS hide the loading panel and reset the flag
            _isDataLoading = False ' Reset the flag
            ToggleLoading(False)
        End Try
    End Sub


    ' --- THIS IS THE CORRECTED CODE FOR THE USER BUTTON ---
    Private Async Sub btn_User_Click(sender As Object, e As EventArgs) Handles btn_User.Click
        If _isDataLoading Then Return ' Prevent double-clicks
        _isDataLoading = True ' Set the flag
        Try
            ' 1. Show the loading panel BEFORE doing any work
            ToggleLoading(True, "Loading Users...")

            ' 2. Give the UI thread 1ms to "breathe" and draw the loading panel
            Await Task.Delay(1)

            ' 3. AWAIT the data loading
            Await UC_HPAL_User_Tab1.RefreshUserData()

            ' 4. NOW that all the data is loaded, show the tab.
            ShowTab(UC_HPAL_User_Tab1)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' 5. ALWAYS hide the loading panel and reset the flag
            _isDataLoading = False ' Reset the flag
            ToggleLoading(False)
        End Try
    End Sub

    ' --- CORRECTED LIBRARIAN BUTTON ---
    Private Async Sub btn_Librarian_Click(sender As Object, e As EventArgs) Handles btn_Librarian.Click
        If _isDataLoading Then Return ' Prevent double-clicks
        _isDataLoading = True ' Set the flag
        Try
            ToggleLoading(True, "Loading Librarians...")
            Await Task.Delay(1)

            ' TODO: Call the RefreshData function for your Librarian Tab
            ' Await UC_HPAL_Librarian_Tab1.RefreshLibrarianData()

            ShowTab(UC_HPAL_Librarian_Tab1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _isDataLoading = False ' Reset the flag
            ToggleLoading(False)
        End Try
    End Sub

    ' --- CORRECTED NOTIFICATION/REQUEST BUTTON ---
    Private Async Sub btn_notification_Click(sender As Object, e As EventArgs) Handles btn_notification.Click
        If _isDataLoading Then Return ' Prevent double-clicks
        _isDataLoading = True ' Set the flag
        Try
            ToggleLoading(True, "Loading Requests...")
            Await Task.Delay(1)

            ' TODO: Call the RefreshData function for your Request Tab
            ' Await UC_HPAL_Request_Tab1.RefreshRequestData()

            ShowTab(UC_HPAL_Request_Tab1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _isDataLoading = False ' Reset the flag
            ToggleLoading(False)
        End Try
    End Sub

    ' --- CORRECTED LOGS BUTTON ---
    Private Async Sub btn_Logs_Click(sender As Object, e As EventArgs) Handles btn_Logs.Click
        If _isDataLoading Then Return ' Prevent double-clicks
        _isDataLoading = True ' Set the flag
        Try
            ToggleLoading(True, "Loading Logs...")
            Await Task.Delay(1)

            ' TODO: Call the RefreshData function for your Logs Tab
            ' Await UC_HPAL_Logs_Tab1.RefreshLogData()

            ShowTab(UC_HPAL_Logs_Tab1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            _isDataLoading = False ' Reset the flag
            ToggleLoading(False)
        End Try
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        ' --- This line raises the event for Program.vb ---
        RaiseEvent LogoutClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        ' TODO: Implement profile logic
    End Sub

    Private Sub UC_Loading_Panel1_Load(sender As Object, e As EventArgs) Handles UC_Loading_Panel1.Load

    End Sub
End Class