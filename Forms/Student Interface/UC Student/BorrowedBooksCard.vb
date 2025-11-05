Public Class BorrowedBooksCard
    Inherits UserControl

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

    ' Properties to set labels from parent
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

    ' Adjust card height dynamically
    Private Sub AdjustCardHeight()
        Dim textHeight = TextRenderer.MeasureText(lblBookTitle.Text, lblBookTitle.Font, New Size(lblBookTitle.MaximumSize.Width, 0), TextFormatFlags.WordBreak).Height
        lblBookTitle.Height = textHeight
        Me.Height = lblBookTitle.Height + lblBorrowedDate.Height + lblDueDate.Height + 20
    End Sub

    ' Set status color
    Public Sub SetStatusColor(color As Color)
        pnlStatus.BackColor = color
    End Sub
End Class
