Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class LogDAOTests
    Inherits BaseDAOTest

    Private _testAccountId As Integer

    Private Sub CreateTestAccount()
        Dim accountDao As New AccountDAO(_transaction)
        _testAccountId = accountDao.Create(New Account With {
            .Username = "log_user",
            .Name = "Log User",
            .Email = "log@example.com",
            .PasswordHash = "hash",
            .Role = "Member"
        })
    End Sub

    <TestMethod>
    Public Sub LogDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        CreateTestAccount()
        Dim dao As New LogDAO(_transaction)
        Dim newLog As New Log With {
            .AccountID = _testAccountId,
            .Action = "Test Log",
            .Details = "Details...",
            .IPAddress = "127.0.0.1",
            .Severity = "Warning"
        }

        ' Act
        Dim newId = dao.Create(newLog)
        Dim fetched = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetched)
        Assert.AreEqual(_testAccountId, fetched.AccountID)
        Assert.AreEqual("Test Log", fetched.Action)
        Assert.AreEqual("127.0.0.1", fetched.IPAddress)
        Assert.AreEqual("Warning", fetched.Severity)
    End Sub

    <TestMethod>
    Public Sub LogDAO_Create_ShouldHandleNullAccountId()
        ' Arrange
        Dim dao As New LogDAO(_transaction)
        Dim newLog As New Log With {
            .AccountID = Nothing,
            .Action = "System Log",
            .Details = "System startup",
            .Severity = "Info"
        }

        ' Act
        Dim newId = dao.Create(newLog)
        Dim fetched = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetched)
        Assert.IsNull(fetched.AccountID)
        Assert.AreEqual("System Log", fetched.Action)
    End Sub
End Class
