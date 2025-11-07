Public Class UC_HPAL_Librarian_Tab
    ' Keeps track of the currently selected container
    Private selectedContainer As UC_Librarian_container = Nothing

    Private Sub UC_HPAL_Librarian_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Safety check: make sure FlowLayoutPanel exists
        If FlowLayoutPanel1 Is Nothing Then
            MessageBox.Show("FlowLayoutPanel1 not found. Check the control name in the designer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Clear old controls before loading new ones
        FlowLayoutPanel1.Controls.Clear()

        Dim librarianContainer As New UC_Librarian_container()



        ' Dynamically add librarian containers
        For i As Integer = 1 To 10

            ' OPTIONAL: adjust width/margin to fit nicely in the flow layout
            librarianContainer.Width = FlowLayoutPanel1.ClientSize.Width - 25
            librarianContainer.Margin = New Padding(5, 5, 5, 5)

            ' If your UserControl has labels inside it, set their text here:
            If librarianContainer.Controls.ContainsKey("lblName") Then
                librarianContainer.Controls("lblName").Text = $"Librarian {i}"
            End If
            If librarianContainer.Controls.ContainsKey("lbl_email") Then
                librarianContainer.Controls("lbl_email").Text = $"librarian{i}@library.com"
            End If
            If librarianContainer.Controls.ContainsKey("Label1") Then
                librarianContainer.Controls("Label1").Text = If(i Mod 2 = 0, "Active", "On Break")
            End If

            ' Subscribe to its Selected event
            AddHandler librarianContainer.Selected, AddressOf LibrarianContainer_Selected

            ' Add to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(librarianContainer)
        Next
    End Sub

    ''' <summary>
    ''' Handles when a librarian container is clicked (Selected event triggered)
    ''' </summary>
    Private Sub LibrarianContainer_Selected(sender As Object, e As EventArgs)
        Dim clicked As UC_Librarian_container = DirectCast(sender, UC_Librarian_container)

        ' Deselect the previously selected container
        If selectedContainer IsNot Nothing AndAlso selectedContainer IsNot clicked Then
            selectedContainer.IsSelected = False
        End If

        ' Select the newly clicked one
        clicked.IsSelected = True
        selectedContainer = clicked
    End Sub

    ' --- Resize Logic ---

    Private Sub FlowLayoutPanel1_Resize(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Resize
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            ' Use the original width adjustment logic for consistency
            ctrl.Width = FlowLayoutPanel1.ClientSize.Width - 40
        Next
    End Sub

End Class
