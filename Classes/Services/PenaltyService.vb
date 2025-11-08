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

    ' --- (MODIFIED) THIS FUNCTION ---
    ''' <summary>
    ''' Calculates the penalty for an overdue book.
    ''' </summary>
    ''' <param name="dueDate">The date the book was due.</param>
    ''' <returns>A new Penalty object if overdue, otherwise Nothing.</returns>
    Public Function CalculatePenalty(dueDate As Date) As Penalty
        ' Check if today's date is past the due date
        If DateTime.Today <= dueDate.Date Then
            Return Nothing ' Not overdue
        End If

        Dim daysOverdue As Integer = (DateTime.Today - dueDate.Date).Days
        ' Assuming a flat rate for simplicity.
        ' You can make this calculation more complex (e.g., $1.00 per day).
        Dim penaltyRatePerDay As Double = 1.0
        Dim penaltyAmount As Double = daysOverdue * penaltyRatePerDay

        ' (MODIFIED) Create a new Penalty object using the correct model properties
        Dim newPenalty As New Penalty With {
            .FineAmount = penaltyAmount,
            .ViolationType = "Overdue",
            .ScoreDeduction = 0,
            .Status = "Outstanding",
            .PenaltyDate = DateTime.Today
        }

        Return newPenalty
    End Function

End Class