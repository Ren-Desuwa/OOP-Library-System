Imports System.Windows.Forms

Partial Public Class UC_Loading_Panel
    Private typeIndex As Integer = 0
    Private baseMessage As String = "Loading All Books..."

    ''' <summary>
    ''' Public method to update the loading text from the parent form.
    ''' </summary>
    Public Sub SetMessage(message As String)
        baseMessage = message.Trim() ' Remove any extra spaces
        typeIndex = 0
        lbl_LoadingText.Text = ""
        tmr_Animate.Start() ' Start or re-start the animation
    End Sub

    Private Sub tmr_Animate_Tick(sender As Object, e As EventArgs) Handles tmr_Animate.Tick
        ' This is the "typewriter" logic
        If typeIndex < baseMessage.Length Then
            ' Add one more character
            typeIndex += 1
            lbl_LoadingText.Text = baseMessage.Substring(0, typeIndex)
        Else
            ' When finished, pause for a moment, then reset
            typeIndex = 0
            lbl_LoadingText.Text = ""
        End If
    End Sub

    Private Sub UC_Loading_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' No centering code needed! The TableLayoutPanel does it all.
        tmr_Animate.Start()
    End Sub

    ' We don't even need a Resize event anymore.
End Class