Imports System.IO
Imports System.Windows.Forms
Imports System.Linq ' <-- Make sure this is at the top

Partial Class Home_Panel_Students
    ' This list will hold all books from the database
    Private allBooks As List(Of Book)

    ''' <summary>
    ''' This runs when the form first opens.
    ''' </summary>
    Private Sub Home_Panel_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Load all book data from the GLOBAL service
            LoadAllBooks()

            ' 2. Populate the genre buttons on the left
            PopulateGenreButtons()

            ' 3. Display all books in the main panel by default
            DisplayAllBooks()
        Catch ex As Exception
            MessageBox.Show("Error loading book catalogue: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Gets all books from the service.
    ''' </summary>
    Private Sub LoadAllBooks()
        Try
            ' Use the global service from Program.vb
            allBooks = Program.CatSvc.GetAllBooks() ' Fetches books AND their genre lists
        Catch ex As Exception
            MessageBox.Show("Error fetching books: " & ex.Message)
            allBooks = New List(Of Book)() ' Create an empty list on failure
        End Try
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
            If book.Genres IsNot Nothing Then
                For Each genre As Genre In book.Genres
                    If genre IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(genre.Name) Then
                        uniqueGenreSet.Add(genre.Name)
                    End If
                Next
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
    ''' Clears the panel and loads ALL books grouped by their genres.
    ''' </summary>
    Private Sub DisplayAllBooks()
        flow_main_book_panel.Controls.Clear()

        If allBooks Is Nothing OrElse allBooks.Count = 0 Then Return

        ' 1. Get all unique, sorted genre names
        Dim uniqueGenreSet As New HashSet(Of String)
        For Each book As Book In allBooks
            If book.Genres IsNot Nothing Then
                For Each genre As Genre In book.Genres
                    If genre IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(genre.Name) Then
                        uniqueGenreSet.Add(genre.Name)
                    End If
                Next
            End If
        Next
        Dim uniqueGenres As New List(Of String)(uniqueGenreSet)
        uniqueGenres.Sort()

        ' 2. Loop through each unique genre name
        For Each genreName As String In uniqueGenres
            Dim bookList = New UC_booklist_container()
            bookList.GenreTitle = genreName
            bookList.Width = flow_main_book_panel.Width - 25

            ' 3. Get all books that *contain* this genre
            Dim booksInGenre As New List(Of Book)
            For Each book As Book In allBooks
                If book.Genres IsNot Nothing AndAlso book.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name = genreName) Then
                    booksInGenre.Add(book)
                End If
            Next

            ' 4. Add the book cards (only if books were found)
            If booksInGenre.Any() Then
                For Each book As Book In booksInGenre
                    Dim bookCard = CreateBookCard(book)
                    bookList.AddBook(bookCard)
                Next
                ' 5. Add the populated list container
                flow_main_book_panel.Controls.Add(bookList)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Runs when the "Show All" button is clicked.
    ''' </summary>
    Private Sub ShowAllBooks_Clicked(sender As Object, e As EventArgs)
        DisplayAllBooks()
    End Sub

    ''' <summary>
    ''' Runs when a specific genre button is clicked.
    ''' </summary>
    Private Sub GenreButton_Clicked(sender As Object, e As EventArgs)
        Dim clickedButton = CType(sender, UC_btn_genre)
        Dim selectedGenre = clickedButton.GenreText
        flow_main_book_panel.Controls.Clear()

        Dim bookList = New UC_booklist_container()
        bookList.GenreTitle = selectedGenre
        bookList.Width = flow_main_book_panel.Width - 25

        Dim booksInGenre As New List(Of Book)
        For Each book As Book In allBooks
            If book.Genres IsNot Nothing AndAlso book.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name = selectedGenre) Then
                booksInGenre.Add(book)
            End If
        Next

        If booksInGenre.Any() Then
            For Each book As Book In booksInGenre
                Dim bookCard = CreateBookCard(book)
                bookList.AddBook(bookCard)
            Next
            flow_main_book_panel.Controls.Add(bookList)
        Else
            Dim noBooksLabel As New Label()
            noBooksLabel.Text = "No books found for this genre."
            noBooksLabel.AutoSize = True
            flow_main_book_panel.Controls.Add(noBooksLabel)
        End If
    End Sub

    ''' <summary>
    ''' Helper function to create a book card.
    ''' </summary>
    Private Function CreateBookCard(ByVal book As Book) As UC_book_container
        Dim bookCard = New UC_book_container()
        bookCard.BookTitle = book.Title
        bookCard.BookID = book.BookID

        Dim coverFileName As String = book.GetCoverFileName()
        Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

        Try
            If System.IO.File.Exists(coverPath) Then
                bookCard.BookCover = Image.FromFile(coverPath)
            Else
                If coverFileName <> "default_cover.png" Then
                    Debug.WriteLine($"Cover image not found: {coverPath}")
                End If
            End If
        Catch imgEx As Exception
            Debug.WriteLine($"Error loading image {coverPath}: {imgEx.Message}")
        End Try

        AddHandler bookCard.BookClicked, AddressOf BookCard_Clicked
        Return bookCard
    End Function

    ''' <summary>
    ''' Runs when ANY book card is clicked.
    ''' </summary>
    Private Sub BookCard_Clicked(sender As Object, e As EventArgs)
        Dim clickedCard = CType(sender, UC_book_container)
        Dim selectedBookId As Integer = clickedCard.BookID
        Dim selectedBook As Book = allBooks.FirstOrDefault(Function(b) b.BookID = selectedBookId)

        If selectedBook IsNot Nothing Then
            Dim detailsForm As New TestWindow(selectedBook) ' Pass the whole Book object
            detailsForm.ShowDialog()
        Else
            MessageBox.Show("Could not find book details for ID: " & selectedBookId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class