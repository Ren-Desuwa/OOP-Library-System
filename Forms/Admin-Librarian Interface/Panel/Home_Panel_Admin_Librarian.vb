Imports System.Collections.Generic
Public Class Home_Panel_Admin_Librarian

    'ADD THIS FOR LOGS TAB AND MAKE IT ACCESSIBLE GLOBALLY FOR BEING LOGGED WHEN SYSTEM OPENS (WHEN GUESTVIEW IS OPENED)
    Public logsTab As UC_HPAL_Logs_Tab
    Public pendingLogs As New List(Of String)

    Private Sub btn_Logs_Click(sender As Object, e As EventArgs) Handles btn_Logs.Click
        ' Clear any existing controls in the panel
        pnl_UC_container.Controls.Clear()

        ' Create and store the logs tab instance globally
        logsTab = New UC_HPAL_Logs_Tab()

        ' Make it fill the panel
        logsTab.Dock = DockStyle.Fill

        ' Add the UserControl to the panel
        pnl_UC_container.Controls.Add(logsTab)

        ' --- Flush pending logs ---
        If pendingLogs.Count > 0 Then
            For Each msg In pendingLogs
                logsTab.AppendColoredLog(msg, Color.White)
            Next
            pendingLogs.Clear()
        End If
    End Sub
End Class