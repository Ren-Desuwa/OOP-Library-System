Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MySql.Data.MySqlClient
Imports LibrarySystem.Classes.DataAccessObjects

<TestClass>
Public MustInherit Class BaseDAOTest
    Protected _dbCon As DBcon
    Protected _connection As MySqlConnection
    Protected _transaction As MySqlTransaction

    <TestInitialize>
    Public Sub Setup()
        ' This runs BEFORE every single test
        ' We connect to the TEST database and start a transaction
        _dbCon = New DBcon("ooplibrary") ' Using your confirmed DB name
        _dbCon.OpenConnection()
        _connection = _dbCon.GetConnection()
        _transaction = _connection.BeginTransaction()
    End Sub

    <TestCleanup>
    Public Sub Teardown()
        ' This runs AFTER every single test
        ' We roll back all changes and close the connection
        If _transaction IsNot Nothing Then
            _transaction.Rollback()
        End If
        If _dbCon IsNot Nothing Then
            _dbCon.CloseConnection()
        End If
    End Sub
End Class
