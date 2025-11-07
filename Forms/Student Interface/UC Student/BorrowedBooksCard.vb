' No Imports needed here anymore for this logic

Public Class BorrowedBooksCard
    Inherits UserControl

    ' --- We no longer need a Status property ---

    Public Sub New()
        InitializeComponent()

        ' Make labels wrap text and autosize
        lblBookTitle.AutoSize = False
        lblBookTitle.MaximumSize = New Size(Me.Width - 20, 0)
        lblBookTitle.AutoEllipsis = True
        lblBookTitle.TextAlign = ContentAlignment.MiddleLeft

        lblBorrowedDate.AutoSize = True
        lblDueDate.AutoSize = True

        ' Enable auto-size for card
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    ' --- *** NEW DYNAMIC FUNCTION *** ---
    ''' <summary>
    ''' Calculates and sets the panel color based on the Due Date and transaction status.
    ''' </summary>
    Public Sub SetDynamicStatus(dueDate As Date?, isReturned As Boolean, isOverdue As Boolean)
        Dim today As Date = Date.Today

        If isReturned Then
            ' 1. Check if Returned (Green)
            pnlStatus.BackColor = Color.FromArgb(128, 255, 128)
        ElseIf isOverdue Then
            ' 2. Check if DB status is Overdue (Red)
            pnlStatus.BackColor = Color.LightCoral
        ElseIf dueDate.HasValue Then
            ' 3. Check dates only if it's not returned or marked overdue
            If dueDate.Value.Date = today Then
                ' Due Today (Light Blue)
                pnlStatus.BackColor = Color.FromArgb(128, 255, 255)
            ElseIf dueDate.Value.Date > today AndAlso dueDate.Value.Date <= today.AddDays(3) Then
                ' Due Soon (Yellow)
                pnlStatus.BackColor = Color.FromArgb(255, 255, 128)
            Else
                ' Borrowed, but not due soon (White/Default)
                pnlStatus.BackColor = Color.White
            End If
        Else
            ' No due date, not returned (e.g., Pending)
            pnlStatus.BackColor = Color.White
        End If
    End Sub
    ' --- *** END OF NEW FUNCTION *** ---

    ' Properties to set labels from parent (Unchanged)
    Public Property BookTitle As String
        Get
            Return lblBookTitle.Text
        End Get
        Set(value As String)
            lblBookTitle.Text = value
            AdjustCardHeight()
        End Set
    End Property

    Public Property BorrowedDate As String
        Get
            Return lblBorrowedDate.Text
        End Get
        Set(value As String)
            lblBorrowedDate.Text = value
        End Set
    End Property

    Public Property DueDate As String
        Get
            Return lblDueDate.Text
        End Get
        Set(value As String)
            lblDueDate.Text = value
        End Set
    End Property

    ' Adjust card height dynamically (Unchanged)
    Private Sub AdjustCardHeight()
        Dim textHeight = TextRenderer.MeasureText(lblBookTitle.Text, lblBookTitle.Font, New Size(lblBookTitle.MaximumSize.Width, 0), TextFormatFlags.WordBreak).Height
        lblBookTitle.Height = textHeight
        Me.Height = lblBookTitle.Height + lblBorrowedDate.Height + lblDueDate.Height + 20
    End Sub

End Class