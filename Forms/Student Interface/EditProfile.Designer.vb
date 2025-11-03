<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditProfile
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
        Me.picBox_profile = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.lbl_editavatar = New System.Windows.Forms.LinkLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.picbox_QRcode = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtbox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2DateTimePicker1 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.btn_confirmchanges = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(Me.picBox_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_QRcode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picBox_profile
        '
        Me.picBox_profile.FillColor = System.Drawing.Color.Transparent
        Me.picBox_profile.Image = Global.OOP_Library_System.My.Resources.Resources.Accountwhite0_icon
        Me.picBox_profile.ImageRotate = 0!
        Me.picBox_profile.Location = New System.Drawing.Point(12, 12)
        Me.picBox_profile.Name = "picBox_profile"
        Me.picBox_profile.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.picBox_profile.Size = New System.Drawing.Size(163, 149)
        Me.picBox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBox_profile.TabIndex = 0
        Me.picBox_profile.TabStop = False
        '
        'lbl_editavatar
        '
        Me.lbl_editavatar.AutoSize = True
        Me.lbl_editavatar.LinkColor = System.Drawing.Color.Black
        Me.lbl_editavatar.Location = New System.Drawing.Point(59, 164)
        Me.lbl_editavatar.Name = "lbl_editavatar"
        Me.lbl_editavatar.Size = New System.Drawing.Size(72, 16)
        Me.lbl_editavatar.TabIndex = 1
        Me.lbl_editavatar.TabStop = True
        Me.lbl_editavatar.Text = "Edit Avatar"
        Me.lbl_editavatar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.AutoSize = False
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(12, 229)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(194, 33)
        Me.Guna2HtmlLabel2.TabIndex = 0
        Me.Guna2HtmlLabel2.Text = "Nickname:"
        '
        'picbox_QRcode
        '
        Me.picbox_QRcode.ImageRotate = 0!
        Me.picbox_QRcode.Location = New System.Drawing.Point(270, 12)
        Me.picbox_QRcode.Name = "picbox_QRcode"
        Me.picbox_QRcode.Size = New System.Drawing.Size(173, 149)
        Me.picbox_QRcode.TabIndex = 0
        Me.picbox_QRcode.TabStop = False
        '
        'txtbox_username
        '
        Me.txtbox_username.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtbox_username.BorderColor = System.Drawing.Color.Gray
        Me.txtbox_username.BorderRadius = 2
        Me.txtbox_username.BorderThickness = 2
        Me.txtbox_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_username.DefaultText = ""
        Me.txtbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbox_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_username.Location = New System.Drawing.Point(12, 269)
        Me.txtbox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.PlaceholderText = ""
        Me.txtbox_username.SelectedText = ""
        Me.txtbox_username.Size = New System.Drawing.Size(431, 38)
        Me.txtbox_username.TabIndex = 2
        '
        'Guna2DateTimePicker1
        '
        Me.Guna2DateTimePicker1.BackColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2DateTimePicker1.BorderRadius = 2
        Me.Guna2DateTimePicker1.BorderThickness = 2
        Me.Guna2DateTimePicker1.Checked = True
        Me.Guna2DateTimePicker1.FillColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.FocusedColor = System.Drawing.Color.White
        Me.Guna2DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Guna2DateTimePicker1.Location = New System.Drawing.Point(12, 351)
        Me.Guna2DateTimePicker1.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Guna2DateTimePicker1.Name = "Guna2DateTimePicker1"
        Me.Guna2DateTimePicker1.Size = New System.Drawing.Size(268, 41)
        Me.Guna2DateTimePicker1.TabIndex = 10
        Me.Guna2DateTimePicker1.Value = New Date(2025, 10, 28, 2, 3, 30, 955)
        '
        'btn_confirmchanges
        '
        Me.btn_confirmchanges.BorderColor = System.Drawing.Color.Gray
        Me.btn_confirmchanges.BorderRadius = 2
        Me.btn_confirmchanges.BorderThickness = 5
        Me.btn_confirmchanges.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirmchanges.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirmchanges.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_confirmchanges.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_confirmchanges.FillColor = System.Drawing.Color.White
        Me.btn_confirmchanges.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_confirmchanges.ForeColor = System.Drawing.Color.Black
        Me.btn_confirmchanges.Location = New System.Drawing.Point(12, 438)
        Me.btn_confirmchanges.Name = "btn_confirmchanges"
        Me.btn_confirmchanges.Size = New System.Drawing.Size(218, 48)
        Me.btn_confirmchanges.TabIndex = 13
        Me.btn_confirmchanges.Tag = ""
        Me.btn_confirmchanges.Text = "Confirm Changes"
        Me.btn_confirmchanges.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'btn_back
        '
        Me.btn_back.BorderColor = System.Drawing.Color.Gray
        Me.btn_back.BorderRadius = 2
        Me.btn_back.BorderThickness = 5
        Me.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_back.FillColor = System.Drawing.Color.White
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Location = New System.Drawing.Point(279, 438)
        Me.btn_back.MaximumSize = New System.Drawing.Size(164, 48)
        Me.btn_back.MinimumSize = New System.Drawing.Size(164, 48)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(164, 48)
        Me.btn_back.TabIndex = 14
        Me.btn_back.Text = "Back"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(3, 3)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(111, 33)
        Me.Guna2HtmlLabel3.TabIndex = 0
        Me.Guna2HtmlLabel3.Text = "Birthday:"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.AutoSize = False
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(12, 314)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(194, 33)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "Birthday:"
        '
        'EditProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(456, 504)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Controls.Add(Me.picbox_QRcode)
        Me.Controls.Add(Me.picBox_profile)
        Me.Controls.Add(Me.txtbox_username)
        Me.Controls.Add(Me.lbl_editavatar)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_confirmchanges)
        Me.Controls.Add(Me.Guna2DateTimePicker1)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EditProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "3"
        CType(Me.picBox_profile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_QRcode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBox_profile As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents lbl_editavatar As LinkLabel

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles picBox_profile.Click

    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2DateTimePicker1.ValueChanged

    End Sub

    Friend WithEvents btn_confirmchanges As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents picbox_QRcode As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Guna2DateTimePicker1 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
