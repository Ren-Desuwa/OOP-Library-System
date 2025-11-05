Imports System.IO
Imports System.ComponentModel

Public Class UC_ProfileBookDisplay

    ' This is the main public method.
    ' The UserProfile form will call this and pass in the books.
    Public Sub LoadBooks(books As List(Of Book))
        ' Hide all picture boxes by default
        picBook1.Visible = False
        picBook2.Visible = False
        picBook3.Visible = False

        ' Exit if there are no books
        If books Is Nothing OrElse books.Count = 0 Then
            ' Optional: You could show a "No books selected" label here
            Return
        End If

        ' Apply layouts based on book count
        Select Case books.Count
            Case 1
                ApplyLayout_1_Book(books)
            Case 2
                ApplyLayout_2_Book(books)
            Case Else ' 3 or more (we only care about the first 3)
                ApplyLayout_3_Book(books)
        End Select
    End Sub

    ' --- LAYOUT 1: One Book (like your Figma) ---
    Private Sub ApplyLayout_1_Book(books As List(Of Book))
        ' --- 1. Configure the TableLayoutPanel ---
        tlpMain.SetRowSpan(picBook1, 2)    ' Make picBook1 span 2 rows
        tlpMain.SetColumnSpan(picBook1, 2) ' Make picBook1 span 2 columns

        ' --- 2. Load Image and Show ---
        SetBookImage(picBook1, books(0))
        picBook1.Visible = True
    End Sub

    ' --- LAYOUT 2: Two Books (Stacked, inspired by Figma) ---
    Private Sub ApplyLayout_2_Book(books As List(Of Book))
        ' --- 1. Configure the TableLayoutPanel ---
        ' Book 1: Top, spans 2 columns
        tlpMain.SetRowSpan(picBook1, 1)    ' Reset to 1 row
        tlpMain.SetColumnSpan(picBook1, 2) ' Make picBook1 span 2 columns

        ' Book 2: Bottom, spans 2 columns
        ' We will re-use picBook2 for this
        tlpMain.SetRowSpan(picBook2, 1)
        tlpMain.SetColumnSpan(picBook2, 2)
        ' Move picBook2 to the second row, first column
        tlpMain.SetCellPosition(picBook2, New TableLayoutPanelCellPosition(0, 1))

        ' --- 2. Load Images and Show ---
        SetBookImage(picBook1, books(0))
        SetBookImage(picBook2, books(1))
        picBook1.Visible = True
        picBook2.Visible = True
    End Sub

    ' --- LAYOUT 3: Three Books (Figma) ---
    Private Sub ApplyLayout_3_Book(books As List(Of Book))
        ' --- 1. Configure the TableLayoutPanel ---
        ' Book 1: Top, spans 2 columns
        tlpMain.SetRowSpan(picBook1, 1)
        tlpMain.SetColumnSpan(picBook1, 2) ' Make picBook1 span 2 columns

        ' Book 2: Bottom-Left
        tlpMain.SetRowSpan(picBook2, 1)
        tlpMain.SetColumnSpan(picBook2, 1) ' Reset to 1 column
        ' Move picBook2 to its original cell (0, 1)
        tlpMain.SetCellPosition(picBook2, New TableLayoutPanelCellPosition(0, 1))

        ' Book 3: Bottom-Right
        tlpMain.SetRowSpan(picBook3, 1)
        tlpMain.SetColumnSpan(picBook3, 1) ' Reset to 1 column
        ' Move picBook3 to its original cell (1, 1)
        tlpMain.SetCellPosition(picBook3, New TableLayoutPanelCellPosition(1, 1))


        ' --- 2. Load Images and Show ---
        SetBookImage(picBook1, books(0))
        SetBookImage(picBook2, books(1))
        SetBookImage(picBook3, books(2))
        picBook1.Visible = True
        picBook2.Visible = True
        picBook3.Visible = True
    End Sub

    ' --- Helper function to load the image into a PictureBox ---
    Private Sub SetBookImage(picBox As Guna.UI2.WinForms.Guna2PictureBox, book As Book)
        Try
            Dim coverFileName As String = book.GetCoverFileName()
            Dim coverPath As String = Path.Combine(Application.StartupPath, "..\..\Assets\Bookcover", coverFileName)

            If System.IO.File.Exists(coverPath) Then
                picBox.Image = Image.FromFile(coverPath)
            Else
                ' Use a default image if not found
                picBox.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
            End If
        Catch ex As Exception
            picBox.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        End Try
    End Sub
End Class