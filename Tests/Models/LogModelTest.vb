Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports LibrarySystem.Classes.Models

<TestClass>
Public Class LogModelTests

    <TestMethod>
    Public Sub Log_RecordAction_ShouldPopulateProperties()
        ' Arrange
        Dim accountId As Integer = 123
        Dim action As String = "Test Action"
        Dim details As String = "Some details"

        ' Act
        Dim logEntry = Log.RecordAction(accountId, action, details, "Warning")

        ' Assert
        Assert.AreEqual(accountId, logEntry.AccountID)
        Assert.AreEqual(action, logEntry.Action)
        Assert.AreEqual(details, logEntry.Details)
        Assert.AreEqual("Warning", logEntry.Severity)
        Assert.IsTrue(logEntry.Timestamp <= DateTime.Now AndAlso logEntry.Timestamp > DateTime.Now.AddSeconds(-5))
    End Sub

    <TestMethod>
    Public Sub Log_RecordAction_ShouldHandleNullAccountId()
        ' Arrange
        Dim action As String = "System Action"
        Dim details As String = "System details"

        ' Act
        Dim logEntry = Log.RecordAction(Nothing, action, details, "Error")

        ' Assert
        Assert.IsNull(logEntry.AccountID)
        Assert.AreEqual(action, logEntry.Action)
        Assert.AreEqual("Error", logEntry.Severity)
    End Sub

    <TestMethod>
    Public Sub Log_New_ShouldDefaultSeverityToInfo()
        ' Arrange
        Dim logEntry As New Log()
        ' Act & Assert
        Assert.AreEqual("Info", logEntry.Severity)
    End Sub
End Class
