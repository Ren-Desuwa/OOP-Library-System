Public Class UC_ReturnBook_Penalty

    ' 🔙 Back Button: Return to Book Info
    Private Sub PenaltyBackBtn_Click(sender As Object, e As EventArgs) Handles PenaltyBackBtn.Click
        Dim parentForm As ReturnBook = TryCast(Me.ParentForm, ReturnBook)
        If parentForm IsNot Nothing Then
            parentForm.LoadContent(New UC_ReturnBook_BookInfo())
        End If
    End Sub

    ' 🟦 UserControl Load: set default credit score
    Private Sub UC_ReturnBook_Penalty_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim parentForm As ReturnBook = TryCast(Me.ParentForm, ReturnBook)
        If parentForm IsNot Nothing Then
            parentForm.CreditScore_Lbl.Text = "Credit Score: 100"
        End If
    End Sub

    ' ➕ Confirm / Add Fine Button
    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        Dim parentForm As ReturnBook = TryCast(Me.ParentForm, ReturnBook)
        If parentForm Is Nothing Then Exit Sub

        ' --- VALIDATE FINE ---
        If String.IsNullOrWhiteSpace(FineTxtBox.Text) Then
            MessageBox.Show("Please enter a fine amount.", "Missing Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FineTxtBox.Focus()
            Exit Sub
        End If

        If Not IsNumeric(FineTxtBox.Text) Then
            MessageBox.Show("Fine amount must be a number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FineTxtBox.Focus()
            Exit Sub
        End If

        If FineTxtBox.TextLength > 10 Then
            MessageBox.Show("Fine amount cannot exceed 10 digits.", "Too Long", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FineTxtBox.Focus()
            Exit Sub
        End If

        ' Set fine label
        Dim fineAmount As String = FineTxtBox.Text.Trim()
        parentForm.Penalty__Lbl.Text = $"Penalty: Php {fineAmount}"

        ' --- CREDIT SCORE ---
        Dim currentScore As Integer = 100 ' default
        Dim adjustment As String = creditScoreTxtBox.Text.Trim()

        If String.IsNullOrEmpty(adjustment) Then
            MessageBox.Show("Credit score adjustment is required and must start with '+' or '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        ' Must start with + or -
        Dim firstChar As Char = adjustment(0)
        If firstChar <> "+"c AndAlso firstChar <> "-"c Then
            MessageBox.Show("Credit score adjustment must start with '+' or '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        ' Remove sign for numeric validation
        Dim numberPart As String = adjustment.Substring(1)

        ' Only digits allowed after sign
        If Not System.Text.RegularExpressions.Regex.IsMatch(numberPart, "^\d+$") Then
            MessageBox.Show("Credit score adjustment must contain only digits after the sign.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        ' Apply adjustment
        Dim value As Integer = CInt(numberPart)
        If firstChar = "+"c Then
            currentScore += value
        Else
            currentScore -= value
            If currentScore < 0 Then
                MessageBox.Show("Credit score cannot go below 0.", "Invalid Adjustment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                creditScoreTxtBox.Focus()
                Exit Sub
            End If
        End If

        ' Update credit score label
        parentForm.CreditScore_Lbl.Text = $"Credit Score: {currentScore}"

        ' Disable Add Penalty button
        parentForm.AddPenaltyBtn.Enabled = False

        ' Success message
        MessageBox.Show("Fine and credit score successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Return to Book Info automatically
        parentForm.LoadContent(New UC_ReturnBook_BookInfo())
    End Sub

    ' 🔢 Fine TextBox: only digits
    Private Sub FineTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FineTxtBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' 🔢 Credit Score TextBox: only one sign at the start, then digits
    Private Sub creditScoreTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles creditScoreTxtBox.KeyPress
        Dim txt As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)

        ' Allow control keys
        If Char.IsControl(e.KeyChar) Then Return

        ' If first character, allow + or -
        If txt.SelectionStart = 0 AndAlso (e.KeyChar = "+"c OrElse e.KeyChar = "-"c) Then
            Return
        End If

        ' Only digits allowed after first character
        If Char.IsDigit(e.KeyChar) Then
            Return
        End If

        ' Anything else is invalid
        e.Handled = True
    End Sub


End Class
