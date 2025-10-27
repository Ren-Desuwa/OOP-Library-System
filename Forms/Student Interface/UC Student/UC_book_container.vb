Imports System.ComponentModel

Public Class UC_book_container

    ' --- Public Properties to "connect" the UI ---

    ' This new property will store the Book's ID
    Public Property BookID As Integer

    <Category("Custom Props")>
    Public Property BookTitle As String
        Get
            Return lbl_title.Text
        End Get
        Set(ByVal value As String)
            lbl_title.Text = value
        End Set
    End Property

    <Category("Custom Props")>
    Public Property BookCover As Image
        Get
            Return picbox_book.Image
        End Get
        Set(ByVal value As Image)
            picbox_book.Image = value
        End Set
    End Property

    ' --- Public Event for Click ---

    ' This exposes a click event so the main form knows when this book is clicked [cite: 202]
    Public Event BookClicked As EventHandler

    ' We need to handle clicks on the panel, picturebox, and label
    ' and make them all trigger our one custom event.
    Private Sub HandleClick(sender As Object, e As EventArgs) Handles picbox_book.Click, lbl_title.Click, book_container_panel.Click
        RaiseEvent BookClicked(Me, e)
    End Sub

    ' This is the old event handler, you can remove it or leave it. [cite: 204]
    Private Sub lbl_bookname_Click(sender As Object, e As EventArgs)

    End Sub
End Class