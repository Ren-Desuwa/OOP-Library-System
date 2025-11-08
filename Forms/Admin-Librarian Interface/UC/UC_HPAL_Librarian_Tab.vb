Public Class UC_HPAL_Librarian_Tab
    Private selectedContainer As UC_Librarian_container = Nothing ' Track selected container

    Private Sub UC_HPAL_Librarian_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Clear any existing controls ---
        FlowLayoutPanel1.Controls.Clear()

        ' Disable Remove button initially
        btn_remove.Enabled = False

        ' --- FlowLayoutPanel settings ---
        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPanel1.WrapContents = True
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Padding = New Padding(0)
        FlowLayoutPanel1.Margin = New Padding(0)

        ' --- Create five librarian containers manually ---
        Dim librarian1 As New UC_Librarian_container()
        Dim librarian2 As New UC_Librarian_container()
        Dim librarian3 As New UC_Librarian_container()
        Dim librarian4 As New UC_Librarian_container()
        Dim librarian5 As New UC_Librarian_container()

        ' --- Assign mock data ---
        SetLibrarianData(librarian1, "Librarian 1", "librarian1@library.com", "Active")
        SetLibrarianData(librarian2, "Librarian 2", "librarian2@library.com", "On Break")
        SetLibrarianData(librarian3, "Librarian 3", "librarian3@library.com", "Active")
        SetLibrarianData(librarian4, "Librarian 4", "librarian4@library.com", "On Break")
        SetLibrarianData(librarian5, "Librarian 5", "librarian5@library.com", "Active")

        ' --- Add click event handlers for selection ---
        AddHandler librarian1.Selected, AddressOf Librarian_Selected
        AddHandler librarian2.Selected, AddressOf Librarian_Selected
        AddHandler librarian3.Selected, AddressOf Librarian_Selected
        AddHandler librarian4.Selected, AddressOf Librarian_Selected
        AddHandler librarian5.Selected, AddressOf Librarian_Selected

        ' --- Add them to the FlowLayoutPanel ---
        FlowLayoutPanel1.Controls.Add(librarian1)
        FlowLayoutPanel1.Controls.Add(librarian2)
        FlowLayoutPanel1.Controls.Add(librarian3)
        FlowLayoutPanel1.Controls.Add(librarian4)
        FlowLayoutPanel1.Controls.Add(librarian5)

        ' --- Adjust widths ---
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            ctrl.Width = FlowLayoutPanel1.ClientSize.Width - 15
            ctrl.Margin = New Padding(0, 0, 0, 5)
        Next
    End Sub

    ' This replaces the sub in UC_HPAL_Librarian_Tab.vb
    Private Sub SetLibrarianData(container As UC_Librarian_container, name As String, email As String, status As String)
        ' Set the public properties.
        ' This is much safer and won't cause a NullReferenceException.
        container.LibrarianName = name
        container.Email = email
        container.Status = status
    End Sub

    Private Sub Librarian_Selected(sender As Object, e As EventArgs)
        Dim clicked = DirectCast(sender, UC_Librarian_container)

        ' Deselect previous one
        If selectedContainer IsNot Nothing AndAlso selectedContainer IsNot clicked Then
            selectedContainer.IsSelected = False
        End If

        ' Select clicked one
        clicked.IsSelected = True
        selectedContainer = clicked

        ' Enable Remove button once a librarian is selected
        btn_remove.Enabled = True
    End Sub

    Private Sub FlowLayoutPanel1_Resize(sender As Object, e As EventArgs) Handles FlowLayoutPanel1.Resize
        For Each ctrl As Control In FlowLayoutPanel1.Controls
            ctrl.Width = FlowLayoutPanel1.ClientSize.Width - 15
        Next
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        If selectedContainer IsNot Nothing Then
            FlowLayoutPanel1.Controls.Remove(selectedContainer)
            selectedContainer = Nothing
            btn_remove.Enabled = False ' disable again after removal
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim add As New LibrarianADD()
        add.Show()
    End Sub
End Class
