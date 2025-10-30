<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LibrarianList))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pnlHeader = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.btnBooks = New Guna.UI2.WinForms.Guna2Button()
        Me.btnUsers = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLibrarian = New Guna.UI2.WinForms.Guna2Button()
        Me.btnNotification = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button5 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btnAddLibrarian = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.dgvLibrarians = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lblNumberofLibrarians = New System.Windows.Forms.Label()
        Me.pnlHeader.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.dgvLibrarians, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlHeader.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.pnlHeader.Location = New System.Drawing.Point(-2, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(805, 97)
        Me.pnlHeader.TabIndex = 0
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.BurlyWood
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button5)
        Me.Guna2Panel1.Controls.Add(Me.btnNotification)
        Me.Guna2Panel1.Controls.Add(Me.btnLibrarian)
        Me.Guna2Panel1.Controls.Add(Me.btnUsers)
        Me.Guna2Panel1.Controls.Add(Me.btnBooks)
        Me.Guna2Panel1.Location = New System.Drawing.Point(637, 97)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(166, 355)
        Me.Guna2Panel1.TabIndex = 1
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.Aqua
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(707, 12)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(83, 79)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'btnBooks
        '
        Me.btnBooks.AutoRoundedCorners = True
        Me.btnBooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBooks.FillColor = System.Drawing.Color.White
        Me.btnBooks.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBooks.ForeColor = System.Drawing.Color.Black
        Me.btnBooks.Location = New System.Drawing.Point(25, 23)
        Me.btnBooks.Name = "btnBooks"
        Me.btnBooks.Size = New System.Drawing.Size(126, 49)
        Me.btnBooks.TabIndex = 0
        Me.btnBooks.Text = "Books"
        '
        'btnUsers
        '
        Me.btnUsers.AutoRoundedCorners = True
        Me.btnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnUsers.FillColor = System.Drawing.Color.White
        Me.btnUsers.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.ForeColor = System.Drawing.Color.Black
        Me.btnUsers.Location = New System.Drawing.Point(25, 87)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(126, 49)
        Me.btnUsers.TabIndex = 1
        Me.btnUsers.Text = "Users"
        '
        'btnLibrarian
        '
        Me.btnLibrarian.AutoRoundedCorners = True
        Me.btnLibrarian.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLibrarian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLibrarian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLibrarian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLibrarian.FillColor = System.Drawing.Color.White
        Me.btnLibrarian.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibrarian.ForeColor = System.Drawing.Color.Black
        Me.btnLibrarian.Location = New System.Drawing.Point(25, 151)
        Me.btnLibrarian.Name = "btnLibrarian"
        Me.btnLibrarian.Size = New System.Drawing.Size(126, 49)
        Me.btnLibrarian.TabIndex = 2
        Me.btnLibrarian.Text = "Librarians"
        '
        'btnNotification
        '
        Me.btnNotification.AutoRoundedCorners = True
        Me.btnNotification.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNotification.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNotification.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNotification.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNotification.FillColor = System.Drawing.Color.White
        Me.btnNotification.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNotification.ForeColor = System.Drawing.Color.Black
        Me.btnNotification.Location = New System.Drawing.Point(25, 215)
        Me.btnNotification.Name = "btnNotification"
        Me.btnNotification.Size = New System.Drawing.Size(126, 49)
        Me.btnNotification.TabIndex = 3
        Me.btnNotification.Text = "Notifications"
        '
        'Guna2Button5
        '
        Me.Guna2Button5.AutoRoundedCorners = True
        Me.Guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button5.FillColor = System.Drawing.Color.White
        Me.Guna2Button5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button5.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button5.Location = New System.Drawing.Point(25, 279)
        Me.Guna2Button5.Name = "Guna2Button5"
        Me.Guna2Button5.Size = New System.Drawing.Size(126, 49)
        Me.Guna2Button5.TabIndex = 4
        Me.Guna2Button5.Text = "Admin Logs"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.White
        Me.Guna2Panel2.Controls.Add(Me.lblNumberofLibrarians)
        Me.Guna2Panel2.Controls.Add(Me.dgvLibrarians)
        Me.Guna2Panel2.Location = New System.Drawing.Point(7, 114)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(616, 259)
        Me.Guna2Panel2.TabIndex = 2
        '
        'btnAddLibrarian
        '
        Me.btnAddLibrarian.AutoRoundedCorners = True
        Me.btnAddLibrarian.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAddLibrarian.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddLibrarian.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAddLibrarian.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAddLibrarian.FillColor = System.Drawing.Color.White
        Me.btnAddLibrarian.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddLibrarian.ForeColor = System.Drawing.Color.Black
        Me.btnAddLibrarian.Location = New System.Drawing.Point(7, 379)
        Me.btnAddLibrarian.Name = "btnAddLibrarian"
        Me.btnAddLibrarian.Size = New System.Drawing.Size(298, 59)
        Me.btnAddLibrarian.TabIndex = 3
        Me.btnAddLibrarian.Text = "Add Librarian"
        '
        'btnRemove
        '
        Me.btnRemove.AutoRoundedCorners = True
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.White
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.ForeColor = System.Drawing.Color.Black
        Me.btnRemove.Location = New System.Drawing.Point(326, 379)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(298, 59)
        Me.btnRemove.TabIndex = 4
        Me.btnRemove.Text = "Remove"
        '
        'dgvLibrarians
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvLibrarians.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLibrarians.BackgroundColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLibrarians.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLibrarians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLibrarians.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLibrarians.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLibrarians.Location = New System.Drawing.Point(10, 6)
        Me.dgvLibrarians.Name = "dgvLibrarians"
        Me.dgvLibrarians.RowHeadersVisible = False
        Me.dgvLibrarians.RowHeadersWidth = 51
        Me.dgvLibrarians.RowTemplate.Height = 24
        Me.dgvLibrarians.Size = New System.Drawing.Size(594, 202)
        Me.dgvLibrarians.TabIndex = 0
        Me.dgvLibrarians.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLibrarians.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvLibrarians.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvLibrarians.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvLibrarians.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvLibrarians.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.dgvLibrarians.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibrarians.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvLibrarians.ThemeStyle.ReadOnly = False
        Me.dgvLibrarians.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvLibrarians.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvLibrarians.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvLibrarians.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgvLibrarians.ThemeStyle.RowsStyle.Height = 24
        Me.dgvLibrarians.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvLibrarians.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lblNumberofLibrarians
        '
        Me.lblNumberofLibrarians.AutoSize = True
        Me.lblNumberofLibrarians.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofLibrarians.Location = New System.Drawing.Point(6, 224)
        Me.lblNumberofLibrarians.Name = "lblNumberofLibrarians"
        Me.lblNumberofLibrarians.Size = New System.Drawing.Size(139, 23)
        Me.lblNumberofLibrarians.TabIndex = 1
        Me.lblNumberofLibrarians.Text = "No. of Librarians:"
        '
        'LibrarianList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAddLibrarian)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.pnlHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LibrarianList"
        Me.Text = "Librarian List"
        Me.pnlHeader.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.dgvLibrarians, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents btnBooks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button5 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnNotification As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLibrarian As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnUsers As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnAddLibrarian As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNumberofLibrarians As Label
    Friend WithEvents dgvLibrarians As Guna.UI2.WinForms.Guna2DataGridView
End Class
