Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports Classes.Models ' For the Log model

Public Class LogService
    Private ReadOnly _dbcon As DBcon

    Public Sub New(dbcon As DBcon)
        If dbcon Is Nothing Then Throw New ArgumentNullException("dbcon")
        Me._dbcon = dbcon
    End Sub

    ''' <summary>
    ''' Records a system or user event by constructing a Log object (business logic)
    ''' and persisting it via the LogDAO (data persistence).
    ''' </summary>
    Public Sub RecordSystemEvent(action As String, details As String, severity As String, Optional accountID As Integer? = 1)
        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            ' 1. Business Logic: Create the Log model object
            Dim logDao As New LogDAO(transaction)
            Dim newLog = New Log With {
                .AccountID = accountID,
                .Action = action,
                .Details = details,
                .Severity = severity,
                .Timestamp = DateTime.Now ' Timestamp generation is business logic
            }

            ' 2. Persistence: Delegate to DAO
            logDao.Create(newLog)
            transaction.Commit()
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception($"Failed to record log event: {action}. See inner exception for details.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub

    ''' <summary>
    ''' Retrieves the last 100 logs with user details for the Admin/Librarian logs tab 
    ''' by managing a read-only transaction and delegating to LogDAO.
    ''' </summary>
    Public Function GetLatestLogsForUI() As List(Of Object)
        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        ' Use BeginTransaction to ensure a stable connection/context for the DAO
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim logDao As New LogDAO(transaction)

            ' Delegation: Call the DAO method (which runs the complex join query)
            Dim logsList = logDao.GetLatestLogsWithUserDetails()

            ' Management: Rollback the transaction since this was a pure read operation.
            transaction.Rollback()

            Return logsList

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to retrieve latest logs for UI. See inner exception for details.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

End Class