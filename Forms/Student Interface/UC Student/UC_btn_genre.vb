Imports System.ComponentModel

Public Class UC_btn_genre
    ' This property lets us get or set the text on the button inside this User Control
    <Category("Custom Props")>
    Public Property GenreText As String
        Get
            Return btn_genre.Text
        End Get
        Set(ByVal value As String)
            btn_genre.Text = value
        End Set
    End Property

    ' This exposes the button's click event so the main form can listen for it
    Public Event GenreClicked As EventHandler

    Private Sub btn_genre_Click(sender As Object, e As EventArgs) Handles btn_genre.Click
        ' When the button is clicked, raise our custom event
        RaiseEvent GenreClicked(Me, e)
    End Sub
End Class