Imports System.IO
Imports System.Linq

Public Class ViewCart

    Private Sub ViewCart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateCartItems()
    End Sub

    Private Sub PopulateCartItems()
        Flow_BookCartList.Controls.Clear()

        Dim cartBooks As List(Of Book) = Program.CartSvc.GetCartItems()

        If cartBooks.Count = 0 Then Return

        For Each book As Book In cartBooks
            Dim card As New BookCart()
            card.BookTitleText = book.GetFullTitle()

            ' Load cover image
            Try
                Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", book.GetCoverFileName())
                card.BookImagePic = If(File.Exists(coverPath),
                                       Image.FromFile(coverPath),
                                       Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2)
            Catch
                card.BookImagePic = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
            End Try

            card.Tag = book
            card.Margin = New Padding(10)
            Flow_BookCartList.Controls.Add(card)
        Next
    End Sub

    Public Sub SetUsername(name As String)
        lblUsername.Text = name
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Close()
    End Sub

    Private Sub txtbox_search_TextChanged(sender As Object, e As EventArgs) Handles txtbox_search.TextChanged
        Dim keyword As String = txtbox_search.Text.Trim().ToLower()
        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                card.Visible = card.BookTitleText.ToLower().Contains(keyword)
            End If
        Next
    End Sub

    Private Sub btn_borrow_Click(sender As Object, e As EventArgs) Handles btn_borrow.Click
        Dim selectedCards As New List(Of BookCart)
        Dim selectedBooks As New List(Of Book)

        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                If card.BookCheckBoxControl.Checked Then
                    selectedCards.Add(card)
                    selectedBooks.Add(CType(card.Tag, Book))
                End If
            End If
        Next

        If selectedCards.Count = 0 Then
            MessageBox.Show("Please select at least one book to borrow.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Confirmation message
        Dim bookList As String = String.Join(vbCrLf & "• ", selectedBooks.Select(Function(b) b.Title))
        Dim confirm As DialogResult = MessageBox.Show(
            "You are about to borrow the following book(s):" & vbCrLf & vbCrLf & "• " & bookList & vbCrLf & vbCrLf & "Do you want to proceed?",
            "Confirm Borrow",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.No Then Exit Sub

        ' Open BeforeApproval
        Dim beforeForm As New BeforeApproval()
        beforeForm.BooksToBorrow = selectedBooks
        beforeForm.StudentUsername = lblUsername.Text
        AddHandler beforeForm.BorrowingConfirmed, AddressOf BorrowingWasSuccessful
        beforeForm.ShowDialog()
        RemoveHandler beforeForm.BorrowingConfirmed, AddressOf BorrowingWasSuccessful
    End Sub

    Private Sub BorrowingWasSuccessful()
        ' Remove borrowed books from cart and UI
        Dim cardsToRemove As New List(Of BookCart)
        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                If card.BookCheckBoxControl.Checked Then cardsToRemove.Add(card)
            End If
        Next

        For Each card In cardsToRemove
            Dim book As Book = CType(card.Tag, Book)
            Program.CartSvc.RemoveFromCart(book)
            Flow_BookCartList.Controls.Remove(card)
        Next
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Dim toRemove As New List(Of BookCart)

        For Each ctrl As Control In Flow_BookCartList.Controls
            If TypeOf ctrl Is BookCart Then
                Dim card As BookCart = DirectCast(ctrl, BookCart)
                If card.BookCheckBoxControl.Checked Then toRemove.Add(card)
            End If
        Next

        If toRemove.Count = 0 Then
            MessageBox.Show("Please select at least one book to remove.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim bookList As String = String.Join(vbCrLf & "• ", toRemove.Select(Function(c) CType(c.Tag, Book).Title))
        Dim confirm As DialogResult = MessageBox.Show(
            "You are about to remove the following book(s):" & vbCrLf & vbCrLf & "• " & bookList & vbCrLf & vbCrLf & "Do you want to proceed?",
            "Confirm Remove",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If confirm = DialogResult.Yes Then
            For Each card In toRemove
                Dim book As Book = CType(card.Tag, Book)
                Program.CartSvc.RemoveFromCart(book)
                Flow_BookCartList.Controls.Remove(card)
            Next
            MessageBox.Show("Selected book(s) have been removed successfully.", "Removed", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

End Class
