<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCart
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BookTitle = New System.Windows.Forms.Label()
        Me.BookCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BookImage = New System.Windows.Forms.PictureBox()
        CType(Me.BookImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BookTitle
        '
        Me.BookTitle.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BookTitle.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.BookTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BookTitle.Location = New System.Drawing.Point(0, 244)
        Me.BookTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BookTitle.Name = "BookTitle"
        Me.BookTitle.Size = New System.Drawing.Size(197, 54)
        Me.BookTitle.TabIndex = 0
        Me.BookTitle.Text = "Book Title"
        Me.BookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BookCheckBox
        '
        Me.BookCheckBox.AutoSize = True
        Me.BookCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookCheckBox.CheckedState.BorderRadius = 0
        Me.BookCheckBox.CheckedState.BorderThickness = 0
        Me.BookCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!)
        Me.BookCheckBox.Location = New System.Drawing.Point(176, 8)
        Me.BookCheckBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BookCheckBox.Name = "BookCheckBox"
        Me.BookCheckBox.Size = New System.Drawing.Size(18, 17)
        Me.BookCheckBox.TabIndex = 1
        Me.BookCheckBox.UncheckedState.BorderColor = System.Drawing.Color.DarkGray
        Me.BookCheckBox.UncheckedState.BorderRadius = 0
        Me.BookCheckBox.UncheckedState.BorderThickness = 0
        Me.BookCheckBox.UncheckedState.FillColor = System.Drawing.Color.White
        '
        'BookImage
        '
        Me.BookImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.BookImage.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.BookImage.Location = New System.Drawing.Point(0, 0)
        Me.BookImage.Margin = New System.Windows.Forms.Padding(4)
        Me.BookImage.Name = "BookImage"
        Me.BookImage.Size = New System.Drawing.Size(197, 240)
        Me.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BookImage.TabIndex = 0
        Me.BookImage.TabStop = False
        '
        'BookCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.BookCheckBox)
        Me.Controls.Add(Me.BookTitle)
        Me.Controls.Add(Me.BookImage)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BookCart"
        Me.Size = New System.Drawing.Size(197, 298)
        CType(Me.BookImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BookTitle As Label
    Friend WithEvents BookCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BookImage As PictureBox
End Class
