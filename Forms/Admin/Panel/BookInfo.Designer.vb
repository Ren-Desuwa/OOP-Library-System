<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BookInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDesc = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.picBook = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtISBN)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtAuthor)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtDesc)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtTitle)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.picBook)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(-1, -58)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(801, 666)
        Me.Guna2CustomGradientPanel1.TabIndex = 1
        '
        'txtISBN
        '
        Me.txtISBN.BackColor = System.Drawing.Color.Transparent
        Me.txtISBN.BorderColor = System.Drawing.Color.DarkGray
        Me.txtISBN.BorderRadius = 10
        Me.txtISBN.BorderThickness = 3
        Me.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtISBN.DefaultText = ""
        Me.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtISBN.Location = New System.Drawing.Point(322, 239)
        Me.txtISBN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.PlaceholderText = ""
        Me.txtISBN.SelectedText = ""
        Me.txtISBN.Size = New System.Drawing.Size(444, 62)
        Me.txtISBN.TabIndex = 22
        '
        'txtAuthor
        '
        Me.txtAuthor.BackColor = System.Drawing.Color.Transparent
        Me.txtAuthor.BorderColor = System.Drawing.Color.DarkGray
        Me.txtAuthor.BorderRadius = 10
        Me.txtAuthor.BorderThickness = 3
        Me.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAuthor.DefaultText = "Author"
        Me.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAuthor.Location = New System.Drawing.Point(322, 169)
        Me.txtAuthor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.PlaceholderText = ""
        Me.txtAuthor.SelectedText = ""
        Me.txtAuthor.Size = New System.Drawing.Size(444, 62)
        Me.txtAuthor.TabIndex = 21
        '
        'txtDesc
        '
        Me.txtDesc.BackColor = System.Drawing.Color.Transparent
        Me.txtDesc.BorderColor = System.Drawing.Color.DarkGray
        Me.txtDesc.BorderRadius = 10
        Me.txtDesc.BorderThickness = 3
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.DefaultText = ""
        Me.txtDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDesc.Location = New System.Drawing.Point(16, 488)
        Me.txtDesc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.PlaceholderText = ""
        Me.txtDesc.SelectedText = ""
        Me.txtDesc.Size = New System.Drawing.Size(756, 150)
        Me.txtDesc.TabIndex = 20
        '
        'txtTitle
        '
        Me.txtTitle.BackColor = System.Drawing.Color.Transparent
        Me.txtTitle.BorderColor = System.Drawing.Color.DarkGray
        Me.txtTitle.BorderRadius = 10
        Me.txtTitle.BorderThickness = 3
        Me.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTitle.DefaultText = "Title"
        Me.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTitle.Location = New System.Drawing.Point(322, 103)
        Me.txtTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.PlaceholderText = ""
        Me.txtTitle.SelectedText = ""
        Me.txtTitle.Size = New System.Drawing.Size(444, 58)
        Me.txtTitle.TabIndex = 17
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox1.CustomIconSize = 13.0!
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.ForeColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(750, 58)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(48, 38)
        Me.Guna2ControlBox1.TabIndex = 14
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2CustomGradientPanel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'picBook
        '
        Me.picBook.BackColor = System.Drawing.Color.Transparent
        Me.picBook.BorderRadius = 30
        Me.picBook.FillColor = System.Drawing.Color.Transparent
        'Me.picBook.Image = Global.OOP_Library_System.My.Resources.Resources.the_adventure
        Me.picBook.ImageRotate = 0!
        Me.picBook.Location = New System.Drawing.Point(24, 96)
        Me.picBook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.picBook.Name = "picBook"
        Me.picBook.Size = New System.Drawing.Size(268, 370)
        Me.picBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBook.TabIndex = 15
        Me.picBook.TabStop = False
        '
        'BookInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BookInfo"
        Me.Text = "BookInfo"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        CType(Me.picBook, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDesc As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents picBook As Guna.UI2.WinForms.Guna2PictureBox
End Class
