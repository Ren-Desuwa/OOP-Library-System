Imports MySql.Data.MySqlClient
Imports System.IO

Public Class BorrowedBooks

    Private ReadOnly connectionString As String =
        "server=localhost;userid=root;password=;database=ooplibrary"

    Private Sub BorrowedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBorrowedBooks()
    End Sub

    ' 🔹 Public para puwedeng i-access ng ibang forms
    Public Sub LoadBorrowedBooks()
        flpBorrowedBooks.Controls.Clear()

        Try
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String =
                    "SELECT BookTitle, BorrowedDate, DueDate, BookCover, Status
                     FROM borrowed_books
                     ORDER BY BorrowedDate DESC"

                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim card As New BorrowedBooksCard()
                            card.BookTitle = reader("BookTitle").ToString()
                            card.BorrowedDate = Convert.ToDateTime(reader("BorrowedDate")).ToString("MMM dd, yyyy")
                            card.DueDate = Convert.ToDateTime(reader("DueDate")).ToString("MMM dd, yyyy")

                            Select Case reader("Status").ToString().ToLower()
                                Case "overdue"
                                    card.SetStatusColor(Color.Red)
                                Case "due soon"
                                    card.SetStatusColor(Color.Yellow)
                                Case "due today"
                                    card.SetStatusColor(Color.Blue)
                                Case "returned"
                                    card.SetStatusColor(Color.Green)
                            End Select


                            ' ➕ Add to FlowLayoutPanel
                            flpBorrowedBooks.Controls.Add(card)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(
                "Error loading borrowed books:" & vbCrLf & ex.Message,
                "Database Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error)
        End Try
    End Sub

End Class
