' Import all your DAOs and Models
Imports MySql.Data.MySqlClient

Public Class catalougeService
    Private ReadOnly _dbCon As DBcon

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
            Dim book = bookDAO.GetById(bookId)

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
    ''' Gets a list of all books in the catalogue.
    ''' </summary>
    Public Function GetAllBooks() As List(Of Book)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim books = bookDAO.GetAll()

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

    ' #################### WRITE (Management) ####################

    ''' <summary>
    ''' Adds a brand new book to the database, along with one or more initial copies.
    ''' </summary>
    ''' <returns>The BookID of the newly created book.</returns>
    Public Function AddNewBook(book As Book, initialCopies As Integer, shelfLocation As String, condition As String, adminAccountId As Integer?) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim bookCopyDAO As New BookCopyDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Create the main book entry
            Dim newBookId As Integer = bookDAO.Create(book)
            book.BookID = newBookId

            ' 2. Create the initial copies
            If initialCopies <= 0 Then initialCopies = 1 ' Must add at least one copy

            For i = 1 To initialCopies
                Dim copy As New BookCopy With {
                    .BookID = newBookId,
                    .ShelfLocation = shelfLocation,
                    .Condition = condition,
                    .Status = "Available"
                }
                bookCopyDAO.Create(copy)
            Next

            ' 3. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Catalogue Add", $"New book '{book.Title}' (ID: {newBookId}) added with {initialCopies} copies.", "Info"))

            ' 4. Commit
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
    ''' Updates the core details of an existing book. (Does not manage copies).
    ''' </summary>
    Public Sub UpdateBookDetails(book As Book, adminAccountId As Integer?)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Update the book
            bookDAO.Update(book)

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Catalogue Update", $"Book '{book.Title}' (ID: {book.BookID}) details updated.", "Info"))

            ' 3. Commit
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error updating book details: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

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

    Public Function SearchCatalogue(searchTerm As String) As List(Of Book)
        If String.IsNullOrWhiteSpace(searchTerm) Then Return New List(Of Book)() ' Return empty if search is blank

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim bookDAO As New BookDAO(transaction)
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

End Class