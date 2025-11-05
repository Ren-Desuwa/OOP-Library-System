Imports System.Drawing

Public Class UC_Booktable_container

    Private _book As Book
    Private _isSelected As Boolean = False

    ''' <summary>
    ''' Raised when this control is clicked.
    ''' </summary>
    Public Event Selected As EventHandler

    ''' <summary>
    ''' Exposes the Book object this control represents.
    ''' </summary>
    Public ReadOnly Property Book As Book
        Get
            Return _book
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the selection state, updating the UI.
    ''' </summary>
    Public Property IsSelected As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            _isSelected = value
            ' Change color based on selection
            If _isSelected Then
                pnl_table_container.FillColor = Color.Gainsboro ' Selected color
            Else
                pnl_table_container.FillColor = Color.Transparent ' Default color
            End If
        End Set
    End Property

    ''' <summary>
    ''' (REVERTED)
    ''' Stores the book data AND applies it to the UI controls.
    ''' This MUST be called from the UI thread.
    ''' </summary>
    Public Sub SetData(ByVal book As Book)
        _book = book ' Store the book object

        If _book IsNot Nothing Then
            ' Set the text for the labels based on the Book's properties
            lbl_book_title.Text = "Book Title: " + _book.Title
            lbl_book_author.Text = "Author: " + _book.Author
            lbl_book_count.Text = $"Book Count: {_book.AvailableCopies} / {_book.TotalCopies}"

            ' --- GENRE LOGIC ---
            If _book.Genres IsNot Nothing AndAlso _book.Genres.Any() Then
                Dim genreNames = _book.Genres.Select(Function(g) g.Name)
                lbl_Genre.Text = "Genre: " & String.Join(", ", genreNames)
            Else
                lbl_Genre.Text = "Genre: N/A"
            End If
        Else
            lbl_book_title.Text = "N/A"
            lbl_book_author.Text = "N/A"
            lbl_book_count.Text = "0 / 0"
            lbl_Genre.Text = "Genre: N/A"
        End If
    End Sub

    ''' <summary>
    ''' Handles clicks on the main panel AND LABELS and raises the Selected event.
    ''' </summary>
    Private Sub Control_Click(sender As Object, e As EventArgs) Handles pnl_table_container.Click,
                                                                        lbl_book_title.Click,
                                                                        lbl_book_author.Click,
                                                                        lbl_book_count.Click,
                                                                        lbl_Genre.Click,
                                                                        TableLayoutPanel1.Click,
                                                                        Me.Click
        RaiseEvent Selected(Me, EventArgs.Empty)
    End Sub
End Class