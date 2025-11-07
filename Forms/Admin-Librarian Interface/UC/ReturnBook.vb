Imports OOP_Library_System.Models

Public Class ReturnBook

    ' (NEW) Private fields to hold all the data
    Private _bookDetails As BorrowedBookDetails
    Private _transaction As Transaction
    Private _book As Book

    ' (NEW) Private fields for penalty
    Private _manualFine As Decimal = 0D
    Private _creditScoreChange As Short = 0
    Private _penaltyReason As String = ""

    ' (NEW) Constructor that accepts the book details
    Public Sub New(details As BorrowedBookDetails)
        InitializeComponent()
        _bookDetails = details
        _transaction = details.Transaction
        _book = details.Book
    End Sub

    ' 🟦 (MODIFIED) Form Load Event - Now checks status
    Private Sub ReturnBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If _transaction Is Nothing Then
            MessageBox.Show("Error: No transaction data loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' 1. Populate all the labels
        Borrower_Lbl.Text = $"Borrower: {_bookDetails.BorrowerName}"
        BorrowDate_Lbl.Text = $"Borrowed: {_transaction.DateBorrowed?.ToShortDateString()}"
        DueDate_Lbl.Text = $"Due: {_transaction.DateDue?.ToShortDateString()}"

        ' 2. Calculate and store the *initial* fine
        _manualFine = _transaction.CalculateFine() ' Using function from Transaction.vb
        Penalty__Lbl.Text = $"Penalty: Php {_manualFine}"

        ' 3. Set credit score label to pending
        CreditScore_Lbl.Text = "Credit Score: (Not Assessed)"

        ' --- 4. (NEW) Check Status to Enable/Disable Buttons (Your Request) ---
        ReturnBtn.Enabled = False
        AddPenaltyBtn.Enabled = False

        Select Case _transaction.Status.ToLower()
            Case "approved", "borrowed", "overdue", "duesoon"
                ' These are active, returnable loans.
                AddPenaltyBtn.Enabled = True
                Status_Lbl.Text = $"Status: {_transaction.Status}"
                ' ReturnBtn stays False until penalty is set.

            Case "pending"
                ' This is a pending request. Disable all return actions.
                Status_Lbl.Text = "Status: Pending Approval"
                Penalty__Lbl.Text = "Penalty: (Not applicable)"
                CreditScore_Lbl.Text = "Credit Score: (Not applicable)"

            Case "rejected", "returned"
                ' This book is already processed. Disable all return actions.
                Status_Lbl.Text = $"Status: {_transaction.Status} (Closed)"
                Penalty__Lbl.Text = $"Penalty: Php {_transaction.Fine}" ' Show historical fine
                CreditScore_Lbl.Text = "Credit Score: (See History)"

            Case Else
                Status_Lbl.Text = $"Status: {_transaction.Status} (Cannot be returned)"
        End Select
        ' --- END NEW LOGIC ---

        ' 5. Load the default UserControl (Book Info)
        LoadDefaultBookInfo()
    End Sub

    ' 🟦 Universal method to load any UserControl into ContentPanel
    Public Sub LoadContent(userControl As UserControl)
        userControl.Dock = DockStyle.Fill
        ContentPanel.Controls.Clear()
        ContentPanel.Controls.Add(userControl)
    End Sub

    ' 🟦 (NEW) Helper method to reload the default book info UC
    Public Sub LoadDefaultBookInfo()
        Dim bookInfoUC As New UC_ReturnBook_BookInfo(_book)
        LoadContent(bookInfoUC)
    End Sub

    ' 🟦 Close Button
    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Close()
    End Sub

    ' 🟦 (MODIFIED) Add Penalty Button
    Private Sub AddPenaltyBtn_Click(sender As Object, e As EventArgs) Handles AddPenaltyBtn.Click
        ' (MODIFIED) Load the penalty user control, passing details
        Dim penaltyUC As New UC_ReturnBook_Penalty(_bookDetails)

        ' *** (NEW) IMPORTANT: Listen for the 'PenaltySet' event ***
        AddHandler penaltyUC.PenaltySet, AddressOf HandlePenaltySet

        LoadContent(penaltyUC)
    End Sub

    ' 🟦 (NEW) Event Handler for when the penalty is confirmed
    Private Sub HandlePenaltySet(manualFine As Decimal, creditChange As Short, reason As String)
        ' 1. Store the values returned from the event
        _manualFine = manualFine
        _creditScoreChange = creditChange
        _penaltyReason = reason

        ' 2. Update the labels
        Penalty__Lbl.Text = $"Penalty: Php {_manualFine}"
        CreditScore_Lbl.Text = $"Score Change: {If(_creditScoreChange >= 0, "+", "")}{_creditScoreChange}"

        ' 3. *** (YOUR REQUEST) ENABLE THE RETURN BUTTON ***
        ReturnBtn.Enabled = True

        ' 4. Disable the Add Penalty button since it's done
        AddPenaltyBtn.Enabled = False

        ' 5. Reload the Book Info UC to hide the penalty controls
        LoadDefaultBookInfo()
    End Sub

    ' 🟦 (MODIFIED) Return Button
    Private Sub ReturnBtn_Click(sender As Object, e As EventArgs) Handles ReturnBtn.Click
        Try
            ' (NEW) Call the modified service function with all our data
            Program.BorrowSvc.ProcessBookReturn(_transaction.TransactionID, _manualFine, _creditScoreChange)

            MessageBox.Show("Book returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Catch ex As Exception
            MessageBox.Show($"Error returning book: {ex.Message}", "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    ' 🟦 Other Label Click Events (optional)
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