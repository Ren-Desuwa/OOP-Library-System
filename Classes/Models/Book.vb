Public Class Book
    Public Property BookID As Integer
    Public Property Title As String
    Public Property Author As String
    Public Property Genres As List(Of Genre)
    Public Property ISBN As String
    Public Property Publisher As String
    Public Property YearPublished As Integer
    Public Property Description As String
    Public Property CoverUrl As String
    Public Property TotalCopies As Integer
    Public Property AvailableCopies As Integer

    Public Function GetFullTitle() As String
        Return $"{Title} by {Author} ({YearPublished})"
    End Function

    ' Check if book is available for borrowing
    Public Function IsAvailable() As Boolean
        Return AvailableCopies > 0
    End Function

    ' --- ADD THIS NEW FUNCTION ---

    ''' <summary>
    ''' Gets the cover image file name for the asset folder.
    ''' Returns "default_cover.png" if no specific cover URL is set.
    ''' </summary>
    Public Function GetCoverFileName() As String
        Const DEFAULT_COVER_FILENAME As String = "default_cover.png"

        If String.IsNullOrWhiteSpace(Me.CoverUrl) Then
            Return DEFAULT_COVER_FILENAME
        Else
            ' Return the specific file name (e.g., "Dune.png")
            Return Me.CoverUrl
        End If
    End Function
    ' --- END OF NEW FUNCTION ---

    Public Function GenreToString() As String
        If Genres Is Nothing OrElse Genres.Count = 0 Then
            Return ""
        End If
        GenreToString = ""
        For genre As Integer = 0 To Genres.Count - 1
            GenreToString &= Genres(genre).ToString()
        Next
        Return GenreToString
    End Function

End Class