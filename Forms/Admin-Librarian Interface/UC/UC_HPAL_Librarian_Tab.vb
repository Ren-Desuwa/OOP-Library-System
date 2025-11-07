Imports System.Linq

Public Class UC_HPAL_Librarian_Tab
    Private selectedContainer As UC_Librarian_container = Nothing ' Track selected container

    Private Sub UC_HPAL_Librarian_Tab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FlowLayoutPanel1.Controls.Clear()
        btn_remove.Enabled = False

        FlowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight
        FlowLayoutPanel1.WrapContents = True
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Padding = New Padding(0)
        FlowLayoutPanel1.Margin = New Padding(0)

        Try
            ' ✅ Get only librarian accounts from AccountService
            Dim librarians = Program.AccountSvc.GetLibrarianAccounts()

            If librarians Is Nothing OrElse librarians.Count = 0 Then
                Dim lblEmpty As New Label() With {
                    .Text = "No librarian accounts found.",
                    .AutoSize = False,
                    .Dock = DockStyle.Fill,
                    .TextAlign = ContentAlignment.MiddleCenter,
                    .Font = New Font("Segoe UI", 10, FontStyle.Italic)
                }
                FlowLayoutPanel1.Controls.Add(lblEmpty)
                Return
            End If

            ' ✅ Create a container for each librarian
            For Each librarian In librarians
                Dim container As New UC_Librarian_container()

                Dim statusText As String = If(librarian.IsActive, "Active", "Inactive")
                SetLibrarianData(container, librarian.Name, librarian.Email, statusText)

                AddHandler container.Selected, AddressOf Librarian_Selected
                FlowLayoutPanel1.Controls.Add(container)
            Next

            ' Adjust width
            For Each ctrl As Control In FlowLayoutPanel1.Controls
                ctrl.Width = FlowLayoutPanel1.ClientSize.Width - 15
                ctrl.Margin = New Padding(0, 0, 0, 5)
            Next

        Catch ex As Exception
            MessageBox.Show("Failed to load librarians: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub SetLibrarianData(container As UC_Librarian_container, name As String, email As String, status As String)
        Try
            Dim lblName As Label = FindLabelByName(container, "lbl_name")
            Dim lblEmail As Label = FindLabelByName(container, "lbl_email")
            Dim lblStatus As Label = FindLabelByName(container, "Label1") ' or whatever you used for status label

            If lblName IsNot Nothing Then lblName.Text = name
            If lblEmail IsNot Nothing Then lblEmail.Text = email
            If lblStatus IsNot Nothing Then lblStatus.Text = status
        Catch ex As Exception
            MessageBox.Show("Error setting librarian data: " & ex.Message)
        End Try
    End Sub

    Private Function FindLabelByName(parent As Control, labelName As String) As Label
        For Each c As Control In parent.Controls
            If TypeOf c Is Label AndAlso c.Name.Equals(labelName, StringComparison.OrdinalIgnoreCase) Then
                Return DirectCast(c, Label)
            End If
            Dim result As Label = FindLabelByName(c, labelName)
            If result IsNot Nothing Then Return result
        Next
        Return Nothing
    End Function


    Private Sub Librarian_Selected(sender As Object, e As EventArgs)
        Dim clicked = DirectCast(sender, UC_Librarian_container)

        If selectedContainer IsNot Nothing AndAlso selectedContainer IsNot clicked Then
            selectedContainer.IsSelected = False
        End If

        clicked.IsSelected = True
        selectedContainer = clicked
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
            btn_remove.Enabled = False
        End If
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim add As New LibrarianADD()
        add.Show()
    End Sub
End Class
