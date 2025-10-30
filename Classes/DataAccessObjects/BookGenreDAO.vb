Imports MySql.Data.MySqlClient

Public Class BookGenreDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    ''' <summary>
    ''' Creates a link between a book and a genre.
    ''' </summary>
    Public Sub AddGenreToBook(bookId As Integer, genreId As Integer)
        ' Use IGNORE to prevent crashing if the relationship already exists
        Dim sql = "INSERT IGNORE INTO book_genres (book_id, genre_id) VALUES (@BookID, @GenreID)"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", bookId)
            cmd.Parameters.AddWithValue("@GenreID", genreId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>
    ''' Removes a link between a book and a genre.
    ''' </summary>
    Public Sub RemoveGenreFromBook(bookId As Integer, genreId As Integer)
        Dim sql = "DELETE FROM book_genres WHERE book_id = @BookID AND genre_id = @GenreID"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", bookId)
            cmd.Parameters.AddWithValue("@GenreID", genreId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ''' <summary>
    ''' Removes all genre links for a specific book.
    ''' This is useful when updating a book's genre list.
    ''' </summary>
    Public Sub ClearGenresForBook(bookId As Integer)
        Dim sql = "DELETE FROM book_genres WHERE book_id = @BookID"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", bookId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class