Public Class BorrowedBooksCard

    Public Property BookTitle As String
        Get
            Return lblBookTitle.Text
        End Get
        Set(value As String)
            lblBookTitle.Text = value
        End Set
    End Property

    Public Property BorrowedDate As String
        Get
            Return lblBorrowedDate.Text
        End Get
        Set(value As String)
            lblBorrowedDate.Text = value
        End Set
    End Property

    Public Property DueDate As String
        Get
            Return lblDueDate.Text
        End Get
        Set(value As String)
            lblDueDate.Text = value
        End Set
    End Property

    ' 👇 Add this property to handle status colors
    Private _Status As String
    Public Property Status As String
        Get
            Return _Status
        End Get
        Set(value As String)
            _Status = value
            ApplyStatusColor(value)
        End Set
    End Property

    ' 👇 Function to apply border and background colors
    Private Sub ApplyStatusColor(status As String)
        Select Case status.ToLower()
            Case "overdue"
                Me.BackColor = Color.FromArgb(255, 230, 230) ' light red
                Me.BorderStyle = BorderStyle.FixedSingle
                Me.Padding = New Padding(2)
                Me.ForeColor = Color.Black
                Me.BackColor = Color.FromArgb(255, 230, 230)
                Me.Refresh()
                Me.BorderColor(Color.Red)

            Case "due soon"
                Me.BackColor = Color.FromArgb(255, 255, 200) ' light yellow
                Me.BorderColor(Color.Goldenrod)

            Case "due today"
                Me.BackColor = Color.FromArgb(220, 235, 255) ' light blue
                Me.BorderColor(Color.DodgerBlue)

            Case "returned"
                Me.BackColor = Color.FromArgb(220, 255, 220) ' light green
                Me.BorderColor(Color.ForestGreen)
        End Select
    End Sub

    ' Optional helper if you’re using Guna2Panel or want border styling manually
    Private Sub BorderColor(clr As Color)
        Me.BackColor = Me.BackColor ' just to trigger redraw
        Me.CreateGraphics().DrawRectangle(New Pen(clr, 2), 0, 0, Me.Width - 1, Me.Height - 1)
    End Sub

End Class
