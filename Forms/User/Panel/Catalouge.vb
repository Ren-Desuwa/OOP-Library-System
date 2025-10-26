Imports System.Linq
Imports System.IO

Public Class Catalouge

    Private ReadOnly _dbCon As New DBcon("ooplibrary")
    Private ReadOnly _catalogueService As catalougeService

    ' Data Storage
    Private _allBooks As List(Of Book) = New List(Of Book)()
    Private _booksByGenre As Dictionary(Of String, List(Of Book)) = New Dictionary(Of String, List(Of Book))(StringComparer.OrdinalIgnoreCase)
    Private _sortedGenreNames As List(Of String) = New List(Of String)()
    Private _genresDisplayedCount As Integer = 0
    Private Const GENRES_PER_PAGE As Integer = 5

    ' Controls
    Private _genrePageControlInstance As GenrePageControl = Nothing
    Private _btnMoreGenres As Button = Nothing

    Public Sub New()
        InitializeComponent()
        _catalogueService = New catalougeService(_dbCon)
        AddHandler txtSearch.TextChanged, AddressOf txtSearch_TextChanged
    End Sub

    ' --- Event Handlers ---
    Private Sub picUserIcon_Click(sender As Object, e As EventArgs) Handles picUserIcon.Click
        Login()
    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click
        Login()
    End Sub

    Private Sub Login()
        MessageBox.Show("Login() called.")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)
        Dim searchTerm As String = txtSearch.Text.Trim()
        If searchTerm.Length > 1 Then
            DisplaySearchResults(searchTerm)
        ElseIf searchTerm.Length = 0 Then
            ShowGenreView()
        End If
    End Sub

    Private Sub Catalouge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        ' Remove old sidebar if exists
        If Me.Controls.ContainsKey("pnlLeftMenu") Then
            Me.Controls.RemoveByKey("pnlLeftMenu")
        End If

        ' Setup main content panel
        pnlMainContent.Dock = DockStyle.Fill
        pnlMainContent.AutoScroll = True
        pnlMainContent.BackColor = Color.AntiqueWhite

        ' Setup vertical stack - SIMPLIFIED
        flpVerticalStack.SuspendLayout()
        flpVerticalStack.Controls.Clear()
        flpVerticalStack.Location = New Point(0, 0)
        flpVerticalStack.AutoSize = True
        flpVerticalStack.AutoSizeMode = AutoSizeMode.GrowAndShrink
        flpVerticalStack.MinimumSize = New Size(pnlMainContent.ClientSize.Width - 25, 0)
        flpVerticalStack.MaximumSize = New Size(pnlMainContent.ClientSize.Width - 25, 0)
        flpVerticalStack.FlowDirection = FlowDirection.TopDown
        flpVerticalStack.WrapContents = False
        flpVerticalStack.Dock = DockStyle.None
        flpVerticalStack.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        flpVerticalStack.ResumeLayout()

        ' Setup genre page control
        _genrePageControlInstance = New GenrePageControl() With {
            .Dock = DockStyle.Fill,
            .Visible = False
        }
        AddHandler _genrePageControlInstance.BackButtonClicked, AddressOf GenrePage_BackClicked
        AddHandler _genrePageControlInstance.BookClickedRelay, AddressOf HandleBookClicked
        pnlMainContent.Controls.Add(_genrePageControlInstance)
        _genrePageControlInstance.BringToFront()

        ' Setup more button
        _btnMoreGenres = New Button() With {
            .Text = "Load More Genres",
            .Height = 40,
            .Width = flpVerticalStack.ClientSize.Width - 20,
            .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
            .Visible = False,
            .Margin = New Padding(10)
        }
        AddHandler _btnMoreGenres.Click, AddressOf btnMoreGenres_Click

        ' Handle resize to update widths
        AddHandler Me.Resize, AddressOf Form_Resize

        LoadAllBookData()
        ShowGenreView()
    End Sub

    Private Sub Form_Resize(sender As Object, e As EventArgs)
        If flpVerticalStack IsNot Nothing Then
            Dim newWidth As Integer = pnlMainContent.ClientSize.Width - 25
            flpVerticalStack.MinimumSize = New Size(newWidth, 0)
            flpVerticalStack.MaximumSize = New Size(newWidth, 0)

            ' Update all genre rows
            For Each ctrl As Control In flpVerticalStack.Controls
                If TypeOf ctrl Is GenreRowControl Then
                    ctrl.Width = newWidth - 10
                End If
            Next
        End If
    End Sub

    Private Sub LoadAllBookData()
        Try
            _allBooks = _catalogueService.GetAllBooks()

            If _allBooks Is Nothing OrElse _allBooks.Count = 0 Then
                MessageBox.Show("No books loaded from database.", "Data Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _booksByGenre.Clear()

            For Each book In _allBooks
                Dim genres As String() = If(String.IsNullOrWhiteSpace(book.Genre),
                                           New String() {"Uncategorized"},
                                           book.Genre.Split(","c))

                For Each genre In genres
                    Dim trimmedGenre = genre.Trim()
                    If Not String.IsNullOrWhiteSpace(trimmedGenre) Then
                        If Not _booksByGenre.ContainsKey(trimmedGenre) Then
                            _booksByGenre.Add(trimmedGenre, New List(Of Book)())
                        End If
                        _booksByGenre(trimmedGenre).Add(book)
                    End If
                Next
            Next

            _sortedGenreNames = _booksByGenre.Keys.OrderBy(Function(k) k).ToList()

        Catch ex As Exception
            MessageBox.Show($"Failed to load book data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowGenreView()
        ' Hide genre page, show main list
        _genrePageControlInstance.Visible = False
        flpVerticalStack.Visible = True
        pnlMainContent.AutoScroll = True

        ' Clear and reset
        flpVerticalStack.Controls.Clear()
        _genresDisplayedCount = 0

        ' Display first batch
        DisplayNextGenres()
    End Sub

    Private Sub DisplayNextGenres()
        flpVerticalStack.SuspendLayout()

        ' Remove "More" button if present
        If _btnMoreGenres IsNot Nothing AndAlso flpVerticalStack.Controls.Contains(_btnMoreGenres) Then
            flpVerticalStack.Controls.Remove(_btnMoreGenres)
        End If

        Dim startIndex = _genresDisplayedCount
        Dim endIndex = Math.Min(_sortedGenreNames.Count - 1, startIndex + GENRES_PER_PAGE - 1)

        If startIndex > endIndex Then
            flpVerticalStack.ResumeLayout()
            Return
        End If

        ' Calculate proper width for rows
        Dim rowWidth As Integer = flpVerticalStack.ClientSize.Width - 10
        If rowWidth < 100 Then rowWidth = 800 ' Fallback

        ' Add genre rows
        For i = startIndex To endIndex
            Dim genreName = _sortedGenreNames(i)

            If _booksByGenre.ContainsKey(genreName) Then
                Dim genreRow As New GenreRowControl() With {
                    .GenreName = genreName,
                    .Width = rowWidth,
                    .Anchor = AnchorStyles.Left Or AnchorStyles.Right,
                    .Margin = New Padding(5, 5, 5, 10)
                }

                genreRow.PopulateBooks(_booksByGenre(genreName), 10)

                AddHandler genreRow.TitleClicked, AddressOf GenreRow_TitleClicked
                AddHandler genreRow.BookClickedRelay, AddressOf HandleBookClicked

                flpVerticalStack.Controls.Add(genreRow)
            End If
        Next

        _genresDisplayedCount = endIndex + 1

        ' Add "More" button if needed
        If _genresDisplayedCount < _sortedGenreNames.Count Then
            _btnMoreGenres.Width = rowWidth
            flpVerticalStack.Controls.Add(_btnMoreGenres)
            _btnMoreGenres.Visible = True
        End If

        flpVerticalStack.ResumeLayout(True)
    End Sub

    Private Sub btnMoreGenres_Click(sender As Object, e As EventArgs)
        DisplayNextGenres()
    End Sub

    Private Sub GenreRow_TitleClicked(sender As Object, genreName As String)
        ShowGenrePage(genreName)
    End Sub

    Private Sub ShowGenrePage(genreName As String)
        If _booksByGenre.ContainsKey(genreName) Then
            _genrePageControlInstance.PopulateGenrePage(genreName, _booksByGenre(genreName))
            flpVerticalStack.Visible = False
            _genrePageControlInstance.Visible = True
            _genrePageControlInstance.BringToFront()
            pnlMainContent.AutoScroll = False
        End If
    End Sub

    Private Sub GenrePage_BackClicked(sender As Object, e As EventArgs)
        ShowGenreView()
    End Sub

    Private Sub HandleBookClicked(sender As Object, book As Book)
        MessageBox.Show($"Book clicked: {book.Title}", "Book Details")
    End Sub

    Private Sub DisplaySearchResults(searchTerm As String)
        Try
            Dim results As List(Of Book) = _catalogueService.SearchCatalogue(searchTerm)

            flpVerticalStack.Visible = True
            _genrePageControlInstance.Visible = False
            pnlMainContent.AutoScroll = True

            flpVerticalStack.Controls.Clear()
            _genresDisplayedCount = 0
            If _btnMoreGenres IsNot Nothing Then _btnMoreGenres.Visible = False

            If results.Count = 0 Then
                Dim lblNoResults As New Label() With {
                    .Text = "No books found...",
                    .Font = New Font("Segoe UI", 12.0!),
                    .AutoSize = True,
                    .Margin = New Padding(20)
                }
                flpVerticalStack.Controls.Add(lblNoResults)
            Else
                ' Add header
                Dim lblSearchHeader As New Label() With {
                    .Text = $"Search Results for '{searchTerm}':",
                    .Font = New Font("Segoe UI", 14.25!, FontStyle.Bold),
                    .AutoSize = True,
                    .Margin = New Padding(15, 15, 3, 10)
                }
                flpVerticalStack.Controls.Add(lblSearchHeader)

                ' Add results panel
                Dim flpResults As New FlowLayoutPanel() With {
                    .Width = flpVerticalStack.ClientSize.Width - 20,
                    .AutoSize = True,
                    .AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    .FlowDirection = FlowDirection.LeftToRight,
                    .WrapContents = True,
                    .Padding = New Padding(10),
                    .Margin = New Padding(5)
                }

                Dim startupPath As String = Application.StartupPath
                Dim defaultImagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", "default_cover.png")

                For Each book In results
                    Dim coverFileName As String = book.GetCoverFileName()
                    Dim imagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", coverFileName)

                    Dim bookControl As New BookItemControl() With {
                        .Margin = New Padding(10)
                    }
                    bookControl.SetBookData(book, imagePath, defaultImagePath)
                    AddHandler bookControl.BookClicked, AddressOf HandleBookClicked
                    flpResults.Controls.Add(bookControl)
                Next

                flpVerticalStack.Controls.Add(flpResults)
            End If

        Catch ex As Exception
            MessageBox.Show($"Search error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class