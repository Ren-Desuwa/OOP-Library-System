' REMOVED: Imports MySql.Data.MySqlClient
Imports System.IO

Public Class editDisplayedBooks

    Private _account As Account
    ' --- NEW: List to track *only* the checked books ---
    Private selectedBookCarts As New List(Of BookCart)

    ' Constructor
    Public Sub New(account As Account)
        InitializeComponent()
        _account = account
    End Sub

    ' --- This runs when the form loads ---
    Private Sub editDisplayedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllBooks()
    End Sub

    ' --- Loads ALL books and pre-selects the user's chosen 3 ---
    Private Sub LoadAllBooks()
        FlowLayoutPanel1.Controls.Clear()
        selectedBookCarts.Clear()

        ' --- 1. NEW LOGIC: Get the user's currently saved displayed book IDs via Service ---
        Dim usersDisplayedBooks As New HashSet(Of Integer)
        Try
            ' Calls the new service method
            usersDisplayedBooks = Program.AccountSvc.GetUsersDisplayedBookIds(_account.AccountID)
        Catch ex As Exception
            MessageBox.Show("Error loading currently displayed books: " & ex.Message, "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ' Continue loading all books, but none will be pre-checked
        End Try

        ' --- 2. Load ALL books using the Catalogue Service ---
        Try
            Dim allBooks As List(Of Book) = Program.CatSvc.GetAllBooks()

            For Each book As Book In allBooks
                Dim bookUC As New BookCart()
                Dim bookId As Integer = book.BookID

                bookUC.BookTitleText = book.Title
                bookUC.Tag = bookId ' Store book_id

                ' --- Load Image (unchanged file logic) ---
                Try
                    Dim coverFileName As String = book.GetCoverFileName()
                    Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)
                    If File.Exists(coverPath) Then
                        bookUC.BookImagePic = Image.FromFile(coverPath)
                    End If
                Catch ex As Exception
                    ' Use default image on error
                End Try

                ' --- Add the click event handler ---
                AddHandler bookUC.BookCheckBox.CheckedChanged, AddressOf OnBookCheckedChanged

                ' --- Pre-check the box if it's one of the user's saved books ---
                If usersDisplayedBooks.Contains(bookId) Then
                    bookUC.BookCheckBox.Checked = True
                End If

                bookUC.Margin = New Padding(10)
                FlowLayoutPanel1.Controls.Add(bookUC)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading all books: " & ex.Message, "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- NEW: This event enforces the 3-book limit (No changes here) ---
    Private Sub OnBookCheckedChanged(sender As Object, e As EventArgs)
        Dim checkbox = CType(sender, CheckBox)
        Dim bookCard = CType(checkbox.Parent, BookCart)

        If checkbox.Checked Then
            If selectedBookCarts.Count >= 3 Then
                MessageBox.Show("You can only select a maximum of 3 books to display.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                checkbox.Checked = False
                Return
            End If
            If Not selectedBookCarts.Contains(bookCard) Then
                selectedBookCarts.Add(bookCard)
            End If
        Else
            If selectedBookCarts.Contains(bookCard) Then
                selectedBookCarts.Remove(bookCard)
            End If
        End If
    End Sub

    ' --- NEW: This is the "Confirm" button handler ---
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click

        ' 1. Prepare data (extract only the Book IDs)
        Dim newBookIds As New List(Of Integer)
        For Each bookCard As BookCart In selectedBookCarts
            newBookIds.Add(CType(bookCard.Tag, Integer))
        Next

        Try
            ' 2. NEW LOGIC: Call the Service to perform the transactional save (DELETE then INSERT)
            Program.AccountSvc.SaveDisplayedBooks(_account.AccountID, newBookIds)

            MessageBox.Show("Displayed books updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = DialogResult.OK ' Set result to OK
            Me.Close() ' Close the form

        Catch ex As Exception
            ' The service handles the transaction/rollback, UI just shows the error
            MessageBox.Show("Error saving changes: " & ex.Message, "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' --- This is the "X" (Close) button (No changes here) ---
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class