Public Class UC_User_Request_Tab

    Private Sub UC_User_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure FlowLayoutPanel
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        ' Example: Add multiple UC_User_Container controls
        For i As Integer = 1 To 5
            Dim userItem As New UC_User_Container()
            userItem.Margin = New Padding(5)
            userItem.Height = 100 ' fixed height for all
            userItem.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20
            Borrow_Container_FlowLayout.Controls.Add(userItem)
        Next
    End Sub

    ' Make child UserControls resize horizontally with FlowLayoutPanel
    Private Sub Borrow_Container_FlowLayout_Resize(sender As Object, e As EventArgs) Handles Borrow_Container_FlowLayout.Resize
        For Each ctrl As Control In Borrow_Container_FlowLayout.Controls
            ctrl.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20 ' keep margin for padding/scrollbar
        Next
    End Sub

End Class
