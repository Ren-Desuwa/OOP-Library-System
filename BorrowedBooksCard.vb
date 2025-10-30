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
End Class
