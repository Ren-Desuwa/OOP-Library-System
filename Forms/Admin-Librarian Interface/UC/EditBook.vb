' Add these imports for file/directory handling and image handling
Imports System.IO
Imports System.Drawing

Public Class EditBook

    ' This will hold the book we are editing
    Private _bookToEdit As Book
    ' This flag will notify the book tab to refresh
    Public BookWasUpdated As Boolean = False

    ' --- NEW VARIABLES FOR IMAGE HANDLING ---
    ' Stores the full path of the user's *newly* selected image
    Private _newSelectedImagePath As String = Nothing
    ' Stores the new, unique filename we will save
    Private _newCoverFileName As String = Nothing

    ''' <summary>
    ''' A new constructor that requires a Book object to be passed in.
    ''' </summary>
    Public Sub New(book As Book)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the book
        _bookToEdit = book
    End Sub

    ''' <summary>
    ''' Runs when the EditBook form loads.
    ''' </summary>
    Private Sub EditBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Populate all the textboxes with the book's data
        txtbox_Title.Text = _bookToEdit.Title
        txtbox_author.Text = _bookToEdit.Author
        txtbox_yearpublished.Text = _bookToEdit.YearPublished.ToString()
        txtbox_isbn.Text = _bookToEdit.ISBN
        txtbox_description.Text = _bookToEdit.Description

        ' 2. Populate Genres
        ' Convert the List(Of Genre) into a single comma-separated string
        If _bookToEdit.Genres IsNot Nothing AndAlso _bookToEdit.Genres.Any() Then
            txtbox_genre.Text = String.Join(", ", _bookToEdit.Genres.Select(Function(g) g.Name))
        End If

        ' 3. Populate Condition
        ' NOTE: "Condition" is a property of a *BookCopy*, not the main *Book*.
        ' This form edits the main book details. Editing individual copies
        ' would be a different "Manage Copies" screen.
        ' For now, we will disable this textbox.
        txtbox_condition.Text = "(Varies by copy)"
        txtbox_condition.Enabled = False

        ' 4. Load the existing cover image
        Try
            ' Get the path to "bin/Debug"
            Dim startupPath As String = Application.StartupPath
            ' Go up two levels to the project root
            Dim projectRoot As String = Directory.GetParent(startupPath).Parent.FullName
            ' Combine with the Assets/Bookcover folder and the book's cover filename
            Dim imagePath As String = Path.Combine(projectRoot, "Assets", "Bookcover", _bookToEdit.GetCoverFileName())

            ' Load the image
            If File.Exists(imagePath) Then
                picbox.Image = Image.FromFile(imagePath)
            Else
                ' Load a default "not found" image if it's missing
                ' (Assuming you have a default_cover.png)
                Dim defaultPath As String = Path.Combine(projectRoot, "Assets", "Bookcover", "default_cover.png")
                If File.Exists(defaultPath) Then
                    picbox.Image = Image.FromFile(defaultPath)
                End If
            End If
        Catch ex As Exception
            ' Handle error if image loading fails
            Debug.WriteLine("Error loading book cover: " & ex.Message)
        End Try
    End Sub

    ''' <summary>
    ''' Handles clicking the image button to select a new cover.
    ''' </summary>
    Private Sub picbox_Click(sender As Object, e As EventArgs) Handles picbox.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select New Book Cover"
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Store the path of the *new* file
                    _newSelectedImagePath = ofd.FileName
                    ' Create a new unique filename for it
                    _newCoverFileName = Guid.NewGuid().ToString() & Path.GetExtension(_newSelectedImagePath)
                    ' Display the new image
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
    ''' Handles the "Update" button click. (Assuming button name is btn_Update)
    ''' </summary>
    Private Async Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Edit.Click
        ' --- 1. VALIDATION ---
        If String.IsNullOrWhiteSpace(txtbox_Title.Text) Then
            MessageBox.Show("Please enter a Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        ' ... (add other validation as needed, e.g., author) ...

        ' Validate Year Published
        Dim yearInt As Integer
        If Not Integer.TryParse(txtbox_yearpublished.Text, yearInt) OrElse txtbox_yearpublished.Text.Length <> 4 Then
            MessageBox.Show("Please enter a valid 4-digit year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. Process Genre(s) ---
        Dim genreString As String = txtbox_genre.Text
        Dim genreNames As List(Of String) = genreString.Split(","c).Select(Function(s) s.Trim()).Where(Function(s) Not String.IsNullOrEmpty(s)).ToList()

        Try
            Me.Cursor = Cursors.WaitCursor

            ' --- 3. HANDLE NEW IMAGE (if one was selected) ---
            If _newSelectedImagePath IsNot Nothing AndAlso _newCoverFileName IsNot Nothing Then
                ' A new image was picked, so we must copy it to Assets
                Dim startupPath As String = Application.StartupPath
                Dim projectRoot As String = Directory.GetParent(startupPath).Parent.FullName
                Dim destFolder As String = Path.Combine(projectRoot, "Assets", "Bookcover")
                Dim destPath As String = Path.Combine(destFolder, _newCoverFileName)

                File.Copy(_newSelectedImagePath, destPath, True)

                ' Update the book object to point to the new image file
                _bookToEdit.CoverUrl = _newCoverFileName
                ' TODO: You could also delete the *old* image file here if it's not "default_cover.png"
            End If

            ' --- 4. UPDATE THE BOOK OBJECT ---
            _bookToEdit.Title = txtbox_Title.Text
            _bookToEdit.Author = txtbox_author.Text
            _bookToEdit.ISBN = txtbox_isbn.Text
            _bookToEdit.Description = txtbox_description.Text
            _bookToEdit.YearPublished = yearInt
            ' (CoverUrl was updated above if a new image was chosen)

            ' --- 5. CALL THE SERVICE ---
            Dim adminId As Integer? = Program.currentAccount?.AccountID

            Await Task.Run(Sub()
                               ' Call the *updated* service method
                               Program.CatSvc.UpdateBookDetails(
                                   book:=_bookToEdit,
                                   genreNames:=genreNames,
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
            MessageBox.Show("Error updating book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the "Cancel" button click.
    ''' </summary>
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class