Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports MySql.Data.MySqlClient
' Import your main project's namespaces
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class AccountDAOTests
    Private _dbCon As DBcon
    Private _connection As MySqlConnection
    Private _transaction As MySqlTransaction

    <TestInitialize>
    Public Sub Setup()
        ' This runs BEFORE every single test
        ' We connect to the TEST database and start a transaction
        _dbCon = New DBcon("ooplibrary")
        _dbCon.OpenConnection()
        _connection = _dbCon.GetConnection()
        _transaction = _connection.BeginTransaction()
    End Sub

    <TestCleanup>
    Public Sub Teardown()
        ' This runs AFTER every single test
        ' We roll back all changes and close the connection
        _transaction.Rollback()
        _dbCon.CloseConnection()
    End Sub

    <TestMethod>
    Public Sub AccountDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        Dim dao As New AccountDAO(_transaction)
        Dim newAccount As New Account With {
            .Username = "testuser",
            .Name = "Test User",
            .Email = "test@example.com",
            .Role = "Member",
            .PasswordHash = "TestHash123"
        }

        ' Act
        Dim newId As Integer = dao.Create(newAccount)
        Dim fetchedAccount As Account = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedAccount)
        Assert.IsTrue(newId > 0)
        Assert.AreEqual("testuser", fetchedAccount.Username)
        Assert.AreEqual("Test User", fetchedAccount.Name)
    End Sub

    <TestMethod>
    Public Sub AccountDAO_GetByUsername_ShouldReturnCorrectAccount()
        ' Arrange
        Dim dao As New AccountDAO(_transaction)
        Dim newAccount As New Account With {
            .Username = "findme",
            .Name = "Find Me Please",
            .Email = "findme@example.com",
            .Role = "Librarian",
            .PasswordHash = "FindHash123"
        }
        Dim newId As Integer = dao.Create(newAccount)

        ' Act
        Dim foundAccount As Account = dao.GetByUsername("findme")

        ' Assert
        Assert.IsNotNull(foundAccount)
        Assert.AreEqual(newId, foundAccount.AccountID)
        Assert.AreEqual("Librarian", foundAccount.Role)
    End Sub

    <TestMethod>
    Public Sub AccountDAO_GetByUsername_ShouldReturnNothingForInvalidUser()
        ' Arrange
        Dim dao As New AccountDAO(_transaction)
        ' No account created

        ' Act
        Dim foundAccount As Account = dao.GetByUsername("nobody")

        ' Assert
        Assert.IsNull(foundAccount)
    End Sub

    <TestMethod>
    Public Sub AccountDAO_Update_ShouldChangeDataInDB()
        ' Arrange
        Dim dao As New AccountDAO(_transaction)
        Dim newAccount As New Account With {
            .Username = "changeuser",
            .Name = "Original Name",
            .Email = "change@example.com",
            .Role = "Member",
            .PasswordHash = "OriginalHash"
        }
        Dim newId As Integer = dao.Create(newAccount)

        ' Get the created account to make a change
        Dim accountToUpdate As Account = dao.GetById(newId)
        accountToUpdate.Name = "Updated Name"
        accountToUpdate.Role = "Admin"

        ' Act
        dao.Update(accountToUpdate)

        ' Re-fetch the account from the DB to see if changes stuck
        Dim fetchedAccount As Account = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedAccount)
        Assert.AreEqual("Updated Name", fetchedAccount.Name)
        Assert.AreEqual("Admin", fetchedAccount.Role)
        Assert.AreEqual("changeuser", fetchedAccount.Username)
    End Sub
End Class
