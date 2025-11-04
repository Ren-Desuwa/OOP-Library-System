Imports MySql.Data.MySqlClient
Imports System.IO

Public Class editDisplayedBooks


    Private _account As Account

    ' New constructor that accepts Account
    Public Sub New(account As Account)
        InitializeComponent()
        _account = account
    End Sub


    Private Sub editDisplayedBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub


    Private Sub LoadBooks()
        ' Clear the existing FlowLayoutPanel before adding new BookCarts
        FlowLayoutPanel1.Controls.Clear()

        ' --- Database connection string ---
        Dim connStr As String = "server=localhost;userid=root;password=;database=ooplibrary"

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' --- Select all books ---
                Dim query As String = "SELECT * FROM books"
                Using cmd As New MySqlCommand(query, conn)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()

                        While reader.Read()
                            ' --- Create a new BookCart control ---
                            Dim bookUC As New BookCart()


                            ' Set book title
                            bookUC.BookTitleText = reader("title").ToString()

                            ' Store the book_id in Tag for later use
                            bookUC.Tag = Convert.ToInt32(reader("book_id"))

                            ' Load book image
                            Dim imgPath As String = reader("cover_url").ToString()
                            If Not String.IsNullOrEmpty(imgPath) Then
                                Try
                                    If imgPath.StartsWith("http") Then
                                        Using client As New Net.WebClient()
                                            Dim imgBytes As Byte() = client.DownloadData(imgPath)
                                            Using ms As New MemoryStream(imgBytes)
                                                bookUC.BookImagePic = Image.FromStream(ms)
                                            End Using
                                        End Using
                                    ElseIf File.Exists(imgPath) Then
                                        bookUC.BookImagePic = Image.FromFile(imgPath)
                                    Else
                                        bookUC.BookImagePic = My.Resources.Ucc_Logo_NoBG_Big2
                                    End If
                                Catch ex As Exception
                                    bookUC.BookImagePic = My.Resources.Ucc_Logo_NoBG_Big2
                                End Try
                            End If

                            ' Resize checkbox and make image toggle it
                            Dim checkboxes = bookUC.Controls.OfType(Of CheckBox)().ToList()
                            If checkboxes.Count > 0 Then
                                Dim cb = checkboxes(0)
                                cb.AutoSize = False
                                cb.Width = 26
                                cb.Height = 26
                                cb.Font = New Font(cb.Font.FontFamily, 20, FontStyle.Bold)
                                cb.Text = "" ' remove text

                                Dim pictures = bookUC.Controls.OfType(Of PictureBox)().ToList()
                                If pictures.Count > 0 Then
                                    Dim pic = pictures(0)
                                    AddHandler pic.Click, Sub()
                                                              cb.Checked = Not cb.Checked
                                                          End Sub
                                End If
                            End If

                            ' Add extra margin between books
                            bookUC.Margin = New Padding(20)

                            ' Add the control to the FlowLayoutPanel
                            FlowLayoutPanel1.Controls.Add(bookUC)
                        End While

                    End Using
                End Using
            End Using

            ' --- Adjust FlowLayoutPanel padding dynamically after loading all books ---
            If FlowLayoutPanel1.Controls.Count > 0 Then
                Dim bookUCSample = TryCast(FlowLayoutPanel1.Controls(0), BookCart)
                If bookUCSample IsNot Nothing Then
                    Dim itemsPerRow As Integer = Math.Max(1, FlowLayoutPanel1.ClientSize.Width \ (bookUCSample.Width + 20))
                    Dim totalSpacing As Integer = FlowLayoutPanel1.ClientSize.Width - (itemsPerRow * bookUCSample.Width)
                    Dim spacing As Integer = totalSpacing \ (itemsPerRow + 1)
                    FlowLayoutPanel1.Padding = New Padding(spacing, 10, spacing, 10)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint
        ' optional custom drawing
    End Sub

    Private Sub AddToShelf_Click(sender As Object, e As EventArgs) Handles AddToShelf.Click
        ' Get the current user's account_id
        Dim currentAccountId As Integer = _account.AccountID


        ' Database connection string
        Dim connStr As String = "server=localhost;userid=root;password=;database=ooplibrary"

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                For Each ctrl As Control In FlowLayoutPanel1.Controls
                    Dim bookUC As BookCart = TryCast(ctrl, BookCart)
                    If bookUC IsNot Nothing Then
                        Dim cb = bookUC.Controls.OfType(Of CheckBox)().FirstOrDefault()
                        If cb IsNot Nothing AndAlso cb.Checked Then
                            Dim bookId As Integer = Convert.ToInt32(bookUC.Tag)

                            ' Avoid duplicates
                            Dim existsQuery As String = "SELECT COUNT(*) FROM favorites WHERE account_id = @account_id AND book_id = @book_id"
                            Using cmdCheck As New MySqlCommand(existsQuery, conn)
                                cmdCheck.Parameters.AddWithValue("@account_id", currentAccountId)
                                cmdCheck.Parameters.AddWithValue("@book_id", bookId)
                                Dim count As Integer = Convert.ToInt32(cmdCheck.ExecuteScalar())
                                If count = 0 Then
                                    Dim insertQuery As String = "INSERT INTO favorites (account_id, book_id) VALUES (@account_id, @book_id)"
                                    Using cmdInsert As New MySqlCommand(insertQuery, conn)
                                        cmdInsert.Parameters.AddWithValue("@account_id", currentAccountId)
                                        cmdInsert.Parameters.AddWithValue("@book_id", bookId)
                                        cmdInsert.ExecuteNonQuery()
                                    End Using
                                End If
                            End Using

                            ' Optional: uncheck after adding
                            cb.Checked = False
                        End If
                    End If
                Next
            End Using

            MessageBox.Show("Selected books added to your shelf!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error adding to shelf: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
