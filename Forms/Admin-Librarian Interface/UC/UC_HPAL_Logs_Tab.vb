Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class UC_HPAL_Logs_Tab
    Private Sub UC_HPAL_Logs_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLogs()
        ResizeGridAppearance()
        MakeGridLookLikeConsole()
        ColorColumns()

        ' Make all columns unsortable and unresizable in a DataGridView
        For Each col As DataGridViewColumn In DataGridLogs.Columns
            col.SortMode = DataGridViewColumnSortMode.NotSortable
            col.Resizable = DataGridViewTriState.False
        Next

        ' Optional: prevent users from resizing column headers
        DataGridLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing

        ' 🟩 Resize "Account ID" column (since it only has 1–2 digits)
        If DataGridLogs.Columns.Contains("Account ID") Then
            With DataGridLogs.Columns("Account ID")
                .Width = 60                    ' adjust as needed (try 50–70 range)
                .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                .Resizable = DataGridViewTriState.False
            End With
        End If

    End Sub

    Private Sub lbl_username_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FormatGrid()
        With DataGridLogs
            .ReadOnly = True
            .RowHeadersVisible = False
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            ' Row Height
            .RowTemplate.Height = 40

            ' Font Styling
            .ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
            .DefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Regular)

            ' Colors
            .BackgroundColor = Color.White
            .EnableHeadersVisualStyles = False
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 136, 229)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
            .DefaultCellStyle.BackColor = Color.White
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 230, 255)
            .DefaultCellStyle.SelectionForeColor = Color.Black
        End With
    End Sub


    Private Sub LoadLogs()
        Try
            Dim connStr As String = "Server=localhost;Database=ooplibrary;Uid=root;Pwd=;SslMode=None;"
            Dim query As String = "
                SELECT 
                    logs.account_id AS 'Account ID',
                    accounts.username AS 'Username',
                    accounts.role AS 'Role',
                    logs.action AS 'Action',
                    logs.details AS 'Details',
                    logs.severity AS 'Severity',
                    logs.timestamp AS 'Date / Time'
                FROM logs
                INNER JOIN accounts ON logs.account_id = accounts.account_id
                ORDER BY logs.timestamp DESC
                LIMIT 50
            "


            Using conn As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridLogs.DataSource = table
                    End Using
                End Using
            End Using

            FormatGrid()
            MakeGridLookLikeConsole()
            ResizeGridAppearance()
            ColorColumns()

        Catch ex As Exception
            MessageBox.Show("Error loading logs: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadTransactions()
        Try
            Dim connStr As String = "Server=localhost;Database=ooplibrary;Uid=root;Pwd=;SslMode=None;"
            Dim query As String = "
            SELECT 
                transaction_id AS 'Transaction ID',
                account_id AS 'Account ID',
                copy_id AS 'Copy ID',
                transaction_type AS 'Type',
                date_borrowed AS 'Date Borrowed',
                date_due AS 'Date Due',
                date_returned AS 'Date Returned',
                fine AS 'Fine',
                status AS 'Status'
            FROM transactions
            ORDER BY transaction_id DESC
        "

            Using conn As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, conn)
                    Using adapter As New MySqlDataAdapter(cmd)
                        Dim table As New DataTable()
                        adapter.Fill(table)
                        DataGridLogs.DataSource = table
                    End Using
                End Using
            End Using

            MakeGridLookLikeConsole()
            ResizeGridAppearance()

            ' Adjust Account ID column width
            If DataGridLogs.Columns.Contains("Account ID") Then
                With DataGridLogs.Columns("Account ID")
                    .Width = 60
                    .AutoSizeMode = DataGridViewAutoSizeColumnMode.None
                    .Resizable = DataGridViewTriState.False
                End With
            End If

        Catch ex As Exception
            MessageBox.Show("Error loading transactions: " & ex.Message)
        End Try
    End Sub


    Private Sub MakeGridLookLikeConsole()
        With DataGridLogs
            .ReadOnly = True
            .AllowUserToAddRows = False
            .AllowUserToResizeRows = False
            .AllowUserToResizeColumns = False
            .RowHeadersVisible = False
            .ColumnHeadersVisible = False ' ← hides top headers
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .BackColor = Color.FromArgb(33, 33, 33)

            .GridColor = Color.Black
            .BorderStyle = BorderStyle.None

            .DefaultCellStyle.BackColor = Color.Black
            .DefaultCellStyle.ForeColor = Color.Lime
            .DefaultCellStyle.SelectionBackColor = Color.Black
            .DefaultCellStyle.SelectionForeColor = Color.Lime

            .DefaultCellStyle.Font = New Font("Consolas", 11, FontStyle.Regular) ' Terminal font

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
            .DefaultCellStyle.WrapMode = DataGridViewTriState.True

            ' Make rows taller for readability
            .RowTemplate.Height = 32

            .ColumnHeadersVisible = True
            .ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 20, 20)
            .ColumnHeadersDefaultCellStyle.ForeColor = Color.Lime
            .ColumnHeadersDefaultCellStyle.Font = New Font("Consolas", 11, FontStyle.Bold)
            .ColumnHeadersHeight = 35

        End With
    End Sub

    Private Sub DataGridLogs_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If DataGridLogs.Columns(e.ColumnIndex).Name = "LogEntry" AndAlso e.Value IsNot Nothing Then
            Dim txt = e.Value.ToString().ToLower()

            If txt.Contains("[error]") Then
                e.CellStyle.ForeColor = Color.Red
            ElseIf txt.Contains("[warning]") Or txt.Contains("[warn]") Then
                e.CellStyle.ForeColor = Color.Yellow
            ElseIf txt.Contains("[info]") Then
                e.CellStyle.ForeColor = Color.White
            Else
                e.CellStyle.ForeColor = Color.Lime ' default
            End If
        End If
    End Sub

    Private Sub ResizeGridAppearance()
        If DataGridLogs.Height <= 0 Then Exit Sub

        ' Get current size before resizing so scaling works again
        Dim currentSize As Single = DataGridLogs.DefaultCellStyle.Font.Size

        ' Scale relative to DataGrid height
        Dim scale As Single = DataGridLogs.Height / 600.0F ' base height reference
        Dim newSize As Single = currentSize * scale

        ' Minimum readable font size
        If newSize < 10 Then newSize = 10

        ' Apply font family but dynamic size
        DataGridLogs.DefaultCellStyle.Font = New Font("Consolas", newSize, FontStyle.Regular)
        DataGridLogs.ColumnHeadersDefaultCellStyle.Font = New Font("Consolas", newSize + 1, FontStyle.Bold)

        ' Row height scales with font
        Dim rowHeight As Integer = CInt(newSize * 2.4)
        If rowHeight < 28 Then rowHeight = 28

        DataGridLogs.RowTemplate.Height = rowHeight

        For Each row As DataGridViewRow In DataGridLogs.Rows
            row.Height = rowHeight
        Next
    End Sub

    Private Sub DataGridLogs_Resize(sender As Object, e As EventArgs)
        ResizeGridAppearance()
    End Sub

    Private Sub ColorColumns()
        If DataGridLogs.Columns.Contains("Action") Then
            DataGridLogs.Columns("Action").DefaultCellStyle.ForeColor = Color.LightGreen
        End If

        If DataGridLogs.Columns.Contains("Details") Then
            DataGridLogs.Columns("Details").DefaultCellStyle.ForeColor = Color.LightGray
        End If

        If DataGridLogs.Columns.Contains("Date/Time") Then
            DataGridLogs.Columns("Date/Time").DefaultCellStyle.ForeColor = Color.DeepSkyBlue
        End If

        If DataGridLogs.Columns.Contains("Severity") Then
            DataGridLogs.Columns("Severity").DefaultCellStyle.ForeColor = Color.OrangeRed
        End If
    End Sub


    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)
        'this is where the UC_announcementbox.vb should be '
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub lblDateTime_Click(sender As Object, e As EventArgs) Handles lblDateTime.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDateTime.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt")
        lblDateTime.Text = DateTime.Now.ToString("hh:mm:ss tt")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Panel1_Paint_1(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub DataGridLogs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
