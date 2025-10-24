Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class BookModelTests

    <TestMethod>
    Public Sub Book_GetFullTitle_ShouldFormatCorrectly()
        ' Arrange
        Dim book As New Book With {
            .Title = "The Great Gatsby",
            .Author = "F. Scott Fitzgerald",
            .YearPublished = 1925
        }

        ' Act
        Dim fullTitle As String = book.GetFullTitle()

        ' Assert
        Assert.AreEqual("The Great Gatsby by F. Scott Fitzgerald (1925)", fullTitle)
    End Sub

    <TestMethod>
    Public Sub Book_IsAvailable_ShouldReturnTrueWhenCopiesAvailable()
        ' Arrange
        Dim book As New Book With {
            .AvailableCopies = 5
        }

        ' Act
        Dim isAvailable As Boolean = book.IsAvailable()

        ' Assert
        Assert.IsTrue(isAvailable)
    End Sub

    <TestMethod>
    Public Sub Book_IsAvailable_ShouldReturnFalseWhenNoCopiesAvailable()
        ' Arrange
        Dim book As New Book With {
            .AvailableCopies = 0
        }

        ' Act
        Dim isAvailable As Boolean = book.IsAvailable()

        ' Assert
        Assert.IsFalse(isAvailable)
    End Sub

End Class
