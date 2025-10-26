Public Class UC_Signup2_student

    ' --- 1. SIGNALS this control can send ---
    ' New signal for the "Back" button
    Public Event BackClicked As EventHandler
    Public Event ConfirmClicked As EventHandler
    ' (You can add a "ConfirmClicked" event here later)

    ' This handles the "Back" button click
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        ' Send the "BackClicked" signal to the parent form
        RaiseEvent BackClicked(Me, EventArgs.Empty)
    End Sub

    Private Sub btn_next_Click(sender As Object, e As EventArgs) Handles btn_next.Click
        RaiseEvent ConfirmClicked(Me, EventArgs.Empty)
    End Sub

    ' (You will add your "Confirm" button logic here later)

End Class