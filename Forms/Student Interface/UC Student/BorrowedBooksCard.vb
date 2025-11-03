Public Class BorrowedBooksCard
    ' Optional: expose properties para sa data
    Public Property BookTitle As String
        Get
            Return lblBookTitle.Text
        End Get
        Set(value As String)
            lblBookTitle.Text = value
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

    ' --- ADD THIS NEW FUNCTION ---
    Public Property BookCover As Image
        Get
            Return picbox_bookcover.Image
        End Get
        Set(value As Image)
            picbox_bookcover.Image = value
        End Set
    End Property

    ' --- ADD THIS NEW FUNCTION ---
    ''' <summary>
    ''' Sets the background color of the card and the status indicator.
    ''' </summary>
    Public Sub SetCardColor(color As Color)
        ' Guna2Panel1 is the main background panel
        Guna2Panel1.FillColor = color
        ' pnl_colorindicate is the small square
        pnl_colorindicate.FillColor = color
    End Sub
    ' --- END OF NEW FUNCTION ---

End Class