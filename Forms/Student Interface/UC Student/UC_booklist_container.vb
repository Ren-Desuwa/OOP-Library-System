Imports System.ComponentModel

Public Class UC_booklist_container

    ' --- Public Property to set the Genre Title ---

    <Category("Custom Props")>
    Public Property GenreTitle As String
        Get
            Return lbl_genre.Text
        End Get
        Set(ByVal value As String)
            lbl_genre.Text = value
        End Set
    End Property
    ' --- NEW: Public Event for the "See All" button ---
    Public Event SeeAllClicked As EventHandler
    Private Sub btn_SeeAll_Click(sender As Object, e As EventArgs) Handles btn_SeeAll.Click
        ' When "See All" is clicked, raise our new event
        ' We pass 'Me' so the main form knows WHICH genre was clicked
        RaiseEvent SeeAllClicked(Me, e)
    End Sub

    ' --- Public Method to add books ---

    ''' <summary>
    ''' Adds a book (a UC_book_container) to this list's FlowLayoutPanel.
    ''' </summary>
    Public Sub AddBook(ByVal bookControl As UC_book_container)
        flow_book_panel.Controls.Add(bookControl)
    End Sub

    ''' <summary>
    ''' Clears all books from this list.
    ''' </summary>
    Public Sub ClearBooks()
        flow_book_panel.Controls.Clear()
    End Sub
End Class