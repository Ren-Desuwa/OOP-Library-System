<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.lblTItle = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAdd = New Guna.UI2.WinForms.Guna2Button()
        Me.btnBorrow = New Guna.UI2.WinForms.Guna2Button()
        Me.mdSuccess = New Guna.UI2.WinForms.Guna2MessageDialog()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = CType(resources.GetObject("Guna2PictureBox1.Image"), System.Drawing.Image)
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(36, 29)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(253, 315)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.lblAuthor)
        Me.pnlHeader.Controls.Add(Me.lblTItle)
        Me.pnlHeader.Location = New System.Drawing.Point(321, 29)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(556, 93)
        Me.pnlHeader.TabIndex = 1
        '
        'lblAuthor
        '
        Me.lblAuthor.AutoSize = True
        Me.lblAuthor.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(87, 58)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(109, 23)
        Me.lblAuthor.TabIndex = 1
        Me.lblAuthor.Text = "Amisha Sathi"
        '
        'lblTItle
        '
        Me.lblTItle.AutoSize = True
        Me.lblTItle.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTItle.Location = New System.Drawing.Point(74, 12)
        Me.lblTItle.Name = "lblTItle"
        Me.lblTItle.Size = New System.Drawing.Size(395, 45)
        Me.lblTItle.TabIndex = 0
        Me.lblTItle.Text = "Beyond The Ocean Door"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.Controls.Add(Me.lblDescription)
        Me.Guna2Panel1.Location = New System.Drawing.Point(321, 128)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(556, 163)
        Me.Guna2Panel1.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lblDescription.Location = New System.Drawing.Point(15, 13)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(138, 20)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Book Description"
        '
        'btnAdd
        '
        Me.btnAdd.AutoRoundedCorners = True
        Me.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAdd.FillColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(321, 315)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(181, 46)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add to Cart"
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
        Me.btnBorrow.Location = New System.Drawing.Point(696, 315)
        Me.btnBorrow.Name = "btnBorrow"
        Me.btnBorrow.Size = New System.Drawing.Size(181, 46)
        Me.btnBorrow.TabIndex = 4
        Me.btnBorrow.Text = "Borrow"
        '
        'mdSuccess
        '
        Me.mdSuccess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.mdSuccess.Caption = Nothing
        Me.mdSuccess.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.mdSuccess.Parent = Nothing
        Me.mdSuccess.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.mdSuccess.Text = "Successfully Added to Cart."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BurlyWood
        Me.ClientSize = New System.Drawing.Size(934, 373)
        Me.Controls.Add(Me.btnBorrow)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.Guna2PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblTItle As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents mdSuccess As Guna.UI2.WinForms.Guna2MessageDialog
End Class
