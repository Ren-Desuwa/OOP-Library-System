Imports MySql.Data.MySqlClient

Public Class AnnouncementDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToAnnouncement(reader As MySqlDataReader) As Announcement
        Return New Announcement With {
            .AnnouncementID = reader.GetInt32("announcement_id"),
            .AdminID = reader.GetInt32("admin_id"),
            .Title = reader.GetString("title"),
            .Message = reader.GetString("message"),
            .DatePosted = reader.GetDateTime("date_posted"),
            .ExpiryDate = If(reader.IsDBNull(reader.GetOrdinal("expiry_date")), CType(Nothing, DateTime?), reader.GetDateTime("expiry_date")),
            .Priority = reader.GetString("priority"),
            .IsActive = reader.GetBoolean("is_active")
        }
    End Function



    ' #################### CREATE ####################
    Public Function Create(announcement As Announcement) As Integer
        Dim sql = "INSERT INTO announcements (admin_id, title, message, date_posted, expiry_date, priority, is_active) " &
                  "VALUES (@AdminID, @Title, @Message, @DatePosted, @ExpiryDate, @Priority, @IsActive); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AdminID", announcement.AdminID)
            cmd.Parameters.AddWithValue("@Title", announcement.Title)
            cmd.Parameters.AddWithValue("@Message", announcement.Message)
            cmd.Parameters.AddWithValue("@DatePosted", announcement.DatePosted)
            cmd.Parameters.AddWithValue("@ExpiryDate", If(announcement.ExpiryDate.HasValue, CType(announcement.ExpiryDate.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Priority", announcement.Priority)
            cmd.Parameters.AddWithValue("@IsActive", announcement.IsActive)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Announcement
        Dim sql = "SELECT * FROM announcements WHERE announcement_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToAnnouncement(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetActiveAnnouncements() As List(Of Announcement)
        Dim list As New List(Of Announcement)
        Dim sql = "SELECT * FROM announcements WHERE is_active = 1 " &
              "AND (expiry_date IS NULL OR expiry_date > NOW()) " &
              "ORDER BY date_posted DESC, announcement_id DESC" ' <--- ADDED THIS
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToAnnouncement(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(announcement As Announcement)
        Dim sql = "UPDATE announcements SET " &
                  "admin_id = @AdminID, title = @Title, message = @Message, date_posted = @DatePosted, " &
                  "expiry_date = @ExpiryDate, priority = @Priority, is_active = @IsActive " &
                  "WHERE announcement_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AdminID", announcement.AdminID)
            cmd.Parameters.AddWithValue("@Title", announcement.Title)
            cmd.Parameters.AddWithValue("@Message", announcement.Message)
            cmd.Parameters.AddWithValue("@DatePosted", announcement.DatePosted)
            cmd.Parameters.AddWithValue("@ExpiryDate", If(announcement.ExpiryDate.HasValue, CType(announcement.ExpiryDate.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Priority", announcement.Priority)
            cmd.Parameters.AddWithValue("@IsActive", announcement.IsActive)
            cmd.Parameters.AddWithValue("@Id", announcement.AnnouncementID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        Dim sql = "DELETE FROM announcements WHERE announcement_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class