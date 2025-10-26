Imports System.IO
Imports System.Text.RegularExpressions ' Optional for advanced highlighting

Public Class BookSortedList

    ' --- Standard Method for Genre View ---
    Public Sub SetBookData(bookTitle As String, coverImagePath As String, defaultImagePath As String)
        SetBookDataInternal(bookTitle, coverImagePath, defaultImagePath, Nothing, Nothing)
    End Sub

    ' --- New Method for Search Results ---
    Public Sub SetBookDataWithMatchInfo(book As Book, searchTerm As String, coverImagePath As String, defaultImagePath As String)
        Dim matchInfo As String = FindMatch(book, searchTerm)
        ' Pass Nothing for searchTerm to internal method if you don't implement highlighting
        SetBookDataInternal(book.Title, coverImagePath, defaultImagePath, Nothing, matchInfo)
        ' OR pass searchTerm if you implement highlighting:
        ' SetBookDataInternal(book.Title, coverImagePath, defaultImagePath, searchTerm, matchInfo)
    End Sub

    ' --- Private Helper for Setting Data ---
    Private Sub SetBookDataInternal(bookTitle As String, coverImagePath As String, defaultImagePath As String, searchTerm As String, matchInfo As String)
        ' Set title
        lblTitle.Text = bookTitle

        ' Load image (same logic as before)
        Try
            If File.Exists(coverImagePath) Then
                picCover.Image = Image.FromFile(coverImagePath)
            ElseIf File.Exists(defaultImagePath) Then
                picCover.Image = Image.FromFile(defaultImagePath)
            Else
                picCover.Image = Nothing
            End If
        Catch ex As Exception
            picCover.Image = Nothing
            Debug.WriteLine($"Error loading image '{coverImagePath}' or '{defaultImagePath}': {ex.Message}")
        End Try

        ' Display match info (if any)
        If String.IsNullOrWhiteSpace(matchInfo) Then
            lblMatchInfo.Text = ""
            lblMatchInfo.Visible = False
        Else
            lblMatchInfo.Text = matchInfo
            lblMatchInfo.Visible = True
            ' --- Optional Advanced Highlighting (Requires RichTextBox) ---
            ' HighlightText(rtbTitle, searchTerm) ' Assuming rtbTitle exists
            ' HighlightText(rtbMatchInfo, searchTerm) ' Assuming rtbMatchInfo exists
        End If
    End Sub

    ' --- Helper to find where the search term matched ---
    Private Function FindMatch(book As Book, searchTerm As String) As String
        If String.IsNullOrWhiteSpace(searchTerm) OrElse book Is Nothing Then Return ""

        Dim options = StringComparison.OrdinalIgnoreCase ' Case-insensitive search

        If book.Title IsNot Nothing AndAlso book.Title.IndexOf(searchTerm, options) >= 0 Then
            Return "Match in Title" ' Corrected: No $
        ElseIf book.Author IsNot Nothing AndAlso book.Author.IndexOf(searchTerm, options) >= 0 Then
            Return "Match in Author" ' Corrected: No $
        ElseIf book.ISBN IsNot Nothing AndAlso book.ISBN.IndexOf(searchTerm, options) >= 0 Then
            Return "Match in ISBN" ' Corrected: No $
        ElseIf book.Description IsNot Nothing AndAlso book.Description.IndexOf(searchTerm, options) >= 0 Then
            ' --- CORRECTION for BC30455: Use standard concatenation ---
            ' Pass the default contextLength (20) explicitly
            Return "Match in Desc: " & GetSnippet(book.Description, searchTerm, 20) ' Corrected
        ElseIf book.Genre IsNot Nothing AndAlso book.Genre.IndexOf(searchTerm, options) >= 0 Then
            Return "Match in Genre" ' Corrected: No $
        End If

        Return "" ' No match found
    End Function

    ' --- Helper to get a snippet around the search term ---
    ' --- CORRECTION for BC32034: Removed default value from signature ---
    Private Function GetSnippet(text As String, searchTerm As String, contextLength As Integer) As String ' Removed "= 20"
        If String.IsNullOrWhiteSpace(text) OrElse String.IsNullOrWhiteSpace(searchTerm) Then Return ""

        Dim index As Integer = text.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase)
        If index < 0 Then Return ""

        Dim start As Integer = Math.Max(0, index - contextLength)
        Dim length As Integer = Math.Min(text.Length - start, searchTerm.Length + (2 * contextLength))
        Dim snippet As String = text.Substring(start, length)

        If start > 0 Then snippet = "..." & snippet
        If start + length < text.Length Then snippet &= "..."

        Return snippet.Trim()
    End Function

    ' --- Optional Advanced Highlighting for RichTextBox ---
    ' Private Sub HighlightText(rtb As RichTextBox, textToHighlight As String)
    '     If String.IsNullOrWhiteSpace(textToHighlight) OrElse String.IsNullOrWhiteSpace(rtb.Text) Then Return
    '     Dim index As Integer = 0
    '     While index < rtb.TextLength
    '         Dim foundIndex As Integer = rtb.Find(textToHighlight, index, RichTextBoxFinds.None)
    '         If foundIndex = -1 Then Exit While
    '         rtb.SelectionStart = foundIndex
    '         rtb.SelectionLength = textToHighlight.Length
    '         rtb.SelectionBackColor = Color.Yellow
    '         index = foundIndex + textToHighlight.Length
    '     End While
    '     rtb.SelectionStart = 0
    '     rtb.SelectionLength = 0
    '     rtb.SelectionBackColor = rtb.BackColor
    ' End Sub

    ' --- Optional: Add Click Event ---
    ' Public Event BookClicked As EventHandler
    ' Private Sub picCover_Click(sender As Object, e As EventArgs) Handles picCover.Click
    '     RaiseEvent BookClicked(Me, e)
    ' End Sub
    ' Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
    '     RaiseEvent BookClicked(Me, e)
    ' End Sub
    ' Private Sub lblMatchInfo_Click(sender As Object, e As EventArgs) Handles lblMatchInfo.Click
    '     RaiseEvent BookClicked(Me, e) ' Also raise event if match info is clicked
    ' End Sub


End Class