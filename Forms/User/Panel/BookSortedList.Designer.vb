<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookSortedList
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblMatchInfo = New System.Windows.Forms.Label() ' Added Match Info Label
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCover
        '
        Me.picCover.BackColor = System.Drawing.Color.White
        Me.picCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCover.Location = New System.Drawing.Point(0, 0)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(150, 160) ' Adjusted size for new label
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCover.TabIndex = 0
        Me.picCover.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 160) ' Positioned above match info
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 20) ' Adjusted height
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Book Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMatchInfo
        '
        Me.lblMatchInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMatchInfo.Font = New System.Drawing.Font("Segoe UI", 7.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ' Smaller italic font
        Me.lblMatchInfo.ForeColor = System.Drawing.Color.Gray
        Me.lblMatchInfo.Location = New System.Drawing.Point(0, 180) ' Positioned at the very bottom
        Me.lblMatchInfo.Name = "lblMatchInfo"
        Me.lblMatchInfo.Size = New System.Drawing.Size(150, 20) ' Give it height
        Me.lblMatchInfo.TabIndex = 2
        Me.lblMatchInfo.Text = "" ' Initially empty
        Me.lblMatchInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookSortedList ' Changed control name reference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picCover)    ' PicCover fills most space
        Me.Controls.Add(Me.lblTitle)     ' Title sits above MatchInfo
        Me.Controls.Add(Me.lblMatchInfo) ' MatchInfo sits at the bottom
        Me.Name = "BookSortedList"       ' Changed control name reference
        Me.Size = New System.Drawing.Size(150, 200) ' Overall control size
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCover As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblMatchInfo As Label ' Added Match Info Label

End Class