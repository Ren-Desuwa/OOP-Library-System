Public Class Home_Panel_Admin_Librarian
    Private Sub btn_Logs_Click(sender As Object, e As EventArgs) Handles btn_Logs.Click
        ' Clear any existing controls in the panel
        pnl_UC_container.Controls.Clear()

        ' Create a new instance of your Logs UserControl
        Dim logsTab As New UC_HPAL_Logs_Tab()

        ' Make it fill the panel
        logsTab.Dock = DockStyle.Fill

        ' Add the UserControl to the panel
        pnl_UC_container.Controls.Add(logsTab)
    End Sub
End Class