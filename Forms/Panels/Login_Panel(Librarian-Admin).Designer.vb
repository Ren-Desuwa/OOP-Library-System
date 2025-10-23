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
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_titlelogin = New System.Windows.Forms.Label()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2DragControl2 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lbl_titlelogin)
        Me.Panel1.Controls.Add(Me.lbl_show)
        Me.Panel1.Controls.Add(Me.lbl_hide)
        Me.Panel1.Controls.Add(Me.lbl_forgotpass)
        Me.Panel1.Controls.Add(Me.lbl_verifiedid)
        Me.Panel1.Controls.Add(Me.lbl_password)
        Me.Panel1.Controls.Add(Me.lbl_username)
        Me.Panel1.Controls.Add(Me.txtBox_verifiedid)
        Me.Panel1.Controls.Add(Me.txtBox_password)
        Me.Panel1.Controls.Add(Me.txtBox_username)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Location = New System.Drawing.Point(531, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(536, 562)
        Me.Panel1.TabIndex = 1
        '
        'lbl_show
        '
        Me.lbl_show.AutoSize = True
        Me.lbl_show.BackColor = System.Drawing.Color.Transparent
        Me.lbl_show.Location = New System.Drawing.Point(362, 297)
        Me.lbl_show.Name = "lbl_show"
        Me.lbl_show.Size = New System.Drawing.Size(40, 16)
        Me.lbl_show.TabIndex = 10
        Me.lbl_show.Text = "Show"
        '
        'lbl_hide
        '
        Me.lbl_hide.AutoSize = True
        Me.lbl_hide.BackColor = System.Drawing.Color.Transparent
        Me.lbl_hide.Location = New System.Drawing.Point(366, 297)
        Me.lbl_hide.Name = "lbl_hide"
        Me.lbl_hide.Size = New System.Drawing.Size(36, 16)
        Me.lbl_hide.TabIndex = 9
        Me.lbl_hide.Text = "Hide"
        '
        'lbl_forgotpass
        '
        Me.lbl_forgotpass.AutoSize = True
        Me.lbl_forgotpass.Location = New System.Drawing.Point(303, 331)
        Me.lbl_forgotpass.Name = "lbl_forgotpass"
        Me.lbl_forgotpass.Size = New System.Drawing.Size(109, 16)
        Me.lbl_forgotpass.TabIndex = 8
        Me.lbl_forgotpass.Text = "Forgot Password"
        '
        'lbl_verifiedid
        '
        Me.lbl_verifiedid.AutoSize = True
        Me.lbl_verifiedid.Location = New System.Drawing.Point(162, 357)
        Me.lbl_verifiedid.Name = "lbl_verifiedid"
        Me.lbl_verifiedid.Size = New System.Drawing.Size(69, 16)
        Me.lbl_verifiedid.TabIndex = 7
        Me.lbl_verifiedid.Text = "Verified ID"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.Location = New System.Drawing.Point(162, 259)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(67, 16)
        Me.lbl_password.TabIndex = 6
        Me.lbl_password.Text = "Password"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(163, 172)
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
        Me.txtBox_verifiedid.Location = New System.Drawing.Point(165, 377)
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
        Me.txtBox_password.Location = New System.Drawing.Point(166, 279)
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
        Me.txtBox_username.Location = New System.Drawing.Point(166, 192)
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
        Me.btn_login.Location = New System.Drawing.Point(79, 481)
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
        Me.btn_cancel.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_cancel.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.Black
        Me.btn_cancel.Location = New System.Drawing.Point(319, 481)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(180, 45)
        Me.btn_cancel.TabIndex = 0
        Me.btn_cancel.Text = "Cancel"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Tan
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(535, 554)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Tan
        Me.Panel3.Controls.Add(Me.btn_close)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.lbl_title)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1067, 56)
        Me.Panel3.TabIndex = 3
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BorderColor = System.Drawing.Color.Transparent
        Me.btn_close.BorderRadius = 12
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Location = New System.Drawing.Point(999, -1)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(67, 50)
        Me.btn_close.TabIndex = 11
        Me.btn_close.Text = "X"
        Me.btn_close.UseTransparentBackground = True
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(405, 8)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(242, 41)
        Me.lbl_title.TabIndex = 12
        Me.lbl_title.Text = "Library System"
        '
        'lbl_titlelogin
        '
        Me.lbl_titlelogin.AutoSize = True
        Me.lbl_titlelogin.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlelogin.Location = New System.Drawing.Point(226, 92)
        Me.lbl_titlelogin.Name = "lbl_titlelogin"
        Me.lbl_titlelogin.Size = New System.Drawing.Size(101, 41)
        Me.lbl_titlelogin.TabIndex = 13
        Me.lbl_titlelogin.Text = "Login"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Panel3
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
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Moccasin
        Me.Panel4.Location = New System.Drawing.Point(0, 45)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1067, 10)
        Me.Panel4.TabIndex = 0
        '
        'Login_Panel_Librarian_Admin_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login_Panel_Librarian_Admin_"
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_cancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtBox_verifiedid As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtBox_password As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_verifiedid As Label
    Friend WithEvents lbl_password As Label
    Friend WithEvents lbl_username As Label
    Friend WithEvents lbl_forgotpass As Label
    Friend WithEvents lbl_hide As Label
    Friend WithEvents lbl_show As Label
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lbl_title As Label
    Friend WithEvents lbl_titlelogin As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2DragControl2 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Panel4 As Panel
End Class
