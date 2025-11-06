Imports System.Windows.Forms
' --- NEW: Import Interaction for the InputBox ---
Imports Microsoft.VisualBasic.Interaction

Public Class BeforeApproval

    ' --- NEW PROPERTIES & EVENT ---
    Public Property BooksToBorrow As List(Of Book)
    Public Property StudentUsername As String
    Public Event BorrowingConfirmed()
    ' ------------------------------

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

        ' --- START NEW LOGIC ---
        ' 1. Ask the user for the number of days
        Dim daysInput As String = InputBox("How many days would you like to borrow this book for?", "Borrow Duration", "7")
        Dim borrowDays As Integer

        ' 2. Validate the input
        If String.IsNullOrWhiteSpace(daysInput) Then
            Return ' User clicked Cancel
        End If

        If Not Integer.TryParse(daysInput, borrowDays) OrElse borrowDays <= 0 Then
            MessageBox.Show("Please enter a valid number of days (e.g., 7).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' You can also add a maximum limit here
        If borrowDays > 30 Then
            MessageBox.Show("You cannot borrow a book for more than 30 days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' --- END NEW LOGIC ---

        Try
            ' Ensure there are books to borrow
            If BooksToBorrow Is Nothing OrElse BooksToBorrow.Count = 0 Then
                MessageBox.Show("No books selected to borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' --- MODIFIED LOGIC: Call the Service Layer with borrowDays ---
            Program.BorrowSvc.ProcessBorrowing(Program.currentAccount.AccountID, BooksToBorrow, borrowDays)

            MessageBox.Show($"Books successfully borrowed for {borrowDays} days!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

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