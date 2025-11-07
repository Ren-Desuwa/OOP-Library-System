Public Class ReturnBook

    ' 🟦 Form Load Event
    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the default UserControl (Book Info)
        LoadContent(New UC_ReturnBook_BookInfo())
    End Sub

    ' 🟦 Universal method to load any UserControl into ContentPanel
    Public Sub LoadContent(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(userControl)
    End Sub

    ' 🟦 Close Button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    ' 🟦 Add Penalty Button
    Private Sub AddPenaltyBtn_Click(sender As Object, e As EventArgs) Handles AddPenaltyBtn.Click
        ' Load the penalty user control
        LoadContent(New UC_ReturnBook_Penalty())
    End Sub

    ' 🟦 Return Button (optional - load back book info page)
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        ' Extract the fine amount text from the label (remove "Penalty: Php " prefix)
        Dim fineText As String = Penalty__Lbl.Text.Replace("Penalty: Php ", "").Trim()

        ' Extract the credit score number (remove "Credit Score: " prefix)
        Dim creditScoreText As String = CreditScore_Lbl.Text.Replace("Credit Score: ", "").Trim()

        ' Show message box with fine and credit score
        MessageBox.Show($"Returned book details:" & Environment.NewLine &
                    $"Fine: Php {fineText}" & Environment.NewLine &
                    $"Credit Score: {creditScoreText}",
                    "Book Returned", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Close the form after showing message
        Me.Close()
    End Sub



    ' 🟦 Other Label Click Events (if needed, otherwise can be removed)
    Private Sub Borrower_Lbl_Click(sender As Object, e As EventArgs) Handles Borrower_Lbl.Click
    End Sub

    Private Sub Penalty__Lbl_Click(sender As Object, e As EventArgs) Handles Penalty__Lbl.Click
    End Sub

    Private Sub CreditScore_Lbl_Click(sender As Object, e As EventArgs) Handles CreditScore_Lbl.Click
    End Sub

    Private Sub BorrowDate_Lbl_Click(sender As Object, e As EventArgs) Handles BorrowDate_Lbl.Click
    End Sub

    Private Sub DueDate_Lbl_Click(sender As Object, e As EventArgs) Handles DueDate_Lbl.Click
    End Sub

    Private Sub ReturnDate_Lbl_Click(sender As Object, e As EventArgs) Handles Status_Lbl.Click
    End Sub

    Private Sub ContentPanel_Paint(sender As Object, e As PaintEventArgs) Handles ContentPanel.Paint
    End Sub

End Class
