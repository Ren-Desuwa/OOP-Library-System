Public Class UC_pagination_controls

    ' Public events that the parent form can listen to
    Public Event NextClicked As EventHandler
    Public Event PrevClicked As EventHandler

    ''' <summary>
    ''' This is the main public function. The parent form will call this
    ''' to update the label and enable/disable the buttons.
    ''' </summary>
    Public Sub UpdateControls(currentPage As Integer, totalPages As Integer)
        If totalPages <= 1 Then
            ' If there's only one page, hide all controls
            Me.Visible = False
            Return
        End If

        Me.Visible = True
        lbl_PageInfo.Text = $"Page {currentPage} of {totalPages}"

        ' Enable/Disable buttons based on the current page
        btn_Prev.Enabled = (currentPage > 1)
        btn_Next.Enabled = (currentPage < totalPages)
    End Sub

    Private Sub btn_Next_Click(sender As Object, e As EventArgs) Handles btn_Next.Click
        ' Tell the parent form that "Next" was clicked
        RaiseEvent NextClicked(Me, e)
    End Sub

    Private Sub btn_Prev_Click(sender As Object, e As EventArgs) Handles btn_Prev.Click
        ' Tell the parent form that "Prev" was clicked
        RaiseEvent PrevClicked(Me, e)
    End Sub

End Class