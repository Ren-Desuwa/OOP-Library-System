Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class BookCopyDAOTests
    Inherits BaseDAOTest

    Private _testBookId As Integer

    ' Helper to create a book to satisfy foreign key
    Private Sub CreateTestBook()
        Dim bookDao As New BookDAO(_transaction)
        _testBookId = bookDao.Create(New Book With {
            .Title = "Book for Copies",
            .Author = "Test Author",
            .ISBN = "123456789",
            .YearPublished = 2000
        })
    End Sub

    <TestMethod>
    Public Sub BookCopyDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        CreateTestBook() ' Create the parent book
        Dim dao As New BookCopyDAO(_transaction)
        Dim newCopy As New BookCopy With {
            .BookID = _testBookId,
            .Condition = "Good",
            .Status = "Available",
            .ShelfLocation = "A-1"
        }

        ' Act
        Dim newId As Integer = dao.Create(newCopy)
        Dim fetchedCopy As BookCopy = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedCopy)
        Assert.AreEqual(_testBookId, fetchedCopy.BookID)
        Assert.AreEqual("A-1", fetchedCopy.ShelfLocation)
        Assert.AreEqual("Available", fetchedCopy.Status)
    End Sub

    <TestMethod>
    Public Sub BookCopyDAO_GetCopiesByBookId_ShouldReturnAllCopies()
        ' Arrange
        CreateTestBook()
        Dim dao As New BookCopyDAO(_transaction)
        dao.Create(New BookCopy With {.BookID = _testBookId, .Status = "Available", .ShelfLocation = "A-1"})
        dao.Create(New BookCopy With {.BookID = _testBookId, .Status = "Borrowed", .ShelfLocation = "A-2"})

        ' Create another book and its copy, to make sure we don't fetch these
        Dim bookDao As New BookDAO(_transaction)
        Dim otherBookId = bookDao.Create(New Book With {.Title = "Other", .Author = "Other", .ISBN = "987", .YearPublished = 2001})
        dao.Create(New BookCopy With {.BookID = otherBookId, .Status = "Available"})

        ' Act
        Dim copies = dao.GetCopiesByBookId(_testBookId)

        ' Assert
        Assert.IsNotNull(copies)
        Assert.AreEqual(2, copies.Count, "Should only find copies for the specified book ID")
        Assert.AreEqual("A-1", copies(0).ShelfLocation)
        Assert.AreEqual("A-2", copies(1).ShelfLocation)
    End Sub
End Class
