Public Class Penalty
    ' These properties come from your Penalties table in the database
    Public Property PenaltyID As Integer
    Public Property AccountID As Integer
    Public Property TransactionID As Integer? ' (The related book, if any)
    Public Property ViolationType As String ' e.g., "Overdue", "Damaged"
    Public Property FineAmount As Double
    Public Property ScoreDeduction As Integer
    Public Property PenaltyDate As DateTime
    Public Property Status As String ' e.g., "Outstanding", "Paid"

    ' This property is for the UI, to show the book title
    Public Property BookTitle As String = "N/A"
End Class