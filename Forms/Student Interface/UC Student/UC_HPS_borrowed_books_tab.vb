Imports System.IO
Imports OOP_Library_System.Models ' <-- This is needed for BorrowedBookDetails

Public Class UC_HPS_borrowed_books_tab

    Private allBorrowedBooks As New List(Of BorrowedBookDetails)

    Private Sub UC_HPS_borrowed_books_tab_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ' When the tab becomes visible, reload the data
        If Me.Visible Then LoadData()
    End Sub

    ' Load borrowed books from database
    Public Sub LoadData()
        flpBorrowedBooks.Controls.Clear()
        allBorrowedBooks.Clear()

        Try
            ' Get the logged-in user's ID
            Dim accountId As Integer = If(Program.currentAccount IsNot Nothing, Program.currentAccount.AccountID, 0)

            ' If for some reason we don't have an account, exit
            If accountId = 0 Then
                MessageBox.Show("Could not find user account. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Fetch all borrowed book records from the service
            allBorrowedBooks = Program.BorrowSvc.GetBorrowedBooksDetails(accountId)

            ' Run the display/filter logic
            UpdateDisplay()

        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display cards
    Private Sub UpdateDisplay()
        flpBorrowedBooks.SuspendLayout()
        flpBorrowedBooks.Controls.Clear()

        ' --- WE NO LONGER RECALCULATE STATUS HERE ---

        ' --- 2. APPLY CORRECTED FILTER LOGIC ---
        Dim showOverdue As Boolean = Guna2CheckBox1.Checked
        Dim showDueSoon As Boolean = Guna2CheckBox2.Checked
        Dim showDueToday As Boolean = Guna2CheckBox3.Checked
        Dim showReturned As Boolean = Guna2CheckBox4.Checked

        Dim today As Date = Date.Today
        Dim anyBoxChecked = (showOverdue Or showDueSoon Or showDueToday Or showReturned)

        Dim filteredList As New List(Of BorrowedBookDetails)()

        If anyBoxChecked Then
            ' Filter the list based on the correct logic
            filteredList = allBorrowedBooks.Where(Function(b)
                                                      ' Get the database status
                                                      Dim isOverdueStatus = (b.Status = OOP_Library_System.Models.BorrowedBookStatus.Overdue)
                                                      Dim isReturnedStatus = (b.Status = OOP_Library_System.Models.BorrowedBookStatus.Returned)

                                                      ' Calculate the date-based status
                                                      ' We must add "AndAlso Not isReturnedStatus" so returned books don't appear in date filters
                                                      Dim isDueToday = (b.DueDate.HasValue AndAlso b.DueDate.Value.Date = today AndAlso Not isReturnedStatus)
                                                      Dim isDueSoon = (b.DueDate.HasValue AndAlso b.DueDate.Value.Date > today AndAlso b.DueDate.Value.Date <= today.AddDays(3) AndAlso Not isReturnedStatus)

                                                      ' Check which filters to show
                                                      Return (showOverdue AndAlso isOverdueStatus) Or
                                                             (showReturned AndAlso isReturnedStatus) Or
                                                             (showDueToday AndAlso isDueToday) Or
                                                             (showDueSoon AndAlso isDueSoon)
                                                  End Function).ToList()
        Else
            ' NO boxes are checked, so filteredList remains empty.
        End If
        ' --- END OF FILTER LOGIC ---


        ' --- 3. DISPLAY THE FILTERED CARDS ---
        For Each book In filteredList
            Dim card As New BorrowedBooksCard()
            card.Width = flpBorrowedBooks.ClientSize.Width - 25
            card.Margin = New Padding(5)

            card.BookTitle = book.Title
            card.BorrowedDate = If(book.BorrowedDate.HasValue, "Borrowed: " & book.BorrowedDate.Value.ToString("MMM dd, yyyy"), "")
            card.DueDate = If(book.DueDate.HasValue, "Due: " & book.DueDate.Value.ToString("MMM dd, yyyy"), "")

            ' --- *** START OF MODIFICATION *** ---
            ' We call the new function on the card and pass it the info it needs
            Dim isOverdue = (book.Status = OOP_Library_System.Models.BorrowedBookStatus.Overdue)
            Dim isReturned = (book.Status = OOP_Library_System.Models.BorrowedBookStatus.Returned)

            ' The card will now calculate its own color
            card.SetDynamicStatus(book.DueDate, isReturned, isOverdue)

            ' The special case for "Returned" text still needs to be here.
            If isReturned Then
                card.DueDate = "Returned"
            End If
            ' --- *** END OF MODIFICATION *** ---

            ' Insert at top instead of bottom
            flpBorrowedBooks.Controls.Add(card)
            flpBorrowedBooks.Controls.SetChildIndex(card, 0)
        Next
        ' --- END OF DISPLAY ---


        ' Layout adjustments
        flpBorrowedBooks.AutoScroll = True
        flpBorrowedBooks.FlowDirection = FlowDirection.TopDown
        flpBorrowedBooks.WrapContents = False
        flpBorrowedBooks.ResumeLayout()
    End Sub

    ' This event handler is correct and allows multiple selections.
    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged,
                                                                         Guna2CheckBox2.CheckedChanged,
                                                                         Guna2CheckBox3.CheckedChanged,
                                                                         Guna2CheckBox4.CheckedChanged
        ' Just call UpdateDisplay.
        UpdateDisplay()
    End Sub

End Class