' Add this import for Task.Delay
Imports System.Threading.Tasks
Imports System.Runtime.CompilerServices

Public Class UC_HPAL_Book_Tab

    ' This "debouncing" flag prevents the resize code from running
    Private _isResizePending As Boolean = False

    ' --- MODIFIED FOR SERVER-SIDE PAGINATION ---
    ' This cache will store pages by their page number.
    Private _pageCache As New Dictionary(Of Integer, List(Of Book))()
    Private _currentPage As Integer = 1
    Private Const _pageSize As Integer = 18 ' Show 18 books per page
    Private _totalPages As Integer = 1
    Private _selectedBookControl As UC_Booktable_container = Nothing
    ' --- END MODIFICATION ---

    ' This will store a reference to the parent form (Home_Panel_Admin_Librarian)
    Private _parentForm As Home_Panel_Admin_Librarian

    ''' <summary>
    ''' This event fires when the UserControl is first loaded.
    ''' </summary>
    Private Sub UC_HPAL_Book_Tab_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Wire up the ClientSizeChanged event.
        AddHandler flow_panel_container.ClientSizeChanged, AddressOf flow_panel_container_ClientSizeChanged

        ' Enables double buffering, which reduces flicker
        Me.DoubleBuffered = True

        ' Get the reference to the parent form so we can control its loading panel
        _parentForm = CType(Me.ParentForm, Home_Panel_Admin_Librarian)

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
        ' (This function is unchanged)
        If _isResizePending Then Return
        _isResizePending = True
        Await Task.Delay(60)
        Try
            For Each bookControl As Control In flow_panel_container.Controls
                bookControl.Width = flow_panel_container.ClientSize.Width - bookControl.Margin.Horizontal
            Next
        Finally
            _isResizePending = False
        End Try
    End Function

    Private Async Sub flow_panel_container_ClientSizeChanged(sender As Object, e As EventArgs) Handles flow_panel_container.ClientSizeChanged
        ' (This function is unchanged)
        Dim dummyTask As Task = DoResize()
    End Sub

    ' --- THIS FUNCTION IS HEAVILY MODIFIED ---
    ''' <summary>
    ''' Fetches the TOTAL COUNT and then loads ONLY the first page of books.
    ''' It also pre-fetches the second page in the background.
    ''' </summary>
    Public Async Function RefreshBookData() As Task
        Try
            ' 1. Clear UI and give user feedback
            flow_panel_container.Controls.Clear()
            lbl_allbookcount.Text = "Loading, please wait..."
            _selectedBookControl = Nothing ' Clear selection
            btn_Editbook.Enabled = False

            ' 2. Clear the local cache
            _pageCache.Clear()

            ' 3. Fetch the *total count* from the database (on a background thread)
            '    (This assumes you implemented GetTotalBookCountAsync in CatalougeService)
            Dim totalBookCount As Integer = Await Program.CatSvc.GetTotalBookCountAsync()

            ' 4. Calculate pagination
            If totalBookCount > 0 Then
                _currentPage = 1
                _totalPages = CInt(Math.Ceiling(totalBookCount / CSng(_pageSize)))
                If _totalPages = 0 Then _totalPages = 1 ' Ensure at least 1 page

                ' 5. Fetch ONLY the first page of data
                Await GetPageDataAsync(_currentPage) ' This will fetch and store page 1 in the cache

                ' 6. Display the first page
                Await DisplayCurrentPage()

                ' 7. --- YOUR PRE-FETCH LOGIC ---
                '     Start a background task to pre-fetch page 2.
                '     We don't 'Await' this; let it run in the background.
                If _totalPages > 1 Then
                    Dim prefetchTask As Task = Task.Run(Async Function()
                                                            Await GetPageDataAsync(_currentPage + 1)
                                                        End Function)
                End If

            Else
                ' No books found
                _currentPage = 1
                _totalPages = 1
                lbl_allbookcount.Text = "No books found."
                Await DisplayCurrentPage() ' Will display an empty page
            End If

        Catch ex As Exception
            ' Handle any errors during data fetching
            MessageBox.Show($"Error loading book data: {ex.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lbl_allbookcount.Text = "Error loading books."
        End Try
    End Function

    ' --- NEW HELPER FUNCTION FOR CACHING ---
    ''' <summary>
    ''' Gets book data for a specific page, either from the cache or the database.
    ''' This is the central function for managing the page cache.
    ''' </summary>
    ''' <param name="pageNumber">The 1-based page number to fetch.</param>
    Private Async Function GetPageDataAsync(pageNumber As Integer) As Task
        ' 1. Don't fetch if page is out of bounds
        If pageNumber <= 0 OrElse pageNumber > _totalPages Then
            Return
        End If

        ' 2. Don't fetch if data is already in the cache
        If _pageCache.ContainsKey(pageNumber) Then
            Return
        End If

        ' 3. Data is not in cache. Fetch it from the service.
        '    (This assumes you implemented GetBooksByPageAsync in CatalougeService)
        Try
            Dim books As List(Of Book) = Await Program.CatSvc.GetBooksByPageAsync(pageNumber, _pageSize)

            If books IsNot Nothing Then
                ' 4. Store the fetched page in the cache
                _pageCache(pageNumber) = books
            End If
        Catch ex As Exception
            ' Log or handle error if a background pre-fetch fails
            Console.WriteLine($"Error pre-fetching page {pageNumber}: {ex.Message}")
        End Try
    End Function


    ' --- THIS IS THE NEW, FAST DRAWING FUNCTION ---
    ''' <summary>
    ''' Clears and repopulates the flow panel with books for the _currentPage.
    ''' It now reads books from the _pageCache and draws them all at once.
    ''' </summary>
    Private Async Function DisplayCurrentPage() As Task
        ' 1. Clear controls and reset selection
        flow_panel_container.Controls.Clear()
        _selectedBookControl = Nothing
        btn_Editbook.Enabled = False

        ' 2. Get the books for the current page *from the cache*
        Dim booksToShow As New List(Of Book)()
        If _pageCache.ContainsKey(_currentPage) Then
            booksToShow = _pageCache(_currentPage)
        Else
            ' This is a safety check. It shouldn't be hit if logic is correct.
            lbl_allbookcount.Text = $"Error: Page {_currentPage} not found in cache."
            btn_previous.Enabled = (_currentPage > 1)
            btn_next.Enabled = (_currentPage < _totalPages)
            lbl_PageInfo.Text = $"Page {_currentPage} of {_totalPages}"
            Return
        End If

        ' 3. Update labels and buttons
        lbl_PageInfo.Text = $"Page {_currentPage} of {_totalPages}"
        lbl_allbookcount.Text = $"Showing {booksToShow.Count} books" ' Simplified
        btn_previous.Enabled = (_currentPage > 1)
        btn_next.Enabled = (_currentPage < _totalPages)

        ' 4. --- THIS IS THE NEW, FAST BATCHING LOGIC ---

        ' --- Tell the panel to STOP calculating its layout ---
        flow_panel_container.SuspendLayout()
        Try
            ' Create a list to hold the new controls
            Dim newControls As New List(Of Control)

            For Each book As Book In booksToShow
                ' Create and configure the control
                Dim bookControl As New UC_Booktable_container()
                bookControl.Width = flow_panel_container.ClientSize.Width - bookControl.Margin.Horizontal
                bookControl.SetData(book)
                AddHandler bookControl.Selected, AddressOf BookControl_Selected

                ' Add to our temporary list (NOT to the panel yet)
                newControls.Add(bookControl)
            Next

            ' 5. Add ALL 18 controls to the panel in a single operation.
            '    This is thousands of times faster.
            flow_panel_container.Controls.AddRange(newControls.ToArray())

        Finally
            ' 6. Tell the panel to draw everything ONE time.
            flow_panel_container.ResumeLayout()
        End Try

        ' 7. The Await Task.Delay is GONE.
        '    We will only wait 1ms to let the UI breathe *after* drawing.
        Await Task.Delay(1)
    End Function

    ' --- SELECTION SUBROUTINE (Unchanged) ---
    ''' <summary>
    ''' Handles the 'Selected' event from any UC_Booktable_container.
    ''' </summary>
    Private Sub BookControl_Selected(sender As Object, e As EventArgs)
        Dim clickedControl = CType(sender, UC_Booktable_container)
        If _selectedBookControl IsNot Nothing AndAlso _selectedBookControl IsNot clickedControl Then
            _selectedBookControl.IsSelected = False
        End If
        clickedControl.IsSelected = True
        _selectedBookControl = clickedControl
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
                ' 1. Get the page data (from cache or service)
                Await GetPageDataAsync(_currentPage)

                ' 2. Display the data
                Await DisplayCurrentPage()

                ' 3. --- YOUR CACHE LOGIC ---
                '    Pre-fetch the *new* next page in the background
                Task.Run(Async Function()
                             Await GetPageDataAsync(_currentPage + 1)
                         End Function)

                '    "Forget" the old previous page
                If _pageCache.ContainsKey(_currentPage - 2) Then
                    _pageCache.Remove(_currentPage - 2)
                End If
                ' --- END CACHE LOGIC ---

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
                ' 1. Get the page data (from cache or service)
                Await GetPageDataAsync(_currentPage)

                ' 2. Display the data
                Await DisplayCurrentPage()

                ' 3. --- YOUR CACHE LOGIC ---
                '    Pre-fetch the *new* previous page in the background
                Task.Run(Async Function()
                             Await GetPageDataAsync(_currentPage - 1)
                         End Function)

                '    "Forget" the old next page
                If _pageCache.ContainsKey(_currentPage + 2) Then
                    _pageCache.Remove(_currentPage + 2)
                End If
                ' --- END CACHE LOGIC ---

            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
            ' --- END OF FIX ---
        End If
    End Sub

    ' --- ADD/EDIT BUTTONS (Unchanged, but logic is still correct) ---
    ' These functions call RefreshBookData(), which now clears the
    ' cache and re-loads the total count and page 1. This is
    ' the correct behavior after an Add or Edit.

    Private Sub btn_Addbooks_Click(sender As Object, e As EventArgs) Handles btn_Addbooks.Click
        ' (This function is unchanged)
        Try
            Dim createForm As New CreateBook()
            AddHandler createForm.FormClosed, AddressOf HandleCreateFormClosed
            createForm.Show()
        Catch ex As Exception
            MessageBox.Show("The 'Create Book' form failed to load." & vbCrLf &
                            "Please copy and paste this error text:" & vbCrLf & vbCrLf &
                            ex.ToString(),
                            "Form Load Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub HandleCreateFormClosed(sender As Object, e As FormClosedEventArgs)
        ' (This function is unchanged)
        Dim closedForm = CType(sender, CreateBook)
        If closedForm.BookWasCreated Then
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Refreshing book list...")
            Await Task.Delay(1)
            Try
                Await RefreshBookData() ' This reloads count and page 1
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
        End If
        RemoveHandler closedForm.FormClosed, AddressOf HandleCreateFormClosed
    End Sub

    Private Sub btn_Editbook_Click(sender As Object, e As EventArgs) Handles btn_Editbook.Click
        ' (This function is unchanged)
        If _selectedBookControl Is Nothing Then
            MessageBox.Show("Please select a book to edit.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            btn_Editbook.Enabled = False
            Return
        End If

        Try
            Dim bookToEdit As Book = _selectedBookControl.Book
            Dim editForm As New EditBook(bookToEdit)
            AddHandler editForm.FormClosed, AddressOf HandleEditFormClosed
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

    Private Async Sub HandleEditFormClosed(sender As Object, e As FormClosedEventArgs)
        ' (This function is unchanged)
        Dim closedForm = CType(sender, EditBook)
        If closedForm.BookWasUpdated Then
            _parentForm._isDataLoading = True
            _parentForm.ToggleLoading(True, "Refreshing book list...")
            Await Task.Delay(1)
            Try
                Await RefreshBookData() ' This reloads count and page 1
            Finally
                _parentForm._isDataLoading = False
                _parentForm.ToggleLoading(False)
            End Try
        End If
        RemoveHandler closedForm.FormClosed, AddressOf HandleEditFormClosed
    End Sub
End Class