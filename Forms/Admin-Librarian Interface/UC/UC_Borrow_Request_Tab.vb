Imports System.IO
Imports OOP_Library_System.Models
Imports Org.BouncyCastle.Ocsp
' You may need to add Imports System.Windows.Forms if not implicit

Public Class UC_Borrow_Request_Tab
    Private selectedItem As UC_Borrow_Container = Nothing

    ' --- State Variables for Pagination and Search ---
    Private _currentPage As Integer = 1
    Private _pageSize As Integer = 20
    Private _searchTerm As String = ""
    ' ---------------------------------------------------

    Private Sub UC_Borrow_Request_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Borrow_Container_FlowLayout.Dock = DockStyle.Fill
        Borrow_Container_FlowLayout.FlowDirection = FlowDirection.TopDown
        Borrow_Container_FlowLayout.WrapContents = False
        Borrow_Container_FlowLayout.AutoScroll = True
        Borrow_Container_FlowLayout.AutoSize = False

        ' Initial load of the first page
        LoadPendingRequests() ' Calls the refactored function with default state

        ' Detect clicks outside items
        AddHandler Borrow_Container_FlowLayout.MouseDown, AddressOf OnOutsideClick
        AddHandler Me.MouseDown, AddressOf OnOutsideClick
    End Sub

    ''' <summary>
    ''' Public wrapper to allow the parent container to refresh this tab's data.
    ''' </summary>
    Public Sub RefreshData()
        ' Call LoadPendingRequests with default parameters to refresh the current view
        LoadPendingRequests()
    End Sub
    ' --- CORE FUNCTION: Refactored for Search and Paging ---
    ''' <summary>
    ''' Loads pending requests based on search term and page number.
    ''' </summary>
    Public Sub LoadPendingRequests(Optional newSearchTerm As String = Nothing, Optional newPage As Integer = 0)

        ' 1. Update State (Persist search/page state)
        If newSearchTerm IsNot Nothing Then
            _searchTerm = newSearchTerm
            _currentPage = 1 ' Reset page when a new search term is applied
        End If
        If newPage > 0 Then _currentPage = newPage

        Try
            ClearSelection() ' Clear selection before refreshing the list
            Borrow_Container_FlowLayout.Controls.Clear()

            ' Call the Service method with search and pagination support
            Dim pendingRequests = Program.BorrowSvc.GetPendingBorrowRequests(_searchTerm, _currentPage, _pageSize)

            If pendingRequests.Count = 0 Then
                ' Handle empty result set for the current page/filter
                If _currentPage > 1 AndAlso newPage > 0 Then
                    _currentPage -= 1
                    LoadPendingRequests() ' Go back one page and reload
                Else
                    ' Optional: Show a "No requests found" label
                End If
                Return
            End If

            For Each req As BorrowedBookDetails In pendingRequests
                Dim item = New UC_Borrow_Container()
                item.TransactionID = req.Transaction.TransactionID

                ' --- POPULATE LABELS (REQUIRED FOR DISPLAY) ---
                ' NOTE: You must ensure these labels exist in UC_Borrow_Container.Designer.vb
                item.BookName_Lbl.Text = req.Book.Title ' Assuming BookTitle_Lbl exists
                item.Borrower_Lbl.Text = req.BorrowerName ' Assuming BorrowerName_Lbl exists
                item.BorrowDate_Lbl.Text = req.BorrowedDate.Value.ToShortDateString() ' Assuming DateRequested_Lbl exists
                item.DueDate_Lbl.Text = req.DueDate.Value.ToShortDateString() ' Assuming DueDate_Lbl exists
                ' ---------------------------------------------

                item.UpdateStatus(req.Transaction.Status.Substring(0, 1).ToUpper()) ' "P"
                item.Margin = New Padding(5)
                item.Height = 100
                item.Width = Borrow_Container_FlowLayout.ClientSize.Width - 20

                AddHandler item.InstanceClicked, AddressOf OnInstanceClicked
                AddHandler item.ViewDetailsClicked, AddressOf OnViewDetailsClicked
                Borrow_Container_FlowLayout.Controls.Add(item)
            Next

            ' Optional: Update pagination control UI here
            ' pagination_uc.UpdateControls(_currentPage, totalPages) 

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error Loading Requests", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' (NEW) Add this entire Sub to the class. This handles the button click.
    Private Sub OnViewDetailsClicked(transactionId As Integer)
        Try
            ' 1. Get the full details using the new service function
            Dim details As BorrowedBookDetails = Program.BorrowSvc.GetBorrowedBookDetailsById(transactionId)

            If details Is Nothing Then
                Throw New Exception("Could not find transaction details.")
            End If

            ' 2. Open the ReturnBook form and pass it the data
            Dim returnForm As New ReturnBook(details)
            returnForm.ShowDialog()

            ' 3. Refresh the list after the form closes
            LoadPendingRequests()

        Catch ex As Exception
            MessageBox.Show($"Error opening book details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub OnInstanceClicked(selected As Object)
        If selectedItem IsNot Nothing Then selectedItem.SetSelected(False)
        selectedItem = CType(selected, UC_Borrow_Container)
        selectedItem.SetSelected(True)
    End Sub

    Private Sub OnOutsideClick(sender As Object, e As MouseEventArgs)
        ' Clear selection only if the click was not on an item container
        If Not (TypeOf sender Is UC_Borrow_Container) Then
            ClearSelection()
        End If
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

    ' --- ACTION FUNCTIONS: Approve and Reject ---
    ' --- ACTION FUNCTIONS: Approve and Reject ---

    Public Sub ApproveSelected()
        If selectedItem IsNot Nothing Then
            Try
                ' 1. Call the Service to approve the request
                Program.BorrowSvc.ApproveBorrowRequest(selectedItem.TransactionID)

                ' 2. Update the UI status to "A" (Approved)
                selectedItem.UpdateStatus("A")

                MessageBox.Show("Borrow request approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 3. Refresh the list to remove the approved request
                LoadPendingRequests()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Approval Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadPendingRequests()
            End Try
        Else
            MessageBox.Show("Please select a request to approve.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Public Sub RejectSelected()
        If selectedItem IsNot Nothing Then
            Try
                ' 1. Call the Service to reject the request
                Program.BorrowSvc.RejectBorrowRequest(selectedItem.TransactionID)

                ' 2. Update the UI status to "R" (Rejected)
                selectedItem.UpdateStatus("R")

                MessageBox.Show("Borrow request rejected successfully. Book copy made available.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' 3. Refresh the list to remove the rejected request
                LoadPendingRequests()

            Catch ex As Exception
                MessageBox.Show(ex.Message, "Rejection Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoadPendingRequests()
            End Try
        Else
            MessageBox.Show("Please select a request to reject.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

End Class