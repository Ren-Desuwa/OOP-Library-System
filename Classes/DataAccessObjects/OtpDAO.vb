Imports MySql.Data.MySqlClient

' This helper structure passes key data from DAO to Service
Public Structure OtpRecord
    Public ID As Integer
    Public ExpiresAt As DateTime
    Public IsUsed As Boolean
End Structure

Public Class OtpDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    ' --- Invalidate (Mark old codes as used) ---

    Public Sub InvalidateByUserId(userId As Integer)
        Dim sql As String = "UPDATE user_otp SET is_used = 1 WHERE user_id = @userId AND is_used = 0"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@userId", userId)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub InvalidateByTarget(target As String)
        Dim sql As String = "UPDATE user_otp SET is_used = 1 WHERE verification_target = @target AND is_used = 0"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@target", target)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' --- Insert New Code ---

    Public Sub InsertForUser(userId As Integer, otpCode As String, expiresAt As DateTime)
        Dim sql As String = "INSERT INTO user_otp (user_id, otp_code, expires_at, is_used) VALUES (@userId, @otpCode, @expiresAt, 0)"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@userId", userId)
            cmd.Parameters.AddWithValue("@otpCode", otpCode)
            cmd.Parameters.AddWithValue("@expiresAt", expiresAt)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Sub InsertForTarget(target As String, otpCode As String, expiresAt As DateTime)
        Dim sql As String = "INSERT INTO user_otp (verification_target, otp_code, expires_at, is_used) VALUES (@target, @otpCode, @expiresAt, 0)"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@target", target)
            cmd.Parameters.AddWithValue("@otpCode", otpCode)
            cmd.Parameters.AddWithValue("@expiresAt", expiresAt)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' --- Find Code (Returns the full record) ---

    Private Function MapToOtpRecord(reader As MySqlDataReader) As OtpRecord
        Return New OtpRecord With {
            .ID = reader.GetInt32("id"),
            .ExpiresAt = reader.GetDateTime("expires_at"),
            .IsUsed = reader.GetBoolean("is_used")
        }
    End Function

    Public Function FindActiveOtpByUser(userId As Integer, otpCode As String) As OtpRecord?
        Dim sql As String = "SELECT id, expires_at, is_used FROM user_otp WHERE user_id = @userId AND otp_code = @otpCode ORDER BY id DESC LIMIT 1"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@userId", userId)
            cmd.Parameters.AddWithValue("@otpCode", otpCode)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToOtpRecord(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function FindActiveOtpByTarget(target As String, otpCode As String) As OtpRecord?
        Dim sql As String = "SELECT id, expires_at, is_used FROM user_otp WHERE verification_target = @target AND otp_code = @otpCode ORDER BY id DESC LIMIT 1"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@target", target)
            cmd.Parameters.AddWithValue("@otpCode", otpCode)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToOtpRecord(reader), Nothing)
            End Using
        End Using
    End Function

    ' --- Mark as Used (after successful verification) ---

    Public Sub MarkOtpAsUsed(id As Integer)
        Dim sql As String = "UPDATE user_otp SET is_used = 1 WHERE id = @id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class