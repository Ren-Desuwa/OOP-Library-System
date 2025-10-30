Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class AnnouncementDAOTests
    Inherits BaseDAOTest

    Private _testAdminId As Integer

    Private Sub CreateTestAdmin()
        Dim accountDao As New AccountDAO(_transaction)
        _testAdminId = accountDao.Create(New Account With {
            .Username = "admin_user",
            .Name = "Admin User",
            .Email = "admin@example.com",
            .PasswordHash = "hash",
            .Role = "Admin"
        })
    End Sub

    <TestMethod>
    Public Sub AnnouncementDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        CreateTestAdmin()
        Dim dao As New AnnouncementDAO(_transaction)
        Dim newAnnouncement As New Announcement With {
            .AdminID = _testAdminId,
            .Title = "Library Closing Early",
            .Message = "Closing at 5pm today.",
            .Priority = "High"
        }

        ' Act
        Dim newId = dao.Create(newAnnouncement)
        Dim fetched = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetched)
        Assert.AreEqual(_testAdminId, fetched.AdminID)
        Assert.AreEqual("Library Closing Early", fetched.Title)
        Assert.AreEqual("High", fetched.Priority)
    End Sub

    <TestMethod>
    Public Sub AnnouncementDAO_GetActiveAnnouncements_ShouldReturnCorrectly()
        ' Arrange
        CreateTestAdmin()
        Dim dao As New AnnouncementDAO(_transaction)

        ' 1. Active, not expired
        dao.Create(New Announcement With {.AdminID = _testAdminId, .Title = "Active 1", .Message = "...", .ExpiryDate = DateTime.Now.AddDays(1)})
        ' 2. Active, no expiry
        dao.Create(New Announcement With {.AdminID = _testAdminId, .Title = "Active 2", .Message = "...", .ExpiryDate = Nothing})
        ' 3. Inactive
        dao.Create(New Announcement With {.AdminID = _testAdminId, .Title = "Inactive", .Message = "...", .IsActive = False})
        ' 4. Active, but expired
        dao.Create(New Announcement With {.AdminID = _testAdminId, .Title = "Expired", .Message = "...", .ExpiryDate = DateTime.Now.AddDays(-1)})

        ' Act
        Dim activeList = dao.GetActiveAnnouncements()

        ' Assert
        Assert.IsNotNull(activeList)
        Assert.AreEqual(2, activeList.Count)
        Assert.AreEqual("Active 2", activeList(0).Title) ' Ordered by date DESC
        Assert.AreEqual("Active 1", activeList(1).Title)
    End Sub
End Class
