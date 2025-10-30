Imports MySql.Data.MySqlClient

Public Class BookCopyDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToBookCopy(reader As MySqlDataReader) As BookCopy
        Return New BookCopy With {
            .CopyID = reader.GetInt32("copy_id"),
            .BookID = reader.GetInt32("book_id"),
            .Condition = reader.GetString("condition"),
            .Status = reader.GetString("status"),
            .ShelfLocation = reader.GetString("shelf_location"),
            .DateAdded = reader.GetDateTime("date_added"),
            .LastUpdated = reader.GetDateTime("last_updated")
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(copy As BookCopy) As Integer
        ' --- FIX: "condition" is a reserved keyword and must be in backticks ---
        Dim sql = "INSERT INTO book_copies (book_id, `condition`, status, shelf_location, date_added, last_updated) " &
                  "VALUES (@BookID, @Condition, @Status, @ShelfLocation, @DateAdded, @LastUpdated); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", copy.BookID)
            cmd.Parameters.AddWithValue("@Condition", copy.Condition)
            cmd.Parameters.AddWithValue("@Status", copy.Status)
            cmd.Parameters.AddWithValue("@ShelfLocation", copy.ShelfLocation)
            cmd.Parameters.AddWithValue("@DateAdded", copy.DateAdded)
            cmd.Parameters.AddWithValue("@LastUpdated", copy.LastUpdated)
            Return Convert.ToInt32(cmd.ExecuteScalar()) ' This is line 35
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As BookCopy
        Dim sql = "SELECT * FROM book_copies WHERE copy_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToBookCopy(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetCopiesByBookId(bookId As Integer) As List(Of BookCopy)
        Dim list As New List(Of BookCopy)
        Dim sql = "SELECT * FROM book_copies WHERE book_id = @BookID"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", bookId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToBookCopy(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(copy As BookCopy)
        Dim sql = "UPDATE book_copies SET " &
                  "book_id = @BookID, `condition` = @Condition, status = @Status, " &
                  "shelf_location = @ShelfLocation, last_updated = @LastUpdated " &
                  "WHERE copy_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@BookID", copy.BookID)
            cmd.Parameters.AddWithValue("@Condition", copy.Condition)
            cmd.Parameters.AddWithValue("@Status", copy.Status)
            cmd.Parameters.AddWithValue("@ShelfLocation", copy.ShelfLocation)
            cmd.Parameters.AddWithValue("@LastUpdated", DateTime.Now) ' Always update this
            cmd.Parameters.AddWithValue("@Id", copy.CopyID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        ' Note: ON DELETE SET NULL in transactions will handle history
        Dim sql = "DELETE FROM book_copies WHERE copy_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class