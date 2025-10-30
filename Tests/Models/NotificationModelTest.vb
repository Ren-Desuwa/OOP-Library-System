Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class NotificationModelTests

    <TestMethod>
    Public Sub Notification_MarkAsRead_ShouldSetIsReadToTrue()
        ' Arrange
        Dim notification As New Notification With {
            .IsRead = False
        }
        ' Act
        notification.MarkAsRead()
        ' Assert
        Assert.IsTrue(notification.IsRead)
    End Sub

    <TestMethod>
    Public Sub Notification_CreateDueReminder_ShouldSetCorrectProperties()
        ' Arrange
        Dim accountId = 1
        Dim transactionId = 5
        Dim dueDate = New DateTime(2023, 12, 25)

        ' Act
        ' Assuming you fixed the model as suggested
        ' to use the Enum, not a string
        Dim notifications = Notification.CreateDueReminder(accountId, transactionId, dueDate)

        ' Assert
        Assert.AreEqual(accountId, notifications.AccountID)
        Assert.AreEqual(transactionId, notifications.TransactionID)
        Assert.AreEqual(NotificationType.BookReminder, notifications.NotificationType)
        Assert.AreEqual("Reminder: Your book is due on Dec 25, 2023", notifications.Message)
        Assert.IsFalse(notifications.IsRead)
    End Sub
End Class
