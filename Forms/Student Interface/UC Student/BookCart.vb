Public Class BookCart

    ' Property for the Label (BookTitle)
    Public Property BookTitleText As String
        Get
            Return BookTitle.Text
        End Get
        Set(value As String)
            BookTitle.Text = value
        End Set
    End Property

    ' Property for the PictureBox (BookImage)
    Public Property BookImagePic As Image
        Get
            Return BookImage.Image
        End Get
        Set(value As Image)
            BookImage.Image = value
        End Set
    End Property

End Class
