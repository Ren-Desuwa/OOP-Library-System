Imports MySql.Data.MySqlClient

Public Class PenaltyService

    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ' This helper class will hold the summary data
    Public Class PenaltyTabSummary
        Public Property PenaltyHistory As List(Of Penalty)
        Public Property CurrentScore As Integer
        Public Property OutstandingFines As Decimal
        Public Property OverdueBooksCount As Integer
    End Class

    ''' <summary>
    ''' Gets all data needed for the penalty tab in a single database transaction.
    ''' </summary>
    Public Function GetPenaltyTabData(accountId As Integer) As PenaltyTabSummary
        Dim summary As New PenaltyTabSummary()

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' Create the DAO with the active transaction
            Dim penaltyDAO As New PenaltyDAO(transaction)

            ' Call all the DAO methods
            summary.PenaltyHistory = penaltyDAO.GetPenaltiesByAccountId(accountId)
            summary.CurrentScore = penaltyDAO.GetCreditScore(accountId)
            summary.OutstandingFines = penaltyDAO.GetTotalOutstandingFines(accountId)
            summary.OverdueBooksCount = penaltyDAO.GetOverdueBookCount(accountId)

            ' Commit the transaction (or Rollback since it's read-only, like your BorrowService)
            transaction.Rollback()
            Return summary

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching penalty data: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

End Class