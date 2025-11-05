Imports System.IO
Imports MySql.Data.MySqlClient

Public Class UC_HPS_borrowed_books_tab

    Private ReadOnly connectionString As String =
        "server=localhost;userid=root;password=;database=ooplibrary"

    Private allBorrowedBooks As New List(Of BorrowedBookDetails)

    Private Sub UC_HPS_borrowed_books_tab_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then LoadData()
    End Sub

    ' Load borrowed books from database
    Public Sub LoadData()
        flpBorrowedBooks.Controls.Clear()
        allBorrowedBooks.Clear()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                    SELECT BookTitle, BorrowedDate, DueDate, Status
                    FROM borrowed_books
                    WHERE UserID = @UserID
                    ORDER BY BorrowedDate DESC"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@UserID", If(Program.currentAccount IsNot Nothing, Program.currentAccount.AccountID, 1))

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim book As New BorrowedBookDetails()
                            book.Title = reader("BookTitle").ToString()
                            book.BorrowedDate = If(IsDBNull(reader("BorrowedDate")), Nothing, CType(reader("BorrowedDate"), DateTime?))
                            book.DueDate = If(IsDBNull(reader("DueDate")), Nothing, CType(reader("DueDate"), DateTime?))

                            ' Dynamic status calculation
                            If reader("Status").ToString().ToLower() = "returned" Then
                                book.Status = BorrowedBookStatus.Returned
                            ElseIf book.DueDate.HasValue Then
                                Dim today = DateTime.Now.Date
                                Dim due = book.DueDate.Value.Date

                                If today > due Then
                                    book.Status = BorrowedBookStatus.Overdue
                                ElseIf today = due Then
                                    book.Status = BorrowedBookStatus.DueToday
                                ElseIf (due - today).Days <= 3 Then
                                    book.Status = BorrowedBookStatus.DueSoon
                                Else
                                    book.Status = BorrowedBookStatus.Borrowed
                                End If
                            Else
                                book.Status = BorrowedBookStatus.Borrowed
                            End If

                            allBorrowedBooks.Add(book)
                        End While
                    End Using
                End Using
            End Using

            UpdateDisplay()

        Catch ex As Exception
            MessageBox.Show("Error loading borrowed books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Display cards
    Private Sub UpdateDisplay()
        flpBorrowedBooks.SuspendLayout()
        flpBorrowedBooks.Controls.Clear()

        Dim filteredList As List(Of BorrowedBookDetails) = allBorrowedBooks

        ' Apply filter checkboxes
        Dim showOverdue As Boolean = Guna2CheckBox1.Checked
        Dim showDueSoon As Boolean = Guna2CheckBox2.Checked
        Dim showDueToday As Boolean = Guna2CheckBox3.Checked
        Dim showReturned As Boolean = Guna2CheckBox4.Checked
        Dim showAll = Not (showOverdue Or showDueSoon Or showDueToday Or showReturned)

        If Not showAll Then
            filteredList = allBorrowedBooks.Where(Function(b)
                                                      Return (showOverdue AndAlso b.Status = BorrowedBookStatus.Overdue) Or
                                                             (showDueSoon AndAlso b.Status = BorrowedBookStatus.DueSoon) Or
                                                             (showDueToday AndAlso b.Status = BorrowedBookStatus.DueToday) Or
                                                             (showReturned AndAlso b.Status = BorrowedBookStatus.Returned)
                                                  End Function).ToList()
        End If

        ' Add cards to panel (newest on top)
        For Each book In filteredList
            Dim card As New BorrowedBooksCard()
            card.Width = flpBorrowedBooks.ClientSize.Width - 25
            card.Margin = New Padding(5)

            card.BookTitle = book.Title
            card.BorrowedDate = If(book.BorrowedDate.HasValue, "Borrowed: " & book.BorrowedDate.Value.ToString("MMM dd, yyyy"), "")
            card.DueDate = If(book.DueDate.HasValue, "Due: " & book.DueDate.Value.ToString("MMM dd, yyyy"), "")

            Select Case book.Status
                Case BorrowedBookStatus.Overdue
                    card.SetStatusColor(Color.LightCoral)
                Case BorrowedBookStatus.DueToday
                    card.SetStatusColor(Color.FromArgb(128, 255, 255))
                Case BorrowedBookStatus.DueSoon
                    card.SetStatusColor(Color.FromArgb(255, 255, 128))
                Case BorrowedBookStatus.Returned
                    card.SetStatusColor(Color.FromArgb(128, 255, 128))
                    card.DueDate = "Returned"
                Case Else
                    card.SetStatusColor(Color.White)
            End Select

            ' Insert at top instead of bottom
            flpBorrowedBooks.Controls.Add(card)
            flpBorrowedBooks.Controls.SetChildIndex(card, 0)
        Next


        ' Layout adjustments
        flpBorrowedBooks.AutoScroll = True
        flpBorrowedBooks.FlowDirection = FlowDirection.TopDown
        flpBorrowedBooks.WrapContents = False
        flpBorrowedBooks.ResumeLayout()
    End Sub

    ' Filter checkbox behavior
    Private Sub Filter_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged,
                                                                               Guna2CheckBox2.CheckedChanged,
                                                                               Guna2CheckBox3.CheckedChanged,
                                                                               Guna2CheckBox4.CheckedChanged
        Dim cb As Guna.UI2.WinForms.Guna2CheckBox = DirectCast(sender, Guna.UI2.WinForms.Guna2CheckBox)
        If cb.Checked Then
            For Each ctrl As Control In {Guna2CheckBox1, Guna2CheckBox2, Guna2CheckBox3, Guna2CheckBox4}
                If ctrl IsNot cb Then
                    DirectCast(ctrl, Guna.UI2.WinForms.Guna2CheckBox).Checked = False
                End If
            Next
        End If
        UpdateDisplay()
    End Sub

End Class
