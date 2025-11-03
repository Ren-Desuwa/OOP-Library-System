<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Signup_student
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
        Me.Panel_Step1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lbl_studentid = New System.Windows.Forms.Label()
        Me.txtBox_studentid = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_confirmpassword = New System.Windows.Forms.Label()
        Me.txtBox_confirmpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.img_show = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.img_hide = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_titlesignup = New System.Windows.Forms.Label()
        Me.txtBox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_next = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.Panel_Step1.SuspendLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel_Step1
        '
        Me.Panel_Step1.BorderRadius = 30
        Me.Panel_Step1.Controls.Add(Me.lbl_studentid)
        Me.Panel_Step1.Controls.Add(Me.txtBox_studentid)
        Me.Panel_Step1.Controls.Add(Me.lbl_confirmpassword)
        Me.Panel_Step1.Controls.Add(Me.txtBox_confirmpassword)
        Me.Panel_Step1.Controls.Add(Me.img_show)
        Me.Panel_Step1.Controls.Add(Me.img_hide)
        Me.Panel_Step1.Controls.Add(Me.lbl_titlesignup)
        Me.Panel_Step1.Controls.Add(Me.txtBox_password)
        Me.Panel_Step1.Controls.Add(Me.txtBox_username)
        Me.Panel_Step1.Controls.Add(Me.btn_next)
        Me.Panel_Step1.Controls.Add(Me.lbl_username)
        Me.Panel_Step1.Controls.Add(Me.btn_login)
        Me.Panel_Step1.Controls.Add(Me.lbl_password)
        Me.Panel_Step1.CustomizableEdges.BottomLeft = False
        Me.Panel_Step1.CustomizableEdges.TopLeft = False
        Me.Panel_Step1.FillColor = System.Drawing.Color.FloralWhite
        Me.Panel_Step1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Panel_Step1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Panel_Step1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Panel_Step1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_Step1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel_Step1.Name = "Panel_Step1"
        Me.Panel_Step1.Size = New System.Drawing.Size(525, 505)
        Me.Panel_Step1.TabIndex = 2
        '
        'lbl_studentid
        '
        Me.lbl_studentid.AutoSize = True
        Me.lbl_studentid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studentid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studentid.Location = New System.Drawing.Point(128, 177)
        Me.lbl_studentid.Name = "lbl_studentid"
        Me.lbl_studentid.Size = New System.Drawing.Size(88, 20)
        Me.lbl_studentid.TabIndex = 20
        Me.lbl_studentid.Text = "Student ID"
        '
        'txtBox_studentid
        '
        Me.txtBox_studentid.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_studentid.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_studentid.BorderRadius = 10
        Me.txtBox_studentid.BorderThickness = 2
        Me.txtBox_studentid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_studentid.DefaultText = ""
        Me.txtBox_studentid.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_studentid.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_studentid.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_studentid.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_studentid.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_studentid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBox_studentid.ForeColor = System.Drawing.Color.Black
        Me.txtBox_studentid.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_studentid.Location = New System.Drawing.Point(128, 197)
        Me.txtBox_studentid.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_studentid.MaxLength = 10
        Me.txtBox_studentid.Name = "txtBox_studentid"
        Me.txtBox_studentid.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_studentid.PlaceholderText = "Enter Student ID"
        Me.txtBox_studentid.SelectedText = ""
        Me.txtBox_studentid.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_studentid.TabIndex = 19
        '
        'lbl_confirmpassword
        '
        Me.lbl_confirmpassword.AutoSize = True
        Me.lbl_confirmpassword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_confirmpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_confirmpassword.Location = New System.Drawing.Point(120, 335)
        Me.lbl_confirmpassword.Name = "lbl_confirmpassword"
        Me.lbl_confirmpassword.Size = New System.Drawing.Size(147, 20)
        Me.lbl_confirmpassword.TabIndex = 18
        Me.lbl_confirmpassword.Text = "Confirm Password"
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
        Me.txtBox_confirmpassword.Location = New System.Drawing.Point(128, 357)
        Me.txtBox_confirmpassword.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_confirmpassword.MaxLength = 10
        Me.txtBox_confirmpassword.Name = "txtBox_confirmpassword"
        Me.txtBox_confirmpassword.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_confirmpassword.PlaceholderText = "Enter Password"
        Me.txtBox_confirmpassword.SelectedText = ""
        Me.txtBox_confirmpassword.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_confirmpassword.TabIndex = 17
        '
        'img_show
        '
        Me.img_show.BackColor = System.Drawing.Color.White
        Me.img_show.FillColor = System.Drawing.Color.Transparent
        Me.img_show.Image = Global.OOP_Library_System.My.Resources.Resources.Show_icon1
        Me.img_show.ImageRotate = 0!
        Me.img_show.Location = New System.Drawing.Point(368, 297)
        Me.img_show.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.img_hide.Location = New System.Drawing.Point(368, 297)
        Me.img_hide.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.img_hide.Name = "img_hide"
        Me.img_hide.Size = New System.Drawing.Size(24, 22)
        Me.img_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.img_hide.TabIndex = 15
        Me.img_hide.TabStop = False
        '
        'lbl_titlesignup
        '
        Me.lbl_titlesignup.AutoSize = True
        Me.lbl_titlesignup.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titlesignup.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlesignup.Location = New System.Drawing.Point(168, 32)
        Me.lbl_titlesignup.Name = "lbl_titlesignup"
        Me.lbl_titlesignup.Size = New System.Drawing.Size(193, 39)
        Me.lbl_titlesignup.TabIndex = 13
        Me.lbl_titlesignup.Text = "Registration"
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
        Me.txtBox_password.Location = New System.Drawing.Point(128, 279)
        Me.txtBox_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_password.MaxLength = 10
        Me.txtBox_password.Name = "txtBox_password"
        Me.txtBox_password.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_password.PlaceholderText = "Enter Password"
        Me.txtBox_password.SelectedText = ""
        Me.txtBox_password.Size = New System.Drawing.Size(277, 57)
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
        Me.txtBox_username.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBox_username.ForeColor = System.Drawing.Color.Black
        Me.txtBox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_username.Location = New System.Drawing.Point(128, 118)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.MaxLength = 10
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Enter Username "
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_username.TabIndex = 0
        '
        'btn_next
        '
        Me.btn_next.BorderRadius = 10
        Me.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_next.FillColor = System.Drawing.Color.Tan
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_next.ForeColor = System.Drawing.Color.Black
        Me.btn_next.Location = New System.Drawing.Point(59, 433)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(180, 46)
        Me.btn_next.TabIndex = 3
        Me.btn_next.Text = "Next"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(128, 98)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(86, 20)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'btn_login
        '
        Me.btn_login.BorderColor = System.Drawing.Color.DimGray
        Me.btn_login.BorderRadius = 10
        Me.btn_login.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_login.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_login.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_login.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Location = New System.Drawing.Point(299, 433)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(180, 46)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Back to Login"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.Location = New System.Drawing.Point(120, 256)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(83, 20)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Password"
        '
        'UC_Signup_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel_Step1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_Signup_student"
        Me.Size = New System.Drawing.Size(525, 505)
        Me.Panel_Step1.ResumeLayout(False)
        Me.Panel_Step1.PerformLayout()
        CType(Me.img_show, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_hide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Step1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_studentid As Label
    Friend WithEvents txtBox_studentid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_confirmpassword As Label
    Friend WithEvents txtBox_confirmpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents img_show As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents img_hide As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_titlesignup As Label
    Friend WithEvents txtBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_password As Label
End Class
