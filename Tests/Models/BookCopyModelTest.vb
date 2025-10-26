Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class BookCopyModelTests

    <TestMethod>
    Public Sub BookCopy_CanBeBorrowed_ShouldReturnTrueForAvailable()
        ' Arrange
        Dim copy As New BookCopy With {.Status = "Available"}
        ' Act
        ' Assert
        Assert.IsTrue(copy.CanBeBorrowed())
    End Sub

    <TestMethod>
    Public Sub BookCopy_CanBeBorrowed_ShouldReturnTrueForReserved()
        ' Arrange
        Dim copy As New BookCopy With {.Status = "Reserved"}
        ' Act
        ' Assert
        Assert.IsTrue(copy.CanBeBorrowed())
    End Sub

    <TestMethod>
    Public Sub BookCopy_CanBeBorrowed_ShouldReturnFalseForBorrowed()
        ' Arrange
        Dim copy As New BookCopy With {.Status = "Borrowed"}
        ' Act
        ' Assert
        Assert.IsFalse(copy.CanBeBorrowed())
    End Sub

    <TestMethod>
    Public Sub BookCopy_CanBeBorrowed_ShouldReturnFalseForMaintenance()
        ' Arrange
        Dim copy As New BookCopy With {.Status = "Maintenance"}
        ' Act
        ' Assert
        Assert.IsFalse(copy.CanBeBorrowed())
    End Sub

    <TestMethod>
    Public Sub BookCopy_UpdateStatus_ShouldChangeStatusAndDate()
        ' Arrange
        Dim copy As New BookCopy()
        copy.LastUpdated = DateTime.Now.AddDays(-1) ' Set date in the past
        Dim oldDate = copy.LastUpdated
        copy.Status = "Available"

        ' Act
        copy.UpdateStatus("Borrowed")

        ' Assert
        Assert.AreEqual("Borrowed", copy.Status)
        Assert.AreNotEqual(oldDate, copy.LastUpdated, "LastUpdated date should have changed")
        Assert.IsTrue(copy.LastUpdated > oldDate)
    End Sub

End Class
