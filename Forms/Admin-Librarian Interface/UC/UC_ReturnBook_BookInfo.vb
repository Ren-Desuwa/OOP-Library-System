Imports OOP_Library_System.Models

Public Class UC_ReturnBook_BookInfo

    ' (NEW) A constructor to get the data
    Private _book As Book

    Public Sub New(bookData As Book)
        InitializeComponent()
        _book = bookData
    End Sub

    ' (NEW) Populate controls when the UC loads
    Private Sub UC_ReturnBook_BookInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' I am ASSUMING you have controls on this UC.
        ' Please change these names to match your .Designer.vb file

        ' If _book IsNot Nothing Then
        '    BookTitle_Lbl.Text = _book.Title
        '    Author_Lbl.Text = _book.Author
        '    Description_Txt.Text = _book.Description
        '    ' (Assuming GetCoverPath() exists on your Book model)
        '    BookCover_Img.LoadAsync(_book.GetCoverPath()) 
        ' Else
        '    BookTitle_Lbl.Text = "Book Details Not Found"
        '    Author_Lbl.Text = "N/A"
        '    Description_Txt.Text = "Could not load book details for this transaction."
        ' End If
    End Sub
End Class