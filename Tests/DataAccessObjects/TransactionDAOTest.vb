Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.DataAccessObjects
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class TransactionDAOTests
    Inherits BaseDAOTest

    Private _testAccountId As Integer
    Private _testCopyId As Integer

    ' Helper to create all dependencies
    Private Sub CreateTestPrerequisites()
        ' 1. Create Account
        Dim accountDao As New AccountDAO(_transaction)
        _testAccountId = accountDao.Create(New Account With {
            .Username = "tx_user",
            .Name = "Transaction User",
            .Email = "tx@example.com",
            .PasswordHash = "hash",
            .Role = "Member"
        })

        ' 2. Create Book
        Dim bookDao As New BookDAO(_transaction)
        Dim bookId = bookDao.Create(New Book With {
            .Title = "Tx Book",
            .Author = "Tx Author",
            .ISBN = "tx123",
            .YearPublished = 2000
        })

        ' 3. Create Copy
        Dim copyDao As New BookCopyDAO(_transaction)
        _testCopyId = copyDao.Create(New BookCopy With {
            .BookID = bookId,
            .Status = "Available"
        })
    End Sub

    <TestMethod>
    Public Sub TransactionDAO_CreateAndGetById_ShouldWork()
        ' Arrange
        CreateTestPrerequisites()
        Dim dao As New TransactionDAO(_transaction)
        Dim borrowDate = DateTime.Now.AddDays(-10)
        Dim dueDate = borrowDate.AddDays(14)

        Dim newTx As New Transaction With {
            .AccountID = _testAccountId,
            .CopyID = _testCopyId,
            .TransactionType = "Borrow",
            .DateBorrowed = borrowDate,
            .DateDue = dueDate,
            .Fine = 0,
            .Status = "Active"
        }

        ' Act
        Dim newId As Integer = dao.Create(newTx)
        Dim fetchedTx = dao.GetById(newId)

        ' Assert
        Assert.IsNotNull(fetchedTx)
        Assert.AreEqual(_testAccountId, fetchedTx.AccountID)
        Assert.AreEqual(_testCopyId, fetchedTx.CopyID)
        Assert.AreEqual("Borrow", fetchedTx.TransactionType)
        Assert.AreEqual("Active", fetchedTx.Status)
    End Sub

    <TestMethod>
    Public Sub TransactionDAO_GetOverdueTransactions_ShouldReturnOnlyOverdue()
        ' Arrange
        CreateTestPrerequisites()
        Dim dao As New TransactionDAO(_transaction)

        ' Create one overdue tx
        dao.Create(New Transaction With {
            .AccountID = _testAccountId,
            .CopyID = _testCopyId,
            .TransactionType = "Borrow",
            .DateDue = DateTime.Now.AddDays(-2),
            .Status = "Overdue"
        })

        ' Create one active (not overdue) tx
        dao.Create(New Transaction With {
            .AccountID = _testAccountId,
            .CopyID = _testCopyId,
            .TransactionType = "Borrow",
            .DateDue = DateTime.Now.AddDays(10),
            .Status = "Active"
        })

        ' Act
        Dim overdueList = dao.GetOverdueTransactions()

        ' Assert
        Assert.IsNotNull(overdueList)
        Assert.AreEqual(1, overdueList.Count)
        Assert.AreEqual("Overdue", overdueList(0).Status)
    End Sub
End Class
