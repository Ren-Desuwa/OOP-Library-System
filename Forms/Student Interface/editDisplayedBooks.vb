Imports MySql.Data.MySqlClient
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

        Dim connStr As String = "server=localhost;userid=root;password=;database=ooplibrary"
        ' --- Get the user's currently saved displayed books ---
        Dim usersDisplayedBooks As New HashSet(Of Integer)
        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()
                Dim query As String = "SELECT book_id FROM displayed_books WHERE account_id = @account_id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@account_id", _account.AccountID)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            usersDisplayedBooks.Add(reader.GetInt32("book_id"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading displayed books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' --- NEW: Load ALL books using the Catalogue Service ---
        Try
            ' ---
            ' --- THIS IS THE CORRECTED LINE ---
            ' ---
            Dim allBooks As List(Of Book) = Program.CatSvc.GetAllBooks()

            For Each book As Book In allBooks
                Dim bookUC As New BookCart()
                Dim bookId As Integer = book.BookID

                bookUC.BookTitleText = book.Title
                bookUC.Tag = bookId ' Store book_id

                ' --- Load Image (using GetCoverFileName from Book.vb) ---
                Try
                    Dim coverFileName As String = book.GetCoverFileName()
                    Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)
                    If File.Exists(coverPath) Then
                        bookUC.BookImagePic = Image.FromFile(coverPath)
                    Else
                        ' Optional: Set a default image if cover is missing
                        ' bookUC.BookImagePic = My.Resources.default_cover
                    End If
                Catch ex As Exception
                    ' Use default image on error
                End Try

                ' --- Add the click event handler ---
                AddHandler bookUC.BookCheckBox.CheckedChanged, AddressOf OnBookCheckedChanged

                ' --- Pre-check the box if it's one of the user's saved books ---
                If usersDisplayedBooks.Contains(bookId) Then
                    bookUC.BookCheckBox.Checked = True
                    ' The event handler will add it to 'selectedBookCarts'
                End If

                bookUC.Margin = New Padding(10)
                FlowLayoutPanel1.Controls.Add(bookUC)
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading all books: " & ex.Message, "Service Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- NEW: This event enforces the 3-book limit ---
    Private Sub OnBookCheckedChanged(sender As Object, e As EventArgs)
        Dim checkbox = CType(sender, CheckBox)
        ' Get the parent BookCart control
        Dim bookCard = CType(checkbox.Parent, BookCart)

        If checkbox.Checked Then
            ' --- User is CHECKING a book ---
            If selectedBookCarts.Count >= 3 Then
                ' Too many! Show error and uncheck it.
                MessageBox.Show("You can only select a maximum of 3 books to display.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                checkbox.Checked = False
                Return
            End If
            ' Add to our list
            If Not selectedBookCarts.Contains(bookCard) Then
                selectedBookCarts.Add(bookCard)
            End If
        Else
            ' --- User is UNCHECKING a book ---
            ' Remove from our list
            If selectedBookCarts.Contains(bookCard) Then
                selectedBookCarts.Remove(bookCard)
            End If
        End If
    End Sub

    ' --- NEW: This is the "Confirm" button ---
    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Dim connStr As String = "server=localhost;userid=root;password=;database=ooplibrary"

        Using conn As New MySqlConnection(connStr)
            conn.Open()
            ' Use a transaction to delete all, then add all
            Using transaction As MySqlTransaction = conn.BeginTransaction()
                Try
                    ' 1. Delete all old entries for this user
                    Dim deleteQuery As String = "DELETE FROM displayed_books WHERE account_id = @account_id"
                    Using cmdDelete As New MySqlCommand(deleteQuery, conn, transaction)
                        cmdDelete.Parameters.AddWithValue("@account_id", _account.AccountID)
                        cmdDelete.ExecuteNonQuery()
                    End Using

                    ' 2. Insert the new selected books (up to 3)
                    Dim insertQuery As String = "INSERT INTO displayed_books (account_id, book_id, display_order) VALUES (@account_id, @book_id, @order)"
                    Dim order As Integer = 1
                    For Each bookCard As BookCart In selectedBookCarts
                        Dim bookId As Integer = CType(bookCard.Tag, Integer)
                        Using cmdInsert As New MySqlCommand(insertQuery, conn, transaction)
                            cmdInsert.Parameters.AddWithValue("@account_id", _account.AccountID)
                            cmdInsert.Parameters.AddWithValue("@book_id", bookId)
                            cmdInsert.Parameters.AddWithValue("@order", order)
                            cmdInsert.ExecuteNonQuery()
                            order += 1
                        End Using
                    Next

                    ' 3. Commit the changes
                    transaction.Commit()
                    MessageBox.Show("Displayed books updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DialogResult = DialogResult.OK ' Set result to OK
                    Me.Close() ' Close the form

                Catch ex As Exception
                    ' Something went wrong, roll back
                    transaction.Rollback()
                    MessageBox.Show("Error saving changes: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    ' --- This is the "X" (Close) button ---
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class