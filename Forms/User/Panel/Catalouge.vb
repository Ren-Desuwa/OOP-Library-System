' Import System.Linq for GroupBy functionality
Imports System.Linq
' Import System.IO for Path and File operations
Imports System.IO

Public Class Catalouge

    Private ReadOnly _dbCon As New DBcon("ooplibrary") '
    Private ReadOnly _catalogueService As catalougeService

    ' Keep track of the currently "maximized" genre controls
    Private _maximizedGenreLabel As Label = Nothing
    Private _maximizedBooksPanel As FlowLayoutPanel = Nothing
    Private _maximizedBackButton As Button = Nothing

    Public Sub New()
        InitializeComponent() '
        _catalogueService = New catalougeService(_dbCon) '
        ' --- ADD HANDLER FOR SEARCH TEXT CHANGED ---
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged ' Or use KeyDown for Enter
    End Sub

    Private Sub picUserIcon_Click(sender As Object, e As EventArgs) Handles picUserIcon.Click
        Login()
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        Login()
    End Sub

    Private Sub Login()
        ' TODO: Implement login logic
    End Sub

    Private Sub Catalouge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- MAKE FORM FULLSCREEN ---
        Me.WindowState = FormWindowState.Maximized
        ' --- REMOVE SIDEBAR ---
        If Me.Controls.ContainsKey("pnlLeftMenu") Then
            Me.Controls.RemoveByKey("pnlLeftMenu") '
        End If
        pnlMainContent.Dock = DockStyle.Fill

        LoadBooksByGenre() '
    End Sub
    ''' <summary>
    ''' Performs the search and updates the display.
    ''' </summary>
    Private Sub DisplaySearchResults(searchTerm As String)
        Try
            Dim results As List(Of Book) = _catalogueService.SearchCatalogue(searchTerm) '

            ' Ensure we are not stuck in maximized genre view
            RestoreDefaultView()

            flpVerticalStack.Controls.Clear() ' Clear previous display (genres or results)
            flpVerticalStack.AutoScroll = True ' Enable vertical scroll for results if needed

            If results.Count = 0 Then
                Dim lblNoResults As New Label() With {
                    .Text = "No books found matching your search.",
                    .Font = New Font("Segoe UI", 12.0!),
                    .AutoSize = True,
                    .Margin = New Padding(20)
                }
                flpVerticalStack.Controls.Add(lblNoResults)
            Else
                ' --- Display Search Results Header (Optional) ---
                Dim lblSearchHeader As New Label() With {
                    .Text = $"Search Results for '{searchTerm}':",
                    .Font = New Font("Segoe UI", 14.25!, FontStyle.Bold),
                    .AutoSize = True,
                    .Margin = New Padding(15, 15, 3, 5)
                 }
                flpVerticalStack.Controls.Add(lblSearchHeader)

                ' --- Display Results using User Control ---
                ' Use a FlowLayoutPanel for results if you want horizontal flow
                Dim flpResults As New FlowLayoutPanel() With {
                    .Dock = DockStyle.Fill, ' Fill available width
                    .AutoSize = True,      ' Grow vertically
                    .FlowDirection = FlowDirection.LeftToRight, ' Arrange books side-by-side
                    .WrapContents = True, ' Wrap books to next line
                    .Padding = New Padding(15)
                 }

                For Each book In results '
                    ' Calculate paths
                    Dim coverFileName As String = book.GetCoverFileName() '
                    Dim startupPath As String = Application.StartupPath '
                    Dim imagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", coverFileName) '
                    Dim defaultPath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", "default_cover.png") '

                    ' Create and setup the User Control
                    Dim bookControl As New BookSortedList() '
                    bookControl.Margin = New Padding(10) '
                    ' Use the new method to show match info
                    bookControl.SetBookDataWithMatchInfo(book, searchTerm, imagePath, defaultPath) '

                    ' Add the User Control to the results panel
                    flpResults.Controls.Add(bookControl) '
                Next

                flpVerticalStack.Controls.Add(flpResults) ' Add the results panel to the main stack
            End If

        Catch ex As Exception
            MessageBox.Show($"Error during search: {ex.Message}", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    ''' <summary>
    ''' Loads the default view grouped by genre. (Modified to use User Control)
    ''' </summary>
    Private Sub LoadBooksByGenre()
        Try
            Dim allBooks As List(Of Book) = _catalogueService.GetAllBooks() '
            Dim booksByGenre = allBooks.GroupBy(Function(b) b.Genre).OrderBy(Function(g) g.Key) '
            flpVerticalStack.Controls.Clear() '
            flpVerticalStack.Dock = DockStyle.Top
            flpVerticalStack.AutoSize = True
            flpVerticalStack.FlowDirection = FlowDirection.TopDown '
            flpVerticalStack.WrapContents = False
            flpVerticalStack.AutoScroll = False ' Disable vertical scroll for genre view

            For Each genreGroup In booksByGenre '
                Dim genreName As String = If(String.IsNullOrEmpty(genreGroup.Key), "Uncategorized", genreGroup.Key) '

                ' --- Header Panel Setup (pnlGenreHeader, btnBack, lblGenre) ---
                Dim pnlGenreHeader As New FlowLayoutPanel() With {
                    .FlowDirection = FlowDirection.LeftToRight, .AutoSize = True, .WrapContents = False, .Margin = New Padding(15, 15, 3, 0)
                } '
                Dim btnBack As New Button() With {
                    .Text = "← Back", .Size = New Size(75, 25), .Visible = False, .Margin = New Padding(0, 0, 10, 0)
                } '
                AddHandler btnBack.Click, AddressOf BackButton_Click '
                Dim lblGenre As New Label() With {
                    .Text = genreName, .Font = New Font("Segoe UI", 14.25!, FontStyle.Bold), .AutoSize = True, .Cursor = Cursors.Hand
                } '
                AddHandler lblGenre.Click, AddressOf GenreLabel_Click '
                pnlGenreHeader.Controls.Add(btnBack) '
                pnlGenreHeader.Controls.Add(lblGenre) '

                ' --- Horizontal Book Panel ---
                Dim flpBooks As New FlowLayoutPanel() With {
                    .AutoScroll = False, .Size = New Size(flpVerticalStack.ClientSize.Width - 30, 230), .Anchor = AnchorStyles.Left Or AnchorStyles.Right, .Margin = New Padding(15, 3, 3, 15), .WrapContents = False, .Visible = True
                } '

                ' --- Store References ---
                Dim genreControls As New Dictionary(Of String, Control) From {
                    {"Label", lblGenre}, {"BooksPanel", flpBooks}, {"BackButton", btnBack}, {"HeaderPanel", pnlGenreHeader}
                } '
                lblGenre.Tag = genreControls '
                btnBack.Tag = genreControls '

                ' --- Add controls ---
                flpVerticalStack.Controls.Add(pnlGenreHeader) '
                flpVerticalStack.Controls.Add(flpBooks) '

                ' --- Populate Books using User Control ---
                For Each book In genreGroup '
                    Dim coverFileName As String = book.GetCoverFileName() '
                    Dim startupPath As String = Application.StartupPath '
                    Dim imagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", coverFileName) '
                    Dim defaultPath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", "default_cover.png") '

                    Dim bookControl As New BookSortedList() '
                    bookControl.Margin = New Padding(10) '
                    ' Use the simple SetBookData for genre view
                    bookControl.SetBookData(book.Title, imagePath, defaultPath) '

                    flpBooks.Controls.Add(bookControl) '
                Next
            Next

        Catch ex As Exception
            MessageBox.Show($"Failed to load book catalogue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error) '
        End Try
    End Sub

    ' --- GenreLabel_Click (Maximize Logic - Corrected) ---
    Private Sub GenreLabel_Click(sender As Object, e As EventArgs)
        Dim lblClicked As Label = TryCast(sender, Label) '
        If lblClicked Is Nothing OrElse lblClicked.Tag Is Nothing Then Return

        Dim clickedControls As Dictionary(Of String, Control) = TryCast(lblClicked.Tag, Dictionary(Of String, Control)) '
        If clickedControls Is Nothing Then Return

        _maximizedGenreLabel = lblClicked '
        _maximizedBooksPanel = TryCast(clickedControls("BooksPanel"), FlowLayoutPanel) '
        _maximizedBackButton = TryCast(clickedControls("BackButton"), Button) '
        Dim maximizedHeaderPanel As FlowLayoutPanel = TryCast(clickedControls("HeaderPanel"), FlowLayoutPanel) '

        For Each control As Control In flpVerticalStack.Controls
            Dim isTargetHeader As Boolean = (control Is maximizedHeaderPanel)
            Dim isTargetBooks As Boolean = (control Is _maximizedBooksPanel)
            control.Visible = (isTargetHeader Or isTargetBooks) '
        Next

        If _maximizedBackButton IsNot Nothing Then
            _maximizedBackButton.Visible = True '
        End If

        If _maximizedBooksPanel IsNot Nothing Then
            _maximizedBooksPanel.Size = New Size(flpVerticalStack.ClientSize.Width - 30, pnlMainContent.ClientSize.Height - maximizedHeaderPanel.Height - 50) '
            _maximizedBooksPanel.AutoScroll = True ' Re-enable scroll for maximized view if needed
        End If
    End Sub

    ' --- BackButton_Click (Restore Logic) ---
    Private Sub BackButton_Click(sender As Object, e As EventArgs)
        RestoreDefaultView() ' Call helper method

        ' Hide the specific back button that was clicked
        Dim btnClicked As Button = TryCast(sender, Button) '
        If btnClicked IsNot Nothing Then
            btnClicked.Visible = False '
        End If
    End Sub

    ' --- Helper Method to Restore Default Genre View ---
    Private Sub RestoreDefaultView()
        ' Only restore if currently maximized
        If _maximizedGenreLabel IsNot Nothing Or _maximizedBooksPanel IsNot Nothing Then
            For Each control As Control In flpVerticalStack.Controls '
                control.Visible = True '
                ' Check if it's one of the book panels
                If TypeOf control Is FlowLayoutPanel AndAlso TryCast(control.Tag, Dictionary(Of String, Control)) Is Nothing Then '
                    Dim flp As FlowLayoutPanel = TryCast(control, FlowLayoutPanel) '
                    flp.Size = New Size(flpVerticalStack.ClientSize.Width - 30, 230) '
                    flp.AutoScroll = False ' Ensure scroll is off when restored
                End If
            Next

            ' Hide the currently visible back button if there is one
            If _maximizedBackButton IsNot Nothing AndAlso _maximizedBackButton.Visible Then
                _maximizedBackButton.Visible = False
            End If


            _maximizedGenreLabel = Nothing '
            _maximizedBooksPanel = Nothing '
            _maximizedBackButton = Nothing '
        End If
        ' Ensure main panel scroll is off for genre view
        flpVerticalStack.AutoScroll = False
    End Sub

    ''' <summary>
    ''' Handles changes in the search text box.
    ''' </summary>
    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        Dim searchTerm As String = txtSearch.Text.Trim()

        ' Simple approach: Search immediately.
        ' Better: Use a Timer to delay search or search on Enter key press in KeyDown event.
        If searchTerm.Length > 1 Then ' Only search if more than 1 character
            DisplaySearchResults(searchTerm)
        ElseIf searchTerm.Length = 0 Then
            ' If search box is cleared, show default genre view
            LoadBooksByGenre()
            ' Ensure we are not in maximized view
            RestoreDefaultView()
        End If
    End Sub


End Class