Public Class UC_HPAL_Request_Tab

    ' Declare your user controls
    Private UserReqUC As New UC_User_Request_Tab()
    Private BorrowReqUC As New UC_Borrow_Request_Tab()

    Private Sub UC_HPAL_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set Dock to fill the RequestsPanels
        UserReqUC.Dock = DockStyle.Fill
        BorrowReqUC.Dock = DockStyle.Fill

        ' Add them to RequestsPanels
        RequestsPanels.Controls.Add(UserReqUC)
        RequestsPanels.Controls.Add(BorrowReqUC)

        ' Show UserReq panel on top initially
        BorrowReqUC.BringToFront()
        ' Make UserReqBtn appear on top initially
        UserReqBtn.BringToFront()
    End Sub

    ' Click UserReqBtn
    Private Sub UserReqBtn_Click(sender As Object, e As EventArgs) Handles UserReqBtn.Click
        ' Bring corresponding panel on top
        UserReqUC.BringToFront()
        ' Move clicked button to back, other button to front
        UserReqBtn.SendToBack()
        BorrowReqBtn.BringToFront()
    End Sub

    ' Click BorrowReqBtn
    Private Sub BorrowReqBtn_Click(sender As Object, e As EventArgs) Handles BorrowReqBtn.Click
        ' Bring corresponding panel on top
        BorrowReqUC.BringToFront()
        ' Move clicked button to back, other button to front
        BorrowReqBtn.SendToBack()
        UserReqBtn.BringToFront()
    End Sub

End Class
