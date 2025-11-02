Imports System.IO
Imports System.Linq

Public Class ViewCart

    ''' <summary>
    ''' This event runs when the ViewCart form loads.
    ''' It populates the list with real data from the CartService.
    ''' </summary>
    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCartItems()
    End Sub

    ''' <summary>
    ''' Helper sub to load (or reload) all items from the CartService.
    ''' </summary>
    Private Sub PopulateCartItems()
        Flow_BookCartList.Controls.Clear()

        ' Get the list of books from our new global service
        Dim cartBooks As List(Of Book) = Program.CartSvc.GetCartItems()

        If cartBooks.Count = 0 Then
            ' Optional: Add a Label here to say "Your cart is empty."
            Return
        End If

        For Each book As Book In cartBooks
            Dim card As New BookCart()

            ' Use the helper function from Book.vb
            card.BookTitleText = book.GetFullTitle()

            ' --- Load the book cover ---
            Try
                Dim coverFileName As String = book.GetCoverFileName()
                Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

                If System.IO.File.Exists(coverPath) Then
                    card.BookImagePic = Image.FromFile(coverPath)
                Else
                    ' Use a default image if not found
                    card.BookImagePic = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
                End If
            Catch ex As Exception
                card.BookImagePic = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
            End Try

            ' --- CRITICAL: Store the actual Book object in the Tag property. ---
            ' This lets us retrieve the object later in the Remove/Borrow clicks.
            card.Tag = book

            ' add spacing around each card
            card.Margin = New Padding(10)

            Flow_BookCartList.Controls.Add(card)
        Next
    End Sub

    ''' <summary>
    ''' A public method to pass the username from Home_Panel_Students.
    ''' </summary>
    Public Sub SetUsername(name As String)
        lblUsername.Text = name
    End Sub

    ''' <summary>
    ''' This event handles the "Back" button click.
    ''' </summary>
    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Handles the search box text changing.
    ''' </summary>
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbox_search.TextChanged
        ' This search logic is now more effective since the title
        ' loaded in ViewCart.vb contains author and year.
        txtbox_search.PlaceholderText = "Search :"
        Dim keyword As String = txtbox_search.Text.Trim().ToLower()

        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim bookCard As BookCart = DirectCast(ctrl, BookCart)
                Dim title As String = bookCard.BookTitle.Text.ToLower()

                ' Show only if title contains the keyword
                bookCard.Visible = title.Contains(keyword)
            End If
        Next
    End Sub

    ''' <summary>
    ''' Handles the "Borrow" button click.
    ''' </summary>
    Private Sub Guna2ButtonBorrow_Click(sender As Object, e As EventArgs) Handles btn_borrow.Click
        ' Collect BookCart controls and Book objects
        Dim selectedCards As New List(Of BookCart)
        Dim selectedBooks As New List(Of Book) ' Store the actual books

        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                If card.BookCheckBox.Checked Then
                    selectedCards.Add(card)
                    ' Get the book object from the Tag
                    selectedBooks.Add(CType(card.Tag, Book))
                End If
            End If
        Next

        If selectedCards.Count = 0 Then
            MessageBox.Show("Please select at least one book to borrow.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Confirmation message formatting
        Dim bookList As String = String.Join(vbCrLf & "• ", selectedBooks.Select(Function(b) b.Title))
        Dim confirmMsg As String =
            "You are about to borrow the following book(s):" & vbCrLf &
            vbCrLf & "• " & bookList &
            vbCrLf & vbCrLf &
            "Do you want to proceed?"
        Dim confirm As DialogResult = MessageBox.Show(
            confirmMsg,
            "Confirm Borrow",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.No Then Exit Sub

        ' Open BeforeApproval form
        Dim beforeForm As New BeforeApproval()
        beforeForm.lblBookNames.Text = String.Join(", ", selectedBooks.Select(Function(b) b.Title))
        beforeForm.lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        beforeForm.lblTime.Text = Date.Now.ToString("hh:mm tt")
        beforeForm.lblUsername.Text = lblUsername.Text  ' from ViewCart

        beforeForm.ShowDialog()

        ' After 'borrowing', remove items from cart and UI
        For Each card In selectedCards
            Dim bookToRemove As Book = CType(card.Tag, Book)
            ' 1. Remove from the central service
            Program.CartSvc.RemoveFromCart(bookToRemove)
            ' 2. Remove from the UI
            Flow_BookCartList.Controls.Remove(card)
        Next
    End Sub

    ''' <summary>
    ''' Handles the "Remove" button click.
    ''' </summary>
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        ' Collect BookCart controls
        Dim toRemove As New List(Of BookCart)

        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                If card.BookCheckBox.Checked Then
                    toRemove.Add(card)
                End If
            End If
        Next

        ' If nothing is selected
        If toRemove.Count = 0 Then
            MessageBox.Show("Please select at least one book to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Format book titles for message
        Dim bookList As String = String.Join(vbCrLf & "• ", toRemove.Select(Function(c) CType(c.Tag, Book).Title))
        Dim confirmMsg As String =
        "You are about to remove the following book(s):" & vbCrLf &
        vbCrLf & "• " & bookList &
        vbCrLf & vbCrLf &
        "Do you want to proceed?"
        ' Confirmation dialog
        Dim result As DialogResult = MessageBox.Show(
        confirmMsg,
        "Confirm Remove",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        ' Remove books if confirmed
        If result = DialogResult.Yes Then
            For Each card In toRemove
                ' Get the book object from the Tag
                Dim bookToRemove As Book = CType(card.Tag, Book)

                ' 1. Remove from the central service
                Program.CartSvc.RemoveFromCart(bookToRemove)

                ' 2. Remove from the UI
                Flow_BookCartList.Controls.Remove(card)
            Next
            MessageBox.Show("Selected book(s) have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class