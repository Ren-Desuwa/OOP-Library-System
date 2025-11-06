Public Class UC_Borrow_Request_Tab
    Private selectedItem As UC_Borrow_Container = Nothing

    Private Sub UC_Borrow_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        ' Create example containers
        For i As Integer = 1 To 5
            Dim item As New UC_Borrow_Container()
            item.Margin = New Padding(5)
            item.Height = 100
            item.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20

            AddHandler item.InstanceClicked, AddressOf OnInstanceClicked
            Borrow_Container_FlowLayout.Controls.Add(item)
        Next

        ' Detect clicks outside items
        AddHandler Borrow_Container_FlowLayout.MouseDown, AddressOf OnOutsideClick
        AddHandler Me.MouseDown, AddressOf OnOutsideClick
    End Sub

    Private Sub OnInstanceClicked(selected As Object)
        If selectedItem IsNot Nothing Then selectedItem.SetSelected(False)
        selectedItem = CType(selected, UC_Borrow_Container)
        selectedItem.SetSelected(True)
    End Sub

    Private Sub OnOutsideClick(sender As Object, e As MouseEventArgs)
        ClearSelection()
    End Sub

    Public Sub ClearSelection()
        If selectedItem IsNot Nothing Then
            selectedItem.SetSelected(False)
            selectedItem = Nothing
        End If
    End Sub

    Private Sub Borrow_Container_FlowLayout_Resize(sender As Object, e As EventArgs) Handles Borrow_Container_FlowLayout.Resize
        For Each ctrl As Control In Borrow_Container_FlowLayout.Controls
            ctrl.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20
        Next
    End Sub
    ' === Add these ===
    Public Sub ApproveSelected()
        If selectedItem IsNot Nothing Then
            selectedItem.UpdateStatus("A")
        End If
    End Sub

    Public Sub RejectSelected()
        If selectedItem IsNot Nothing Then
            selectedItem.UpdateStatus("R")
        End If
    End Sub

    Private Sub Borrow_Container_FlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles Borrow_Container_FlowLayout.Paint

    End Sub
End Class
