<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ForgotPass_Student
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Borrow = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_verifynum = New Guna.UI2.WinForms.Guna2Button()
        Me.txtbox_otp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_otp = New System.Windows.Forms.Label()
        Me.btn_sendcode = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_confirmpassword = New System.Windows.Forms.Label()
        Me.txtBox_confirmpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.img_show = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.img_hide = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.btn_confirm = New Guna.UI2.WinForms.Guna2Button()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.otpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderRadius = 15
        Me.Guna2CustomGradientPanel1.BorderThickness = 5
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtBox_username)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbl_username)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_sendcode)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_verifynum)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtbox_otp)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbl_otp)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_close)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_Borrow)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbl_confirmpassword)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtBox_confirmpassword)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.img_show)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.img_hide)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtBox_password)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lbl_password)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_confirm)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(525, 505)
        Me.Guna2CustomGradientPanel1.TabIndex = 9
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BorderRadius = 10
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(469, 0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(56, 52)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "X"
        '
        'btn_Borrow
        '
        Me.btn_Borrow.BorderRadius = 20
        Me.btn_Borrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Borrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Borrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Borrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Borrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Borrow.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Borrow.ForeColor = System.Drawing.Color.White
        Me.btn_Borrow.Location = New System.Drawing.Point(688, 392)
        Me.btn_Borrow.Name = "btn_Borrow"
        Me.btn_Borrow.Size = New System.Drawing.Size(171, 52)
        Me.btn_Borrow.TabIndex = 3
        Me.btn_Borrow.Text = "Borrow"
        '
        'btn_verifynum
        '
        Me.btn_verifynum.BorderRadius = 10
        Me.btn_verifynum.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_verifynum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_verifynum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_verifynum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_verifynum.FillColor = System.Drawing.Color.Tan
        Me.btn_verifynum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_verifynum.ForeColor = System.Drawing.Color.Black
        Me.btn_verifynum.Location = New System.Drawing.Point(176, 424)
        Me.btn_verifynum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_verifynum.Name = "btn_verifynum"
        Me.btn_verifynum.Size = New System.Drawing.Size(180, 46)
        Me.btn_verifynum.TabIndex = 26
        Me.btn_verifynum.Text = "Verify"
        '
        'txtbox_otp
        '
        Me.txtbox_otp.BackColor = System.Drawing.Color.Transparent
        Me.txtbox_otp.BorderColor = System.Drawing.Color.DarkGray
        Me.txtbox_otp.BorderRadius = 10
        Me.txtbox_otp.BorderThickness = 2
        Me.txtbox_otp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_otp.DefaultText = ""
        Me.txtbox_otp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_otp.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_otp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_otp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_otp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_otp.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbox_otp.ForeColor = System.Drawing.Color.Black
        Me.txtbox_otp.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_otp.Location = New System.Drawing.Point(97, 151)
        Me.txtbox_otp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_otp.MaxLength = 10
        Me.txtbox_otp.Name = "txtbox_otp"
        Me.txtbox_otp.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtbox_otp.PlaceholderText = "Enter OTP"
        Me.txtbox_otp.SelectedText = ""
        Me.txtbox_otp.Size = New System.Drawing.Size(336, 57)
        Me.txtbox_otp.TabIndex = 25
        '
        'lbl_otp
        '
        Me.lbl_otp.AutoSize = True
        Me.lbl_otp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_otp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_otp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_otp.Location = New System.Drawing.Point(98, 128)
        Me.lbl_otp.Name = "lbl_otp"
        Me.lbl_otp.Size = New System.Drawing.Size(137, 20)
        Me.lbl_otp.TabIndex = 24
        Me.lbl_otp.Text = "Verification Code"
        '
        'btn_sendcode
        '
        Me.btn_sendcode.BorderColor = System.Drawing.Color.Transparent
        Me.btn_sendcode.BorderRadius = 10
        Me.btn_sendcode.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_sendcode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_sendcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_sendcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_sendcode.FillColor = System.Drawing.Color.Transparent
        Me.btn_sendcode.Font = New System.Drawing.Font("Segoe UI", 7.8!)
        Me.btn_sendcode.ForeColor = System.Drawing.Color.RoyalBlue
        Me.btn_sendcode.Location = New System.Drawing.Point(176, 208)
        Me.btn_sendcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sendcode.Name = "btn_sendcode"
        Me.btn_sendcode.Size = New System.Drawing.Size(168, 25)
        Me.btn_sendcode.TabIndex = 27
        Me.btn_sendcode.Text = "Send Code"
        '
        'lbl_confirmpassword
        '
        Me.lbl_confirmpassword.AutoSize = True
        Me.lbl_confirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmpassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_confirmpassword.Location = New System.Drawing.Point(120, 320)
        Me.lbl_confirmpassword.Name = "lbl_confirmpassword"
        Me.lbl_confirmpassword.Size = New System.Drawing.Size(147, 20)
        Me.lbl_confirmpassword.TabIndex = 33
        Me.lbl_confirmpassword.Text = "Confirm Password"
        Me.lbl_confirmpassword.Visible = False
        '
        'txtBox_confirmpassword
        '
        Me.txtBox_confirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_confirmpassword.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_confirmpassword.BorderRadius = 10
        Me.txtBox_confirmpassword.BorderThickness = 2
        Me.txtBox_confirmpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_confirmpassword.DefaultText = ""
        Me.txtBox_confirmpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_confirmpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_confirmpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_confirmpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_confirmpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_confirmpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_confirmpassword.ForeColor = System.Drawing.Color.Black
        Me.txtBox_confirmpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_confirmpassword.Location = New System.Drawing.Point(128, 342)
        Me.txtBox_confirmpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_confirmpassword.MaxLength = 10
        Me.txtBox_confirmpassword.Name = "txtBox_confirmpassword"
        Me.txtBox_confirmpassword.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_confirmpassword.PlaceholderText = "Enter Password"
        Me.txtBox_confirmpassword.SelectedText = ""
        Me.txtBox_confirmpassword.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_confirmpassword.TabIndex = 32
        Me.txtBox_confirmpassword.Visible = False
        '
        'img_show
        '
        Me.img_show.BackColor = System.Drawing.Color.White
        Me.img_show.FillColor = System.Drawing.Color.Transparent
        Me.img_show.Image = Global.OOP_Library_System.My.Resources.Resources.Show_icon1
        Me.img_show.ImageRotate = 0!
        Me.img_show.Location = New System.Drawing.Point(368, 282)
        Me.img_show.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_show.Name = "img_show"
        Me.img_show.Size = New System.Drawing.Size(24, 22)
        Me.img_show.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_show.TabIndex = 31
        Me.img_show.TabStop = False
        Me.img_show.Visible = False
        '
        'img_hide
        '
        Me.img_hide.BackColor = System.Drawing.Color.White
        Me.img_hide.FillColor = System.Drawing.Color.Transparent
        Me.img_hide.Image = Global.OOP_Library_System.My.Resources.Resources.Hide_icon1
        Me.img_hide.ImageRotate = 0!
        Me.img_hide.Location = New System.Drawing.Point(368, 282)
        Me.img_hide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_hide.Name = "img_hide"
        Me.img_hide.Size = New System.Drawing.Size(24, 22)
        Me.img_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_hide.TabIndex = 30
        Me.img_hide.TabStop = False
        Me.img_hide.Visible = False
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
        Me.txtBox_password.Location = New System.Drawing.Point(128, 264)
        Me.txtBox_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_password.MaxLength = 10
        Me.txtBox_password.Name = "txtBox_password"
        Me.txtBox_password.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_password.PlaceholderText = "Enter Password"
        Me.txtBox_password.SelectedText = ""
        Me.txtBox_password.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_password.TabIndex = 28
        Me.txtBox_password.Visible = False
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(120, 241)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(83, 20)
        Me.lbl_password.TabIndex = 29
        Me.lbl_password.Text = "Password"
        Me.lbl_password.Visible = False
        '
        'btn_confirm
        '
        Me.btn_confirm.BorderRadius = 10
        Me.btn_confirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_confirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_confirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_confirm.FillColor = System.Drawing.Color.Tan
        Me.btn_confirm.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_confirm.ForeColor = System.Drawing.Color.Black
        Me.btn_confirm.Location = New System.Drawing.Point(176, 424)
        Me.btn_confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_confirm.Name = "btn_confirm"
        Me.btn_confirm.Size = New System.Drawing.Size(180, 46)
        Me.btn_confirm.TabIndex = 34
        Me.btn_confirm.Text = "Confirm"
        Me.btn_confirm.Visible = False
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
        Me.txtBox_username.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBox_username.ForeColor = System.Drawing.Color.Black
        Me.txtBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_username.Location = New System.Drawing.Point(128, 64)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.MaxLength = 10
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Enter Username "
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_username.TabIndex = 35
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(128, 44)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(86, 20)
        Me.lbl_username.TabIndex = 36
        Me.lbl_username.Text = "Username"
        '
        'otpTimer
        '
        Me.otpTimer.Interval = 1000
        '
        'ForgotPass_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 505)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ForgotPass_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Borrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_verifynum As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbox_otp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_otp As Label
    Friend WithEvents btn_sendcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_confirmpassword As Label
    Friend WithEvents txtBox_confirmpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents img_show As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents img_hide As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_password As Label
    Friend WithEvents btn_confirm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_username As Label
    Friend WithEvents otpTimer As Timer
End Class
