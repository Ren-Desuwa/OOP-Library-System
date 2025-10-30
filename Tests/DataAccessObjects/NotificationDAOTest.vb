Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class NotificationDAOTests
    Inherits BaseDAOTest

    Private _testAccountId As Integer

    Private Sub CreateTestAccount()
        Dim accountDao As New AccountDAO(_transaction)
        _testAccountId = accountDao.Create(New Account With {
            .Username = "notify_user",
            .Name = "Notify User",
            .Email = "notify@example.com",
            .PasswordHash = "hash",
            .Role = "Member"
        })
    End Sub

    <TestMethod>
    Public Sub NotificationDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        CreateTestAccount()
        Dim dao As New NotificationDAO(_transaction)
        Dim newNotification As New Notification With {
            .AccountID = _testAccountId,
            .Message = "Test message",
            .NotificationType = NotificationType.SystemNotice,
            .IsRead = False
        }

        ' Act
        Dim newId = dao.Create(newNotification)
        Dim fetchedNotification = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedNotification)
        Assert.AreEqual(_testAccountId, fetchedNotification.AccountID)
        Assert.AreEqual("Test message", fetchedNotification.Message)
        Assert.AreEqual(NotificationType.SystemNotice, fetchedNotification.NotificationType)
        Assert.IsFalse(fetchedNotification.IsRead)
    End Sub

    <TestMethod>
    Public Sub NotificationDAO_GetByAccountId_ShouldReturnOnlyUnread()
        ' Arrange
        CreateTestAccount()
        Dim dao As New NotificationDAO(_transaction)

        dao.Create(New Notification With {.AccountID = _testAccountId, .Message = "Unread 1", .IsRead = False, .NotificationType = NotificationType.FineNotice})
        dao.Create(New Notification With {.AccountID = _testAccountId, .Message = "Read 1", .IsRead = True, .NotificationType = NotificationType.AdminNotice})
        dao.Create(New Notification With {.AccountID = _testAccountId, .Message = "Unread 2", .IsRead = False, .NotificationType = NotificationType.SystemNotice})

        ' Act
        Dim allNotifications = dao.GetByAccountId(_testAccountId, False)
        Dim unreadNotifications = dao.GetByAccountId(_testAccountId, True)

        ' Assert
        Assert.AreEqual(3, allNotifications.Count)
        Assert.AreEqual(2, unreadNotifications.Count)
        Assert.AreEqual("Unread 2", unreadNotifications(0).Message) ' Ordered by date DESC
        Assert.AreEqual("Unread 1", unreadNotifications(1).Message)
    End Sub
End Class
