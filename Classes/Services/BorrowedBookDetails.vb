Imports OOP_Library_System.Models ' <-- Ensures Transaction and Book are found
Imports System.IO

' --- WRAP THE ENTIRE FILE IN THE "Models" NAMESPACE ---
Namespace Models
    ' This enum will help us filter and set colors in the UI
    Public Enum BorrowedBookStatus
        Borrowed
        DueSoon
        DueToday
        Overdue
        Returned
    End Enum

    Public Class BorrowedBookDetails

        Public Property Title As String
        Public Property CoverUrl As String
        Public Property BorrowedDate As DateTime?
        Public Property DueDate As DateTime?
        Public Property Status As BorrowedBookStatus
        Public Property Transaction As Transaction
        Public Property Book As Book
        Public Property TransactionID As Integer
        Public Property BorrowerName As String

        ' This constructor does all the hard work of combining the data
        Public Sub New(tx As Transaction, book As Book)
            Me.Transaction = tx
            Me.Book = book
            Me.BorrowedDate = tx.DateBorrowed
            Me.DueDate = tx.DateDue
            Me.TransactionID = tx.TransactionID
            ' 1. Set Title and Cover
            If book IsNot Nothing Then
                Me.Title = book.Title
                Me.CoverUrl = book.GetCoverFileName() ' Use the helper from Book.vb
            Else
                Me.Title = "Book Not Found"
                Me.CoverUrl = "default_cover.png"
            End If

            ' 2. Determine the Status Enum from the transaction's string
            Select Case tx.Status.ToLower()
                Case "returned"
                    Me.Status = BorrowedBookStatus.Returned
                Case "overdue"
                    Me.Status = BorrowedBookStatus.Overdue
                Case "borrowed"
                    ' Check if it's DueToday or DueSoon
                    If Me.DueDate.HasValue Then
                        If Me.DueDate.Value.Date = Date.Today Then
                            Me.Status = BorrowedBookStatus.DueToday
                        ElseIf (Me.DueDate.Value.Date - Date.Today).TotalDays <= 3 Then
                            Me.Status = BorrowedBookStatus.DueSoon
                        Else
                            Me.Status = BorrowedBookStatus.Borrowed
                        End If
                    Else
                        Me.Status = BorrowedBookStatus.Borrowed
                    End If
                Case Else
                    Me.Status = BorrowedBookStatus.Borrowed
            End Select
        End Sub


        Public Sub New()
        End Sub

        ''' <summary>
        ''' Helper function to get the full path of the cover image.
        ''' </summary>
        Public Function GetCoverPath() As String
            Return Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", Me.CoverUrl)
        End Function
    End Class
End Namespace ' --- END OF NAMESPACE ---