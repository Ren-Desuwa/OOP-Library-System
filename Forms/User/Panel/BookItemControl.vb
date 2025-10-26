Imports System.IO

Public Class BookItemControl

    Private _BookData As Book = Nothing

    Public Sub New()
        InitializeComponent()

        ' Ensure fixed size
        Me.AutoSize = False
        Me.Size = New Size(150, 200)

        ' Setup picture box
        picCover.SizeMode = PictureBoxSizeMode.Zoom
        picCover.BackColor = Color.WhiteSmoke

        ' Setup label
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        lblTitle.AutoEllipsis = True
    End Sub

    Public Sub SetBookData(book As Book, coverImagePath As String, defaultImagePath As String)
        _BookData = book

        If book IsNot Nothing Then
            lblTitle.Text = book.Title
        Else
            lblTitle.Text = "N/A"
        End If

        Try
            If File.Exists(coverImagePath) Then
                Using fs As New FileStream(coverImagePath, FileMode.Open, FileAccess.Read)
                    picCover.Image = Image.FromStream(fs)
                End Using
            ElseIf File.Exists(defaultImagePath) Then
                Using fs As New FileStream(defaultImagePath, FileMode.Open, FileAccess.Read)
                    picCover.Image = Image.FromStream(fs)
                End Using
            Else
                picCover.Image = Nothing
                picCover.BackColor = Color.LightGray
            End If
        Catch ex As Exception
            picCover.Image = Nothing
            picCover.BackColor = Color.Gainsboro
            Debug.WriteLine($"Error loading image for '{lblTitle.Text}': {ex.Message}")
        End Try
    End Sub

    Public Event BookClicked(sender As Object, book As Book)

    Private Sub HandleClick(sender As Object, e As EventArgs) Handles picCover.Click, lblTitle.Click, Me.Click
        If _BookData IsNot Nothing Then
            RaiseEvent BookClicked(Me, _BookData)
        End If
    End Sub

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing Then
                ' Dispose image to free memory
                If picCover IsNot Nothing AndAlso picCover.Image IsNot Nothing Then
                    picCover.Image.Dispose()
                    picCover.Image = Nothing
                End If
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

End Class