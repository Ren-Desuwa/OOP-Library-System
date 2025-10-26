Imports System.IO

Public Class GenreRowControl

    Private _GenreName As String = "Unknown"
    Private _BooksInGenre As List(Of Book) = New List(Of Book)()

    Public Event TitleClicked(sender As Object, genreName As String)
    Public Event BookClickedRelay(sender As Object, book As Book)

    Public Sub New()
        InitializeComponent()

        ' Ensure proper sizing
        Me.AutoSize = False
        Me.Height = 265

        ' Setup label
        lblGenreTitle.AutoSize = True
        lblGenreTitle.Cursor = Cursors.Hand

        ' Setup books panel
        flpBooks.AutoScroll = False
        flpBooks.WrapContents = False
        flpBooks.FlowDirection = FlowDirection.LeftToRight
        flpBooks.Height = 210
        flpBooks.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
    End Sub

    Public Property GenreName As String
        Get
            Return _GenreName
        End Get
        Set(value As String)
            _GenreName = value
            lblGenreTitle.Text = value
        End Set
    End Property

    Public Sub PopulateBooks(books As List(Of Book), maxBooksToShow As Integer)
        _BooksInGenre = books
        flpBooks.SuspendLayout()
        flpBooks.Controls.Clear()

        Dim startupPath As String = Application.StartupPath
        Dim defaultImagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", "default_cover.png")

        Dim booksToShow As Integer = Math.Min(books.Count, maxBooksToShow)

        For i = 0 To booksToShow - 1
            Dim book = books(i)
            Dim coverFileName As String = book.GetCoverFileName()
            Dim imagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", coverFileName)

            Dim bookControl As New BookItemControl() With {
                .Margin = New Padding(5)
            }
            bookControl.SetBookData(book, imagePath, defaultImagePath)
            AddHandler bookControl.BookClicked, AddressOf HandleBookItemClicked
            flpBooks.Controls.Add(bookControl)
        Next

        flpBooks.ResumeLayout(True)
    End Sub

    Private Sub lblGenreTitle_Click(sender As Object, e As EventArgs) Handles lblGenreTitle.Click
        RaiseEvent TitleClicked(Me, _GenreName)
    End Sub

    Private Sub HandleBookItemClicked(sender As Object, book As Book)
        RaiseEvent BookClickedRelay(sender, book)
    End Sub

    Protected Overrides Sub OnResize(e As EventArgs)
        MyBase.OnResize(e)

        ' Update books panel width when row is resized
        If flpBooks IsNot Nothing Then
            flpBooks.Width = Me.Width - 30
        End If
    End Sub

End Class