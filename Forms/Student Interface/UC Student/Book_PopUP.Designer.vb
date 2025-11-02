<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Book_PopUP
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.pbBookCover = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.btnAddtoCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrow = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBookDescription = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.messagedialogAdded = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.pbBookCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbBookCover
        '
        Me.pbBookCover.BorderRadius = 10
        Me.pbBookCover.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.pbBookCover.ImageRotate = 0!
        Me.pbBookCover.Location = New System.Drawing.Point(26, 12)
        Me.pbBookCover.Name = "pbBookCover"
        Me.pbBookCover.Size = New System.Drawing.Size(289, 379)
        Me.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbBookCover.TabIndex = 0
        Me.pbBookCover.TabStop = False
        '
        'lblBookTitle
        '
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookTitle.Location = New System.Drawing.Point(47, 10)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(400, 38)
        Me.lblBookTitle.TabIndex = 1
        Me.lblBookTitle.Text = "Beyond The Ocean Door"
        '
        'btnAddtoCart
        '
        Me.btnAddtoCart.AutoRoundedCorners = True
        Me.btnAddtoCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddtoCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddtoCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddtoCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddtoCart.FillColor = System.Drawing.Color.White
        Me.btnAddtoCart.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddtoCart.ForeColor = System.Drawing.Color.Black
        Me.btnAddtoCart.Location = New System.Drawing.Point(348, 322)
        Me.btnAddtoCart.Name = "btnAddtoCart"
        Me.btnAddtoCart.Size = New System.Drawing.Size(171, 52)
        Me.btnAddtoCart.TabIndex = 2
        Me.btnAddtoCart.Text = "Add to Cart"
        '
        'btnBorrow
        '
        Me.btnBorrow.AutoRoundedCorners = True
        Me.btnBorrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBorrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBorrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBorrow.FillColor = System.Drawing.Color.White
        Me.btnBorrow.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrow.ForeColor = System.Drawing.Color.Black
        Me.btnBorrow.Location = New System.Drawing.Point(677, 322)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(171, 52)
        Me.btnBorrow.TabIndex = 3
        Me.btnBorrow.Text = "Borrow"
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(50, 58)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(115, 22)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "Amisha Sathi"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.AutoRoundedCorners = True
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.lblBookDescription)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.Location = New System.Drawing.Point(349, 140)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(499, 170)
        Me.Guna2Panel1.TabIndex = 5
        '
        'lblBookDescription
        '
        Me.lblBookDescription.AutoSize = True
        Me.lblBookDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookDescription.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblBookDescription.Location = New System.Drawing.Point(12, 10)
        Me.lblBookDescription.Name = "lblBookDescription"
        Me.lblBookDescription.Size = New System.Drawing.Size(138, 20)
        Me.lblBookDescription.TabIndex = 0
        Me.lblBookDescription.Text = "Book Description"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.lblAuthor)
        Me.Guna2Panel2.Controls.Add(Me.lblBookTitle)
        Me.Guna2Panel2.Location = New System.Drawing.Point(349, 28)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(498, 100)
        Me.Guna2Panel2.TabIndex = 6
        '
        'messagedialogAdded
        '
        Me.messagedialogAdded.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.messagedialogAdded.Caption = ""
        Me.messagedialogAdded.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.messagedialogAdded.Parent = Nothing
        Me.messagedialogAdded.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.messagedialogAdded.Text = "Successfully Added to Cart."
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btn_close
        '
        Me.btn_close.AutoRoundedCorners = True
        Me.btn_close.BorderRadius = 24
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(848, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(51, 52)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "X"
        '
        'Book_PopUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(902, 403)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnAddtoCart)
        Me.Controls.Add(Me.pbBookCover)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Book_PopUP"
        Me.Text = "Form1"
        CType(Me.pbBookCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pbBookCover As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents btnAddtoCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAuthor As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblBookDescription As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents messagedialogAdded As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
End Class
