Public Class UC_HPAL_Request_Tab
    Private UserReqUC As New UC_User_Request_Tab()
    Private BorrowReqUC As New UC_Borrow_Request_Tab()

    ' Track which tab is active
    Private activeTab As Control = Nothing

    Private Sub UC_HPAL_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UserReqUC.Dock = DockStyle.Fill
        BorrowReqUC.Dock = DockStyle.Fill
        RequestsPanels.Controls.Add(UserReqUC)
        RequestsPanels.Controls.Add(BorrowReqUC)

        ' Show Borrow tab by default
        BorrowReqUC.BringToFront()
        activeTab = BorrowReqUC
        UserReqBtn.BringToFront()
    End Sub

    Private Sub UserReqBtn_Click(sender As Object, e As EventArgs)
        UserReqUC.BringToFront()
        activeTab = UserReqUC
        UserReqBtn.SendToBack()
        BorrowReqBtn.BringToFront()
    End Sub

    Private Sub BorrowReqBtn_Click(sender As Object, e As EventArgs)
        BorrowReqUC.BringToFront()
        activeTab = BorrowReqUC
        BorrowReqBtn.SendToBack()
        UserReqBtn.BringToFront()
    End Sub

    Private Sub ApproveBtn_Click(sender As Object, e As EventArgs) Handles ApproveBtn.Click
        If activeTab Is BorrowReqUC Then
            BorrowReqUC.ApproveSelected()
        ElseIf activeTab Is UserReqUC Then
            UserReqUC.ApproveSelected()
        End If
    End Sub

    Private Sub RejectBtn_Click(sender As Object, e As EventArgs) Handles RejectBtn.Click
        If activeTab Is BorrowReqUC Then
            BorrowReqUC.RejectSelected()
        ElseIf activeTab Is UserReqUC Then
            UserReqUC.RejectSelected()
        End If
    End Sub

    Private Sub RequestsPanels_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub RequestsPanels_Paint_1(sender As Object, e As PaintEventArgs) Handles RequestsPanels.Paint

    End Sub

    Private Sub BorrowReqBtn_Click_1(sender As Object, e As EventArgs) Handles BorrowReqBtn.Click
        BorrowReqUC.BringToFront()
        activeTab = BorrowReqUC
        BorrowReqBtn.SendToBack()
        UserReqBtn.BringToFront()

        ' Update label
        RequestsTitle.Text = "Borrow Requests"
    End Sub

    Private Sub UserReqBtn_Click_1(sender As Object, e As EventArgs) Handles UserReqBtn.Click
        UserReqUC.BringToFront()
        activeTab = UserReqUC
        UserReqBtn.SendToBack()
        BorrowReqBtn.BringToFront()

        ' Update label
        RequestsTitle.Text = "User Requests"
    End Sub


    Private Sub RequestsTitle_Click(sender As Object, e As EventArgs) Handles RequestsTitle.Click

    End Sub
End Class
