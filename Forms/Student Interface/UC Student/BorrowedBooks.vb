Imports System.IO
' Imports MySql.Data.MySqlClient <-- REMOVED

Public Class BorrowedBooks

    ' Private ReadOnly connectionString As String = ... <-- REMOVED

    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub

    ' 🔹 Public para puwedeng i-access ng ibang forms
    Public Sub LoadBorrowedBooks()
        flpBorrowedBooks.Controls.Clear()

        Try
            ' --- MODIFIED LOGIC: Call the Service Layer ---
            Dim accountId As Integer = If(Program.currentAccount IsNot Nothing, Program.currentAccount.AccountID, 1)
            Dim detailsList As List(Of BorrowedBookDetails) = Program.BorrowSvc.GetBorrowedBooksDetails(accountId)

            For Each bookDetails In detailsList
                Dim card As New BorrowedBooksCard()

                card.BookTitle = bookDetails.Title
                card.BorrowedDate = If(bookDetails.BorrowedDate.HasValue, bookDetails.BorrowedDate.Value.ToString("MMM dd, yyyy"), "N/A")
                card.DueDate = If(bookDetails.DueDate.HasValue, bookDetails.DueDate.Value.ToString("MMM dd, yyyy"), "N/A")

                ' Set status color based on DTO (BorrowedBookDetails)
                Select Case bookDetails.Status
                    Case BorrowedBookStatus.Overdue
                        card.SetStatusColor(Color.Red)
                    Case BorrowedBookStatus.DueSoon
                        card.SetStatusColor(Color.Yellow)
                    Case BorrowedBookStatus.DueToday
                        card.SetStatusColor(Color.Blue)
                    Case BorrowedBookStatus.Returned
                        card.SetStatusColor(Color.Green)
                    Case Else
                        card.SetStatusColor(Color.Gray) ' Default/Borrowed
                End Select

                ' ➕ Add to FlowLayoutPanel
                flpBorrowedBooks.Controls.Add(card)
            Next
            ' --- END OF MODIFIED LOGIC ---

        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books:" & vbCrLf & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class