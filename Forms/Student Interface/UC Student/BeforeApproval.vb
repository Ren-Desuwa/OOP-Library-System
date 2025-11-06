Imports System.Windows.Forms
' Imports MySql.Data.MySqlClient <-- REMOVED

Public Class BeforeApproval


    ' --- NEW PROPERTIES & EVENT ---
    Public Property BooksToBorrow As List(Of Book)
    Public Property StudentUsername As String
    Public Event BorrowingConfirmed()
    ' ------------------------------

    ' Private connectionString As String = ... <-- REMOVED

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

            ' --- MODIFIED LOGIC: Call the Service Layer for transactional borrow ---
            Program.BorrowSvc.ProcessBorrowing(Program.currentAccount.AccountID, BooksToBorrow)

            MessageBox.Show("Books successfully borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Refresh BorrowedBooks form if open
            ' NOTE: This still uses the old 'BorrowedBooks' form
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
            ' The Service Layer throws an informative exception on inventory or database failure
            MessageBox.Show("Error processing borrowing request: " & ex.Message, "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class