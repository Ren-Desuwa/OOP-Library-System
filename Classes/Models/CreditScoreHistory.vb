Imports System

Public Class CreditScoreHistory
    Public Property HistoryID As Integer
    Public Property ScoredAccountID As Integer
    Public Property AdminID As Integer? ' Nullable for system-initiated changes
    Public Property ScoreChange As Short
    Public Property NewScore As Short
    Public Property Reason As String
    Public Property TransactionID As Integer? ' Nullable if not tied to a transaction
    Public Property ChangeDate As DateTime

    Public Sub New()
        ChangeDate = DateTime.Now
    End Sub
End Class