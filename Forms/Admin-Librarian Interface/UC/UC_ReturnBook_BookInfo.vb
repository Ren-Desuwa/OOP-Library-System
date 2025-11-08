Imports OOP_Library_System.Models

Public Class UC_ReturnBook_BookInfo

    ' (NEW) A constructor to get the data
    Private _book As Book

    Public Sub New(bookData As Book)
        InitializeComponent()
        _book = bookData
    End Sub

    ' (NEW) Populate controls when the UC loads
    ' (NEW) Populate controls when the UC loads
    Private Sub UC_ReturnBook_BookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If _book IsNot Nothing Then
            ' Use the control names from your Designer.vb file
            BookName_Lbl.Text = _book.Title
            Author_Lbl.Text = _book.Author

            ' Assuming your Book model has properties for ISBN and Genre
            ISBN_Lbl.Text = $"ISBN: {_book.ISBN}"
            Genre_Lbl.Text = $"{_book.GenreToString()}"

            ' (Assuming GetCoverPath() exists on your Book model)
            Guna2PictureBox1.LoadAsync(_book.GetCoverFileName())
        Else
            ' Handle case where book data is missing
            BookName_Lbl.Text = "Book Details Not Found"
            Author_Lbl.Text = "N/A"
            ISBN_Lbl.Text = "ISBN: N/A"
            Genre_Lbl.Text = "Genre: N/A"
        End If

    End Sub
End Class