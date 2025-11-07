Imports MySql.Data.MySqlClient

Public Class CreditScoreHistoryDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToCreditScoreHistory(reader As MySqlDataReader) As CreditScoreHistory
        Dim colAdminID = reader.GetOrdinal("admin_id")
        Dim colTransactionID = reader.GetOrdinal("transaction_id")

        Return New CreditScoreHistory With {
            .HistoryID = reader.GetInt32("history_id"),
            .ScoredAccountID = reader.GetInt32("scored_account_id"),
            .AdminID = If(reader.IsDBNull(colAdminID), CType(Nothing, Integer?), reader.GetInt32(colAdminID)),
            .ScoreChange = reader.GetInt16("score_change"),
            .NewScore = reader.GetInt16("new_score"),
            .Reason = reader.GetString("reason"),
            .TransactionID = If(reader.IsDBNull(colTransactionID), CType(Nothing, Integer?), reader.GetInt32(colTransactionID)),
            .ChangeDate = reader.GetDateTime("change_date")
        }
    End Function

    ' #################### CREATE ####################
    ''' <summary>
    ''' Inserts a new record into the credit_score_history table.
    ''' </summary>
    Public Function Create(history As CreditScoreHistory) As Integer
        Dim sql = "INSERT INTO credit_score_history (scored_account_id, admin_id, score_change, new_score, reason, transaction_id, change_date) " & vbCrLf &
                  "VALUES (@ScoredAccountID, @AdminID, @ScoreChange, @NewScore, @Reason, @TransactionID, @ChangeDate);" & vbCrLf &
                  "SELECT LAST_INSERT_ID();"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@ScoredAccountID", history.ScoredAccountID)
            cmd.Parameters.AddWithValue("@AdminID", If(history.AdminID.HasValue, CType(history.AdminID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@ScoreChange", history.ScoreChange)
            cmd.Parameters.AddWithValue("@NewScore", history.NewScore)
            cmd.Parameters.AddWithValue("@Reason", history.Reason)
            cmd.Parameters.AddWithValue("@TransactionID", If(history.TransactionID.HasValue, CType(history.TransactionID.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@ChangeDate", history.ChangeDate)

            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    ''' <summary>
    ''' Retrieves the credit score history for a specific account, ordered by most recent first.
    ''' </summary>
    Public Function GetHistoryByAccountID(accountID As Integer, limit As Integer) As List(Of CreditScoreHistory)
        Dim list As New List(Of CreditScoreHistory)
        Dim sql = $"SELECT * FROM credit_score_history WHERE scored_account_id = @AccountID ORDER BY change_date DESC LIMIT {limit}"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountID)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToCreditScoreHistory(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Retrieves all credit score history records.
    ''' </summary>
    Public Function GetAllHistory() As List(Of CreditScoreHistory)
        Dim list As New List(Of CreditScoreHistory)
        Dim sql = "SELECT * FROM credit_score_history ORDER BY change_date DESC"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToCreditScoreHistory(reader))
                End While
            End Using
        End Using
        Return list
    End Function
End Class