Imports MySql.Data.MySqlClient

Public Class BookDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    ' Helper to map from reader, including calculated fields
    Private Function MapToBook(reader As MySqlDataReader) As Book
        ' --- FIX: Get column indexes once for safety ---
        Dim colGenre = reader.GetOrdinal("genre")
        Dim colPublisher = reader.GetOrdinal("publisher")
        Dim colYearPublished = reader.GetOrdinal("year_published")
        Dim colDescription = reader.GetOrdinal("description")
        Dim colCoverUrl = reader.GetOrdinal("cover_url") ' <-- ADD THIS LINE

        Return New Book With {
            .BookID = reader.GetInt32("book_id"),
            .Title = reader.GetString("title"),
            .Author = reader.GetString("author"),
            .ISBN = reader.GetString("isbn"),
            .Genre = If(reader.IsDBNull(colGenre), Nothing, reader.GetString(colGenre)),
            .Publisher = If(reader.IsDBNull(colPublisher), Nothing, reader.GetString(colPublisher)),
            .YearPublished = If(reader.IsDBNull(colYearPublished), 0, reader.GetInt32(colYearPublished)),
            .Description = If(reader.IsDBNull(colDescription), Nothing, reader.GetString(colDescription)),
            .CoverUrl = If(reader.IsDBNull(colCoverUrl), Nothing, reader.GetString(colCoverUrl)), ' <-- ADD THIS LINE
            .TotalCopies = reader.GetInt32("total_copies"),
            .AvailableCopies = reader.GetInt32("available_copies")
        }
    End Function

    ' This is the base SQL query that includes the calculated counts
    Private Const SELECT_SQL As String =
        "SELECT b.*, " &
        "  (SELECT COUNT(*) FROM book_copies bc WHERE bc.book_id = b.book_id) AS total_copies, " &
        "  (SELECT COUNT(*) FROM book_copies bc WHERE bc.book_id = b.book_id AND bc.status = 'Available') AS available_copies " &
        "FROM books b "
    ' (No change needed here, "b.*" will automatically pick up the new column)

    ' 
    '#################### CREATE ####################
    Public Function Create(book As Book) As Integer
        ' Note: We only insert the non-calculated fields
        Dim sql = "INSERT INTO books (title, author, genre, isbn, publisher, year_published, description, cover_url) " & ' <-- ADD cover_url
                  "VALUES (@Title, @Author, @Genre, @ISBN, @Publisher, @YearPublished, @Description, @CoverUrl);" & ' <-- ADD @CoverUrl
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Title", book.Title)
            cmd.Parameters.AddWithValue("@Author", book.Author)
            cmd.Parameters.AddWithValue("@Genre", If(book.Genre Is Nothing, Nothing, book.Genre))
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN)
            cmd.Parameters.AddWithValue("@Publisher", If(book.Publisher Is Nothing, Nothing, book.Publisher))
            cmd.Parameters.AddWithValue("@YearPublished", If(book.YearPublished = 0, Nothing, book.YearPublished))
            cmd.Parameters.AddWithValue("@Description", If(book.Description Is Nothing, Nothing, book.Description))
            cmd.Parameters.AddWithValue("@CoverUrl", If(book.CoverUrl Is Nothing, Nothing, book.CoverUrl)) ' <-- ADD THIS LINE
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    ' (GetById, GetAll, GetByAuthor functions require NO changes because they use SELECT_SQL and MapToBook)
    Public Function GetById(id As Integer) As Book
        Dim sql = SELECT_SQL & " WHERE b.book_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToBook(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetAll() As List(Of Book)
        Dim list As New List(Of Book)
        Dim sql = SELECT_SQL & " ORDER BY b.title"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToBook(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    Public Function GetByAuthor(author As String) As List(Of Book)
        Dim list As New List(Of Book)
        Dim sql = SELECT_SQL & " WHERE b.author LIKE @Author ORDER BY b.title"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Author", "%" & author & "%")
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToBook(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(book As Book)
        Dim sql = "UPDATE books SET " &
                  "title = @Title, author = @Author, genre = @Genre, isbn = @ISBN, " &
                  "publisher = @Publisher, year_published = @YearPublished, description = @Description, " &
                  "cover_url = @CoverUrl " & ' <-- ADD cover_url
                  "WHERE book_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Title", book.Title)
            cmd.Parameters.AddWithValue("@Author", book.Author)
            cmd.Parameters.AddWithValue("@Genre", If(book.Genre Is Nothing, Nothing, book.Genre))
            cmd.Parameters.AddWithValue("@ISBN", book.ISBN)
            cmd.Parameters.AddWithValue("@Publisher", If(book.Publisher Is Nothing, Nothing, book.Publisher))
            cmd.Parameters.AddWithValue("@YearPublished", If(book.YearPublished = 0, Nothing, book.YearPublished))
            cmd.Parameters.AddWithValue("@Description", If(book.Description Is Nothing, Nothing, book.Description))
            cmd.Parameters.AddWithValue("@CoverUrl", If(book.CoverUrl Is Nothing, Nothing, book.CoverUrl)) ' <-- ADD THIS LINE
            cmd.Parameters.AddWithValue("@Id", book.BookID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        ' Note: ON DELETE CASCADE in book_copies will delete related copies
        Dim sql = "DELETE FROM books WHERE book_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### HELPERS ###########################
    Public Function SearchBooks(searchTerm As String) As List(Of Book)
        Dim list As New List(Of Book)
        ' Use the base SELECT_SQL which includes copy counts
        ' Add a WHERE clause to search across relevant text fields
        Dim sql = SELECT_SQL & " WHERE b.title LIKE @SearchTerm " &
                  " OR b.author LIKE @SearchTerm " &
                  " OR b.isbn LIKE @SearchTerm " &
                  " OR b.description LIKE @SearchTerm " &
                  " OR b.genre LIKE @SearchTerm " &
                  " ORDER BY b.title"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            ' Add parameter with wildcards for partial matching
            cmd.Parameters.AddWithValue("@SearchTerm", "%" & searchTerm & "%")

            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToBook(reader)) ' Use existing mapping function
                End While
            End Using
        End Using
        Return list
    End Function

End Class