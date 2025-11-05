' Add this import for Task.Delay
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Public Class UC_HPAL_Book_Tab

    ' This "debouncing" flag prevents the resize code from running
    Private _isResizePending As Boolean = False

    ' --- ADDED FOR PAGINATION AND SELECTION ---
    Private _allBooks As New List(Of Book)() ' Stores the complete list
    Private _currentPage As Integer = 1
    Private Const _pageSize As Integer = 18 ' Show 16 books per page
    Private _totalPages As Integer = 1
    Private _selectedBookControl As UC_Booktable_container = Nothing

    ' --- NEW ---
    ' This will store a reference to the parent form (Home_Panel_Admin_Librarian)
    Private _parentForm As Home_Panel_Admin_Librarian
    ' --- END NEW ---

    ''' <summary>
    ''' This event fires when the UserControl is first loaded.
    ''' </summary>
    Private Sub UC_HPAL_Book_Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Wire up the ClientSizeChanged event.
        AddHandler flow_panel_container.ClientSizeChanged, AddressOf flow_panel_container_ClientSizeChanged

        ' Enables double buffering, which reduces flicker
        Me.DoubleBuffered = True

        ' --- NEW ---
        ' Get the reference to the parent form so we can control its loading panel
        _parentForm = CType(Me.ParentForm, Home_Panel_Admin_Librarian)
        ' --- END NEW ---

        ' Set initial button states
        btn_Editbook.Enabled = False
        btn_previous.Enabled = False
        btn_next.Enabled = False
        lbl_PageInfo.Text = "Page 1 of 1"
    End Sub
    ''' <summary>
    ''' NEW: A public function the main form can call to force a resize.
    ''' This contains the debouncing logic.
    ''' </summary>
    Public Async Function DoResize() As Task
        ' 1. If a resize is already queued, ignore this new event.
        If _isResizePending Then Return

        ' 2. Set the flag to true, so no new resize events can run.
        _isResizePending = True

        ' 3. --- THIS IS YOUR "DELAY" IDEA ---
        '    Wait 20 milliseconds. This gives the window
        '    time to finish maximizing *before* we resize the books.
        Await Task.Delay(60)

        ' 4. Now that the layout is stable, run the resize logic.
        Try
            For Each bookControl As Control In flow_panel_container.Controls
                ' This formula is correct.
                bookControl.Width = flow_panel_container.ClientSize.Width - bookControl.Margin.Horizontal
            Next
        Finally
            ' 5. Reset the flag, allowing the next "final" resize to be processed.
            _isResizePending = False
        End Try
    End Function
    ' This is your OLD sub, which should now look like this:
    Private Async Sub flow_panel_container_ClientSizeChanged(sender As Object, e As EventArgs) Handles flow_panel_container.ClientSizeChanged
        ' Call the new resize logic but don't wait for it
        ' This handles small, normal resizes (like a scrollbar appearing)
        Dim dummyTask As Task = DoResize()
    End Sub

    ' --- THIS FUNCTION IS NOW MODIFIED ---
    ''' <summary>
    ''' Fetches ALL books from the service ONCE and then displays the first page.
    ''' </summary>
    Public Async Function RefreshBookData() As Task
        Try
            ' 1. Clear existing books and give user feedback
            flow_panel_container.Controls.Clear()
            lbl_allbookcount.Text = "Loading, please wait..."
            _selectedBookControl = Nothing ' Clear selection
            btn_Editbook.Enabled = False  '

            ' 2. Fetch the *entire* list from the database (on a background thread)
            _allBooks = Await Task.Run(Function()
                                           Return Program.CatSvc.GetAllBooks()
                                       End Function)

            ' 3. Calculate pagination
            If _allBooks IsNot Nothing AndAlso _allBooks.Any() Then
                _currentPage = 1
                _totalPages = CInt(Math.Ceiling(_allBooks.Count / CSng(_pageSize)))
                If _totalPages = 0 Then _totalPages = 1 ' Ensure at least 1 page
            Else
                _currentPage = 1
                _totalPages = 1
                _allBooks = New List(Of Book)() ' Ensure list is not null
            End If

            ' 4. Display the first page
            Await DisplayCurrentPage()

        Catch ex As Exception
            ' Handle any errors during data fetching
            MessageBox.Show($"Error loading book data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_allbookcount.Text = "Error loading books."
        End Try
    End Function

    ' --- NEW FUNCTION FOR PAGINATION (REWRITTEN) ---
    ''' <summary>
    ''' (REVERTED TO BATCHING)
    ''' Clears and repopulates the flow panel with books for the _currentPage.
    ''' This is the only method that works for this complex control.
    ''' </summary>
    Private Async Function DisplayCurrentPage() As Task
        ' 1. Clear controls and reset selection
        flow_panel_container.Controls.Clear()
        _selectedBookControl = Nothing
        btn_Editbook.Enabled = False

        ' 2. Get the 18 books for the current page using LINQ
        Dim booksToShow = _allBooks.Skip((_currentPage - 1) * _pageSize).Take(_pageSize)

        ' 3. Update labels and buttons
        lbl_PageInfo.Text = $"Page {_currentPage} of {_totalPages}"
        lbl_allbookcount.Text = $"Showing {booksToShow.Count} of {_allBooks.Count} books"
        btn_previous.Enabled = (_currentPage > 1)
        btn_next.Enabled = (_currentPage < _totalPages)

        ' 4. --- THIS IS THE CORRECT BATCHING LOGIC ---
        Dim batchCounter As Integer = 0

        ' We will add 3 books at a time. This is a fast "block".
        Const batchSize As Integer = 1

        ' --- Tell the panel to STOP calculating its layout ---
        flow_panel_container.SuspendLayout()
        Try
            For Each book As Book In booksToShow
                ' Create and add the control (This blocks the UI)
                Dim bookControl As New UC_Booktable_container()
                bookControl.Width = flow_panel_container.ClientSize.Width - bookControl.Margin.Horizontal
                bookControl.SetData(book) ' This also blocks the UI

                AddHandler bookControl.Selected, AddressOf BookControl_Selected

                flow_panel_container.Controls.Add(bookControl)

                batchCounter += 1

                ' Check if the batch of 3 is complete
                If batchCounter Mod batchSize = 0 Then
                    ' --- BATCH IS DONE ---
                    ' 1. Tell the panel to draw the 3 controls. (This is the "STOP")
                    flow_panel_container.ResumeLayout()

                    ' 2. Pause to let the UI thread animate. (This is the "GO")
                    '    We use a short delay so the process is fast.
                    Await Task.Delay(60)

                    ' 3. Suspend layout again for the next batch.
                    flow_panel_container.SuspendLayout()
                End If
            Next
        Finally
            ' 5. Draw any remaining controls
            flow_panel_container.ResumeLayout()
        End Try
    End Function

    ' --- NEW SUBROUTINE FOR SELECTION ---
    ''' <summary>
    ''' Handles the 'Selected' event from any UC_Booktable_container.
    ''' </summary>
    Private Sub BookControl_Selected(sender As Object, e As EventArgs)
        Dim clickedControl = CType(sender, UC_Booktable_container)

        ' De-select the previously selected control (if any)
        If _selectedBookControl IsNot Nothing AndAlso _selectedBookControl IsNot clickedControl Then
            _selectedBookControl.IsSelected = False
        End If

        ' Select the new control
        clickedControl.IsSelected = True
        _selectedBookControl = clickedControl

        ' Enable the Edit button
        btn_Editbook.Enabled = True
    End Sub

    ' --- MODIFIED BUTTON CLICK HANDLERS ---
    Private Async Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        If _currentPage < _totalPages Then
            _currentPage += 1

            ' --- THIS IS THE FIX for Next Page ---
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Loading Page...")
            Await Task.Delay(1) ' Let loading panel draw
            Try
                Await DisplayCurrentPage()
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
            ' --- END OF FIX ---
        End If
    End Sub

    Private Async Sub btn_previous_Click(sender As Object, e As EventArgs) Handles btn_previous.Click
        If _currentPage > 1 Then
            _currentPage -= 1

            ' --- THIS IS THE FIX for Previous Page ---
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Loading Page...")
            Await Task.Delay(1) ' Let loading panel draw
            Try
                Await DisplayCurrentPage()
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
            ' --- END OF FIX ---
        End If
    End Sub

    ' --- THIS IS THE NEW BUTTON CLICK ---
    ' It no longer uses "Using" or "ShowDialog"
    Private Sub btn_Addbooks_Click(sender As Object, e As EventArgs) Handles btn_Addbooks.Click
        Try
            ' 1. Create the new form instance
            Dim createForm As New CreateBook()

            ' 2. Add a handler to its FormClosed event.
            '    This tells VB: "When this form closes, run my 'HandleCreateFormClosed' sub."
            AddHandler createForm.FormClosed, AddressOf HandleCreateFormClosed

            ' 3. Show the form non-modally.
            '    Your code does NOT pause here; it finishes immediately.
            createForm.Show()

        Catch ex As Exception
            ' --- This will catch any crash if the form itself is broken ---
            MessageBox.Show("The 'Create Book' form failed to load." & vbCrLf &
                            "Please copy and paste this error text:" & vbCrLf & vbCrLf &
                            ex.ToString(),
                            "Form Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ADD THIS NEW SUBROUTINE ---
    ' This sub will be called automatically when the CreateBook form closes.
    Private Async Sub HandleCreateFormClosed(sender As Object, e As FormClosedEventArgs)
        ' 1. Get the form that just closed
        Dim closedForm = CType(sender, CreateBook)

        ' 2. Check the public property we are about to add to it
        If closedForm.BookWasCreated Then

            ' 3. If so, refresh the entire book list.
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Refreshing book list...")
            Await Task.Delay(1) ' Let loading panel draw
            Try
                Await RefreshBookData()
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
        End If

        ' 4. Clean up the event handler
        RemoveHandler closedForm.FormClosed, AddressOf HandleCreateFormClosed
    End Sub

    Private Sub btn_Editbook_Click(sender As Object, e As EventArgs) Handles btn_Editbook.Click
        If _selectedBookControl Is Nothing Then
            MessageBox.Show("Please select a book to edit.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btn_Editbook.Enabled = False
            Return
        End If

        Try
            ' 1. Get the book object from the selected control
            Dim bookToEdit As Book = _selectedBookControl.Book

            ' 2. Create the new form instance, passing the book to its constructor
            Dim editForm As New EditBook(bookToEdit)

            ' 3. Add a handler to its FormClosed event
            AddHandler editForm.FormClosed, AddressOf HandleEditFormClosed

            ' 4. Show the form non-modally
            editForm.Show()

        Catch ex As Exception
            MessageBox.Show("The 'Edit Book' form failed to load." & vbCrLf &
                            "Please copy and paste this error text:" & vbCrLf & vbCrLf &
                            ex.ToString(),
                            "Form Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- ADD THIS NEW SUBROUTINE ---
    ' This sub will be called automatically when the EditBook form closes.
    Private Async Sub HandleEditFormClosed(sender As Object, e As FormClosedEventArgs)
        ' 1. Get the form that just closed
        Dim closedForm = CType(sender, EditBook)

        ' 2. Check the public property we added to it
        If closedForm.BookWasUpdated Then

            ' 3. If so, refresh the entire book list.
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Refreshing book list...")
            Await Task.Delay(1) ' Let loading panel draw
            Try
                Await RefreshBookData()
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
        End If

        ' 4. Clean up the event handler
        RemoveHandler closedForm.FormClosed, AddressOf HandleEditFormClosed
    End Sub
End Class