<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookItemControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picCover
        '
        Me.picCover.BackColor = System.Drawing.Color.WhiteSmoke
        Me.picCover.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picCover.Location = New System.Drawing.Point(0, 0)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(150, 175) ' Fill space above label
        Me.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCover.TabIndex = 0
        Me.picCover.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)) ' Slightly smaller font
        Me.lblTitle.Location = New System.Drawing.Point(0, 175)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(150, 25)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Book Title"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.picCover)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "BookItemControl"
        Me.Size = New System.Drawing.Size(150, 200) ' Standard size for a book item
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picCover As PictureBox
    Friend WithEvents lblTitle As Label

End Class