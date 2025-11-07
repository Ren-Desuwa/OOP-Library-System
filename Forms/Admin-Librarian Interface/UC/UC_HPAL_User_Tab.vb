' Add these imports for Task.Delay and async operations
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class UC_HPAL_User_Tab

    ' This "debouncing" flag prevents the resize code from running
    Private _isResizePending As Boolean = False

    ' --- STORES ALL USERS ---
    Private _allAccounts As New List(Of Account)() ' Stores the complete list
    Private _selectedUserControl As UC_user_container = Nothing

    ' This will store a reference to the parent form (Home_Panel_Admin_Librarian)
    Private _parentForm As Home_Panel_Admin_Librarian

    ''' <summary>
    ''' This event fires when the UserControl is first loaded.
    ''' </summary>
    Private Sub UC_HPAL_User_Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Wire up the ClientSizeChanged event.
        AddHandler flow_panel_users.ClientSizeChanged, AddressOf flow_panel_users_ClientSizeChanged

        ' Enables double buffering, which reduces flicker
        Me.DoubleBuffered = True

        ' Get the reference to the parent form so we can control its loading panel
        _parentForm = CType(Me.ParentForm, Home_Panel_Admin_Librarian)

        ' Set initial button states
        btn_DeleteUser.Enabled = False
        lbl_allusercount.Text = "0 Users"
    End Sub

    ''' <summary>
    ''' A public function the main form can call to force a resize.
    ''' </summary>
    Public Async Function DoResize() As Task
        ' 1. If a resize is already queued, ignore this new event.
        If _isResizePending Then Return

        ' 2. Set the flag to true, so no new resize events can run.
        _isResizePending = True

        ' 3. Wait 60 milliseconds
        Await Task.Delay(60)

        ' 4. Now that the layout is stable, run the resize logic.
        Try
            For Each userControl As Control In flow_panel_users.Controls
                ' This formula ensures controls fill the width
                userControl.Width = flow_panel_users.ClientSize.Width - userControl.Margin.Horizontal
            Next
        Finally
            ' 5. Reset the flag.
            _isResizePending = False
        End Try
    End Function

    ' This handles small, normal resizes (like a scrollbar appearing)
    Private Async Sub flow_panel_users_ClientSizeChanged(sender As Object, e As EventArgs) Handles flow_panel_users.ClientSizeChanged
        Dim dummyTask As Task = DoResize()
    End Sub


    ''' <summary>
    ''' Fetches ALL accounts from the service ONCE and displays them.
    ''' </summary>
    Public Async Function RefreshUserData() As Task
        Try
            ' 1. Clear existing controls and give user feedback
            flow_panel_users.Controls.Clear()
            lbl_allusercount.Text = "Loading, please wait..."
            _selectedUserControl = Nothing ' Clear selection
            btn_DeleteUser.Enabled = False

            ' 2. Fetch the *entire* list from the database (on a background thread)
            _allAccounts = Await Task.Run(Function()
                                              Return Program.AccountSvc.GetAllAccounts()
                                          End Function)

            ' 3. Display ALL users
            Await DisplayAllUsers()

        Catch ex As Exception
            ' Handle any errors during data fetching
            MessageBox.Show($"Error loading user data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_allusercount.Text = "Error loading users."
        End Try
    End Function

    ''' <summary>
    ''' Clears and repopulates the flow panel with ALL users.
    ''' </summary>
    Private Async Function DisplayAllUsers() As Task
        ' 1. Reset selection state
        _selectedUserControl = Nothing
        btn_DeleteUser.Enabled = False

        ' 2. Update count label
        lbl_allusercount.Text = $"Showing {_allAccounts.Count} of {_allAccounts.Count} users"

        ' 3. --- Add all controls ---
        flow_panel_users.SuspendLayout()
        Try
            For Each account As Account In _allAccounts
                ' Create and add the control
                Dim userControl As New UC_user_container()
                userControl.Width = flow_panel_users.ClientSize.Width - userControl.Margin.Horizontal
                userControl.SetData(account) ' Apply the account data

                ' Wire up the custom 'Selected' event
                AddHandler userControl.Selected, AddressOf UserControl_Selected

                flow_panel_users.Controls.Add(userControl)
            Next
        Finally
            ' 4. Draw all controls at once
            flow_panel_users.ResumeLayout()
        End Try

        ' 5. Run resize logic to make sure widths are correct
        Await DoResize()
    End Function

    ''' <summary>
    ''' Handles the 'Selected' event from any UC_user_container.
    ''' </summary>
    Private Sub UserControl_Selected(sender As Object, e As EventArgs)
        Dim clickedControl = CType(sender, UC_user_container)

        ' De-select the previously selected control (if any)
        If _selectedUserControl IsNot Nothing AndAlso _selectedUserControl IsNot clickedControl Then
            _selectedUserControl.IsSelected = False
        End If

        ' Select the new control
        clickedControl.IsSelected = True
        _selectedUserControl = clickedControl

        ' Enable the action buttons
        btn_DeleteUser.Enabled = True
    End Sub

    ' --- ACTION BUTTON CLICK HANDLERS ---
    Private Sub btn_AddUser_Click(sender As Object, e As EventArgs) Handles btn_AddUser.Click
        ' TODO: Implement Add logic (e.g., show CreateUser form)
        MessageBox.Show("Add User Clicked")
    End Sub

    Private Async Sub btn_DeleteUser_Click(sender As Object, e As EventArgs) Handles btn_DeleteUser.Click
        If _selectedUserControl IsNot Nothing Then
            ' --- We have the selected account! ---
            Dim userToDelete As Account = _selectedUserControl.Account

            ' Confirmation logic
            Dim result = MessageBox.Show($"Are you sure you want to delete user: {userToDelete.Name} ({userToDelete.StudentID})?",
                                         "Confirm Delete",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                ' TODO: Implement Delete logic by calling the service
                Try
                    ' Show loading panel
                    _parentForm._isDataLoading = True
                    _parentForm.ToggleLoading(True, "Deleting User...")

                    ' Call the service on a background thread
                    Await Task.Run(Sub()
                                       Program.AccountSvc.DeleteAccount(userToDelete.AccountID)
                                   End Sub)

                    MessageBox.Show("User deleted successfully.")

                    ' Refresh the list
                    Await RefreshUserData()

                Catch ex As Exception
                    MessageBox.Show("Error deleting user: " & ex.Message, "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    ' Hide loading panel
                    _parentForm._isDataLoading = False
                    _parentForm.ToggleLoading(False)
                End Try
            End If
        Else
            MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btn_DeleteUser.Enabled = False
        End If
    End Sub

End Class