Imports MySql.Data.MySqlClient

' We assume the NotificationType Enum is available here
' Public Enum NotificationType
'     BookReminder = 0
'     OverdueReminder = 1
'     ...
' End Enum

Public Class NotificationDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToNotification(reader As MySqlDataReader) As Notification
        ' This code assumes the model was corrected to use the Enum/Integer
        ' If model still uses String, mapping logic is needed here
        Return New Notification With {
            .NotificationID = reader.GetInt32("notification_id"),
            .AccountID = reader.GetInt32("account_id"),
            .TransactionID = If(reader.IsDBNull(reader.GetOrdinal("transaction_id")), CType(Nothing, Integer?), reader.GetInt32("transaction_id")),
            .Message = reader.GetString("message"),
            .DateSent = reader.GetDateTime("date_sent"),
            .IsRead = reader.GetBoolean("is_read"),
            .NotificationType = CType(reader.GetInt32("notification_type"), NotificationType) ' Cast to Enum
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(notification As Notification) As Integer
        Dim sql = "INSERT INTO notifications (account_id, transaction_id, message, date_sent, is_read, notification_type) " &
                  "VALUES (@AccountID, @TransactionID, @Message, @DateSent, @IsRead, @NotificationType); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", notification.AccountID)
            cmd.Parameters.AddWithValue("@TransactionID", If(notification.TransactionID.HasValue, CType(notification.TransactionID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Message", notification.Message)
            cmd.Parameters.AddWithValue("@DateSent", notification.DateSent)
            cmd.Parameters.AddWithValue("@IsRead", notification.IsRead)
            cmd.Parameters.AddWithValue("@NotificationType", CInt(notification.NotificationType)) ' Cast Enum to Int
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Notification
        Dim sql = "SELECT * FROM notifications WHERE notification_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToNotification(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByAccountId(accountId As Integer, Optional unreadOnly As Boolean = False) As List(Of Notification)
        Dim list As New List(Of Notification)
        Dim sql = "SELECT * FROM notifications WHERE account_id = @AccountID " &
                  If(unreadOnly, " AND is_read = 0 ", "") &
                  " ORDER BY date_sent DESC, notification_id DESC"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToNotification(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(notification As Notification)
        Dim sql = "UPDATE notifications SET " &
                  "account_id = @AccountID, transaction_id = @TransactionID, message = @Message, " &
                  "date_sent = @DateSent, is_read = @IsRead, notification_type = @NotificationType " &
                  "WHERE notification_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", notification.AccountID)
            cmd.Parameters.AddWithValue("@TransactionID", If(notification.TransactionID.HasValue, CType(notification.TransactionID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Message", notification.Message)
            cmd.Parameters.AddWithValue("@DateSent", notification.DateSent)
            cmd.Parameters.AddWithValue("@IsRead", notification.IsRead)
            cmd.Parameters.AddWithValue("@NotificationType", CInt(notification.NotificationType))
            cmd.Parameters.AddWithValue("@Id", notification.NotificationID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        Dim sql = "DELETE FROM notifications WHERE notification_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class