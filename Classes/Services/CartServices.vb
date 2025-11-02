Imports System.Linq

''' <summary>
''' A globally accessible, shared service to manage the student's book cart.
''' </summary>
Public Class CartService
    ' This list holds the books. It's "Shared" so all forms see the same list.
    Private Shared _cart As New List(Of Book)

    ''' <summary>
    ''' Adds a book to the cart. Prevents duplicates.
    ''' </summary>
    Public Sub AddToCart(book As Book)
        If book Is Nothing Then Return

        ' Check if the book (by ID) is already in the cart
        If Not _cart.Any(Function(b) b.BookID = book.BookID) Then
            _cart.Add(book)
        End If
    End Sub

    ''' <summary>
    ''' Removes a specific book from the cart.
    ''' </summary>
    Public Sub RemoveFromCart(book As Book)
        If book Is Nothing Then Return

        ' Find the book in the cart by its ID and remove it
        Dim bookInCart = _cart.FirstOrDefault(Function(b) b.BookID = book.BookID)
        If bookInCart IsNot Nothing Then
            _cart.Remove(bookInCart)
        End If
    End Sub

    ''' <summary>
    ''' Returns the complete list of books currently in the cart.
    ''' </summary>
    Public Function GetCartItems() As List(Of Book)
        Return _cart
    End Function

    ''' <summary>
    ''' Empties the entire cart.
    ''' </summary>
    Public Sub ClearCart()
        _cart.Clear()
    End Sub
End Class