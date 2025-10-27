<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_book_container
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
        Me.book_container_panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.picbox_book = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.book_container_panel.SuspendLayout()
        CType(Me.picbox_book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'book_container_panel
        '
        Me.book_container_panel.BackColor = System.Drawing.Color.Transparent
        Me.book_container_panel.BorderRadius = 20
        Me.book_container_panel.BorderThickness = 1
        Me.book_container_panel.Controls.Add(Me.lbl_title)
        Me.book_container_panel.Controls.Add(Me.picbox_book)
        Me.book_container_panel.Location = New System.Drawing.Point(0, 0)
        Me.book_container_panel.Name = "book_container_panel"
        Me.book_container_panel.Size = New System.Drawing.Size(178, 270)
        Me.book_container_panel.TabIndex = 15
        '
        'picbox_book
        '
        Me.picbox_book.BackColor = System.Drawing.Color.Transparent
        Me.picbox_book.Dock = System.Windows.Forms.DockStyle.Top
        Me.picbox_book.FillColor = System.Drawing.Color.Transparent
        Me.picbox_book.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picbox_book.ImageRotate = 0!
        Me.picbox_book.Location = New System.Drawing.Point(0, 0)
        Me.picbox_book.Name = "picbox_book"
        Me.picbox_book.Size = New System.Drawing.Size(178, 240)
        Me.picbox_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_book.TabIndex = 16
        Me.picbox_book.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.Black
        Me.lbl_title.Location = New System.Drawing.Point(0, 216)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(178, 54)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "Title"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UC_book_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.book_container_panel)
        Me.Name = "UC_book_container"
        Me.Size = New System.Drawing.Size(178, 270)
        Me.book_container_panel.ResumeLayout(False)
        CType(Me.picbox_book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents book_container_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents picbox_book As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_title As Label
End Class
