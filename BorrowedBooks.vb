Public Class BorrowedBooks
    Friend Sub ShowDialog()
        Throw New NotImplementedException()
    End Sub

    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub

    Private Sub LoadBorrowedBooks()
        ' Halimbawa, static data lang muna
        Dim sampleBooks As New List(Of (title As String, borrowDate As String, dueDate As String)) From {
            ("Harry Potter", "Oct 1, 2025", "Oct 15, 2025"),
            ("The Hobbit", "Oct 5, 2025", "Oct 25, 2025"),
            ("Noli Me Tangere", "Sep 20, 2025", "Returned")
        }

        flpBorrowedBooks.Controls.Clear()

        For Each book In sampleBooks
            Dim card As New BorrowedBooksCard()
            card.BookTitle = book.title
            card.BorrowedDate = book.borrowDate
            card.DueDate = book.dueDate

            ' Optional: lagyan ng kulay depende sa status
            If book.dueDate = "Returned" Then
                card.BackColor = Color.FromArgb(200, 255, 200)
            End If

            flpBorrowedBooks.Controls.Add(card)
        Next
    End Sub

End Class
