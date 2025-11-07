Imports System.Windows.Forms
' --- NEW: Import Interaction for the InputBox ---
Imports Microsoft.VisualBasic.Interaction

Public Class BeforeApproval

    ' --- NEW PROPERTIES & EVENT ---
    Public Property BooksToBorrow As List(Of Book)
    Public Property StudentUsername As String
    Public Event BorrowingConfirmed()
    ' ------------------------------
    Private newTransactionIds As List(Of Integer)
    Private WithEvents StatusPollTimer As New Timer()
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
    Private Async Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        If btnConfirm.Text = "Waiting..." Then
            Return
        End If


        If btnConfirm.Text = "Confirm" AndAlso newTransactionIds IsNot Nothing AndAlso newTransactionIds.Count > 0 Then
            RaiseEvent BorrowingConfirmed()
            Me.Close()
            Return
        End If

        ' Ask for borrow duration
        Dim daysInput As String = InputBox("How many days would you like to borrow this book for?", "Borrow Duration", "7")
        Dim borrowDays As Integer
        If String.IsNullOrWhiteSpace(daysInput) Then Return
        If Not Integer.TryParse(daysInput, borrowDays) OrElse borrowDays <= 0 OrElse borrowDays > 30 Then
            MessageBox.Show("Please enter a valid number of days (1–30).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            ' Validate book list
            If BooksToBorrow Is Nothing OrElse BooksToBorrow.Count = 0 Then
                MessageBox.Show("No books selected to borrow.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            ' Disable button while processing
            btnConfirm.Enabled = False
            btnConfirm.Text = "Processing..."

            ' 🔹 Connect to DB through BorrowService
            ' BorrowService handles transaction & DB logic internally
            newTransactionIds = Await Task.Run(Function()
                                                   Return Program.BorrowSvc.ProcessBorrowing(Program.currentAccount.AccountID, BooksToBorrow, borrowDays)
                                               End Function)

            Label5.Text = "Request sent! Waiting for librarian approval..."
            btnConfirm.Enabled = True
            btnConfirm.Text = "Waiting..."

            ' Start polling every 5s to check if approved
            StatusPollTimer.Interval = 500
            StatusPollTimer.Start()

        Catch ex As Exception
            MessageBox.Show("Error processing borrowing request: " & ex.Message,
                        "Borrow Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btnConfirm.Enabled = True
            btnConfirm.Text = "Confirm"
        End Try
    End Sub

    ' 🔁 Polling every few seconds for librarian approval
    Private Async Sub StatusPollTimer_Tick(sender As Object, e As EventArgs) Handles StatusPollTimer.Tick
        If newTransactionIds Is Nothing OrElse newTransactionIds.Count = 0 Then Return

        ' Check if all transactions are processed (approved or rejected)
        Dim allProcessed As Boolean = Await Program.BorrowSvc.AreTransactionsApproved(newTransactionIds)

        If allProcessed Then
            ' Stop polling
            StatusPollTimer.Stop()

            ' Enable button and change text
            btnConfirm.Enabled = True
            btnConfirm.Text = "Confirm"

            ' Notify user
            MessageBox.Show("Your borrow request has been processed. Click Confirm to close.", "Borrow Request", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub




End Class