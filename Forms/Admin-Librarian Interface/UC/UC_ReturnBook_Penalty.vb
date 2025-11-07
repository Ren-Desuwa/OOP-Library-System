Imports OOP_Library_System.Models

Public Class UC_ReturnBook_Penalty

    ' (NEW) Event that ReturnBook.vb will listen for
    Public Event PenaltySet(manualFine As Decimal, creditChange As Short, reason As String)

    ' (NEW) Store the book details to pass back if user clicks "Back"
    Private _bookDetails As BorrowedBookDetails

    ' (NEW) Constructor to receive book data
    Public Sub New(details As BorrowedBookDetails)
        InitializeComponent()
        _bookDetails = details
    End Sub

    ' 🔙 (MODIFIED) Back Button: Return to Book Info
    Private Sub PenaltyBackBtn_Click(sender As Object, e As EventArgs) Handles PenaltyBackBtn.Click
        Dim parentForm As ReturnBook = TryCast(Me.ParentForm, ReturnBook)
        If parentForm IsNot Nothing Then
            ' (MODIFIED) This calls a new function on the parent
            parentForm.LoadDefaultBookInfo()
        End If
    End Sub

    ' 🟦 (REMOVED) The 'UC_ReturnBook_Penalty_Load' sub is not needed
    '    (The parent 'ReturnBook' form will now control the labels)

    ' ➕ (MODIFIED) Confirm / Add Fine Button
    Private Sub ConfirmBtn_Click(sender As Object, e As EventArgs) Handles ConfirmBtn.Click
        ' --- 1. VALIDATE FINE ---
        If String.IsNullOrWhiteSpace(FineTxtBox.Text) Then
            MessageBox.Show("Please enter a fine amount (e.g., 0).", "Missing Fine", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            FineTxtBox.Focus()
            Exit Sub
        End If

        Dim parsedFine As Decimal
        If Not Decimal.TryParse(FineTxtBox.Text, parsedFine) Then
            MessageBox.Show("Fine amount must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FineTxtBox.Focus()
            Exit Sub
        End If

        If FineTxtBox.TextLength > 10 Then
            MessageBox.Show("Fine amount cannot exceed 10 digits.", "Too Long", MessageBoxButtons.OK, MessageBoxIcon.Error)
            FineTxtBox.Focus()
            Exit Sub
        End If

        ' --- 2. VALIDATE CREDIT SCORE ---
        Dim adjustment As String = creditScoreTxtBox.Text.Trim()
        If String.IsNullOrEmpty(adjustment) Then
            MessageBox.Show("Credit score adjustment is required (e.g., +5, -10, or 0).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        ' Handle "0" as a valid input (means "+0")
        If adjustment = "0" Then adjustment = "+0"

        Dim firstChar As Char = adjustment(0)
        If firstChar <> "+"c AndAlso firstChar <> "-"c Then
            MessageBox.Show("Credit score adjustment must start with '+' or '-'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        Dim numberPart As String = adjustment.Substring(1)
        If Not System.Text.RegularExpressions.Regex.IsMatch(numberPart, "^\d+$") Then
            MessageBox.Show("Credit score adjustment must contain only digits after the sign.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        Dim parsedCreditValue As Short
        If Not Short.TryParse(numberPart, parsedCreditValue) Then
            MessageBox.Show("Credit score value is too large.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            creditScoreTxtBox.Focus()
            Exit Sub
        End If

        ' Apply the sign
        If firstChar = "-"c Then
            parsedCreditValue = CShort(-parsedCreditValue)
        End If

        ' --- 3. (NEW) RAISE THE EVENT ---
        ' This sends the data back to the ReturnBook.vb form.
        RaiseEvent PenaltySet(parsedFine, parsedCreditValue, "Librarian adjustment")
    End Sub

    ' 🔢 (Unchanged) Your KeyPress validation logic
    Private Sub FineTxtbox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles FineTxtBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub creditScoreTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles creditScoreTxtBox.KeyPress
        Dim txt As Guna.UI2.WinForms.Guna2TextBox = CType(sender, Guna.UI2.WinForms.Guna2TextBox)
        If Char.IsControl(e.KeyChar) Then Return
        If txt.SelectionStart = 0 AndAlso (e.KeyChar = "+"c OrElse e.KeyChar = "-"c OrElse e.KeyChar = "0"c) Then
            ' Allow 0 as first char
            Return
        End If
        ' If first char was + or -, only allow digits after
        If txt.TextLength > 0 AndAlso (txt.Text(0) = "+"c OrElse txt.Text(0) = "-"c) Then
            If Char.IsDigit(e.KeyChar) Then Return
        End If
        ' If first char was 0, allow nothing else
        If txt.Text = "0" Then
            e.Handled = True
            Return
        End If
        ' Allow digits if first char was a digit (but not 0)
        If Char.IsDigit(e.KeyChar) AndAlso txt.SelectionStart > 0 Then
            Return
        End If
        e.Handled = True
    End Sub
End Class