Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Runtime.InteropServices

Public Class UC_HPAL_Logs_Tab

    ' === Add internal padding for RichTextBox ===
    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) As IntPtr
    End Function

    Private Const EM_SETMARGINS As Integer = &HD3
    Private Const EC_LEFTMARGIN As Integer = &H1
    Private Const EC_RIGHTMARGIN As Integer = &H2

    Private Sub UC_HPAL_Logs_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupConsoleBox()
        LoadLogsFromDatabase()
    End Sub

    ' 🟩 Setup RichTextBox for Console Look (updated font)
    Private Sub SetupConsoleBox()
        With RichTextBoxLogs
            .Multiline = True
            .ReadOnly = True
            .Dock = DockStyle.Fill
            .BackColor = Color.Bisque
            .ForeColor = Color.Black
            .Font = New Font("Consolas", GetResponsiveFontSize(), FontStyle.Regular) ' font is now bigger
            .BorderStyle = BorderStyle.None
            .ScrollBars = RichTextBoxScrollBars.Vertical
            .WordWrap = False
        End With

        ' 🟫 Add left/right padding inside RichTextBox
        SendMessage(RichTextBoxLogs.Handle, EM_SETMARGINS,
                CType(EC_LEFTMARGIN Or EC_RIGHTMARGIN, IntPtr),
                CType((20 << 16) Or 20, IntPtr)) ' Left=20px, Right=20px
    End Sub

    ' 🟨 Responsive Font Scaling (increased base font size)
    Private Function GetResponsiveFontSize() As Single
        Dim baseSize As Single = 14 ' ↑ increased from 11 to 14 for bigger text
        Dim scaleFactor As Single = Me.Width / 900.0F
        Dim newSize As Single = baseSize * scaleFactor
        If newSize < 12 Then newSize = 12
        If newSize > 20 Then newSize = 24
        Return newSize
    End Function

    Private Sub UC_HPAL_Logs_Tab_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Try
            Dim zoomLevel As Single = Me.Width / 900.0F
            If zoomLevel < 0.8F Then zoomLevel = 0.8F
            If zoomLevel > 1.4F Then zoomLevel = 1.4F
            RichTextBoxLogs.ZoomFactor = zoomLevel
        Catch
            ' Ignore any rare RichTextBox scaling errors
        End Try
    End Sub

    ' 🟦 Load Logs from Database
    Private Sub LoadLogsFromDatabase()
        Try
            Dim connStr As String = "Server=localhost;Database=ooplibrary;Uid=root;Pwd=;SslMode=None;"
            Dim query As String = "
                SELECT 
                    logs.account_id,
                    accounts.username,
                    logs.action,
                    logs.details,
                    logs.severity,
                    logs.timestamp
                FROM logs
                INNER JOIN accounts ON logs.account_id = accounts.account_id
                ORDER BY logs.timestamp DESC
                LIMIT 100
            "

            Using conn As New MySqlConnection(connStr)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        RichTextBoxLogs.Clear()

                        While reader.Read()
                            Dim timestamp = Convert.ToDateTime(reader("timestamp")).ToString("yyyy-MM-dd HH:mm:ss")
                            Dim accountId = reader("account_id").ToString()
                            Dim username = reader("username").ToString()
                            Dim action = reader("action").ToString()
                            Dim details = reader("details").ToString()
                            Dim severity = reader("severity").ToString().ToLower()

                            Dim severityColor As Color = Color.Lime
                            Select Case severity
                                Case "error" : severityColor = Color.Red
                                Case "warning", "warn" : severityColor = Color.Yellow
                                Case "info" : severityColor = Color.DeepSkyBlue
                            End Select

                            ' Construct log line with colors
                            AppendColoredLog("[", Color.DimGray)
                            AppendColoredLog(timestamp, Color.Gray)
                            AppendColoredLog("] ", Color.DimGray)

                            AppendColoredLog("(ID:", Color.DimGray)
                            AppendColoredLog(accountId, Color.Orange)
                            AppendColoredLog(" | ", Color.DimGray)
                            AppendColoredLog(username, Color.MediumTurquoise)
                            AppendColoredLog(") ", Color.DimGray)

                            AppendColoredLog(severity.ToUpper(), severityColor)
                            AppendColoredLog(" → ", Color.DimGray)
                            AppendColoredLog(action & ": ", Color.LightGreen)
                            AppendColoredLog(details, Color.LightGray)

                            RichTextBoxLogs.AppendText(Environment.NewLine)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            AppendColoredLog("[Error] Failed to load logs: " & ex.Message, Color.Black)
        End Try
    End Sub

    ' 🟥 Append Text with Color
    Public Sub AppendColoredLog(text As String, color As Color)
        RichTextBoxLogs.SelectionStart = RichTextBoxLogs.TextLength
        RichTextBoxLogs.SelectionLength = 0
        RichTextBoxLogs.SelectionColor = color
        RichTextBoxLogs.AppendText(text)
        RichTextBoxLogs.SelectionColor = RichTextBoxLogs.ForeColor
    End Sub

    ' 🕒 Timer for Live Clock
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.Now.ToString("MMM dd, yyyy | hh:mm:ss tt")
        Label2.Font = New Font("Century Gothic", 10.0!, FontStyle.Bold)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBoxLogs_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub RichTextBoxLogs_TextChanged_1(sender As Object, e As EventArgs) Handles RichTextBoxLogs.TextChanged

    End Sub
End Class
