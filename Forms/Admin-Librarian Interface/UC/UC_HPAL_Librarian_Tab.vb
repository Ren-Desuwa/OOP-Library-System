' Add these imports for Task, Task.Delay, and List
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Linq

Public Class UC_HPAL_Librarian_Tab

    ' This "debouncing" flag prevents the resize code from running
    Private _isResizePending As Boolean = False

    ' --- ADDED FOR DATA AND SELECTION ---
    Private _allLibrarians As New List(Of Account)() ' Stores the complete list
    Private _selectedLibrarianControl As UC_Librarian_container = Nothing

    ''' <summary>
    ''' This event fires when the UserControl is first loaded.
    ''' </summary>
    Private Sub UC_HPAL_Librarian_Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Wire up the ClientSizeChanged event.
        AddHandler flow_panel_container.ClientSizeChanged, AddressOf flow_panel_container_ClientSizeChanged ' [cite: 85]

        ' Enables double buffering, which reduces flicker
        Me.DoubleBuffered = True

        ' Set initial button states
        btn_remove.Enabled = False ' [cite: 89]
        lbl_librarian.Text = "No. of Librarians: 0" ' [cite: 93-95]

        ' Load the data asynchronously
        Dim dummyTask As Task = RefreshLibrarianData()
    End Sub

    ''' <summary>
    ''' Public function to force a resize (same as book tab).
    ''' This contains the debouncing logic. [cite: 181-188]
    ''' </summary>
    Public Async Function DoResize() As Task
        If _isResizePending Then Return
        _isResizePending = True
        Await Task.Delay(60) ' Wait for layout to stabilize

        Try
            For Each libControl As Control In flow_panel_container.Controls ' [cite: 85]
                ' Set width to fill the panel
                libControl.Width = flow_panel_container.ClientSize.Width - libControl.Margin.Horizontal ' [cite: 85]
            Next
        Finally
            _isResizePending = False
        End Try
    End Function

    ' Handles small, normal resizes (like a scrollbar appearing) [cite: 181-188]
    Private Async Sub flow_panel_container_ClientSizeChanged(sender As Object, e As EventArgs) Handles flow_panel_container.ClientSizeChanged
        Dim dummyTask As Task = DoResize()
    End Sub


    ''' <summary>
    ''' Fetches ALL librarians from the service and displays them.
    ''' (No pagination is needed here, simplifying the logic from the book tab)
    ''' </summary>
    Public Async Function RefreshLibrarianData() As Task
        Try
            ' 1. Clear existing controls and give user feedback
            flow_panel_container.Controls.Clear() ' [cite: 85]
            lbl_librarian.Text = "Loading, please wait..." ' [cite: 93-95]
            _selectedLibrarianControl = Nothing ' Clear selection
            btn_remove.Enabled = False ' [cite: 89]

            ' 2. Fetch the *entire* list from the database (on a background thread)
            '    using your new LibrarianService.
            '    (Assuming you have initialized it as Program.LibSvc)
            _allLibrarians = Await Task.Run(Function()
                                                Return Program.LibSvc.GetAllLibrarians()
                                            End Function)

            ' 3. Update count and ensure list is not null
            If _allLibrarians Is Nothing Then
                _allLibrarians = New List(Of Account)()
            End If
            lbl_librarian.Text = $"No. of Librarians: {_allLibrarians.Count}" ' [cite: 93-95]


            ' 4. Display all librarians (with batching, like the book tab) [cite: 198-205]
            Const batchSize As Integer = 1 ' Load one at a time to keep UI responsive
            Dim batchCounter As Integer = 0

            flow_panel_container.SuspendLayout() ' [cite: 85]
            Try
                For Each lib As Account In _allLibrarians
                    ' Create and add the control
                    Dim libControl As New UC_Librarian_container()
                    libControl.Width = flow_panel_container.ClientSize.Width - libControl.Margin.Horizontal ' [cite: 85]
                    libControl.SetData(lib)

                    ' Add the event handler for selection
                    AddHandler libControl.Selected, AddressOf LibrarianControl_Selected

                    flow_panel_container.Controls.Add(libControl) ' [cite: 85]

                    batchCounter += 1
                    ' Check if the batch is complete
                    If batchCounter Mod batchSize = 0 Then
                        flow_panel_container.ResumeLayout() ' [cite: 85]
                        Await Task.Delay(1) ' Pause to let UI thread update (1ms is usually enough)
                        flow_panel_container.SuspendLayout() ' [cite: 85]
                    End If
                Next
            Finally
                ' 5. Draw any remaining controls
                flow_panel_container.ResumeLayout() ' [cite: 85]
            End Try

        Catch ex As Exception
            ' Handle any errors during data fetching
            MessageBox.Show($"Error loading librarian data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_librarian.Text = "Error loading data." ' [cite: 93-95]
        End Try
    End Function

    ''' <summary>
    ''' Handles the 'Selected' event from any UC_Librarian_container. [cite: 206-207]
    ''' </summary>
    Private Sub LibrarianControl_Selected(sender As Object, e As EventArgs)
        Dim clickedControl = CType(sender, UC_Librarian_container)

        ' De-select the previously selected control (if any)
        If _selectedLibrarianControl IsNot Nothing AndAlso _selectedLibrarianControl IsNot clickedControl Then
            _selectedLibrarianControl.IsSelected = False
        End If

        ' Select the new control
        clickedControl.IsSelected = True
        _selectedLibrarianControl = clickedControl

        ' Enable the Remove button
        btn_remove.Enabled = True ' [cite: 89]
    End Sub

    ' --- BUTTON CLICK HANDLERS ---

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click ' [cite: 91]
        ' TODO: Implement Add logic (e.g., show CreateLibrarian form)
        MessageBox.Show("Add Librarian Clicked")
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click ' [cite: 89]
        If _selectedLibrarianControl IsNot Nothing Then
            ' --- We have the selected librarian! ---
            Dim libToRemove As Account = _selectedLibrarianControl.Librarian

            Dim result As DialogResult = MessageBox.Show($"Are you sure you want to remove '{libToRemove.Name}'?",
                                                         "Confirm Removal",
                                                         MessageBoxButtons.YesNo,
                                                         MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                MessageBox.Show($"Removing librarian: {libToRemove.Name}")
                ' TODO: Implement Remove logic
                ' Example:
                ' Try
                '     Program.LibSvc.RemoveAccount(libToRemove.AccountID, Program.CurrentUser.AccountID)
                '     Dim dummyTask As Task = RefreshLibrarianData() ' Refresh list after removal
                ' Catch ex As Exception
                '     MessageBox.Show("Error removing account: " & ex.Message)
                ' End Try
            End If
        Else
            MessageBox.Show("Please select a librarian to remove.", "No Librarian Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btn_remove.Enabled = False ' [cite: 89]
        End If
    End Sub
End Class