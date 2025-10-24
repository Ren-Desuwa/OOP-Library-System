Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class TransactionModelTests

    <TestMethod>
    Public Sub Transaction_CalculateDueDate_ShouldBe14Days()
        ' Arrange
        Dim tx As New Transaction()
        Dim borrowDate As New DateTime(2023, 1, 1)
        tx.DateBorrowed = borrowDate

        ' Act
        Dim dueDate = tx.CalculateDueDate()

        ' Assert
        Dim expectedDate = borrowDate.AddDays(14)
        Assert.AreEqual(expectedDate, dueDate)
    End Sub

    <TestMethod>
    Public Sub Transaction_IsOverdue_ShouldBeTrueIfPastDueAndNotReturned()
        ' Arrange
        Dim tx As New Transaction With {
            .DateDue = DateTime.Now.AddDays(-1), ' Due yesterday
            .DateReturned = Nothing
        }
        ' Act & Assert
        Assert.IsTrue(tx.IsOverdue())
    End Sub

    <TestMethod>
    Public Sub Transaction_IsOverdue_ShouldBeFalseIfReturned()
        ' Arrange
        Dim tx As New Transaction With {
            .DateDue = DateTime.Now.AddDays(-10), ' Due 10 days ago
            .DateReturned = DateTime.Now.AddDays(-1) ' Returned yesterday
        }
        ' Act & Assert
        Assert.IsFalse(tx.IsOverdue())
    End Sub

    <TestMethod>
    Public Sub Transaction_IsOverdue_ShouldBeFalseIfNotDueYet()
        ' Arrange
        Dim tx As New Transaction With {
            .DateDue = DateTime.Now.AddDays(1), ' Due tomorrow
            .DateReturned = Nothing
        }
        ' Act & Assert
        Assert.IsFalse(tx.IsOverdue())
    End Sub

    <TestMethod>
    Public Sub Transaction_CalculateFine_ShouldBeZeroIfNotOverdue()
        ' Arrange
        Dim tx As New Transaction With {
            .DateDue = DateTime.Now.AddDays(1) ' Not overdue
        }
        ' Act
        Dim fine = tx.CalculateFine()
        ' Assert
        Assert.AreEqual(0D, fine)
    End Sub

    <TestMethod>
    Public Sub Transaction_CalculateFine_ShouldBeCorrectAmountWhenOverdue()
        ' Arrange
        Dim tx As New Transaction With {
            .DateDue = DateTime.Now.AddDays(-5) ' 5 days overdue
        }
        ' Act
        Dim fine = tx.CalculateFine()
        ' Assert
        Assert.AreEqual(5D, fine, "Fine should be $1 per day overdue")
    End Sub
End Class
