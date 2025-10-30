Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class AnnouncementModelTests

    <TestMethod>
    Public Sub Announcement_IsValid_ShouldBeTrueForActiveAndNotExpired()
        ' Arrange
        Dim announcement As New Announcement With {
            .IsActive = True,
            .ExpiryDate = DateTime.Now.AddDays(1) ' Expires tomorrow
        }
        ' Act & Assert
        Assert.IsTrue(announcement.IsValid())
    End Sub

    <TestMethod>
    Public Sub Announcement_IsValid_ShouldBeTrueForActiveAndNoExpiry()
        ' Arrange
        Dim announcement As New Announcement With {
            .IsActive = True,
            .ExpiryDate = Nothing
        }
        ' Act & Assert
        Assert.IsTrue(announcement.IsValid())
    End Sub

    <TestMethod>
    Public Sub Announcement_IsValid_ShouldBeFalseForInactive()
        ' Arrange
        Dim announcement As New Announcement With {
            .IsActive = False,
            .ExpiryDate = Nothing
        }
        ' Act & Assert
        Assert.IsFalse(announcement.IsValid())
    End Sub

    <TestMethod>
    Public Sub Announcement_IsValid_ShouldBeFalseForExpired()
        ' Arrange
        Dim announcement As New Announcement With {
            .IsActive = True,
            .ExpiryDate = DateTime.Now.AddDays(-1) ' Expired yesterday
        }
        ' Act & Assert
        Assert.IsFalse(announcement.IsValid())
    End Sub
End Class
