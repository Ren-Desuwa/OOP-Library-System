Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class BeforeApproval


    ' --- NEW PROPERTIES & EVENT ---
    Public Property BooksToBorrow As List(Of Book)
    Public Property StudentUsername As String
    Public Event BorrowingConfirmed()
    ' ------------------------------

    Private connectionString As String =
        "server=localhost;userid=root;password=;database=ooplibrary"

    Private Sub BeforeApproval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set date and time
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm tt")

        ' Show book titles in the label
        If BooksToBorrow IsNot Nothing AndAlso BooksToBorrow.Count > 0 Then
            lblBookNames.Text = String.Join(", ", BooksToBorrow.Select(Function(b) b.Title))
        Else
            lblBookNames.Text = "No books selected"
        End If

        ' Show student username
        lblUsername.Text = StudentUsername
    End Sub

    ' ✅ Confirm Borrow button
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Try
            ' Ensure there are books to borrow
            If BooksToBorrow Is Nothing OrElse BooksToBorrow.Count = 0 Then
                MessageBox.Show("No books selected to borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                For Each book As Book In BooksToBorrow
                    Using cmd As New MySqlCommand("
                        INSERT INTO borrowed_books
                        (UserID, BookTitle, BorrowedDate, DueDate, Status)
                        VALUES (@UserID, @BookTitle, @BorrowedDate, @DueDate, @Status)", conn)

                        ' Use actual logged-in user ID
                        cmd.Parameters.AddWithValue("@UserID", Program.currentAccount.AccountID)
                        cmd.Parameters.AddWithValue("@BookTitle", book.Title)
                        cmd.Parameters.AddWithValue("@BorrowedDate", DateTime.Now)
                        cmd.Parameters.AddWithValue("@DueDate", DateTime.Now.AddDays(7)) ' 7 days due
                        cmd.Parameters.AddWithValue("@Status", "Borrowed")

                        cmd.ExecuteNonQuery()
                    End Using
                Next
            End Using

            MessageBox.Show("Books successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh BorrowedBooks form if open
            Dim bbForm As BorrowedBooks = Application.OpenForms.OfType(Of BorrowedBooks)().FirstOrDefault()
            If bbForm Is Nothing Then
                bbForm = New BorrowedBooks()
                bbForm.Show()
            End If
            bbForm.LoadBorrowedBooks()

            ' Notify ViewCart to remove borrowed items
            RaiseEvent BorrowingConfirmed()

            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
