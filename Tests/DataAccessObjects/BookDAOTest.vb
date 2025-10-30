Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class BookDAOTests
    Inherits BaseDAOTest

    <TestMethod>
    Public Sub BookDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        Dim dao As New BookDAO(_transaction)
        Dim newBook As New Book With {
            .Title = "1984",
            .Author = "George Orwell",
            .Genre = "Dystopian",
            .ISBN = "9780451524935",
            .Publisher = "Signet Classic",
            .YearPublished = 1949,
            .Description = "A classic novel."
        }

        ' Act
        Dim newId As Integer = dao.Create(newBook)
        Dim fetchedBook As Book = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedBook)
        Assert.AreEqual("1984", fetchedBook.Title)
        Assert.AreEqual("George Orwell", fetchedBook.Author)
        Assert.AreEqual("9780451524935", fetchedBook.ISBN)
    End Sub

    <TestMethod>
    Public Sub BookDAO_Update_ShouldChangeData()
        ' Arrange
        Dim dao As New BookDAO(_transaction)
        Dim newBook As New Book With {
            .Title = "Original Title",
            .Author = "Original Author",
            .ISBN = "1234567890123",
            .YearPublished = 2000
        }
        Dim newId As Integer = dao.Create(newBook)

        Dim bookToUpdate = dao.GetById(newId)
        bookToUpdate.Title = "Updated Title"
        bookToUpdate.Author = "Updated Author"

        ' Act
        dao.Update(bookToUpdate)
        Dim fetchedBook As Book = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedBook)
        Assert.AreEqual("Updated Title", fetchedBook.Title)
        Assert.AreEqual("Updated Author", fetchedBook.Author)
    End Sub

    <TestMethod>
    Public Sub BookDAO_GetByAuthor_ShouldReturnMatchingBooks()
        ' Arrange
        Dim dao As New BookDAO(_transaction)
        dao.Create(New Book With {.Title = "Book 1", .Author = "John Doe", .ISBN = "111", .YearPublished = 2001})
        dao.Create(New Book With {.Title = "Book 2", .Author = "Jane Smith", .ISBN = "222", .YearPublished = 2002})
        dao.Create(New Book With {.Title = "Book 3", .Author = "John Doe", .ISBN = "333", .YearPublished = 2003})

        ' Act
        Dim johnDoeBooks = dao.GetByAuthor("John Doe")
        Dim janeSmithBooks = dao.GetByAuthor("Smith") ' Test partial match
        Dim noBooks = dao.GetByAuthor("Nobody")

        ' Assert
        Assert.AreEqual(2, johnDoeBooks.Count)
        Assert.AreEqual("Book 1", johnDoeBooks(0).Title)
        Assert.AreEqual("Book 3", johnDoeBooks(1).Title)
        Assert.AreEqual(1, janeSmithBooks.Count)
        Assert.AreEqual("Book 2", janeSmithBooks(0).Title)
        Assert.AreEqual(0, noBooks.Count)
    End Sub

    <TestMethod>
    Public Sub BookDAO_GetById_ShouldCalculateCopies()
        ' Arrange
        Dim bookDao As New BookDAO(_transaction)
        Dim copyDao As New BookCopyDAO(_transaction)

        ' 1. Create the main book record
        Dim newBook As New Book With {.Title = "Copy Test Book", .Author = "Author", .ISBN = "555", .YearPublished = 2020}
        Dim bookId As Integer = bookDao.Create(newBook)

        ' 2. Create copies for this book
        copyDao.Create(New BookCopy With {.BookID = bookId, .Status = "Available"})
        copyDao.Create(New BookCopy With {.BookID = bookId, .Status = "Available"})
        copyDao.Create(New BookCopy With {.BookID = bookId, .Status = "Borrowed"})

        ' Act
        ' Re-fetch the book to check calculated fields
        Dim fetchedBook As Book = bookDao.GetById(bookId)

        ' Assert
        Assert.IsNotNull(fetchedBook)
        Assert.AreEqual(3, fetchedBook.TotalCopies, "TotalCopies should be 3")
        Assert.AreEqual(2, fetchedBook.AvailableCopies, "AvailableCopies should be 2")
    End Sub
End Class
