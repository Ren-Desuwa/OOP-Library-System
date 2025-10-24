Imports MySql.Data.MySqlClient

Public Class LogDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToLog(reader As MySqlDataReader) As Log
        ' --- FIX: Get column ordinals once ---
        Dim colAccountId = reader.GetOrdinal("account_id")
        Dim colDetails = reader.GetOrdinal("details")
        Dim colIpAddress = reader.GetOrdinal("ip_address")

        Return New Log With {
            .LogID = reader.GetInt32("log_id"),
            .Action = reader.GetString("action"),
            .Timestamp = reader.GetDateTime("timestamp"),
            .Severity = reader.GetString("severity"),
            .AccountID = If(reader.IsDBNull(colAccountId), CType(Nothing, Integer?), reader.GetInt32(colAccountId)),
            .Details = If(reader.IsDBNull(colDetails), Nothing, reader.GetString(colDetails)),
            .IPAddress = If(reader.IsDBNull(colIpAddress), Nothing, reader.GetString(colIpAddress))
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(log As Log) As Integer
        Dim sql = "INSERT INTO logs (account_id, action, timestamp, details, ip_address, severity) " &
                  "VALUES (@AccountID, @Action, @Timestamp, @Details, @IPAddress, @Severity); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", If(log.AccountID.HasValue, CType(log.AccountID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Action", log.Action)
            cmd.Parameters.AddWithValue("@Timestamp", log.Timestamp)
            cmd.Parameters.AddWithValue("@Details", log.Details)
            cmd.Parameters.AddWithValue("@IPAddress", log.IPAddress)
            cmd.Parameters.AddWithValue("@Severity", log.Severity)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Log
        Dim sql = "SELECT * FROM logs WHERE log_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToLog(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByAccountId(accountId As Integer) As List(Of Log)
        Dim list As New List(Of Log)
        Dim sql = "SELECT * FROM logs WHERE account_id = @AccountID ORDER BY timestamp DESC"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToLog(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    ' (Update/Delete for logs is highly irregular but included for CRUD completeness)
    Public Sub Update(log As Log)
        Dim sql = "UPDATE logs SET " &
                  "account_id = @AccountID, action = @Action, timestamp = @Timestamp, " &
                  "details = @Details, ip_address = @IPAddress, severity = @Severity " &
                  "WHERE log_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", If(log.AccountID.HasValue, CType(log.AccountID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Action", log.Action)
            cmd.Parameters.AddWithValue("@Timestamp", log.Timestamp)
            cmd.Parameters.AddWithValue("@Details", log.Details)
            cmd.Parameters.AddWithValue("@IPAddress", log.IPAddress)
            cmd.Parameters.AddWithValue("@Severity", log.Severity)
            cmd.Parameters.AddWithValue("@Id", log.LogID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        Dim sql = "DELETE FROM logs WHERE log_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class