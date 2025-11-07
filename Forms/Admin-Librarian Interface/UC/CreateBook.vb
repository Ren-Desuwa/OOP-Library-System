' Add these imports for file/directory handling and image handling
Imports System.IO
Imports System.Drawing

Public Class CreateBook

    ' --- ADDED THIS NEW PROPERTY ---
    Public BookWasCreated As Boolean = False
    ' --- END OF NEW PROPERTY ---

    ' Stores the full path of the user's selected image
    Private _selectedImagePath As String = Nothing
    ' Stores the new, unique filename we will save
    Private _newCoverFileName As String = Nothing

    Private Sub CreateBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- REMOVED THIS LINE ---
        ' Me.DialogResult = DialogResult.Cancel
    End Sub

    ''' <summary>
    ''' Handles clicking the image button to browse for a cover.
    ''' </summary>
    Private Sub picbox_Click(sender As Object, e As EventArgs) Handles picbox.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select Book Cover"
            ' Filter for common image files
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' Store the full path of the original file (e.g., "C:\Users\You\Desktop\my_book.png")
                    _selectedImagePath = ofd.FileName

                    ' Create a unique filename to avoid conflicts in the assets folder
                    ' e.g., "a1b2c3d4-e5f6-....png"
                    _newCoverFileName = Guid.NewGuid().ToString() & Path.GetExtension(_selectedImagePath)

                    ' Display the selected image in the picture box
                    picbox.Image = Image.FromFile(_selectedImagePath)

                Catch ex As Exception
                    MessageBox.Show("Error loading image: " & ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    _selectedImagePath = Nothing
                    _newCoverFileName = Nothing
                End Try
            End If
        End Using
    End Sub

    ''' <summary>
    ''' Handles the "Create" button click.
    ''' </summary>
    Private Async Sub btn_Create_Click(sender As Object, e As EventArgs) Handles btn_Create.Click
        ' --- 1. VALIDATION ---
        If String.IsNullOrWhiteSpace(txtbox_Title.Text) Then '
            MessageBox.Show("Please enter a Title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtbox_author.Text) Then '
            MessageBox.Show("Please enter an Author.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtbox_yearpublished.Text) Then '
            MessageBox.Show("Please enter a Year Published.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtbox_condition.Text) Then '
            MessageBox.Show("Please enter a Condition.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If _selectedImagePath Is Nothing OrElse _newCoverFileName Is Nothing Then
            MessageBox.Show("Please select a cover image.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Validate Year Published
        Dim yearInt As Integer
        If Not Integer.TryParse(txtbox_yearpublished.Text, yearInt) OrElse txtbox_yearpublished.Text.Length <> 4 Then '
            MessageBox.Show("Please enter a valid 4-digit year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. GET MISSING DATA (Initial Copies) ---
        ' Your form does not have a textbox for this, so we use an InputBox.
        Dim copiesStr As String = InputBox("Enter number of initial copies:", "Initial Copies", "1")
        Dim copiesInt As Integer
        If Not Integer.TryParse(copiesStr, copiesInt) OrElse copiesInt <= 0 Then
            MessageBox.Show("Please enter a valid number of copies (1 or more).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. VALIDATE NEW BOOK COUNT (Using your new textbox) ---
        ' (Assuming your new textbox is named txtbox_bookcount)
        If Not Integer.TryParse(txtbox_bookcount.Text, copiesInt) OrElse copiesInt <= 0 Then
            MessageBox.Show("Please enter a valid number of copies (1 or more).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 3. Process Genre(s) ---
        Dim genreString As String = txtbox_genre.Text '
        ' Split the string by commas, trim whitespace, and remove any empty entries
        Dim genreNames As List(Of String) = genreString.Split(","c).Select(Function(s) s.Trim()).Where(Function(s) Not String.IsNullOrEmpty(s)).ToList()

        Try
            ' --- 4. COPY THE IMAGE FILE ---
            ' Get the path to your "bin/Debug" folder
            Dim startupPath As String = Application.StartupPath
            ' Go up two levels to the project root (e.g., from "bin/Debug" to "OOP_Library_System")
            Dim projectRoot As String = Directory.GetParent(startupPath).Parent.FullName
            ' Combine with the Assets/Bookcover folder
            Dim destFolder As String = Path.Combine(projectRoot, "Assets", "Bookcover")

            ' Ensure the destination directory exists
            If Not Directory.Exists(destFolder) Then
                Directory.CreateDirectory(destFolder)
            End If

            ' Create the full destination path (e.g., ".../Assets/Bookcover/a1b2c3d4-....png")
            Dim destPath As String = Path.Combine(destFolder, _newCoverFileName)

            ' Copy the file
            File.Copy(_selectedImagePath, destPath, True)

            ' --- 5. CREATE THE BOOK OBJECT ---
            Dim newBook As New Book With {
                .Title = txtbox_Title.Text, '
                .Author = txtbox_author.Text, '
                .ISBN = txtbox_isbn.Text, '
                .Description = txtbox_description.Text, '
                .CoverUrl = _newCoverFileName, ' Just the new, unique filename
                .YearPublished = yearInt
            }

            ' --- 6. CALL THE SERVICE ---
            Dim adminId As Integer? = Program.currentAccount?.AccountID
            Me.Cursor = Cursors.WaitCursor ' Show a loading cursor

            ' Run the database logic on a background thread
            Await Task.Run(Sub()
                               ' Call the *new* service method
                               Program.CatSvc.AddNewBook(
                                   book:=newBook,
                                   genreNames:=genreNames, ' <-- Pass the string list
                                   initialCopies:=copiesInt,
                                   shelfLocation:="N/A", ' <-- Hardcoded as requested
                                   condition:=txtbox_condition.Text, '
                                   adminAccountId:=adminId
                               )
                           End Sub)

            ' --- 7. FINISH ---
            Me.Cursor = Cursors.Default
            MessageBox.Show("Book created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' --- SET THE SUCCESS FLAG ---
            Me.BookWasCreated = True

            ' --- REMOVED THIS LINE ---
            ' Me.DialogResult = DialogResult.OK

            ' This will now trigger the 'HandleCreateFormClosed' event
            Me.Close()

        Catch ex As Exception
            ' Handle errors (e.g., database error, file copy error)
            Me.Cursor = Cursors.Default
            MessageBox.Show("Error creating book: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ''' <summary>
    ''' Handles the "Cancel" button click.
    ''' </summary>
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ' --- REMOVED THIS LINE ---
        ' Me.DialogResult = DialogResult.Cancel

        ' This will now trigger the 'HandleCreateFormClosed' event
        Me.Close()
    End Sub
End Class