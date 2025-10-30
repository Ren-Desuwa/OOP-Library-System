Imports System.IO
Imports System.Windows.Forms
Imports System.Linq ' <-- *** ADD THIS LINE AT THE TOP ***

Partial Class Home_Panel_Guest
    ' This list will hold all books from the database
    Public Event OpenLogin As EventHandler

    Private allBooks As List(Of Book)

    Private Sub Home_Panel_Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' 1. Load all book data from the GLOBAL service
            LoadAllBooks()

            ' 2. Populate the genre buttons on the left
            PopulateGenreButtons() ' <-- Will use the updated version below

            ' 3. NEW: Display all books in the main panel by default
            DisplayAllBooks() ' <-- Will use the updated version below
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
            allBooks = CatSvc.GetAllBooks()
        Catch ex As Exception
            MessageBox.Show("Error fetching books: " & ex.Message)
            allBooks = New List(Of Book)() ' Create an empty list on failure
        End Try
    End Sub

    ''' <summary>
    ''' Finds all unique genres and creates a button for each.
    ''' </summary>
    Private Sub PopulateGenreButtons() ' *** UPDATED METHOD ***
        flow_genre_panel.Controls.Clear()

        If allBooks Is Nothing OrElse allBooks.Count = 0 Then Return

        ' --- Create a "Show All" button first ---
        Dim allButton = New UC_btn_genre()
        allButton.GenreText = "Show All"
        AddHandler allButton.GenreClicked, AddressOf ShowAllBooks_Clicked
        flow_genre_panel.Controls.Add(allButton)

        ' 1. Use a HashSet to get unique genre names by iterating through each book's genre list
        Dim uniqueGenreSet As New HashSet(Of String)
        For Each book As Book In allBooks
            If book.Genres IsNot Nothing Then ' Check if the Genres list exists
                For Each genre As Genre In book.Genres ' <-- Iterate through the list of Genres
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
    Private Sub DisplayAllBooks() ' *** UPDATED METHOD ***
        flow_main_book_panel.Controls.Clear()

        If allBooks Is Nothing OrElse allBooks.Count = 0 Then Return

        ' 1. Get all unique, sorted genre names from all books
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
            bookList.Width = flow_main_book_panel.Width - 25 ' Subtract for scrollbar/padding

            ' 3. Get all books that *contain* this genre in their list
            Dim booksInGenre As New List(Of Book)
            For Each book As Book In allBooks
                If book.Genres IsNot Nothing AndAlso book.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name = genreName) Then ' <-- Check if list contains the genre
                    booksInGenre.Add(book)
                End If
            Next

            ' 4. Add the book cards to the list container (only if books were found for this genre)
            If booksInGenre.Any() Then
                For Each book As Book In booksInGenre
                    Dim bookCard = CreateBookCard(book)
                    bookList.AddBook(bookCard)
                Next
                ' 5. Add the populated list container to the main panel
                flow_main_book_panel.Controls.Add(bookList)
            End If
        Next
    End Sub

    ''' <summary>
    ''' This event runs when the "Show All" button is clicked.
    ''' </summary>
    Private Sub ShowAllBooks_Clicked(sender As Object, e As EventArgs)
        DisplayAllBooks() ' Calls the updated version
    End Sub

    ''' <summary>
    ''' This event runs when a specific genre button is clicked.
    ''' </summary>
    Private Sub GenreButton_Clicked(sender As Object, e As EventArgs) ' *** UPDATED METHOD ***
        ' 1. Get the button that was clicked
        Dim clickedButton = CType(sender, UC_btn_genre)
        Dim selectedGenre = clickedButton.GenreText

        ' 2. Clear the main panel
        flow_main_book_panel.Controls.Clear()

        ' 3. Create ONE list container for this genre
        Dim bookList = New UC_booklist_container()
        bookList.GenreTitle = selectedGenre
        bookList.Width = flow_main_book_panel.Width - 25 ' Subtract for scrollbar/padding

        ' 4. Find all books that *contain* the selected genre in their list
        Dim booksInGenre As New List(Of Book)
        For Each book As Book In allBooks
            If book.Genres IsNot Nothing AndAlso book.Genres.Any(Function(g) g IsNot Nothing AndAlso g.Name = selectedGenre) Then ' <-- Check if list contains the genre
                booksInGenre.Add(book)
            End If
        Next

        ' 5. Create a book-card for each book and add it (only if books were found)
        If booksInGenre.Any() Then
            For Each book As Book In booksInGenre
                Dim bookCard = CreateBookCard(book)
                bookList.AddBook(bookCard)
            Next

            ' 6. Add the single, populated list to the main panel
            flow_main_book_panel.Controls.Add(bookList)
        Else
            ' Optional: Display a message if no books are found for this genre
            Dim noBooksLabel As New Label()
            noBooksLabel.Text = "No books found for this genre."
            noBooksLabel.AutoSize = True
            flow_main_book_panel.Controls.Add(noBooksLabel)
        End If
    End Sub

    ''' <summary>
    ''' Helper function to create a book card. (NO CHANGES NEEDED HERE)
    ''' </summary>
    Private Function CreateBookCard(ByVal book As Book) As UC_book_container
        Dim bookCard = New UC_book_container()
        bookCard.BookTitle = book.Title
        bookCard.BookID = book.BookID ' Assuming BookID is correct

        ' Construct the full path carefully
        Dim coverFileName As String = book.GetCoverFileName() ' Use the helper function from the Book model
        Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

        ' --- Load the book cover image ---
        Try
            If System.IO.File.Exists(coverPath) Then
                bookCard.BookCover = Image.FromFile(coverPath)
            Else
                ' Optional: Log if the specific cover file is missing but CoverUrl was set
                If coverFileName <> "default_cover.png" Then
                    Debug.WriteLine($"Cover image not found: {coverPath}")
                End If
                ' If file doesn't exist, it will keep the default image set in the designer
            End If
        Catch imgEx As Exception
            Debug.WriteLine($"Error loading image {coverPath}: {imgEx.Message}")
            ' Keep the default image on error
        End Try

        ' Add a click event handler for this specific book
        AddHandler bookCard.BookClicked, AddressOf BookCard_Clicked

        Return bookCard
    End Function

    ''' <summary>
    ''' This event runs when ANY of the "UC_book_container" cards are clicked. (NO CHANGES NEEDED HERE)
    ''' </summary>
    Private Sub BookCard_Clicked(sender As Object, e As EventArgs)
        ' 1. Get the card that was clicked
        Dim clickedCard = CType(sender, UC_book_container)
        Dim selectedBookId As Integer = clickedCard.BookID

        ' --- Find the actual Book object from our list ---
        Dim selectedBook As Book = allBooks.FirstOrDefault(Function(b) b.BookID = selectedBookId)

        If selectedBook IsNot Nothing Then
            ' 2. Create and show the TestWindow (or your actual Book Details form)
            Dim detailsForm As New TestWindow(selectedBook) ' Pass the whole Book object
            detailsForm.ShowDialog() ' Use ShowDialog to make it modal
        Else
            MessageBox.Show("Could not find book details for ID: " & selectedBookId, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub flow_main_book_panel_Paint(sender As Object, e As PaintEventArgs) Handles flow_main_book_panel.Paint
        ' No code needed here
    End Sub

    Private Sub btn_Open_Login(sender As Object, e As EventArgs) Handles btn_profile.Click, lbl_user.Click
        RaiseEvent OpenLogin(Me, EventArgs.Empty)
    End Sub
End Class