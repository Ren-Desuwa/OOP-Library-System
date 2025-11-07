Imports OOP_Library_System.Models
Imports System.IO
Public Class UC_Borrow_Request_Tab
    Private selectedItem As UC_Borrow_Container = Nothing

    Private Sub UC_Borrow_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        LoadPendingRequests()

        ' Detect clicks outside items
        AddHandler Borrow_Container_FlowLayout.MouseDown, AddressOf OnOutsideClick
        AddHandler Me.MouseDown, AddressOf OnOutsideClick
    End Sub
    Public Sub LoadPendingRequests()
        Try
            Borrow_Container_FlowLayout.Controls.Clear()
            Dim pendingRequests = Program.BorrowSvc.GetPendingBorrowRequests()

            If pendingRequests.Count = 0 Then
                ' (Optional: Show a "No requests" label)
                Return
            End If

            For Each req As BorrowedBookDetails In pendingRequests
                Dim item = New UC_Borrow_Container()
                item.TransactionID = req.Transaction.TransactionID

                ' --- POPULATE LABELS (Adjust label names to match your .Designer.vb) ---
                ' Assuming your UC_Borrow_Container.Designer.vb has labels like:
                ' item.BookTitle_Lbl.Text = req.Book.Title
                ' item.BorrowerName_Lbl.Text = req.BorrowerName
                ' item.DateRequested_Lbl.Text = req.Transaction.DateBorrowed.ToShortDateString()
                ' -----------------------------------------------------------------

                item.UpdateStatus(req.Transaction.Status.Substring(0, 1).ToUpper()) ' "P"
                item.Margin = New Padding(5)
                item.Height = 100
                item.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20

                AddHandler item.InstanceClicked, AddressOf OnInstanceClicked
                Borrow_Container_FlowLayout.Controls.Add(item)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Requests", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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
            Try
                Program.BorrowSvc.ApproveBorrowRequest(selectedItem.TransactionID)
                selectedItem.UpdateStatus("A")
                ' Optional: Remove from list after approval
                ' Borrow_Container_FlowLayout.Controls.Remove(selectedItem)
                ' ClearSelection()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub RejectSelected()
        If selectedItem IsNot Nothing Then
            Try
                Program.BorrowSvc.RejectBorrowRequest(selectedItem.TransactionID)
                selectedItem.UpdateStatus("R")
                ' Optional: Remove from list after rejection
                ' Borrow_Container_FlowLayout.Controls.Remove(selectedItem)
                ' ClearSelection()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Rejection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Borrow_Container_FlowLayout_Paint(sender As Object, e As PaintEventArgs) Handles Borrow_Container_FlowLayout.Paint

    End Sub
End Class
