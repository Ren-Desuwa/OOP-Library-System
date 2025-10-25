<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Panel_Student_
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
        Me.lbl_forgotpass = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.txtBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_cancel = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.title_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btn_createaccount = New Guna.UI2.WinForms.Guna2Button()
        Me.img_show = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.img_hide = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.title_panel.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titlelogin
        '
        Me.lbl_titlelogin.AutoSize = True
        Me.lbl_titlelogin.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titlelogin.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlelogin.Location = New System.Drawing.Point(200, 36)
        Me.lbl_titlelogin.Name = "lbl_titlelogin"
        Me.lbl_titlelogin.Size = New System.Drawing.Size(99, 39)
        Me.lbl_titlelogin.TabIndex = 13
        Me.lbl_titlelogin.Text = "Login"
        '
        'lbl_forgotpass
        '
        Me.lbl_forgotpass.AutoSize = True
        Me.lbl_forgotpass.BackColor = System.Drawing.Color.Transparent
        Me.lbl_forgotpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_forgotpass.Location = New System.Drawing.Point(288, 333)
        Me.lbl_forgotpass.Name = "lbl_forgotpass"
        Me.lbl_forgotpass.Size = New System.Drawing.Size(136, 20)
        Me.lbl_forgotpass.TabIndex = 2
        Me.lbl_forgotpass.Text = "Forgot Password"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(120, 245)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(98, 25)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(120, 121)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(148, 25)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username or ID"
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
        Me.txtBox_password.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_password.ForeColor = System.Drawing.Color.Black
        Me.txtBox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_password.Location = New System.Drawing.Point(128, 276)
        Me.txtBox_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_password.Name = "txtBox_password"
        Me.txtBox_password.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_password.PlaceholderText = "Enter Password"
        Me.txtBox_password.SelectedText = ""
        Me.txtBox_password.Size = New System.Drawing.Size(278, 57)
        Me.txtBox_password.TabIndex = 1
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
        Me.txtBox_username.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_username.ForeColor = System.Drawing.Color.Black
        Me.txtBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_username.Location = New System.Drawing.Point(128, 152)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Enter Username or ID"
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(278, 57)
        Me.txtBox_username.TabIndex = 0
        '
        'btn_login
        '
        Me.btn_login.BorderRadius = 10
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.Tan
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(58, 409)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(180, 45)
        Me.btn_login.TabIndex = 3
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
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(298, 409)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 4
        Me.btn_cancel.Text = "Cancel"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.title_panel
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'title_panel
        '
        Me.title_panel.Controls.Add(Me.Guna2ControlBox1)
        Me.title_panel.Controls.Add(Me.lbl_title)
        Me.title_panel.Controls.Add(Me.Guna2ControlBox3)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.title_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.title_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.title_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.title_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.title_panel.Location = New System.Drawing.Point(0, 0)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(1067, 56)
        Me.title_panel.TabIndex = 1
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
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(549, 556)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(-3, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(546, 200)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Unlock Worlds of Knowledge! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Dive into our vast collection, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discover your next" &
    " favorite read, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "And borrow books effortlessly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Your adventure begins here!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(5, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(533, 88)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Welcome To Library Management System"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btn_createaccount)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.img_show)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.img_hide)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_titlelogin)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtBox_password)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.txtBox_username)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btn_login)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_forgotpass)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_username)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.btn_cancel)
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.lbl_password)
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FloralWhite
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(542, 51)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(525, 505)
        Me.Guna2CustomGradientPanel3.TabIndex = 1
        '
        'btn_createaccount
        '
        Me.btn_createaccount.BackColor = System.Drawing.Color.Transparent
        Me.btn_createaccount.BorderColor = System.Drawing.Color.Transparent
        Me.btn_createaccount.BorderRadius = 10
        Me.btn_createaccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_createaccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_createaccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_createaccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_createaccount.FillColor = System.Drawing.Color.Transparent
        Me.btn_createaccount.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_createaccount.ForeColor = System.Drawing.Color.Black
        Me.btn_createaccount.Location = New System.Drawing.Point(200, 463)
        Me.btn_createaccount.Name = "btn_createaccount"
        Me.btn_createaccount.Size = New System.Drawing.Size(136, 32)
        Me.btn_createaccount.TabIndex = 5
        Me.btn_createaccount.Text = "Create Account"
        Me.btn_createaccount.UseTransparentBackground = True
        '
        'img_show
        '
        Me.img_show.BackColor = System.Drawing.Color.White
        Me.img_show.FillColor = System.Drawing.Color.Transparent
        Me.img_show.Image = Global.OOP_Library_System.My.Resources.Resources.Show_icon1
        Me.img_show.ImageRotate = 0!
        Me.img_show.Location = New System.Drawing.Point(368, 293)
        Me.img_show.Name = "img_show"
        Me.img_show.Size = New System.Drawing.Size(24, 22)
        Me.img_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_show.TabIndex = 16
        Me.img_show.TabStop = False
        '
        'img_hide
        '
        Me.img_hide.BackColor = System.Drawing.Color.White
        Me.img_hide.FillColor = System.Drawing.Color.Transparent
        Me.img_hide.Image = Global.OOP_Library_System.My.Resources.Resources.Hide_icon1
        Me.img_hide.ImageRotate = 0!
        Me.img_hide.Location = New System.Drawing.Point(368, 293)
        Me.img_hide.Name = "img_hide"
        Me.img_hide.Size = New System.Drawing.Size(24, 22)
        Me.img_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_hide.TabIndex = 15
        Me.img_hide.TabStop = False
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2PictureBox1.ErrorImage = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG2
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG2
        Me.Guna2PictureBox1.ImageLocation = ""
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(167, 56)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(211, 137)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'Login_Panel_Student_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.title_panel)
        Me.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1067, 554)
        Me.Name = "Login_Panel_Student_"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.title_panel.ResumeLayout(False)
        Me.title_panel.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_forgotpass As Label
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_titlelogin As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_title As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents img_hide As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents img_show As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btn_createaccount As Guna.UI2.WinForms.Guna2Button
End Class
