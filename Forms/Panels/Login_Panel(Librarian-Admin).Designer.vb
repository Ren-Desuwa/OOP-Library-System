<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Panel_Librarian_Admin_
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
        Me.lbl_titlelogin = New System.Windows.Forms.Label()
        Me.lbl_show = New System.Windows.Forms.Label()
        Me.lbl_hide = New System.Windows.Forms.Label()
        Me.lbl_forgotpass = New System.Windows.Forms.Label()
        Me.lbl_verifiedid = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txtBox_verifiedid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titlelogin
        '
        Me.lbl_titlelogin.AutoSize = True
        Me.lbl_titlelogin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titlelogin.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlelogin.Location = New System.Drawing.Point(225, 45)
        Me.lbl_titlelogin.Name = "lbl_titlelogin"
        Me.lbl_titlelogin.Size = New System.Drawing.Size(99, 39)
        Me.lbl_titlelogin.TabIndex = 13
        Me.lbl_titlelogin.Text = "Login"
        '
        'lbl_show
        '
        Me.lbl_show.AutoSize = True
        Me.lbl_show.BackColor = System.Drawing.Color.White
        Me.lbl_show.Location = New System.Drawing.Point(350, 250)
        Me.lbl_show.Name = "lbl_show"
        Me.lbl_show.Size = New System.Drawing.Size(40, 16)
        Me.lbl_show.TabIndex = 10
        Me.lbl_show.Text = "Show"
        '
        'lbl_hide
        '
        Me.lbl_hide.AutoSize = True
        Me.lbl_hide.BackColor = System.Drawing.Color.White
        Me.lbl_hide.Location = New System.Drawing.Point(353, 250)
        Me.lbl_hide.Name = "lbl_hide"
        Me.lbl_hide.Size = New System.Drawing.Size(36, 16)
        Me.lbl_hide.TabIndex = 9
        Me.lbl_hide.Text = "Hide"
        '
        'lbl_forgotpass
        '
        Me.lbl_forgotpass.AutoSize = True
        Me.lbl_forgotpass.Location = New System.Drawing.Point(302, 284)
        Me.lbl_forgotpass.Name = "lbl_forgotpass"
        Me.lbl_forgotpass.Size = New System.Drawing.Size(109, 16)
        Me.lbl_forgotpass.TabIndex = 8
        Me.lbl_forgotpass.Text = "Forgot Password"
        '
        'lbl_verifiedid
        '
        Me.lbl_verifiedid.AutoSize = True
        Me.lbl_verifiedid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_verifiedid.Location = New System.Drawing.Point(161, 310)
        Me.lbl_verifiedid.Name = "lbl_verifiedid"
        Me.lbl_verifiedid.Size = New System.Drawing.Size(69, 16)
        Me.lbl_verifiedid.TabIndex = 7
        Me.lbl_verifiedid.Text = "Verified ID"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Location = New System.Drawing.Point(161, 212)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(67, 16)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Location = New System.Drawing.Point(162, 125)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(70, 16)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'txtBox_verifiedid
        '
        Me.txtBox_verifiedid.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_verifiedid.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_verifiedid.BorderRadius = 10
        Me.txtBox_verifiedid.BorderThickness = 2
        Me.txtBox_verifiedid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_verifiedid.DefaultText = ""
        Me.txtBox_verifiedid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_verifiedid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_verifiedid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_verifiedid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_verifiedid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_verifiedid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBox_verifiedid.ForeColor = System.Drawing.Color.Black
        Me.txtBox_verifiedid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_verifiedid.Location = New System.Drawing.Point(164, 330)
        Me.txtBox_verifiedid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_verifiedid.Name = "txtBox_verifiedid"
        Me.txtBox_verifiedid.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_verifiedid.PlaceholderText = "Enter Verified ID"
        Me.txtBox_verifiedid.SelectedText = ""
        Me.txtBox_verifiedid.Size = New System.Drawing.Size(246, 48)
        Me.txtBox_verifiedid.TabIndex = 4
        '
        'txtBox_password
        '
        Me.txtBox_password.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_password.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_password.BorderRadius = 10
        Me.txtBox_password.BorderThickness = 2
        Me.txtBox_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_password.DefaultText = ""
        Me.txtBox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_password.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBox_password.ForeColor = System.Drawing.Color.Black
        Me.txtBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_password.Location = New System.Drawing.Point(164, 232)
        Me.txtBox_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_password.Name = "txtBox_password"
        Me.txtBox_password.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_password.PlaceholderText = "Enter Password"
        Me.txtBox_password.SelectedText = ""
        Me.txtBox_password.Size = New System.Drawing.Size(246, 48)
        Me.txtBox_password.TabIndex = 3
        '
        'txtBox_username
        '
        Me.txtBox_username.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_username.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.BorderRadius = 10
        Me.txtBox_username.BorderThickness = 2
        Me.txtBox_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_username.DefaultText = ""
        Me.txtBox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_username.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBox_username.ForeColor = System.Drawing.Color.Black
        Me.txtBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_username.Location = New System.Drawing.Point(165, 145)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Enter Username"
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(246, 48)
        Me.txtBox_username.TabIndex = 2
        '
        'btn_login
        '
        Me.btn_login.BorderRadius = 10
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.Tan
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(78, 434)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(180, 45)
        Me.btn_login.TabIndex = 1
        Me.btn_login.Text = "Confirm"
        '
        'btn_cancel
        '
        Me.btn_cancel.BorderColor = System.Drawing.Color.DimGray
        Me.btn_cancel.BorderRadius = 10
        Me.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(318, 434)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TargetControl = Me.lbl_title
        Me.Guna2DragControl2.TransparentWhileDrag = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(554, 556)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lbl_title)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2ControlBox3)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(1067, 56)
        Me.Guna2CustomGradientPanel2.TabIndex = 1
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_show)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_hide)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_titlelogin)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtBox_verifiedid)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtBox_password)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtBox_username)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btn_login)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_forgotpass)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_username)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_verifiedid)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btn_cancel)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_password)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FloralWhite
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(531, 37)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(536, 519)
        Me.Guna2CustomGradientPanel3.TabIndex = 1
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(435, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(235, 39)
        Me.lbl_title.TabIndex = 12
        Me.lbl_title.Text = "Library System"
        '
        'Guna2ControlBox3
        '
        Me.Guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.BorderColor = System.Drawing.Color.Brown
        Me.Guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.Guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox3.CustomIconSize = 20.0!
        Me.Guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox3.ForeColor = System.Drawing.Color.Brown
        Me.Guna2ControlBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2ControlBox3.Location = New System.Drawing.Point(954, -22)
        Me.Guna2ControlBox3.Name = "Guna2ControlBox3"
        Me.Guna2ControlBox3.Size = New System.Drawing.Size(75, 78)
        Me.Guna2ControlBox3.TabIndex = 15
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
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1016, -4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(52, 59)
        Me.Guna2ControlBox1.TabIndex = 13
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(141, 182)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(300, 200)
        Me.Guna2PictureBox1.TabIndex = 0
        Me.Guna2PictureBox1.TabStop = False
        '
        'Login_Panel_Librarian_Admin_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login_Panel_Librarian_Admin_"
        Me.Text = "Login"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBox_verifiedid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_verifiedid As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_forgotpass As Label
    Friend WithEvents lbl_hide As Label
    Friend WithEvents lbl_show As Label
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_titlelogin As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
