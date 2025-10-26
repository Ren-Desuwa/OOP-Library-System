Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class AccountModelTests

    <TestMethod>
    Public Sub Account_HashPassword_ShouldBeConsistent()
        ' Arrange
        Dim password As String = "myPa$$word123"

        ' Act
        ' This call is correct because there is no variable named "Account"
        Dim hash1 As String = Account.HashPassword(password)
        Dim hash2 As String = Account.HashPassword(password)

        ' Assert
        Assert.IsNotNull(hash1)
        Assert.AreEqual(64, hash1.Length, "Hash should be SHA256 length (64 chars)")
        Assert.AreEqual(hash1, hash2, "Hashing the same password should produce the same hash")
    End Sub

    <TestMethod>
    Public Sub Account_VerifyPassword_ShouldReturnTrueForCorrectPassword()
        ' Arrange
        Dim password As String = "myCorrectPa$$word"
        ' This call is now correct
        Dim hash As String = Account.HashPassword(password)

        ' Renamed variable from "account" to "testAccount"
        Dim testAccount As New Account()
        testAccount.PasswordHash = hash

        ' Act
        Dim result As Boolean = testAccount.VerifyPassword(password)

        ' Assert
        Assert.IsTrue(result)
    End Sub

    <TestMethod>
    Public Sub Account_VerifyPassword_ShouldReturnFalseForWrongPassword()
        ' Arrange
        Dim correctPassword As String = "myCorrectPa$$word"
        Dim wrongPassword As String = "myWRONGpa$$word"
        ' This call is now correct
        Dim hash As String = Account.HashPassword(correctPassword)

        ' Renamed variable from "account" to "testAccount"
        Dim testAccount As New Account()
        testAccount.PasswordHash = hash

        ' Act
        Dim result As Boolean = testAccount.VerifyPassword(wrongPassword)

        ' Assert
        Assert.IsFalse(result)
    End Sub

    <TestMethod>
    Public Sub Account_IsAdmin_ShouldBeCaseInsensitive()
        ' Arrange
        Dim adminAccount As New Account With {.Role = "Admin"}
        Dim adminAccountLower As New Account With {.Role = "admin"}
        Dim memberAccount As New Account With {.Role = "Member"}

        ' Act
        Dim isAdmin1 As Boolean = adminAccount.IsAdmin()
        Dim isAdmin2 As Boolean = adminAccountLower.IsAdmin()
        Dim isMemberAdmin As Boolean = memberAccount.IsAdmin()

        ' Assert
        Assert.IsTrue(isAdmin1)
        Assert.IsTrue(isAdmin2)
        Assert.IsFalse(isMemberAdmin)
    End Sub
End Class

