Imports System.IO
Imports MySql.Data.MySqlClient

Public Class BooksFromProfile

    Private _account As Account

    ' Constructor that accepts the logged-in account
    Public Sub New(account As Account)
        InitializeComponent()
        _account = account
    End Sub

    Public Sub LoadBooks()
        FlowLayoutPanel1.Controls.Clear()

        Dim connStr As String = "server=localhost;userid=root;password=;database=ooplibrary"

        Try
            Using conn As New MySqlConnection(connStr)
                conn.Open()

                ' Get only the user's favorite books
                Dim query As String =
                    "SELECT b.* FROM books b " &
                    "INNER JOIN favorites f ON b.book_id = f.book_id " &
                    "WHERE f.account_id = @account_id"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@account_id", _account.AccountID)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim bookUC As New BookCart()

                            bookUC.BookTitleText = reader("title").ToString()

                            ' Load image
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
                            Else
                                bookUC.BookImagePic = My.Resources.Ucc_Logo_NoBG_Big2
                            End If

                            For Each cb As CheckBox In bookUC.Controls.OfType(Of CheckBox)()
                                cb.Visible = False
                            Next

                            bookUC.Margin = New Padding(10)
                            FlowLayoutPanel1.Controls.Add(bookUC)
                        End While
                    End Using
                End Using
            End Using

            FlowLayoutPanel1.WrapContents = True
            FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
            FlowLayoutPanel1.AutoScroll = True
            FlowLayoutPanel1.Padding = New Padding(20)

            For Each bookUC As BookCart In FlowLayoutPanel1.Controls
                bookUC.Margin = New Padding(10, 10, 10, 30) ' bottom spacing for shelf
            Next

        Catch ex As Exception
            MessageBox.Show("Error loading favorite books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BooksFromProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooks()
    End Sub
End Class
