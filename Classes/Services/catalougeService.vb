' Import all your DAOs and Models
Imports MySql.Data.MySqlClient
Imports System.Threading.Tasks

Public Class CatalougeService
    Private ReadOnly _dbCon As DBcon
    Private Shared _rand As New Random()

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub


    ' #################### READ (Getters) ####################

    ''' <summary>
    ''' Gets a single book and its copy counts by its ID.
    ''' </summary>
    Public Function GetBookById(bookId As Integer) As Book
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim genreDAO As New GenreDAO(transaction)
            Dim book = bookDAO.GetById(bookId)

            If book IsNot Nothing Then
                book.Genres = genreDAO.GetGenresByBookId(book.BookID)
            End If

            ' No changes, so we can roll back (or just not commit)
            transaction.Rollback()
            Return book
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting book by ID: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets a list of all known genres.
    ''' </summary>
    Public Function GetAllGenres() As List(Of Genre)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim genreDAO As New GenreDAO(transaction)
            Dim genres = genreDAO.GetAll()

            transaction.Rollback() ' Read-only operation
            Return genres
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting all genres: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets a list of all books in the catalogue.
    ''' </summary>
    Public Function GetAllBooks() As List(Of Book)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim genreDAO As New GenreDAO(transaction)
            Dim bookGenreDAO As New BookGenreDAO(transaction)
            Dim books = bookDAO.GetAll()

            For Each book In books
                book.Genres = genreDAO.GetGenresByBookId(book.BookID)
            Next

            transaction.Rollback() ' Read-only operation
            Return books
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting all books: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Searches for books where the author name contains the search term.
    ''' </summary>
    Public Function SearchBooksByAuthor(author As String) As List(Of Book)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim books = bookDAO.GetByAuthor(author)

            transaction.Rollback() ' Read-only operation
            Return books
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error searching books by author: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Gets all specific copies associated with a single book ID.
    ''' </summary>
    Public Function GetBookCopies(bookId As Integer) As List(Of BookCopy)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim copies = bookCopyDAO.GetCopiesByBookId(bookId)

            transaction.Rollback() ' Read-only operation
            Return copies
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting book copies: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    Public Function SearchCatalogue(searchTerm As String) As List(Of Book)
        If String.IsNullOrWhiteSpace(searchTerm) Then Return New List(Of Book)() ' Return empty if search is blank

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            ' Note: Assuming SearchBooks also attaches genres or it's not needed for search.
            ' If it is, you'll need to loop here too.
            Dim results = bookDAO.SearchBooks(searchTerm)

            transaction.Rollback() ' Read-only operation
            Return results
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error searching catalogue: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' #################### WRITE (Management) ####################

    ''' <summary>
    ''' Adds a brand new book to the database...
    ''' </summary>
    Public Function AddNewBook(book As Book, genreNames As List(Of String), initialCopies As Integer, shelfLocation As String, condition As String, adminAccountId As Integer?) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection.BeginTransaction()

        Try
            ' ... (DAOs, Book Creation, and Genre Logic is all the same) ...
            Dim bookDAO As New BookDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim bookGenreDAO As New BookGenreDAO(transaction)
            Dim genreDAO As New GenreDAO(transaction)
            Dim logDAO As New LogDAO(transaction)
            Dim newBookId As Integer = bookDAO.Create(book)
            book.BookID = newBookId
            If genreNames IsNot Nothing AndAlso genreNames.Any() Then
                Dim allGenres As List(Of Genre) = genreDAO.GetAll()
                For Each rawName As String In genreNames
                    Dim trimmedName = rawName.Trim()
                    If String.IsNullOrEmpty(trimmedName) Then Continue For
                    Dim foundGenre = allGenres.FirstOrDefault(Function(g) g.Name.Equals(trimmedName, StringComparison.OrdinalIgnoreCase))
                    Dim genreIdToLink As Integer
                    If foundGenre IsNot Nothing Then
                        genreIdToLink = foundGenre.GenreID
                    Else
                        Dim newGenre As New Genre With {.Name = trimmedName}
                        genreIdToLink = genreDAO.Create(newGenre)
                        newGenre.GenreID = genreIdToLink
                        allGenres.Add(newGenre)
                    End If
                    bookGenreDAO.AddGenreToBook(newBookId, genreIdToLink)
                Next
            End If

            ' 2. Create the initial copies
            If initialCopies <= 0 Then initialCopies = 1 ' Must add at least one copy

            For i = 1 To initialCopies
                Dim copy As New BookCopy With {
                    .BookID = newBookId,
                .ShelfLocation = GenerateRandomShelf(),
                .Condition = condition,
                    .Status = "Available"
                }
                bookCopyDAO.Create(copy)
            Next

            ' 3. Log the action
            ' ... (rest of the function is the same) ...
            logDAO.Create(Log.RecordAction(adminAccountId, "Catalogue Add", $"New book '{book.Title}' (ID: {newBookId}) added with {initialCopies} copies.", "Info"))
            transaction.Commit()
            Return newBookId
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error adding new book: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Updates the core details of an existing book.
    ''' </summary>
    Public Sub UpdateBookDetails(book As Book, genreNames As List(Of String), newCopyCount As Integer, newCondition As String, adminAccountId As Integer?)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection.BeginTransaction()

        Try
            ' ... (DAOs, Book Update, Genre Logic is all the same) ...
            Dim bookDAO As New BookDAO(transaction)
            Dim logDAO As New LogDAO(transaction)
            Dim genreDAO As New GenreDAO(transaction)
            Dim bookGenreDAO As New BookGenreDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            bookDAO.Update(book)
            bookGenreDAO.ClearGenresForBook(book.BookID)
            If genreNames IsNot Nothing AndAlso genreNames.Any() Then
                Dim allGenres As List(Of Genre) = genreDAO.GetAll()
                For Each rawName As String In genreNames
                    Dim trimmedName = rawName.Trim()
                    If String.IsNullOrEmpty(trimmedName) Then Continue For
                    Dim foundGenre = allGenres.FirstOrDefault(Function(g) g.Name.Equals(trimmedName, StringComparison.OrdinalIgnoreCase))
                    Dim genreIdToLink As Integer
                    If foundGenre IsNot Nothing Then
                        genreIdToLink = foundGenre.GenreID
                    Else
                        Dim newGenre As New Genre With {.Name = trimmedName}
                        genreIdToLink = genreDAO.Create(newGenre)
                        newGenre.GenreID = genreIdToLink
                        allGenres.Add(newGenre)
                    End If
                    bookGenreDAO.AddGenreToBook(book.BookID, genreIdToLink)
                Next
            End If

            ' --- 4. NEW DELTA COPY MANAGEMENT LOGIC ---
            Dim currentCopyCount As Integer = bookCopyDAO.GetCopiesByBookId(book.BookID).Count
            Dim copyDifference = newCopyCount - currentCopyCount

            If copyDifference > 0 Then
                ' A. ADD COPIES: User wants *more* copies than before.
                For i = 1 To copyDifference
                    Dim copy As New BookCopy With {
                        .BookID = book.BookID,
                    .ShelfLocation = GenerateRandomShelf(),
                    .Condition = newCondition,
                        .Status = "Available"
                    }
                    bookCopyDAO.Create(copy)
                Next
            ElseIf copyDifference < 0 Then
                ' ... (Delete logic is unchanged) ...
                Dim copiesToDelete As Integer = Math.Abs(copyDifference)
                Dim actualDeletedCount As Integer = bookCopyDAO.DeleteAvailableCopiesByBookId(book.BookID, copiesToDelete)
                If actualDeletedCount < copiesToDelete Then
                    Dim copiesInUse = copiesToDelete - actualDeletedCount
                    Throw New Exception($"Could not remove all requested copies. {copiesInUse} copies are currently 'Borrowed' or 'In Maintenance'. Only {actualDeletedCount} 'Available' copies were removed.")
                End If
            End If

            ' ... (Log, Commit, Catch, Finally are all the same) ...
            logDAO.Create(Log.RecordAction(adminAccountId, "Catalogue Update", $"Book '{book.Title}' (ID: {book.BookID}) details updated. Copy count set to {newCopyCount}.", "Info"))
            transaction.Commit()
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception(ex.Message, ex)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

    ' Note: Removed the duplicate/older AddNewBook function that was here.
    Private Function GenerateRandomShelf() As String
        ' 1. Pick a random category
        Dim categories = {"FIC", "SCI", "HIS", "REF", "MAN", "BIO", "ART", "PHI"}
        Dim category = categories(_rand.Next(0, categories.Length))

        ' 2. Pick a random letter (ASCII 65='A' to 90='Z')
        Dim letter As Char = Convert.ToChar(_rand.Next(65, 91))

        ' 3. Pick a random number (1 to 15)
        Dim number = _rand.Next(1, 16)

        ' 4. Combine them, (e.g., "FIC-A-07")
        Return $"{category}-{letter}-{number:D2}"
    End Function

    ''' <summary>
    ''' Adds a new copy of an *existing* book to the catalogue.
    ''' </summary>
    ''' <returns>The CopyID of the new copy.</returns>
    Public Function AddBookCopy(bookId As Integer, shelfLocation As String, condition As String, adminAccountId As Integer?) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Create the new copy
            Dim copy As New BookCopy With {
                .BookID = bookId,
                .ShelfLocation = shelfLocation,
                .Condition = condition,
                .Status = "Available"
            }
            Dim newCopyId As Integer = bookCopyDAO.Create(copy)

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Catalogue Add Copy", $"New copy (ID: {newCopyId}) added for Book ID: {bookId}.", "Info"))

            ' 3. Commit
            transaction.Commit()

            Return newCopyId
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error adding book copy: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' ##################################################
    ' --- NEW PAGINATION FUNCTIONS (IMPLEMENTED) ---
    ' ##################################################

    ''' <summary>
    ''' Gets the total count of all books in the database.
    ''' </summary>
    Public Function GetTotalBookCount() As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            ' Call the new BookDAO function that runs:
            ' "SELECT COUNT(BookID) FROM Book"
            Dim bookDAO As New BookDAO(transaction)
            Dim count As Integer = bookDAO.GetTotalBookCount()

            transaction.Rollback() ' Read-only operation
            Return count
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting total book count: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Fetches a single page of books from the database.
    ''' </summary>
    Public Function GetBooksByPage(pageNumber As Integer, pageSize As Integer) As List(Of Book)
        ' The pageNumber here is 1-based, but SQL OFFSET is 0-based.
        Dim offset As Integer = (pageNumber - 1) * pageSize

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()
        Try
            ' Call the new BookDAO function that runs SQL for pagination
            Dim bookDAO As New BookDAO(transaction)
            Dim genreDAO As New GenreDAO(transaction) ' <-- Needed to attach genres
            Dim books = bookDAO.GetBooksByPage(offset, pageSize)

            ' --- CRITICAL ---
            ' We must also load the genres for the books on this page,
            ' just like GetAllBooks() does.
            For Each book In books
                book.Genres = genreDAO.GetGenresByBookId(book.BookID)
            Next
            ' --- END CRITICAL ---

            transaction.Rollback() ' Read-only operation
            Return books
        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error getting books by page: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' --- We also add ASYNC wrappers for the UI to call ---

    Public Function GetTotalBookCountAsync() As Task(Of Integer)
        Return Task.Run(Function()
                            Return GetTotalBookCount()
                        End Function)
    End Function

    Public Function GetBooksByPageAsync(pageNumber As Integer, pageSize As Integer) As Task(Of List(Of Book))
        Return Task.Run(Function()
                            Return GetBooksByPage(pageNumber, pageSize)
                        End Function)
    End Function

End Class