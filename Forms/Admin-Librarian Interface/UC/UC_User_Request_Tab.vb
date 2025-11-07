Public Class UC_User_Request_Tab
    Private selectedItem As UC_UserRequest_Container = Nothing

    Private Sub UC_User_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        ' Add sample items
        LoadPendingUsers()

        AddHandler Borrow_Container_FlowLayout.MouseDown, AddressOf OnOutsideClick
        AddHandler Me.MouseDown, AddressOf OnOutsideClick
    End Sub
    Private Sub LoadPendingUsers()
        Try
            Borrow_Container_FlowLayout.Controls.Clear() ' Clear old items
            Dim pendingAccounts = Program.AccountSvc.GetPendingAccounts()

            If pendingAccounts.Count = 0 Then
                ' Optional: Show a label if no requests
                Dim lbl As New Label()
                lbl.Text = "No pending user requests."
                lbl.Font = New Font("Segoe UI", 12)
                lbl.ForeColor = Color.DimGray
                lbl.AutoSize = True
                lbl.Margin = New Padding(10)
                Borrow_Container_FlowLayout.Controls.Add(lbl)
                Return
            End If

            For Each acc As Account In pendingAccounts
                Dim userItem As New UC_UserRequest_Container()
                userItem.AccountID = acc.AccountID ' <-- Store the ID
                userItem.UserName_Lbl.Text = acc.Username '
                userItem.DateCreated_Lbl.Text = acc.DateCreated.ToShortDateString() '
                userItem.UpdateStatus("P") '

                userItem.Margin = New Padding(5)
                userItem.Height = 100
                userItem.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20
                AddHandler userItem.InstanceClicked, AddressOf OnInstanceClicked
                Borrow_Container_FlowLayout.Controls.Add(userItem)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Requests", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub OnInstanceClicked(selected As Object)
        If selectedItem IsNot Nothing Then selectedItem.SetSelected(False)
        selectedItem = CType(selected, UC_UserRequest_Container)
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

    ' === Approve/Reject ===
    Public Sub ApproveSelected()
        If selectedItem IsNot Nothing Then
            Try
                ' 1. Call the service to update the database
                Program.AccountSvc.ApproveAccount(selectedItem.AccountID)

                ' 2. Update UI
                selectedItem.UpdateStatus("A")

                ' 3. Optional: Remove from list after approval
                ' Borrow_Container_FlowLayout.Controls.Remove(selectedItem)
                ' ClearSelection()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub RejectSelected()
        If selectedItem IsNot Nothing Then
            ' Ask for confirmation before deleting
            Dim result = MessageBox.Show($"Are you sure you want to reject and delete the user '{selectedItem.UserName_Lbl.Text}'?",
                                           "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If result = DialogResult.Yes Then
                Try
                    ' 1. Call the service to delete from database
                    Program.AccountSvc.RejectAccount(selectedItem.AccountID)

                    ' 2. Update UI by removing it
                    Borrow_Container_FlowLayout.Controls.Remove(selectedItem)
                    ClearSelection()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Rejection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub Borrow_Container_FlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles Borrow_Container_FlowLayout.Paint

    End Sub
End Class
