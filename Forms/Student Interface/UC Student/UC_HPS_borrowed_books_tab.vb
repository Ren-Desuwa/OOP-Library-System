Imports System.IO

Public Class UC_HPS_borrowed_books_tab

    ' This list will hold all borrowed books from the database
    Private allBorrowedBooks As New List(Of BorrowedBookDetails)

    ' This event fires every time the tab becomes visible
    Private Sub UC_HPS_borrowed_books_tab_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' When the tab is shown, reload the data from the database
        If Me.Visible Then
            LoadData()
        End If
    End Sub

    ' This method calls the service and populates the list
    Private Sub LoadData()
        flpBorrowedBooks.Controls.Clear()

        Try
            ' Get the logged-in user's ID from Program.vb
            If Program.currentAccount Is Nothing Then
                ' This should not happen, but as a safeguard:
                MessageBox.Show("Could not identify logged-in user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim currentUserId = Program.currentAccount.AccountID

            ' Fetch the real data from the service
            allBorrowedBooks = Program.BorrowSvc.GetBorrowedBooksDetails(currentUserId)

            ' Display the filtered results
            UpdateDisplay()

        Catch ex As Exception
            MessageBox.Show("Failed to load borrowed books: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' This method filters and displays the books based on the checkboxes
    Private Sub UpdateDisplay()
        flpBorrowedBooks.SuspendLayout()
        flpBorrowedBooks.Controls.Clear()

        Dim filteredList As New List(Of BorrowedBookDetails)

        ' Check which filters are active
        Dim showOverdue As Boolean = Guna2CheckBox1.Checked
        Dim showDueSoon As Boolean = Guna2CheckBox2.Checked
        Dim showDueToday As Boolean = Guna2CheckBox3.Checked
        Dim showReturned As Boolean = Guna2CheckBox4.Checked

        ' If no checkboxes are ticked, show everything
        Dim showAll = Not (showOverdue Or showDueSoon Or showDueToday Or showReturned)

        If showAll Then
            filteredList = allBorrowedBooks
        Else
            ' Apply filters
            filteredList = allBorrowedBooks.Where(Function(b)
            Return (showOverdue AndAlso b.Status = BorrowedBookStatus.Overdue) Or
                    (showDueSoon AndAlso b.Status = BorrowedBookStatus.DueSoon) Or
                    (showDueToday AndAlso b.Status = BorrowedBookStatus.DueToday) Or
                    (showReturned AndAlso b.Status = BorrowedBookStatus.Returned)
                                                  End Function).ToList()
        End If

        ' Create and add the cards
        For Each book In filteredList
            Dim card As New BorrowedBooksCard()
            card.BookTitle = book.Title
            card.BorrowedDate = If(book.BorrowedDate.HasValue, "Borrowed: " & book.BorrowedDate.Value.ToString("MMM dd, yyyy"), "")
            card.DueDate = If(book.DueDate.HasValue, "Due: " & book.DueDate.Value.ToString("MMM dd, yyyy"), "")

            ' Set the card color based on status
            Select Case book.Status
                Case BorrowedBookStatus.Overdue
                    card.SetCardColor(Color.LightCoral)
                Case BorrowedBookStatus.DueToday
                    card.SetCardColor(Color.FromArgb(128, 255, 255))
                Case BorrowedBookStatus.DueSoon
                    card.SetCardColor(Color.FromArgb(255, 255, 128))
                Case BorrowedBookStatus.Returned
                    card.SetCardColor(Color.FromArgb(128, 255, 128))
                    card.DueDate = "Returned"
                Case Else ' Borrowed
                    card.SetCardColor(Color.White)
            End Select

            ' Load the cover image
            Dim coverPath = book.GetCoverPath()
            If File.Exists(coverPath) Then
                card.BookCover = Image.FromFile(coverPath)
            End If

            flpBorrowedBooks.Controls.Add(card)
        Next

        flpBorrowedBooks.ResumeLayout()
    End Sub

    ' This single event handler is called by ALL checkboxes
    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged,
                                                                               Guna2CheckBox2.CheckedChanged,
                                                                               Guna2CheckBox3.CheckedChanged,
                                                                               Guna2CheckBox4.CheckedChanged
        UpdateDisplay()
    End Sub

End Class