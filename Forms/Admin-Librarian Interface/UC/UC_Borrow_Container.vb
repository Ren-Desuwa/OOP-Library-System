Imports System.Drawing.Drawing2D

Public Class UC_Borrow_Container
    Public Event InstanceClicked(selected As Object)
    Public Event ViewDetailsClicked(transactionId As Integer)

    Public TransactionID As Integer
    Private isSelected As Boolean = False
    Private currentStatus As String = "P"
    ' Store the default and selected colors
    Private ReadOnly defaultColor As Color = Color.Tan
    Private ReadOnly selectedColor As Color = Color.FromArgb(198, 158, 107) ' slightly darker tan

    Private Sub UC_Borrow_Container_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateStatus("P")

        ' Set the initial color
        Me.BackColor = defaultColor
        TableLayoutPanel1.BackColor = defaultColor

        ' Make all nested controls clickable
        AddMouseDownHandlers(Me)
    End Sub

    ' Recursively attach MouseDown handler
    Private Sub AddMouseDownHandlers(parent As Control)
        AddHandler parent.MouseDown, AddressOf OnMouseDownInstance
        For Each c As Control In parent.Controls
            AddHandler c.MouseDown, AddressOf OnMouseDownInstance
            If c.HasChildren Then AddMouseDownHandlers(c)
        Next
    End Sub

    Private Sub OnMouseDownInstance(sender As Object, e As MouseEventArgs)
        ' (NEW) Check if the control that was clicked is the button
        Dim clickedControl = CType(sender, Control)
        If IsControlOrChildOf(clickedControl, btn_viewbook) Then
            Exit Sub ' Do not select if the button was clicked
        End If

        ' Notify selection
        SetSelected(True)
        RaiseEvent InstanceClicked(Me)
    End Sub

    ' (NEW) Add this helper function to check if a control is the button
    Private Function IsControlOrChildOf(control As Control, parent As Control) As Boolean
        If control Is Nothing OrElse parent Is Nothing Then Return False
        Dim current = control
        Do While current IsNot Nothing
            If current Is parent Then Return True
            current = current.Parent
        Loop
        Return False
    End Function

    ' Change colors when selected/unselected
    Public Sub SetSelected(value As Boolean)
        isSelected = value

        If isSelected Then
            Me.BackColor = selectedColor
            TableLayoutPanel1.BackColor = selectedColor
        Else
            Me.BackColor = defaultColor
            TableLayoutPanel1.BackColor = defaultColor
        End If

        Me.Invalidate()
    End Sub

    ' Update status label + gradient instantly
    Public Sub UpdateStatus(status As String)
        currentStatus = status
        StatusLbl.Text = status

        Select Case status
            Case "A"
                StatusPanel.FillColor = Color.MediumSeaGreen
                StatusPanel.FillColor2 = Color.LightGreen
                StatusPanel.FillColor3 = Color.MediumSeaGreen
                StatusPanel.FillColor4 = Color.LightGreen
            Case "R"
                StatusPanel.FillColor = Color.IndianRed
                StatusPanel.FillColor2 = Color.LightCoral
                StatusPanel.FillColor3 = Color.IndianRed
                StatusPanel.FillColor4 = Color.LightCoral
            Case Else
                StatusPanel.FillColor = Color.LightBlue
                StatusPanel.FillColor2 = Color.SkyBlue
                StatusPanel.FillColor3 = Color.LightBlue
                StatusPanel.FillColor4 = Color.SkyBlue
        End Select
    End Sub


    ' Gradient background for StatusPanel
    Private Sub DrawGradient(panel As Panel, c1 As Color, c2 As Color)
        If panel.Width = 0 OrElse panel.Height = 0 Then Exit Sub
        Dim bmp As New Bitmap(panel.Width, panel.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using br As New LinearGradientBrush(New Rectangle(0, 0, panel.Width, panel.Height), c1, c2, LinearGradientMode.Vertical)
                g.FillRectangle(br, 0, 0, panel.Width, panel.Height)
            End Using
        End Using
        panel.BackgroundImage = bmp
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub

    Private Sub ViewDetailsBtn_Click(sender As Object, e As EventArgs) Handles btn_viewbook.Click
        RaiseEvent ViewDetailsClicked(Me.TransactionID)
    End Sub
End Class
