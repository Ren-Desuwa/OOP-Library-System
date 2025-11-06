Imports System.Drawing.Drawing2D

Public Class UC_User_Container
    Public Event InstanceClicked(selected As Object)

    Private isSelected As Boolean = False
    Private currentStatus As String = "P"

    Private ReadOnly defaultColor As Color = Color.Tan
    Private ReadOnly selectedColor As Color = Color.FromArgb(198, 158, 107)

    Private Sub UC_User_Container_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = defaultColor
        TableLayoutPanel1.BackColor = defaultColor

        ' Initialize status
        UpdateStatus("P")

        ' Make all nested controls clickable
        AddMouseDownHandlers(Me)
    End Sub

    Private Sub AddMouseDownHandlers(parent As Control)
        AddHandler parent.MouseDown, AddressOf OnMouseDownInstance
        For Each c As Control In parent.Controls
            AddHandler c.MouseDown, AddressOf OnMouseDownInstance
            If c.HasChildren Then AddMouseDownHandlers(c)
        Next
    End Sub

    Private Sub OnMouseDownInstance(sender As Object, e As MouseEventArgs)
        SetSelected(True)
        RaiseEvent InstanceClicked(Me)
    End Sub

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

    Private Sub DrawGradient(panel As Panel, c1 As Color, c2 As Color)
        If panel.Width = 0 OrElse panel.Height = 0 Then Exit Sub
        Dim bmp As New Bitmap(panel.Width, panel.Height)
        Using g As Graphics = Graphics.FromImage(bmp)
            Using br As New LinearGradientBrush(New Rectangle(0, 0, panel.Width, panel.Height), c1, c2, LinearGradientMode.Vertical)
                g.FillRectangle(br, 0, 0, panel.Width, panel.Height)
            End Using
        End Using
        panel.BackgroundImage = bmp
        panel.Refresh()
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
