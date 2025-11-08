Imports MySql.Data.MySqlClient
' Imports System.Transactions ' (REMOVED - No longer using TransactionScope)

Public Class CreditScoreService
    Private ReadOnly _dbCon As DBcon

    ' Constants for score changes (REVISED FOR 75-100 SCALE)
    Public Const SCORE_MAX As Short = 100 ' Maximum score
    Public Const SCORE_INITIAL As Short = 75 ' Starting score is 75
    Public Const SCORE_LATE_RETURN As Short = -10 ' Penalty for late return
    Public Const SCORE_ON_TIME_RETURN As Short = 1 ' Bonus for on-time return
    Public Const SCORE_MIN_ALLOWED_BORROW As Short = 75 ' Minimum score to borrow books

    Public Sub New(dbCon As DBcon)
        If dbCon Is Nothing Then Throw New ArgumentNullException("dbCon")
        _dbCon = dbCon
    End Sub

    ''' <summary>
    ''' Applies a credit score change to a user and logs the action.
    ''' This operation is transactional. (MODIFIED to use standard pattern)
    ''' </summary>
    Public Sub UpdateCreditScore(accountID As Integer, changeAmount As Short, reason As String, adminID As Integer?, transactionID As Integer?)
        ' Using scope As New TransactionScope() ' (REMOVED)

        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If
        Dim dbTransaction As MySqlTransaction = _dbCon.GetConnection.BeginTransaction()

        Try
            ' 1. Get the current account object
            Dim accountDAO As New AccountDAO(dbTransaction)
            Dim account As Account = accountDAO.GetById(accountID)

            If account Is Nothing Then
                Throw New Exception($"Account with ID {accountID} not found.")
            End If

            ' 2. Calculate the new score
            Dim oldScore As Short = account.CreditScore
            Dim newScore As Short = CShort(account.CreditScore + changeAmount)

            ' Enforce minimum score (0)
            If newScore < 0 Then
                newScore = 0
            End If

            ' Enforce maximum score (100)
            If newScore > SCORE_MAX Then
                newScore = SCORE_MAX
            End If

            ' 3. Update the account's score in the database
            account.CreditScore = newScore
            accountDAO.Update(account)

            ' 4. Create a history log entry
            Dim history = New CreditScoreHistory With {
                .ScoredAccountID = accountID,
                .AdminID = adminID,
                .ScoreChange = changeAmount,
                .NewScore = newScore,
                .Reason = reason,
                .TransactionID = transactionID
            }

            Dim historyDAO As New CreditScoreHistoryDAO(dbTransaction)
            historyDAO.Create(history)

            ' 5. Commit the changes
            dbTransaction.Commit()
            ' scope.Complete() ' (REMOVED)

        Catch ex As Exception
            dbTransaction.Rollback()
            Throw New Exception($"Failed to update credit score for user {accountID}. Details: {ex.Message}", ex)
        Finally
            _dbCon.CloseConnection()
        End Try
        ' End Using ' (REMOVED)
    End Sub

    ''' <summary>
    ''' Retrieves the current credit score for a user.
    ''' </summary>
    Public Function GetCurrentScore(accountID As Integer) As Short
        Dim score As Short = SCORE_INITIAL
        _dbCon.OpenConnection()
        Try
            Using transaction As MySqlTransaction = _dbCon.GetConnection.BeginTransaction()
                Dim accountDAO As New AccountDAO(transaction)
                Dim account As Account = accountDAO.GetById(accountID)
                If account IsNot Nothing Then
                    score = account.CreditScore
                End If
                transaction.Commit()
            End Using
        Catch ex As Exception
            ' Log error if necessary, but for a simple read, return default/initial score
        Finally
            _dbCon.CloseConnection()
        End Try
        Return score
    End Function

    ''' <summary>
    ''' Retrieves the credit score history for a user.
    ''' </summary>
    Public Function GetCreditScoreHistory(accountID As Integer, Optional limit As Integer = 10) As List(Of CreditScoreHistory)
        Dim history As New List(Of CreditScoreHistory)
        _dbCon.OpenConnection()
        Try
            Using transaction As MySqlTransaction = _dbCon.GetConnection.BeginTransaction()
                Dim historyDAO As New CreditScoreHistoryDAO(transaction)
                history = historyDAO.GetHistoryByAccountID(accountID, limit)
                transaction.Commit()
            End Using
        Catch ex As Exception
            ' Log or handle error
            Throw
        Finally
            _dbCon.CloseConnection()
        End Try
        Return history
    End Function
End Class