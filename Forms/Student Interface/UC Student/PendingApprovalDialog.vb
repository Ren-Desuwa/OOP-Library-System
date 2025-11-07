Imports System.Windows.Forms

Public Class PendingApprovalDialog

    ' This ID is set by the Signup form
    Public StudentAccountID As Integer

    Private Sub PendingApprovalDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Set initial button state
        btnConfirm.Enabled = False
        btnConfirm.Text = "Waiting for Approval"

        ' 2. Configure and start the timer
        StatusPollTimer.Interval = 5000 ' Check every 5 seconds
        StatusPollTimer.Start()
    End Sub

    Private Async Sub StatusPollTimer_Tick(sender As Object, e As EventArgs) Handles StatusPollTimer.Tick
        Try
            ' 3. Check the account's active status
            ' (We will create this IsAccountActive function in Step 2)
            If Await Program.AccountSvc.IsAccountActive(StudentAccountID) Then

                ' 4. APPROVED! Stop the timer and update the UI
                StatusPollTimer.Stop()

                lblStatus.Text = "Your account has been approved! You can now log in."
                btnConfirm.Enabled = True
                btnConfirm.Text = "Confirm"

                ' Optional: Flash the window to get the user's attention
                Me.FlashWindow()
            End If
            ' 5. If not approved, the timer just ticks again
        Catch ex As Exception
            ' Stop the timer if a database error occurs
            StatusPollTimer.Stop()
            lblStatus.Text = "Error checking status. Please restart the application."
        End Try
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        ' 6. Close the dialog
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    ' Helper function to flash the window
    Private Sub FlashWindow()
        ' (This requires Imports System.Runtime.InteropServices)
        ' You can skip this if it's too complex, but it's a nice touch.
    End Sub
End Class