Imports System.IO
Imports System.Linq

Public Class Book_PopUP

    ' This will store the book object that is passed in
    Private _book As Book

    ''' <summary>
    ''' This is the new constructor.
    ''' It accepts a Book object AND a flag for guest mode.
    ''' </summary>
    Public Sub New(ByVal book As Book, ByVal isGuest As Boolean)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the book object in the form-level variable
        Me._book = book

        ' --- 1. Populate the Title Panel ---
        lbl_book_title.Text = book.Title
        lblAuthorData.Text = "by " & book.Author

        ' --- 2. Populate the TableLayoutPanel ---
        If book.Genres IsNot Nothing AndAlso book.Genres.Any() Then
            lblGenreData.Text = String.Join(", ", book.Genres.Select(Function(g) g.Name))
        Else
            lblGenreData.Text = "N/A"
        End If

        lblPublisherData.Text = If(Not String.IsNullOrWhiteSpace(book.Publisher), book.Publisher, "N/A")
        lblYearData.Text = If(book.YearPublished > 0, book.YearPublished.ToString(), "N/A")
        lblISBNData.Text = If(Not String.IsNullOrWhiteSpace(book.ISBN), book.ISBN, "N/A")

        ' --- 3. Set Book Description ---
        If String.IsNullOrWhiteSpace(book.Description) Then
            lblDescription.Text = "No description available for this book."
        Else
            lblDescription.Text = book.Description
        End If

        ' --- 4. NEW LOGIC: Hide buttons if user is a guest ---
        If isGuest Then
            btn_Borrow.Visible = False
            btn_AddtoCart.Visible = False
            ' You may also want to hide the status label
            lblStatus.Visible = False
            Label6.Visible = False ' This is the "Status:" text label
        Else
            ' This is the normal logic for a logged-in student
            btn_Borrow.Visible = True
            btn_AddtoCart.Visible = True
            lblStatus.Visible = True
            Label6.Visible = True

            If book.AvailableCopies > 0 Then
                lblStatus.Text = $"Available ({book.AvailableCopies} Copies)"
                lblStatus.ForeColor = System.Drawing.Color.ForestGreen
                btn_Borrow.Enabled = True
                btn_AddtoCart.Enabled = True
            Else
                lblStatus.Text = "Not Available"
                lblStatus.ForeColor = System.Drawing.Color.Firebrick
                btn_Borrow.Enabled = False
                btn_AddtoCart.Enabled = False
            End If
        End If

        ' --- 5. Load the book cover image ---
        Try
            Dim coverFileName As String = book.GetCoverFileName()
            Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

            If System.IO.File.Exists(coverPath) Then
                picbox_book.Image = Image.FromFile(coverPath)
            Else
                picbox_book.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
            End If
        Catch ex As Exception
            picbox_book.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        End Try
    End Sub

    ''' <summary>
    ''' 3. Handles the "Borrow" button click.
    ''' </summary>
    Private Sub btn_Borrow_Click(sender As Object, e As EventArgs) Handles btn_Borrow.Click
        ' TODO: Add your borrow logic here
        MessageBox.Show("Borrow logic for '" & _book.Title & "' goes here.")
        ' Example: Program.BorrowSvc.BorrowBook(currentUser.ID, _book.BookID)

        Me.Close()
    End Sub

    ''' <summary>
    ''' 4. Handles the "Add to Cart" button click.
    ''' </summary>
    Private Sub btn_AddtoCart_Click(sender As Object, e As EventArgs) Handles btn_AddtoCart.Click
        ' --- ADDED THIS LINE ---
        ' Add the book (stored in Me._book) to the central cart service
        Program.CartSvc.AddToCart(Me._book)
        ' --- END OF ADDITION ---

        messagedialogAdded.Show("Successfully Added to Cart.", "Success")
    End Sub

    ''' <summary>
    ''' 5. Handles the "X" (Close) button click.
    ''' </summary>
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' 6. Handles the form losing focus (clicking "outside").
    ''' </summary>
    Private Sub Book_PopUP_Deactivate(sender As Object, e As EventArgs) Handles Me.Deactivate
        ' This event fires when the user clicks onto another window,
        ' effectively "clicking outside" the popup.
        Me.Close()
    End Sub
End Class