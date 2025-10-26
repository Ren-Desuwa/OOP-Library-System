<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Signup2_student
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel_Step1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtBox_contactnum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbox_otp = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lbl_otp = New System.Windows.Forms.Label()
        Me.lbl_titlesignup = New System.Windows.Forms.Label()
        Me.btn_register = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_contactnum = New System.Windows.Forms.Label()
        Me.btn_backstepone = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_sendcode = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_verifynum = New Guna.UI2.WinForms.Guna2Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.otpTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel_Step1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Step1
        '
        Me.Panel_Step1.BorderRadius = 30
        Me.Panel_Step1.Controls.Add(Me.btn_verifynum)
        Me.Panel_Step1.Controls.Add(Me.txtBox_contactnum)
        Me.Panel_Step1.Controls.Add(Me.txtbox_otp)
        Me.Panel_Step1.Controls.Add(Me.lbl_otp)
        Me.Panel_Step1.Controls.Add(Me.lbl_titlesignup)
        Me.Panel_Step1.Controls.Add(Me.btn_register)
        Me.Panel_Step1.Controls.Add(Me.lbl_contactnum)
        Me.Panel_Step1.Controls.Add(Me.btn_backstepone)
        Me.Panel_Step1.Controls.Add(Me.btn_sendcode)
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
        Me.Panel_Step1.TabIndex = 3
        '
        'txtBox_contactnum
        '
        Me.txtBox_contactnum.BackColor = System.Drawing.Color.Transparent
        Me.txtBox_contactnum.BorderColor = System.Drawing.Color.DarkGray
        Me.txtBox_contactnum.BorderRadius = 10
        Me.txtBox_contactnum.BorderThickness = 2
        Me.txtBox_contactnum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBox_contactnum.DefaultText = ""
        Me.txtBox_contactnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBox_contactnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBox_contactnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_contactnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBox_contactnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_contactnum.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtBox_contactnum.ForeColor = System.Drawing.Color.Black
        Me.txtBox_contactnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBox_contactnum.Location = New System.Drawing.Point(128, 148)
        Me.txtBox_contactnum.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_contactnum.MaxLength = 16
        Me.txtBox_contactnum.Name = "txtBox_contactnum"
        Me.txtBox_contactnum.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_contactnum.PlaceholderText = "e.g., 0917 123 4567"
        Me.txtBox_contactnum.SelectedText = ""
        Me.txtBox_contactnum.Size = New System.Drawing.Size(277, 57)
        Me.txtBox_contactnum.TabIndex = 0
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
        Me.txtbox_otp.Location = New System.Drawing.Point(128, 272)
        Me.txtbox_otp.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtbox_otp.MaxLength = 10
        Me.txtbox_otp.Name = "txtbox_otp"
        Me.txtbox_otp.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtbox_otp.PlaceholderText = "Enter OTP"
        Me.txtbox_otp.SelectedText = ""
        Me.txtbox_otp.Size = New System.Drawing.Size(277, 57)
        Me.txtbox_otp.TabIndex = 21
        '
        'lbl_otp
        '
        Me.lbl_otp.AutoSize = True
        Me.lbl_otp.BackColor = System.Drawing.Color.Transparent
        Me.lbl_otp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_otp.Location = New System.Drawing.Point(128, 249)
        Me.lbl_otp.Name = "lbl_otp"
        Me.lbl_otp.Size = New System.Drawing.Size(137, 20)
        Me.lbl_otp.TabIndex = 20
        Me.lbl_otp.Text = "Verification Code"
        '
        'lbl_titlesignup
        '
        Me.lbl_titlesignup.AutoSize = True
        Me.lbl_titlesignup.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titlesignup.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlesignup.Location = New System.Drawing.Point(152, 32)
        Me.lbl_titlesignup.Name = "lbl_titlesignup"
        Me.lbl_titlesignup.Size = New System.Drawing.Size(226, 39)
        Me.lbl_titlesignup.TabIndex = 13
        Me.lbl_titlesignup.Text = "Verify Number"
        '
        'btn_register
        '
        Me.btn_register.BorderRadius = 10
        Me.btn_register.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_register.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_register.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_register.FillColor = System.Drawing.Color.Tan
        Me.btn_register.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_register.ForeColor = System.Drawing.Color.Black
        Me.btn_register.Location = New System.Drawing.Point(59, 433)
        Me.btn_register.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(180, 46)
        Me.btn_register.TabIndex = 3
        Me.btn_register.Text = "Register"
        Me.btn_register.Visible = False
        '
        'lbl_contactnum
        '
        Me.lbl_contactnum.AutoSize = True
        Me.lbl_contactnum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contactnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contactnum.Location = New System.Drawing.Point(128, 128)
        Me.lbl_contactnum.Name = "lbl_contactnum"
        Me.lbl_contactnum.Size = New System.Drawing.Size(122, 20)
        Me.lbl_contactnum.TabIndex = 5
        Me.lbl_contactnum.Text = "Mobile Number"
        '
        'btn_backstepone
        '
        Me.btn_backstepone.BorderColor = System.Drawing.Color.DimGray
        Me.btn_backstepone.BorderRadius = 10
        Me.btn_backstepone.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_backstepone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_backstepone.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_backstepone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_backstepone.FillColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btn_backstepone.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backstepone.ForeColor = System.Drawing.Color.Black
        Me.btn_backstepone.Location = New System.Drawing.Point(299, 433)
        Me.btn_backstepone.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_backstepone.Name = "btn_backstepone"
        Me.btn_backstepone.Size = New System.Drawing.Size(180, 46)
        Me.btn_backstepone.TabIndex = 4
        Me.btn_backstepone.Text = "Back"
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
        Me.btn_sendcode.Location = New System.Drawing.Point(176, 204)
        Me.btn_sendcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_sendcode.Name = "btn_sendcode"
        Me.btn_sendcode.Size = New System.Drawing.Size(168, 25)
        Me.btn_sendcode.TabIndex = 22
        Me.btn_sendcode.Text = "Send Code"
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
        Me.btn_verifynum.Location = New System.Drawing.Point(59, 433)
        Me.btn_verifynum.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_verifynum.Name = "btn_verifynum"
        Me.btn_verifynum.Size = New System.Drawing.Size(180, 46)
        Me.btn_verifynum.TabIndex = 23
        Me.btn_verifynum.Text = "Verify"
        '
        'otpTimer
        '
        Me.otpTimer.Interval = 1000
        '
        'UC_Signup2_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel_Step1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UC_Signup2_student"
        Me.Size = New System.Drawing.Size(525, 505)
        Me.Panel_Step1.ResumeLayout(False)
        Me.Panel_Step1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Step1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_otp As Label
    Friend WithEvents lbl_titlesignup As Label
    Friend WithEvents txtBox_contactnum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_register As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_contactnum As Label
    Friend WithEvents btn_backstepone As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtbox_otp As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_sendcode As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_verifynum As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents otpTimer As Timer
End Class
