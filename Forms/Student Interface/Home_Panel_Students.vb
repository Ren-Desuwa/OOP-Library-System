Imports System.IO
Imports System.Windows.Forms

Partial Class Home_Panel_Students
    ' This list will hold all books from the database
    Private allBooks As List(Of Book)
    ' --- ADD THIS TOGGLE ---
    ' Set this to True to use fake data for testing.
    ' Set this to False to use the real database.
    Private Const USE_MOCK_DATA As Boolean = True

    ''' <summary>
    ''' NEW: Creates a fake list of books for testing the UI without a database.
    ''' </summary>
    Private Function CreateMockBookList() As List(Of Book)
        Dim mockList As New List(Of Book)

        ' We will create a few fake books.
        ' The property names (BookID, Title, Genre)
        ' must match your real Book class.

        Dim book1 = New Book()
        book1.BookID = 1
        book1.Title = "1984"
        book1.Genre = "Fantasy"
        book1.CoverUrl = "1984.jpg" ' Path doesn't matter
        mockList.Add(book1)

        Dim book2 = New Book()
        book2.BookID = 2
        book2.Title = "Big Little Lies"
        book2.Genre = "Sci-Fi"
        book2.CoverUrl = "big_little_lies.jpg"
        mockList.Add(book2)

        Dim book3 = New Book()
        book3.BookID = 3
        book3.Title = "Hobbit"
        book3.Genre = "Fantasy"
        book3.CoverUrl = "hobbit.jpg"
        mockList.Add(book3)

        Dim book4 = New Book()
        book4.BookID = 4
        book4.Title = "The Plot"
        book4.Genre = "Sci-Fi"
        book4.CoverUrl = "the_plot.jpg"
        mockList.Add(book4)

        Dim book5 = New Book()
        book5.BookID = 5
        book5.Title = "Sharp Objects"
        book5.Genre = "Science"
        book5.CoverUrl = "sharp_objects.jpg"
        mockList.Add(book5)

        Return mockList
    End Function

    ''' <summary>
    ''' This runs when the form first opens.
    ''' </summary>
    Private Sub Home_Panel_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Load all book data from the GLOBAL service
            LoadAllBooks()

            ' 2. Populate the genre buttons on the left
            PopulateGenreButtons()

            ' 3. NEW: Display all books in the main panel by default
            DisplayAllBooks()
        Catch ex As Exception
            MessageBox.Show("Error loading book catalogue: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Gets all books from the service OR from the mock list.
    ''' </summary>
    Private Sub LoadAllBooks()
        If USE_MOCK_DATA Then
            ' Load fake data instead of calling the database
            allBooks = CreateMockBookList()
        Else
            ' This is your original code
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
    ''' Finds all unique genres and creates a button for each.
    ''' </summary>
    Private Sub PopulateGenreButtons()
        flow_genre_panel.Controls.Clear()

        If allBooks Is Nothing OrElse allBooks.Count = 0 Then Return

        ' --- Create a "Show All" button first ---
        Dim allButton = New UC_btn_genre()
        allButton.GenreText = "Show All"
        AddHandler allButton.GenreClicked, AddressOf ShowAllBooks_Clicked
        flow_genre_panel.Controls.Add(allButton)

        ' 1. Use a HashSet to get unique genre names
        Dim uniqueGenreSet As New HashSet(Of String)
        For Each book As Book In allBooks
            If Not String.IsNullOrWhiteSpace(book.Genre) Then
                uniqueGenreSet.Add(book.Genre)
            End If
        Next

        ' 2. Convert the set to a List so we can sort it
        Dim uniqueGenres As New List(Of String)(uniqueGenreSet)
        uniqueGenres.Sort()

        ' 3. Create a button for each unique genre
        For Each genreName As String In uniqueGenres
            Dim genreButton = New UC_btn_genre()
            genreButton.GenreText = genreName
            AddHandler genreButton.GenreClicked, AddressOf GenreButton_Clicked
            flow_genre_panel.Controls.Add(genreButton)
        Next
    End Sub

    ''' <summary>
    ''' NEW: This function clears the panel and loads ALL genres.
    ''' </summary>
    Private Sub DisplayAllBooks()
        ' Clear the main panel
        flow_main_book_panel.Controls.Clear()

        ' Get all unique, sorted genres
        Dim uniqueGenreSet As New HashSet(Of String)
        For Each book As Book In allBooks
            If Not String.IsNullOrWhiteSpace(book.Genre) Then
                uniqueGenreSet.Add(book.Genre)
            End If
        Next
        Dim uniqueGenres As New List(Of String)(uniqueGenreSet)
        uniqueGenres.Sort()

        ' Loop through each genre and create a booklist for it
        For Each genre As String In uniqueGenres
            Dim bookList = New UC_booklist_container()
            bookList.GenreTitle = genre
            ' IMPORTANT: Don't use Dock.Fill. Set a fixed width.
            bookList.Width = flow_main_book_panel.Width - 25 ' Subtract for scrollbar/padding

            ' Get all books for this genre
            Dim booksInGenre As New List(Of Book)
            For Each book As Book In allBooks
                If book.Genre = genre Then
                    booksInGenre.Add(book)
                End If
            Next

            ' Add the books to the list
            For Each book As Book In booksInGenre
                Dim bookCard = CreateBookCard(book)
                bookList.AddBook(bookCard)
            Next

            ' Add the populated list to the main panel
            flow_main_book_panel.Controls.Add(bookList)
        Next
    End Sub

    ''' <summary>
    ''' This event runs when the "Show All" button is clicked.
    ''' </summary>
    Private Sub ShowAllBooks_Clicked(sender As Object, e As EventArgs)
        DisplayAllBooks()
    End Sub

    ''' <summary>
    ''' This event runs when a specific genre button is clicked.
    ''' </summary>
    Private Sub GenreButton_Clicked(sender As Object, e As EventArgs)
        ' 1. Get the button that was clicked
        Dim clickedButton = CType(sender, UC_btn_genre)
        Dim selectedGenre = clickedButton.GenreText

        ' 2. Clear the main panel
        flow_main_book_panel.Controls.Clear()

        ' 3. Create ONE list container for this genre
        Dim bookList = New UC_booklist_container()
        bookList.GenreTitle = selectedGenre
        bookList.Width = flow_main_book_panel.Width - 25 ' Subtract for scrollbar/padding

        ' 4. Find all books that match the selected genre
        Dim booksInGenre As New List(Of Book)
        For Each book As Book In allBooks
            If book.Genre = selectedGenre Then
                booksInGenre.Add(book)
            End If
        Next

        ' 5. Create a book-card for each book and add it
        For Each book As Book In booksInGenre
            Dim bookCard = CreateBookCard(book)
            bookList.AddBook(bookCard)
        Next

        ' 6. Add the single, populated list to the main panel
        flow_main_book_panel.Controls.Add(bookList)
    End Sub

    ''' <summary>
    ''' NEW: Helper function to create a book card to avoid repeating code.
    ''' </summary>
    Private Function CreateBookCard(ByVal book As Book) As UC_book_container
        Dim bookCard = New UC_book_container()
        bookCard.BookTitle = book.Title
        bookCard.BookID = book.BookID
        Dim coverLink As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", book.CoverUrl)
        ' --- Load the book cover image ---
        Try
            If Not String.IsNullOrWhiteSpace(coverLink) Then
                If System.IO.File.Exists(coverLink) Then
                    bookCard.BookCover = Image.FromFile(coverLink)
                End If
            End If
        Catch imgEx As Exception
            ' Do nothing. The bookCard will just keep its placeholder image.
        End Try

        ' Add a click event handler for this specific book
        AddHandler bookCard.BookClicked, AddressOf BookCard_Clicked

        Return bookCard
    End Function

    ''' <summary>
    ''' This event runs when ANY of the "UC_book_container" cards are clicked.
    ''' </summary>
    Private Sub BookCard_Clicked(sender As Object, e As EventArgs)
        ' 1. Get the card that was clicked
        Dim clickedCard = CType(sender, UC_book_container)
        Dim selectedBookId As Integer = clickedCard.BookID

        ' 2. TODO: Open the Book Details panel
        MessageBox.Show("You clicked on Book ID: " & selectedBookId)
    End Sub

End Class