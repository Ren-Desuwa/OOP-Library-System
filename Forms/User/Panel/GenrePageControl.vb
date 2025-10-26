Imports System.IO

Public Class GenrePageControl

    Public Event BackButtonClicked(sender As Object, e As EventArgs)
    Public Event BookClickedRelay(sender As Object, book As Book)

    Public Sub New()
        InitializeComponent()

        ' Setup books panel for proper wrapping
        flpAllBooks.FlowDirection = FlowDirection.LeftToRight
        flpAllBooks.WrapContents = True
        flpAllBooks.AutoScroll = True
        flpAllBooks.Padding = New Padding(15)
    End Sub

    Public Sub PopulateGenrePage(genreName As String, books As List(Of Book))
        lblGenreTitleFull.Text = genreName

        flpAllBooks.SuspendLayout()

        ' Clear existing books
        For Each ctrl As Control In flpAllBooks.Controls.OfType(Of BookItemControl)().ToList()
            RemoveHandler DirectCast(ctrl, BookItemControl).BookClicked, AddressOf HandleBookItemClicked
            ctrl.Dispose()
        Next
        flpAllBooks.Controls.Clear()

        ' Load book data
        Dim startupPath As String = Application.StartupPath
        Dim defaultImagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", "default_cover.png")

        For Each book In books
            Dim coverFileName As String = book.GetCoverFileName()
            Dim imagePath As String = Path.Combine(startupPath, "..\..\Assets\Bookcover", coverFileName)

            Dim bookControl As New BookItemControl() With {
                .Margin = New Padding(10)
            }
            bookControl.SetBookData(book, imagePath, defaultImagePath)
            AddHandler bookControl.BookClicked, AddressOf HandleBookItemClicked
            flpAllBooks.Controls.Add(bookControl)
        Next

        flpAllBooks.ResumeLayout(True)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        RaiseEvent BackButtonClicked(Me, e)
    End Sub

    Private Sub HandleBookItemClicked(sender As Object, book As Book)
        RaiseEvent BookClickedRelay(sender, book)
    End Sub

End Class