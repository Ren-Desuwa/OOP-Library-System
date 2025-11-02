Imports System.IO
Imports System.Windows.Forms
Imports System.Linq ' <-- Make sure this is at the top

Partial Class Home_Panel_Guest
    Implements ILoadingContainer  ' <-- 1. Implement the Interface

    Public Event OpenLogin As EventHandler

    ' --- 2. THIS METHOD IS REQUIRED BY THE INTERFACE ---
    ''' <summary>
    ''' Public method to control the new loading panel.
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

    ' --- 3. THIS IS THE MODIFIED LOAD EVENT ---
    ' Note: We MUST make this event "Async Sub"
    Private Async Sub Home_Panel_Guest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await Task.Delay(50)

        ' --- ADD THIS LINE ---
        UC_HPS_catalouge_tab1.IsGuestMode = True
        ' --- END ADDITION ---

        UC_HPS_catalouge_tab1.BeginLoading(Me)
    End Sub

    ' --- 4. THIS HOOKS UP YOUR SEARCH BAR ---
    ' (This assumes your search textbox is named txtBox_username, based on your files)
    Private Async Sub txtBox_username_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged
        ' Tell the catalogue control to filter its results
        Await UC_HPS_catalouge_tab1.Search(txtBox_username.Text)
    End Sub

    ' --- 5. THIS IS YOUR EXISTING LOGIN BUTTON CODE ---
    Private Sub btn_Open_Login(sender As Object, e As EventArgs) Handles btn_profile.Click, lbl_user.Click
        MessageBox.Show("clicked")
        RaiseEvent OpenLogin(Me, EventArgs.Empty)
    End Sub

    ' We no longer need any of the old book-loading or button-creating methods
    ' as the User Control handles all of that now.

End Class