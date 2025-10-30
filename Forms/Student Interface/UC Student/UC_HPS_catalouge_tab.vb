Imports System.IO
Imports System.Windows.Forms
Imports System.Linq ' <-- Make sure this is imported

Public Class UC_HPS_catalouge_tab

#Region "Class-Level Variables"

    ' --- Data ---
    Private allBooks As List(Of Book)
    Private uniqueGenres As List(Of String)

    ' --- Pagination Settings ---
    Private Const GENRES_PER_PAGE As Integer = 5
    Private Const BOOKS_PER_PAGE As Integer = 15 ' 3 rows of 5

    ' --- Layout Settings ---
    Private Const BOOKS_PER_ROW As Integer = 5      ' For grid view (See All / Search)
    Private Const BOOK_GRID_SPACING As Integer = 5  ' Padding on ALL sides in grid view
    Private Const BOOK_PREVIEW_SPACING As Integer = 10 ' Padding on ALL sides in catalogue preview
    Private Const MIN_BOOK_CARD_WIDTH As Integer = 120 ' <<<--- NEW: Set this to your UC_book_container's MinimumSize.Width

    ' --- State Management ---
    Private currentGenrePage As Integer = 1
    Private currentBookPage As Integer = 1
    Private currentView As String = "Catalogue" ' "Catalogue" or "GenreDetail"
    Private selectedGenre As String = ""

    ' --- Mock Data Toggle ---
    Private Const USE_MOCK_DATA As Boolean = False ' <-- Set to False to use your real database

#End Region

#Region "Load and Setup"

    ''' <summary>
    ''' **FIX**: This is the correct event.
    ''' It will set up the loading screen, then call the async method
    ''' without waiting for it. This lets the UI load smoothly.
    ''' </summary>
    Private Sub UC_HPS_catalouge_tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' LEAVE THIS COMPLETELY EMPTY.
        ' We are no longer starting the load from here.
    End Sub

    ' Note: We accept the parentForm as a parameter
    Public Async Sub BeginLoading(ByVal parentForm As Home_Panel_Students)
        ' This is called by the parent form *after* it has maximized.
        ' 1. First, tell the parent to show the loading screen.
        '    (We pass the parentForm reference along)
        SetupLoadingState(parentForm, True, "Loading Catalogue...")

        ' 2. --- THIS IS THE FIX ---
        ' We await a small delay to let the UI draw the label.
        Await Task.Delay(5) ' Increased slightly to be safe

        ' 3. Now that the loading label is *actually visible*,
        '    we start the real async data loading.
        LoadDataAsync(parentForm)
    End Sub

    ' Note: We accept and pass the parentForm
    Private Async Sub LoadDataAsync(ByVal parentForm As Home_Panel_Students)
        ' Give the UI thread a tiny break
        Await Task.Delay(100)

        Try
            ' --- 1. DO THE SLOW WORK ON A BACKGROUND THREAD ---
            Await Task.Run(Sub()
                               ' These functions are slow but don't touch the UI.
                               LoadAllBooks()
                               PopulateUniqueGenreList()
                           End Sub)

            ' --- 2. WE ARE NOW BACK ON THE UI THREAD ---
            PopulateGenreButtons()
            DisplayCataloguePage(1)

        Catch ex As Exception
            ' If something went wrong, show the error *before* hiding loading
            SetupLoadingState(parentForm, True, "Error!")
            MessageBox.Show("Error loading book catalogue: " & ex.Message)
            Return
        End Try

        ' --- 3. HIDE LOADING STATE ---
        SetupLoadingState(parentForm, False)
    End Sub

    ''' <summary>
    ''' Central function to show/hide loading label BY CALLING THE PARENT FORM
    ''' </summary>
    ' Note: We accept parentForm as a parameter
    Private Sub SetupLoadingState(ByVal parentForm As Home_Panel_Students, isLoading As Boolean, Optional message As String = "")

        If parentForm IsNot Nothing Then
            ' Call the parent's public method to show/hide the main loading label
            parentForm.ToggleLoading(isLoading, message)
        End If

        If isLoading Then
            ' Hide all main UI elements inside this UserControl
            genre_panel.Visible = False
            container_panel.Visible = False
            UC_pagination_controls1.Visible = False
            btn_Back.Visible = False
        Else
            ' Show all main UI elements inside this UserControl
            genre_panel.Visible = True
            container_panel.Visible = True
            ' Note: The pagination and back button visibility
            ' will be set correctly by DisplayCataloguePage or DisplayBookPage.
        End If
    End Sub

    ''' <summary>
    ''' Gets all books from the service OR from the mock list.
    ''' </summary>
    Private Sub LoadAllBooks()
        If USE_MOCK_DATA Then
            allBooks = CreateMockBookList()
        Else
            Try
                ' Use the global service from Program.vb
                allBooks = Program.CatSvc.GetAllBooks()
            Catch ex As Exception
                MessageBox.Show("Error fetching books: " & ex.Message)
                allBooks = New List(Of Book)() ' Create an empty list on failure
            End Try
        End If
    End Sub

    ''' <summary>
    ''' **REFACTORED**: Creates the master list of genres from the new model.
    ''' </summary>
    Private Sub PopulateUniqueGenreList()
        ' Use StringComparer.OrdinalIgnoreCase to treat "Fantasy" and "fantasy" as the same
        Dim uniqueGenreSet As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

        For Each book As Book In allBooks
            If book.Genres IsNot Nothing Then ' Check if the list exists
                For Each genre As Genre In book.Genres ' Iterate the list
                    If genre IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(genre.Name) Then
                        uniqueGenreSet.Add(genre.Name.Trim()) ' Add the name
                    End If
                Next
            End If
        Next

        uniqueGenres = New List(Of String)(uniqueGenreSet)
        uniqueGenres.Sort()
    End Sub


    ''' <summary>
    ''' Populates the genre buttons on the LEFT panel.
    ''' </summary>
    Private Sub PopulateGenreButtons()
        flow_genre_panel.SuspendLayout()
        flow_genre_panel.Controls.Clear()

        If uniqueGenres Is Nothing OrElse uniqueGenres.Count = 0 Then
            flow_genre_panel.ResumeLayout()
            Return
        End If

        ' Add "Show All" button
        Dim allButton = New UC_btn_genre()
        allButton.GenreText = "Show All"

        ' *** NEW FIX ***: Base calculation on the VISIBLE parent panel
        Dim leftMargin = CInt((genre_panel.ClientSize.Width - allButton.Width) / 2)

        allButton.Margin = New Padding(If(leftMargin > 0, leftMargin, 0), 3, 3, 3)
        AddHandler allButton.GenreClicked, AddressOf ShowAllBooks_Clicked
        flow_genre_panel.Controls.Add(allButton)

        ' Add a button for each unique genre
        For Each genreName As String In uniqueGenres
            Dim genreButton = New UC_btn_genre()
            genreButton.GenreText = genreName

            ' *** NEW FIX ***: Base calculation on the VISIBLE parent panel
            leftMargin = CInt((genre_panel.ClientSize.Width - genreButton.Width) / 2)

            genreButton.Margin = New Padding(If(leftMargin > 0, leftMargin, 0), 3, 3, 3)
            AddHandler genreButton.GenreClicked, AddressOf GenreButton_Clicked
            flow_genre_panel.Controls.Add(genreButton)
        Next

        flow_genre_panel.ResumeLayout()
    End Sub

#End Region

#Region "View Display Functions (Catalogue vs. GenreDetail)"

    ''' <summary>
    ''' **VIEW 1**: Displays the main catalogue view (list of genres).
    ''' </summary>
    Private Sub DisplayCataloguePage(pageNumber As Integer)
        ' 1. Set state
        currentView = "Catalogue"
        currentGenrePage = pageNumber
        btn_Back.Visible = False

        ' Show the panel AND the buttons inside it
        genre_panel.Visible = True
        flow_genre_panel.Visible = True

        flow_main_book_panel.FlowDirection = FlowDirection.TopDown ' Vertical list
        flow_main_book_panel.WrapContents = False ' Force vertical stacking
        flow_main_book_panel.AutoScroll = False ' Ensure vertical scrolling is on
        flow_main_book_panel.AutoScroll = True
        flow_main_book_panel.Padding = New Padding(0) ' Reset padding

        ' 2. Suspend layout
        flow_main_book_panel.SuspendLayout()
        flow_main_book_panel.Controls.Clear()

        ' 3. Calculate pages
        Dim totalPages = CInt(Math.Ceiling(uniqueGenres.Count / GENRES_PER_PAGE))
        UC_pagination_controls1.UpdateControls(currentGenrePage, totalPages)

        ' 4. Get the 5 genres for this page
        Dim genresToShow = uniqueGenres.Skip((pageNumber - 1) * GENRES_PER_PAGE).Take(GENRES_PER_PAGE)

        ' 5. Create a UC_booklist_container for each of the 5 genres
        For Each genreName As String In genresToShow
            Dim bookList = New UC_booklist_container()
            bookList.GenreTitle = genreName
            bookList.Width = flow_main_book_panel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth - 5
            AddHandler bookList.SeeAllClicked, AddressOf SeeAll_Clicked

            ' 6. **REFACTORED**: Get all books for this genre using the new model
            Dim booksInGenre = allBooks.Where(Function(b) b.Genres IsNot Nothing AndAlso b.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name.Equals(genreName, StringComparison.OrdinalIgnoreCase))).ToList()

            ' 7. Add up to 8 books to the preview
            For Each book As Book In booksInGenre.Take(8)
                                                      Dim bookCard = CreateBookCard(book)
                                                      bookCard.Margin = New Padding(BOOK_PREVIEW_SPACING)
                                                      bookList.AddBook(bookCard)
                                                  Next

                                                  ' 8. Show "See All" button if there are more than 8 books
                                                  If booksInGenre.Count > 8 Then
                                                      bookList.btn_SeeAll.Visible = True
                                                  End If

                                                  flow_main_book_panel.Controls.Add(bookList)
        Next

        ' 9. Resume layout
        flow_main_book_panel.ResumeLayout()
    End Sub

    ''' <summary>
    ''' **VIEW 2**: Displays the detail view (grid of books for one genre).
    ''' </summary>
    Private Sub DisplayBookPage(genre As String, pageNumber As Integer)
        ' 1. Set state
        currentView = "GenreDetail"
        currentBookPage = pageNumber
        selectedGenre = genre ' Remember which genre we're viewing
        btn_Back.Visible = True ' Show the back button
        flow_genre_panel.Visible = False ' Hide the genre buttons
        flow_main_book_panel.FlowDirection = FlowDirection.LeftToRight ' Grid view
        flow_main_book_panel.WrapContents = True ' Allow wrapping for the grid
        flow_main_book_panel.AutoScroll = False ' Toggle AutoScroll
        flow_main_book_panel.AutoScroll = True

        ' --- Robust Spacing & Centering ---
        Dim usableWidth As Integer = flow_main_book_panel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth
        Dim totalSlotWidth As Integer = CInt(Math.Floor(usableWidth / BOOKS_PER_ROW))
        Dim actualSpacing As Integer = BOOK_GRID_SPACING
        If (BOOK_GRID_SPACING * 2) + MIN_BOOK_CARD_WIDTH > totalSlotWidth Then
            actualSpacing = CInt(Math.Floor((totalSlotWidth - MIN_BOOK_CARD_WIDTH) / 2))
            If actualSpacing < 0 Then actualSpacing = 0
        End If
        Dim cardWidth As Integer = totalSlotWidth - (actualSpacing * 2)
        Dim totalOccupiedWidth As Integer = totalSlotWidth * BOOKS_PER_ROW
        Dim leftoverSpace As Integer = usableWidth - totalOccupiedWidth
        flow_main_book_panel.Padding = New Padding(CInt(leftoverSpace / 2), 0, 0, 0)
        ' --- End of Spacing ---

        ' 2. Suspend layout
        flow_main_book_panel.SuspendLayout()
        flow_main_book_panel.Controls.Clear()

        ' 3. **REFACTORED**: Get all books for this genre using the new model
        Dim allBooksInGenre = allBooks.Where(Function(b) b.Genres IsNot Nothing AndAlso b.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name.Equals(genre, StringComparison.OrdinalIgnoreCase))).ToList()

        ' 4. Calculate pages
        Dim totalPages = CInt(Math.Ceiling(allBooksInGenre.Count / BOOKS_PER_PAGE))
                                                 UC_pagination_controls1.UpdateControls(currentBookPage, totalPages)

                                                 ' 5. Get the books for this page
                                                 Dim booksToShow = allBooksInGenre.Skip((pageNumber - 1) * BOOKS_PER_PAGE).Take(BOOKS_PER_PAGE)

                                                 ' 6. Add book cards
                                                 For Each book As Book In booksToShow
                                                     Dim bookCard = CreateBookCard(book)
                                                     bookCard.Width = cardWidth
                                                     bookCard.Margin = New Padding(actualSpacing)
                                                     flow_main_book_panel.Controls.Add(bookCard)
                                                 Next

                                                 ' 7. Resume layout
                                                 flow_main_book_panel.ResumeLayout()
    End Sub

#End Region

#Region "Search and Book Card Creation"

    ''' <summary>
    ''' Public function that the main form calls to search.
    ''' </summary>
    Public Sub Search(searchTerm As String)
        flow_main_book_panel.SuspendLayout()

        If String.IsNullOrWhiteSpace(searchTerm) Then
            ' If search is empty, show the main catalogue
            DisplayCataloguePage(1)
        Else
            ' If searching, show a simple grid of results
            currentView = "Search"
            btn_Back.Visible = False
            genre_panel.Visible = True
            flow_genre_panel.Visible = True
            UC_pagination_controls1.Visible = False ' Hide pagination
            flow_main_book_panel.FlowDirection = FlowDirection.LeftToRight
            flow_main_book_panel.WrapContents = True
            flow_main_book_panel.AutoScroll = False
            flow_main_book_panel.AutoScroll = True

            ' --- Robust Spacing & Centering ---
            Dim usableWidth As Integer = flow_main_book_panel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth
            Dim totalSlotWidth As Integer = CInt(Math.Floor(usableWidth / BOOKS_PER_ROW))
            Dim actualSpacing As Integer = BOOK_GRID_SPACING
            If (BOOK_GRID_SPACING * 2) + MIN_BOOK_CARD_WIDTH > totalSlotWidth Then
                actualSpacing = CInt(Math.Floor((totalSlotWidth - MIN_BOOK_CARD_WIDTH) / 2))
                If actualSpacing < 0 Then actualSpacing = 0
            End If
            Dim cardWidth As Integer = totalSlotWidth - (actualSpacing * 2)
            Dim totalOccupiedWidth As Integer = totalSlotWidth * BOOKS_PER_ROW
            Dim leftoverSpace As Integer = usableWidth - totalOccupiedWidth
            flow_main_book_panel.Padding = New Padding(CInt(leftoverSpace / 2), 0, 0, 0)
            ' --- End of Spacing ---

            flow_main_book_panel.Controls.Clear()

            ' Get filtered books
            Dim filteredBooks As New List(Of Book)
            Dim lowerSearchTerm = searchTerm.ToLower()
            For Each book As Book In allBooks
                ' Search title, author, and genres
                Dim titleMatch = book.Title.ToLower().Contains(lowerSearchTerm)
                Dim authorMatch = book.Author.ToLower().Contains(lowerSearchTerm)
                Dim genreMatch = False
                If book.Genres IsNot Nothing Then
                    genreMatch = book.Genres.Any(Function(g) g.Name.ToLower().Contains(lowerSearchTerm))
                End If

                If titleMatch Or authorMatch Or genreMatch Then
                    filteredBooks.Add(book)
                End If
            Next

            ' Add book cards for results
            For Each book As Book In filteredBooks
                Dim bookCard = CreateBookCard(book)
                bookCard.Width = cardWidth
                bookCard.Margin = New Padding(actualSpacing)
                flow_main_book_panel.Controls.Add(bookCard)
            Next
        End If

        flow_main_book_panel.ResumeLayout()
    End Sub

    ''' <summary>
    ''' Helper function to create a book card.
    ''' </summary>
    Private Function CreateBookCard(ByVal book As Book) As UC_book_container
        Dim bookCard = New UC_book_container()
        bookCard.BookTitle = book.Title
        bookCard.BookID = book.BookID

        ' Use the GetCoverFileName() helper from the Book model
        Dim coverFileName As String = book.GetCoverFileName()
        Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

        Try
            If System.IO.File.Exists(coverPath) Then
                bookCard.BookCover = Image.FromFile(coverPath)
            Else
                ' Use the cached default image from My.Resources
                If coverFileName <> "default_cover.png" Then
                    Debug.WriteLine($"Cover image not found: {coverPath}. Reverting to default.")
                End If
            End If
        Catch imgEx As Exception
            Debug.WriteLine($"Error loading image {coverPath}: {imgEx.Message}")
            ' Fallback to default image on error
        End Try

        AddHandler bookCard.BookClicked, AddressOf BookCard_Clicked
        Return bookCard
    End Function

#End Region

#Region "Event Handlers"

    ' --- Navigation Clicks (Left Panel) ---
    Private Sub ShowAllBooks_Clicked(sender As Object, e As EventArgs)
        DisplayCataloguePage(1)
    End Sub

    Private Sub GenreButton_Clicked(sender As Object, e As EventArgs)
        Dim clickedButton = CType(sender, UC_btn_genre)
        DisplayBookPage(clickedButton.GenreText, 1)
    End Sub

    ' --- Main UI Clicks ---
    Private Sub SeeAll_Clicked(sender As Object, e As EventArgs)
        Dim clickedList = CType(sender, UC_booklist_container)
        DisplayBookPage(clickedList.GenreTitle, 1)
    End Sub

    Private Sub btn_Back_Click(sender As Object, e As EventArgs) Handles btn_Back.Click
        DisplayCataloguePage(currentGenrePage)
    End Sub

    Private Sub BookCard_Clicked(sender As Object, e As EventArgs)
        Dim clickedCard = CType(sender, UC_book_container)

        ' Find the actual Book object from our list
        Dim selectedBook As Book = allBooks.FirstOrDefault(Function(b) b.BookID = clickedCard.BookID)

        If selectedBook IsNot Nothing Then
            ' 2. Create and show the TestWindow (or your actual Book Details form)
            Dim detailsForm As New TestWindow(selectedBook) ' Pass the whole Book object
            detailsForm.ShowDialog() ' Use ShowDialog to make it modal
        Else
            MessageBox.Show("Could not find book details for ID: " & clickedCard.BookID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' --- Pagination Clicks (Bottom) ---
    Private Sub paginationControls_NextClicked(sender As Object, e As EventArgs) Handles UC_pagination_controls1.NextClicked
        If currentView = "Catalogue" Then
            currentGenrePage += 1
            DisplayCataloguePage(currentGenrePage)
        ElseIf currentView = "GenreDetail" Then
            currentBookPage += 1
            DisplayBookPage(selectedGenre, currentBookPage)
        End If
    End Sub

    Private Sub paginationControls_PrevClicked(sender As Object, e As EventArgs) Handles UC_pagination_controls1.PrevClicked
        If currentView = "Catalogue" Then
            currentGenrePage -= 1
            DisplayCataloguePage(currentGenrePage)
        ElseIf currentView = "GenreDetail" Then
            currentBookPage -= 1
            DisplayBookPage(selectedGenre, currentBookPage)
        End If
    End Sub

#End Region

#Region "Mock Data Function"

    ''' <summary>
    ''' **REFACTORED**: This now generates mock data using the correct List(Of Genre) model.
    ''' </summary>
    Private Function CreateMockBookList() As List(Of Book)
        Dim mockList As New List(Of Book)

        ' 1. Create mock genre objects
        Dim gFantasy = New Genre With {.GenreID = 1, .Name = "Fantasy"}
        Dim gSciFi = New Genre With {.GenreID = 2, .Name = "Sci-Fi"}
        Dim gScience = New Genre With {.GenreID = 3, .Name = "Science"}
        Dim gMystery = New Genre With {.GenreID = 4, .Name = "Mystery"}
        Dim gHistory = New Genre With {.GenreID = 5, .Name = "History"}
        Dim gRomance = New Genre With {.GenreID = 6, .Name = "Romance"}
        Dim gBiography = New Genre With {.GenreID = 7, .Name = "Biography"}

        ' 2. Add 6 books for "Fantasy" to test "See All"
        For i = 1 To 6
            Dim book = New Book() With {
                .BookID = i,
                .Title = $"Fantasy Book {i}",
                .Author = "Author Name",
                .Genres = New List(Of Genre) From {gFantasy}, ' Assign list
                .CoverUrl = "hobbit.jpg"
            }
            mockList.Add(book)
        Next

        ' 3. Add 30 books for "Sci-Fi" to test book pagination
        For i = 1 To 30
            Dim book = New Book() With {
                .BookID = 100 + i,
                .Title = $"Sci-Fi Book {i}",
                .Author = "Author Name",
                .Genres = New List(Of Genre) From {gSciFi}, ' Assign list
                .CoverUrl = "1984.jpg"
            }
            mockList.Add(book)
        Next

        ' 4. Add other genres to test genre pagination
        Dim otherGenres = {gScience, gMystery, gHistory, gRomance, gBiography}
        Dim bookIdCounter = 200
        For Each g In otherGenres
            For i = 1 To 3 ' Add 3 books for each
                Dim book = New Book() With {
                    .BookID = bookIdCounter + i,
                    .Title = $"{g.Name} Book {i}",
                    .Author = "Author Name",
                    .Genres = New List(Of Genre) From {g}, ' Assign list
                    .CoverUrl = "the_plot.jpg"
                }
                mockList.Add(book)
            Next
            bookIdCounter += 10
        Next

        ' 5. Add a duplicate, poorly-cased genre to test bug fix
        Dim dupeBook = New Book() With {
            .BookID = 999,
            .Title = "Duplicate Test",
            .Author = "Author Name",
            .Genres = New List(Of Genre) From {New Genre With {.GenreID = 1, .Name = "  fantasy  "}},
            .CoverUrl = "big_little_lies.jpg"
        }
        mockList.Add(dupeBook)

        ' 6. Add a book with multiple genres
        Dim multiGenreBook = New Book() With {
            .BookID = 1000,
            .Title = "Sci-Fi Fantasy Book",
            .Author = "Author Name",
            .Genres = New List(Of Genre) From {gFantasy, gSciFi},
            .CoverUrl = "dune.jpg"
        }
        mockList.Add(multiGenreBook)

        Return mockList
    End Function

#End Region

End Class