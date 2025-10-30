Imports MySql.Data.MySqlClient

Public Class GenreDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    ' Helper to map from reader to a Genre object
    ' (Assumes a 'Genre' model class exists with these properties)
    Private Function MapToGenre(reader As MySqlDataReader) As Genre
        Return New Genre With {
            .GenreID = reader.GetInt32("genre_id"),
            .Name = reader.GetString("name")
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(genre As Genre) As Integer
        Dim sql = "INSERT INTO genres (name) VALUES (@Name); SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Name", genre.Name)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Genre
        Dim sql = "SELECT * FROM genres WHERE genre_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToGenre(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByName(name As String) As Genre
        Dim sql = "SELECT * FROM genres WHERE name = @Name"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Name", name)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToGenre(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetAll() As List(Of Genre)
        Dim list As New List(Of Genre)
        Dim sql = "SELECT * FROM genres ORDER BY name"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToGenre(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Gets a list of all Genres associated with a specific Book ID.
    ''' </summary>
    Public Function GetGenresByBookId(bookId As Integer) As List(Of Genre)
        Dim list As New List(Of Genre)
        ' Join genres with the book_genres junction table
        Dim sql = "SELECT g.* FROM genres g " &
                  "JOIN book_genres bg ON g.genre_id = bg.genre_id " &
                  "WHERE bg.book_id = @BookID ORDER BY g.name"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", bookId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToGenre(reader))
                End While
            End Using
        End Using
        Return list
    End Function


    ' #################### UPDATE ####################
    Public Sub Update(genre As Genre)
        Dim sql = "UPDATE genres SET name = @Name WHERE genre_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Name", genre.Name)
            cmd.Parameters.AddWithValue("@Id", genre.GenreID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        ' Note: ON DELETE CASCADE in book_genres will handle related records
        Dim sql = "DELETE FROM genres WHERE genre_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class