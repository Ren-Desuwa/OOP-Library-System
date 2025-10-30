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
        Me.Panel_Step1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Datetime_picker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.lbl_studentid = New System.Windows.Forms.Label()
        Me.lbl_titlesignup = New System.Windows.Forms.Label()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_next = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_Step1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel_Step1
        '
        Me.Panel_Step1.BorderRadius = 30
        Me.Panel_Step1.Controls.Add(Me.Datetime_picker)
        Me.Panel_Step1.Controls.Add(Me.lbl_studentid)
        Me.Panel_Step1.Controls.Add(Me.lbl_titlesignup)
        Me.Panel_Step1.Controls.Add(Me.txtBox_username)
        Me.Panel_Step1.Controls.Add(Me.btn_next)
        Me.Panel_Step1.Controls.Add(Me.lbl_username)
        Me.Panel_Step1.Controls.Add(Me.btn_login)
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
        'Datetime_picker
        '
        Me.Datetime_picker.BackColor = System.Drawing.Color.Transparent
        Me.Datetime_picker.BorderColor = System.Drawing.Color.DarkGray
        Me.Datetime_picker.BorderRadius = 10
        Me.Datetime_picker.BorderThickness = 2
        Me.Datetime_picker.Checked = True
        Me.Datetime_picker.FillColor = System.Drawing.Color.White
        Me.Datetime_picker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Datetime_picker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Datetime_picker.Location = New System.Drawing.Point(128, 276)
        Me.Datetime_picker.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Datetime_picker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Datetime_picker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Datetime_picker.Name = "Datetime_picker"
        Me.Datetime_picker.Size = New System.Drawing.Size(277, 57)
        Me.Datetime_picker.TabIndex = 21
        Me.Datetime_picker.Value = New Date(2025, 10, 26, 4, 23, 46, 473)
        '
        'lbl_studentid
        '
        Me.lbl_studentid.AutoSize = True
        Me.lbl_studentid.BackColor = System.Drawing.Color.Transparent
        Me.lbl_studentid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_studentid.Location = New System.Drawing.Point(128, 249)
        Me.lbl_studentid.Name = "lbl_studentid"
        Me.lbl_studentid.Size = New System.Drawing.Size(86, 20)
        Me.lbl_studentid.TabIndex = 20
        Me.lbl_studentid.Text = "Birth Date"
        '
        'lbl_titlesignup
        '
        Me.lbl_titlesignup.AutoSize = True
        Me.lbl_titlesignup.BackColor = System.Drawing.Color.Transparent
        Me.lbl_titlesignup.Font = New System.Drawing.Font("Roboto", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titlesignup.Location = New System.Drawing.Point(200, 30)
        Me.lbl_titlesignup.Name = "lbl_titlesignup"
        Me.lbl_titlesignup.Size = New System.Drawing.Size(119, 39)
        Me.lbl_titlesignup.TabIndex = 13
        Me.lbl_titlesignup.Text = "Signup"
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
        Me.txtBox_username.Location = New System.Drawing.Point(128, 148)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.MaxLength = 10
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Enter Number"
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
        Me.btn_next.Text = "Confirm"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(128, 128)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(131, 20)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Contact Number"
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
        Me.btn_login.Text = "Back"
        '
        'UC_Signup2_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel_Step1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UC_Signup2_student"
        Me.Size = New System.Drawing.Size(525, 505)
        Me.Panel_Step1.ResumeLayout(False)
        Me.Panel_Step1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel_Step1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_studentid As Label
    Friend WithEvents lbl_titlesignup As Label
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_username As Label
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Datetime_picker As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
