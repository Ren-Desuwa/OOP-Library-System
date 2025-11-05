Public Class BookCart
    Inherits UserControl

    ' Property for the Book Title label
    Public Property BookTitleText As String
        Get
            Return lblBookTitle.Text
        End Get
        Set(value As String)
            lblBookTitle.Text = value
        End Set
    End Property

    ' Property for the Book Image
    Public Property BookImagePic As Image
        Get
            Return BookImage.Image
        End Get
        Set(value As Image)
            BookImage.Image = value
        End Set
    End Property

    ' Expose the CheckBox for external access
    Public ReadOnly Property BookCheckBoxControl As CheckBox
        Get
            Return BookCheckBox
        End Get
    End Property

    ' Optional aliases for BeforeApproval
    Public ReadOnly Property BookTitleAlias As String
        Get
            Return BookTitleText
        End Get
    End Property

    Public ReadOnly Property BookCover As Image
        Get
            Return BookImagePic
        End Get
    End Property
End Class
