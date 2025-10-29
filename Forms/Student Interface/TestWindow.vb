Public Class TestWindow
    Public Sub New(Book As Book)

        ' This call is required by the designer.
        InitializeComponent()
        TextBox1.Text = Book.Title
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class