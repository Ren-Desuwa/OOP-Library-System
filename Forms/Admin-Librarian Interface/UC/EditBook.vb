' Add these imports for file/directory handling and image handling
Imports System.IO
Imports System.Drawing

Public Class EditBook

    ' ... (Private properties _bookToEdit, BookWasUpdated, etc. are fine) ...
    Private _bookToEdit As Book
    Public BookWasUpdated As Boolean = False
    Private _newSelectedImagePath As String = Nothing
    Private _newCoverFileName As String = Nothing

    Public Sub New(book As Book)
        InitializeComponent()
        _bookToEdit = book
    End Sub

    ''' <summary>
    ''' Runs when the EditBook form loads.
    ''' </summary>
    Private Sub EditBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Populate all the textboxes with the book's data
        txtbox_Title.Text = _bookToEdit.Title
        ' ... (Populate author, year, isbn, description) ...
        txtbox_author.Text = _bookToEdit.Author
        txtbox_yearpublished.Text = _bookToEdit.YearPublished.ToString()
        txtbox_isbn.Text = _bookToEdit.ISBN
        txtbox_description.Text = _bookToEdit.Description

        ' 2. Populate Genres
        If _bookToEdit.Genres IsNot Nothing AndAlso _bookToEdit.Genres.Any() Then
            txtbox_genre.Text = String.Join(", ", _bookToEdit.Genres.Select(Function(g) g.Name))
        End If

        ' --- 3. MODIFIED: Populate Book Count and Condition ---
        ' Re-enable the condition textbox
        txtbox_condition.Enabled = True

        Try
            ' Get all copies to find the count and default condition
            Dim copies As List(Of BookCopy) = Program.CatSvc.GetBookCopies(_bookToEdit.BookID)

            ' Set the count in the (assumed) book count textbox
            txtbox_bookcount.Text = copies.Count.ToString()

            ' Set the condition from the first copy, or "Good" if none exist
            txtbox_condition.Text = If(copies.Any(), copies.First().Condition, "Good")

        Catch ex As Exception
            ' Fallback if copies can't be loaded
            txtbox_bookcount.Text = "1"
            txtbox_condition.Text = "Good"
            Debug.WriteLine("Error loading book copies: " & ex.Message)
        End Try

        ' 4. Load the existing cover image
        ' ... (Your existing image loading code is fine) ...
        Try
            Dim startupPath As String = Application.StartupPath
            Dim projectRoot As String = Directory.GetParent(startupPath).Parent.FullName
            Dim imagePath As String = Path.Combine(projectRoot, "Assets", "Bookcover", _bookToEdit.GetCoverFileName())

            If File.Exists(imagePath) Then
                picbox.Image = Image.FromFile(imagePath)
            Else
                Dim defaultPath As String = Path.Combine(projectRoot, "Assets", "Bookcover", "default_cover.png")
                If File.Exists(defaultPath) Then
                    picbox.Image = Image.FromFile(defaultPath)
                End If
            End If
        Catch ex As Exception
            Debug.WriteLine("Error loading book cover: " & ex.Message)
        End Try
    End Sub

    ' ... (picbox_Click event handler is fine) ...
    Private Sub picbox_Click(sender As Object, e As EventArgs) Handles picbox.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select New Book Cover"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    _newSelectedImagePath = ofd.FileName
                    _newCoverFileName = Guid.NewGuid().ToString() & Path.GetExtension(_newSelectedImagePath)
                    picbox.Image = Image.FromFile(_newSelectedImagePath)
                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _newSelectedImagePath = Nothing
                    _newCoverFileName = Nothing
                End Try
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Handles the "Update" button click.
    ''' </summary>
    Private Async Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        ' --- 1. VALIDATION ---
        If String.IsNullOrWhiteSpace(txtbox_Title.Text) Then
            MessageBox.Show("Please enter a Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' ... (add author validation) ...

        ' Validate Year Published
        Dim yearInt As Integer
        If Not Integer.TryParse(txtbox_yearpublished.Text, yearInt) OrElse txtbox_yearpublished.Text.Length <> 4 Then
            MessageBox.Show("Please enter a valid 4-digit year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- VALIDATION for Book Count and Condition ---
        Dim copiesInt As Integer
        If Not Integer.TryParse(txtbox_bookcount.Text, copiesInt) OrElse copiesInt < 0 Then ' Allow 0
            MessageBox.Show("Please enter a valid number of copies (0 or more).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If String.IsNullOrWhiteSpace(txtbox_condition.Text) Then
            MessageBox.Show("Please enter a Condition for the copies (e.g., Good, New, Worn).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim newCondition As String = txtbox_condition.Text
        ' --- END OF VALIDATION ---

        ' --- 2. Process Genre(s) ---
        Dim genreString As String = txtbox_genre.Text
        Dim genreNames As List(Of String) = genreString.Split(","c).Select(Function(s) s.Trim()).Where(Function(s) Not String.IsNullOrEmpty(s)).ToList()

        Try
            Me.Cursor = Cursors.WaitCursor

            ' --- 3. HANDLE NEW IMAGE (if one was selected) ---
            If _newSelectedImagePath IsNot Nothing AndAlso _newCoverFileName IsNot Nothing Then
                ' ... (Your existing image copy logic is fine) ...
                Dim startupPath As String = Application.StartupPath
                Dim projectRoot As String = Directory.GetParent(startupPath).Parent.FullName
                Dim destFolder As String = Path.Combine(projectRoot, "Assets", "Bookcover")
                Dim destPath As String = Path.Combine(destFolder, _newCoverFileName)

                File.Copy(_newSelectedImagePath, destPath, True)
                _bookToEdit.CoverUrl = _newCoverFileName
            End If

            ' --- 4. UPDATE THE BOOK OBJECT ---
            _bookToEdit.Title = txtbox_Title.Text
            _bookToEdit.Author = txtbox_author.Text
            _bookToEdit.ISBN = txtbox_isbn.Text
            _bookToEdit.Description = txtbox_description.Text
            _bookToEdit.YearPublished = yearInt

            ' --- 5. CALL THE SERVICE (Now with new parameters) ---
            Dim adminId As Integer? = Program.currentAccount?.AccountID

            Await Task.Run(Sub()
                               ' Call the *modified* service method
                               Program.CatSvc.UpdateBookDetails(
                                   book:=_bookToEdit,
                                   genreNames:=genreNames,
                                   newCopyCount:=copiesInt, ' <-- PASS THE NEW COUNT
                                   newCondition:=newCondition, ' <-- PASS THE NEW CONDITION
                                   adminAccountId:=adminId
                               )
                           End Sub)

            ' --- 6. FINISH ---
            Me.Cursor = Cursors.Default
            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.BookWasUpdated = True
            Me.Close()

        Catch ex As Exception
            Me.Cursor = Cursors.Default
            ' This will now show our custom error message if copies are in use!
            MessageBox.Show("Error updating book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class