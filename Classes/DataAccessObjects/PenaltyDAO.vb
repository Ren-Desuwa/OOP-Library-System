Imports MySql.Data.MySqlClient
Imports System.Data

Public Class PenaltyDAO

    Private _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        _transaction = transaction
    End Sub

    ''' <summary>
    ''' Gets a list of all penalties for a specific user.
    ''' </summary>
    Public Function GetPenaltiesByAccountId(accountId As Integer) As List(Of Penalty)
        Dim penalties As New List(Of Penalty)

        ' This query joins Penalties with Transactions and Books to get the book title
        Dim query As String = "
            SELECT p.PenaltyID, p.AccountID, p.TransactionID, p.ViolationType, 
                   p.FineAmount, p.ScoreDeduction, p.PenaltyDate, p.Status,
                   COALESCE(b.Title, 'N/A') AS BookTitle
            FROM Penalties p
            LEFT JOIN Transactions t ON p.TransactionID = t.TransactionID
            LEFT JOIN BookCopies bc ON t.CopyID = bc.CopyID
            LEFT JOIN Books b ON bc.BookID = b.BookID
            WHERE p.AccountID = @AccountID
            ORDER BY p.PenaltyDate DESC"

        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    Dim p As New Penalty()
                    p.PenaltyID = reader.GetInt32("PenaltyID")
                    p.AccountID = reader.GetInt32("AccountID")
                    p.TransactionID = If(reader.IsDBNull(CInt("TransactionID")), CType(Nothing, Integer?), reader.GetInt32("TransactionID"))
                    p.ViolationType = reader.GetString("ViolationType")
                    p.FineAmount = reader.GetDecimal("FineAmount")
                    p.ScoreDeduction = reader.GetInt32("ScoreDeduction")
                    p.PenaltyDate = reader.GetDateTime("PenaltyDate")
                    p.Status = reader.GetString("Status")
                    p.BookTitle = reader.GetString("BookTitle")
                    penalties.Add(p)
                End While
            End Using
        End Using
        Return penalties
    End Function

    ''' <summary>
    ''' Gets the user's current credit score from their account record.
    ''' </summary>
    Public Function GetCreditScore(accountId As Integer) As Integer
        Dim query As String = "SELECT CreditScore FROM Accounts WHERE AccountID = @AccountID"
        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Dim result = cmd.ExecuteScalar()
            If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                Return Convert.ToInt32(result)
            End If
        End Using
        Return 100 ' Default score
    End Function

    ''' <summary>
    ''' Calculates the total of all unpaid fines.
    ''' </summary>
    Public Function GetTotalOutstandingFines(accountId As Integer) As Decimal
        Dim query As String = "SELECT COALESCE(SUM(FineAmount), 0) FROM Penalties WHERE AccountID = @AccountID AND Status = 'Outstanding'"
        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Return Convert.ToDecimal(cmd.ExecuteScalar())
        End Using
    End Function

    ''' <summary>
    ''' Counts how many books are currently overdue for this user.
    ''' </summary>
    Public Function GetOverdueBookCount(accountId As Integer) As Integer
        Dim query As String = "SELECT COUNT(*) FROM Transactions WHERE AccountID = @AccountID AND Status = 'Overdue'"
        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

End Class