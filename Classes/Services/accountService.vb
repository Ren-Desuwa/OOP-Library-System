Imports MySql.Data.MySqlClient
Imports System.Collections.Generic
Imports System.Exception

Public Class AccountService
    Private ReadOnly _dbcon As DBcon

    Public Sub New(dbcon As DBcon)
        If dbcon Is Nothing Then Throw New ArgumentNullException("dbcon")
        Me._dbcon = dbcon
    End Sub

    ''' <summary>
    ''' Retrieves the list of books marked as "displayed" for a specific account.
    ''' </summary>
    Public Function GetDisplayedBooksForAccount(accountId As Integer) As List(Of Book)
        ' 1. Manually open the connection using the DBcon method
        If Not _dbcon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        ' 2. Start a transaction on the now-open connection
        Dim transaction As MySqlTransaction = Nothing
        Try
            ' Get the connection object and start the transaction
            transaction = _dbcon.GetConnection().BeginTransaction()

            ' 3. Instantiate the DAO with the transaction
            Dim accountDao As New AccountDAO(transaction)

            ' 4. Call the DAO method
            Dim books = accountDao.GetDisplayedBooks(accountId)

            ' 5. Commit the transaction
            transaction.Commit()

            Return books

        Catch ex As Exception
            ' 6. Rollback on error
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to load displayed books for the user. See inner exception for details.", ex)
        Finally
            ' 7. Manually close the connection managed by DBcon
            _dbcon.CloseConnection()
        End Try
    End Function
    ''' <summary>
    ''' Retrieves a list of book IDs currently marked as favorites/displayed by the account.
    ''' </summary>
    Public Function GetUsersDisplayedBookIds(accountId As Integer) As HashSet(Of Integer)
        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDao As New AccountDAO(transaction)
            Dim bookIds = accountDao.GetFavoriteBookIds(accountId)

            transaction.Commit()
            Return bookIds
        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to load user's favorite book IDs.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Saves the user's new list of displayed books using a transactional DELETE/INSERT.
    ''' </summary>
    Public Sub SaveDisplayedBooks(accountId As Integer, bookIds As List(Of Integer))
        If Not _dbcon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbcon.GetConnection().BeginTransaction()

        Try
            Dim accountDao As New AccountDAO(transaction)

            ' Delegate the transactional work (DELETE and INSERT) to the DAO
            accountDao.UpdateDisplayedBooks(accountId, bookIds)

            transaction.Commit()

        Catch ex As Exception
            If transaction IsNot Nothing Then transaction.Rollback()
            Throw New Exception("Failed to save displayed books.", ex)
        Finally
            _dbcon.CloseConnection()
        End Try
    End Sub
End Class