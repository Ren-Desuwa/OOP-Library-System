<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserReqViewProfile
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.imgProfile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtboxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxAge = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnAccept = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(600, 380)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.004845!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.004845!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.00282!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.004845!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.01163!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.295464!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.002342!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33418!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33418!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.004845!))
        Me.TableLayoutPanel1.Controls.Add(Me.imgProfile, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxName, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxAge, 5, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxCourse, 5, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxEmail, 5, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxContact, 5, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxID, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAccept, 8, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Button1, 7, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2ControlBox1, 9, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.13934!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64843!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.787418!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64843!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.787418!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64843!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.787418!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64843!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.787418!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64843!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.46518!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.33168!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.671983!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 380)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TableLayoutPanel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'imgProfile
        '
        Me.imgProfile.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.imgProfile, 4)
        Me.imgProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgProfile.FillColor = System.Drawing.Color.AntiqueWhite
        Me.imgProfile.ImageRotate = 0!
        Me.imgProfile.Location = New System.Drawing.Point(33, 30)
        Me.imgProfile.Name = "imgProfile"
        Me.TableLayoutPanel1.SetRowSpan(Me.imgProfile, 8)
        Me.imgProfile.Size = New System.Drawing.Size(270, 222)
        Me.imgProfile.TabIndex = 0
        Me.imgProfile.TabStop = False
        '
        'txtboxName
        '
        Me.txtboxName.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxName.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxName, 4)
        Me.txtboxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxName.DefaultText = "Name:"
        Me.txtboxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxName.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxName.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxName.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxName.Location = New System.Drawing.Point(309, 30)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.PlaceholderText = ""
        Me.txtboxName.SelectedText = ""
        Me.txtboxName.Size = New System.Drawing.Size(257, 45)
        Me.txtboxName.TabIndex = 1
        '
        'txtboxAge
        '
        Me.txtboxAge.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxAge.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxAge, 4)
        Me.txtboxAge.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxAge.DefaultText = "Age:"
        Me.txtboxAge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxAge.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxAge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxAge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxAge.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxAge.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxAge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxAge.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxAge.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxAge.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxAge.Location = New System.Drawing.Point(309, 87)
        Me.txtboxAge.Name = "txtboxAge"
        Me.txtboxAge.PlaceholderText = ""
        Me.txtboxAge.SelectedText = ""
        Me.txtboxAge.Size = New System.Drawing.Size(257, 45)
        Me.txtboxAge.TabIndex = 2
        '
        'txtboxCourse
        '
        Me.txtboxCourse.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxCourse.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxCourse, 4)
        Me.txtboxCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxCourse.DefaultText = "Course/Yr./Sec.:"
        Me.txtboxCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourse.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxCourse.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourse.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxCourse.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourse.Location = New System.Drawing.Point(309, 144)
        Me.txtboxCourse.Name = "txtboxCourse"
        Me.txtboxCourse.PlaceholderText = ""
        Me.txtboxCourse.SelectedText = ""
        Me.txtboxCourse.Size = New System.Drawing.Size(257, 45)
        Me.txtboxCourse.TabIndex = 3
        '
        'txtboxEmail
        '
        Me.txtboxEmail.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxEmail.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxEmail, 4)
        Me.txtboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxEmail.DefaultText = "Email:"
        Me.txtboxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxEmail.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxEmail.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Location = New System.Drawing.Point(309, 201)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.PlaceholderText = ""
        Me.txtboxEmail.SelectedText = ""
        Me.txtboxEmail.Size = New System.Drawing.Size(257, 45)
        Me.txtboxEmail.TabIndex = 4
        '
        'txtboxContact
        '
        Me.txtboxContact.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxContact.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxContact, 4)
        Me.txtboxContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxContact.DefaultText = "Contact #:"
        Me.txtboxContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxContact.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxContact.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Location = New System.Drawing.Point(309, 258)
        Me.txtboxContact.Name = "txtboxContact"
        Me.txtboxContact.PlaceholderText = ""
        Me.txtboxContact.SelectedText = ""
        Me.txtboxContact.Size = New System.Drawing.Size(257, 45)
        Me.txtboxContact.TabIndex = 5
        '
        'txtboxID
        '
        Me.txtboxID.BorderColor = System.Drawing.Color.Sienna
        Me.txtboxID.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxID, 4)
        Me.txtboxID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxID.DefaultText = "Student ID:"
        Me.txtboxID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtboxID.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxID.ForeColor = System.Drawing.Color.SaddleBrown
        Me.txtboxID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxID.Location = New System.Drawing.Point(33, 258)
        Me.txtboxID.Name = "txtboxID"
        Me.txtboxID.PlaceholderText = ""
        Me.txtboxID.SelectedText = ""
        Me.txtboxID.Size = New System.Drawing.Size(270, 45)
        Me.txtboxID.TabIndex = 6
        '
        'btnAccept
        '
        Me.btnAccept.BorderColor = System.Drawing.Color.Sienna
        Me.btnAccept.BorderRadius = 5
        Me.btnAccept.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAccept.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAccept.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAccept.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAccept.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnAccept.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccept.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnAccept.Location = New System.Drawing.Point(474, 325)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(92, 33)
        Me.btnAccept.TabIndex = 7
        Me.btnAccept.Text = "Approve"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.AntiqueWhite
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Sienna
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.AntiqueWhite
        Me.Guna2Button1.Location = New System.Drawing.Point(376, 325)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(92, 33)
        Me.Guna2Button1.TabIndex = 8
        Me.Guna2Button1.Text = "Reject"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(572, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(25, 21)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'UserReqViewProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 380)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserReqViewProfile"
        Me.Text = "UserReqViewProfile"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.imgProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imgProfile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtboxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxAge As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents txtboxID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAccept As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
End Class
