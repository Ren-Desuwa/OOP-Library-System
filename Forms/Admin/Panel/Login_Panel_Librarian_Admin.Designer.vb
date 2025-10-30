<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Panel_Librarian_Admin
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
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.img_show = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.img_hide = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.login_form_container = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.UC_Welcome_message_student1 = New OOP_Library_System.UC_Welcome_message_student()
        Me.title_panel.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.login_form_container.SuspendLayout()
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
        Me.btn_login.Location = New System.Drawing.Point(58, 424)
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
        Me.btn_cancel.Location = New System.Drawing.Point(298, 424)
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
        Me.title_panel.Controls.Add(Me.login_form_container)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.title_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.title_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.title_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.title_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.title_panel.Location = New System.Drawing.Point(0, 0)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(1048, 505)
        Me.title_panel.TabIndex = 1
        '
        'Guna2DragControl2
        '
        Me.Guna2DragControl2.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl2.TransparentWhileDrag = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel3
        '
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
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FloralWhite
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(523, 0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(525, 505)
        Me.Guna2CustomGradientPanel3.TabIndex = 1
        '
        'img_show
        '
        Me.img_show.BackColor = System.Drawing.Color.White
        Me.img_show.FillColor = System.Drawing.Color.Transparent
        'Me.img_show.Image = Global.OOP_Library_System.My.Resources.Resources.Show_icon1
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
        'Me.img_hide.Image = Global.OOP_Library_System.My.Resources.Resources.Hide_icon1
        Me.img_hide.ImageRotate = 0!
        Me.img_hide.Location = New System.Drawing.Point(368, 293)
        Me.img_hide.Name = "img_hide"
        Me.img_hide.Size = New System.Drawing.Size(24, 22)
        Me.img_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_hide.TabIndex = 15
        Me.img_hide.TabStop = False
        '
        'login_form_container
        '
        Me.login_form_container.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.login_form_container.BackColor = System.Drawing.Color.Transparent
        Me.login_form_container.BorderColor = System.Drawing.Color.DimGray
        Me.login_form_container.BorderRadius = 30
        Me.login_form_container.BorderThickness = 1
        Me.login_form_container.Controls.Add(Me.Guna2CustomGradientPanel3)
        Me.login_form_container.Controls.Add(Me.UC_Welcome_message_student1)
        Me.login_form_container.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.login_form_container.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.login_form_container.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.login_form_container.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.login_form_container.Location = New System.Drawing.Point(0, 0)
        Me.login_form_container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.login_form_container.MaximumSize = New System.Drawing.Size(1048, 505)
        Me.login_form_container.Name = "login_form_container"
        Me.login_form_container.Size = New System.Drawing.Size(1048, 505)
        Me.login_form_container.TabIndex = 16
        '
        'UC_Welcome_message_student1
        '
        Me.UC_Welcome_message_student1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UC_Welcome_message_student1.Location = New System.Drawing.Point(0, 0)
        Me.UC_Welcome_message_student1.Name = "UC_Welcome_message_student1"
        Me.UC_Welcome_message_student1.Size = New System.Drawing.Size(525, 505)
        Me.UC_Welcome_message_student1.TabIndex = 2
        '
        'Login_Panel_Librarian_Admin_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 505)
        Me.Controls.Add(Me.title_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1067, 554)
        Me.Name = "Login_Panel_Librarian_Admin_"
        Me.Text = "Login"
        Me.title_panel.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.PerformLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.login_form_container.ResumeLayout(False)
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
    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents img_hide As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents img_show As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents login_form_container As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents UC_Welcome_message_student1 As UC_Welcome_message_student
End Class
