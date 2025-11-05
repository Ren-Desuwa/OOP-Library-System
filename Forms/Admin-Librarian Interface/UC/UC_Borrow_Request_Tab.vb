Public Class UC_Borrow_Request_Tab

    Private Sub UC_Borrow_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Ensure FlowLayoutPanel fills the parent control
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        ' Example: Add multiple UC_Borrow_Container items dynamically
        For i As Integer = 1 To 5
            Dim item As New UC_Borrow_Container()
            item.Margin = New Padding(5)
            item.Height = 100 ' fixed height for all
            item.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20
            Borrow_Container_FlowLayout.Controls.Add(item)
        Next
    End Sub

    ' Whenever FlowLayoutPanel resizes, make sure each child resizes horizontally
    Private Sub Borrow_Container_FlowLayout_Resize(sender As Object, e As EventArgs) Handles Borrow_Container_FlowLayout.Resize
        For Each ctrl As Control In Borrow_Container_FlowLayout.Controls
            ctrl.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20 ' leave some margin
        Next
    End Sub

    Private Sub Borrow_Container_FlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles Borrow_Container_FlowLayout.Paint

    End Sub
End Class
