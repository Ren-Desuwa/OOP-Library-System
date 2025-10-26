<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowerProfile
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
        Me.imgBorrower = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtboxName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxCourse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.lblCredits = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtboxContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnViewHistory = New Guna.UI2.WinForms.Guna2Button()
        Me.btnManage = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRemove = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.imgBorrower, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.52941!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.901961!))
        Me.TableLayoutPanel1.Controls.Add(Me.imgBorrower, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxName, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxCourse, 4, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxStudentID, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxEmail, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCredits, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.txtboxContact, 4, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.btnViewHistory, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.btnManage, 4, 11)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRemove, 7, 11)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 13
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.908185!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21191!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.727046!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21191!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.727046!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21191!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.727047!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.21191!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.726658!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.2119!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.320898!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.20936!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.59424!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 380)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'imgBorrower
        '
        Me.imgBorrower.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.imgBorrower, 3)
        Me.imgBorrower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.imgBorrower.FillColor = System.Drawing.Color.AntiqueWhite
        Me.imgBorrower.ImageRotate = 0!
        Me.imgBorrower.Location = New System.Drawing.Point(32, 29)
        Me.imgBorrower.Name = "imgBorrower"
        Me.TableLayoutPanel1.SetRowSpan(Me.imgBorrower, 8)
        Me.imgBorrower.Size = New System.Drawing.Size(193, 218)
        Me.imgBorrower.TabIndex = 0
        Me.imgBorrower.TabStop = False
        '
        'txtboxName
        '
        Me.txtboxName.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxName, 5)
        Me.txtboxName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxName.DefaultText = "Name:"
        Me.txtboxName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxName.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxName.Location = New System.Drawing.Point(256, 29)
        Me.txtboxName.Name = "txtboxName"
        Me.txtboxName.PlaceholderText = ""
        Me.txtboxName.SelectedText = ""
        Me.txtboxName.Size = New System.Drawing.Size(308, 44)
        Me.txtboxName.TabIndex = 1
        '
        'txtboxCourse
        '
        Me.txtboxCourse.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxCourse, 5)
        Me.txtboxCourse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxCourse.DefaultText = "Course/Year/Section:"
        Me.txtboxCourse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxCourse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxCourse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourse.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxCourse.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxCourse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourse.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxCourse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourse.Location = New System.Drawing.Point(256, 85)
        Me.txtboxCourse.Name = "txtboxCourse"
        Me.txtboxCourse.PlaceholderText = ""
        Me.txtboxCourse.SelectedText = ""
        Me.txtboxCourse.Size = New System.Drawing.Size(308, 44)
        Me.txtboxCourse.TabIndex = 2
        '
        'txtboxStudentID
        '
        Me.txtboxStudentID.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxStudentID, 5)
        Me.txtboxStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxStudentID.DefaultText = "Student ID:"
        Me.txtboxStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxStudentID.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxStudentID.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxStudentID.Location = New System.Drawing.Point(256, 141)
        Me.txtboxStudentID.Name = "txtboxStudentID"
        Me.txtboxStudentID.PlaceholderText = ""
        Me.txtboxStudentID.SelectedText = ""
        Me.txtboxStudentID.Size = New System.Drawing.Size(308, 44)
        Me.txtboxStudentID.TabIndex = 3
        '
        'txtboxEmail
        '
        Me.txtboxEmail.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxEmail, 5)
        Me.txtboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxEmail.DefaultText = "Email:"
        Me.txtboxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxEmail.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Location = New System.Drawing.Point(256, 197)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.PlaceholderText = ""
        Me.txtboxEmail.SelectedText = ""
        Me.txtboxEmail.Size = New System.Drawing.Size(308, 44)
        Me.txtboxEmail.TabIndex = 4
        '
        'lblCredits
        '
        Me.lblCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCredits.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblCredits, 3)
        Me.lblCredits.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(32, 278)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(81, 19)
        Me.lblCredits.TabIndex = 5
        Me.lblCredits.Text = "Credit Score:"
        '
        'txtboxContact
        '
        Me.txtboxContact.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.txtboxContact, 5)
        Me.txtboxContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxContact.DefaultText = "Contact #:"
        Me.txtboxContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxContact.FillColor = System.Drawing.Color.AntiqueWhite
        Me.txtboxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Location = New System.Drawing.Point(256, 253)
        Me.txtboxContact.Name = "txtboxContact"
        Me.txtboxContact.PlaceholderText = ""
        Me.txtboxContact.SelectedText = ""
        Me.txtboxContact.Size = New System.Drawing.Size(308, 44)
        Me.txtboxContact.TabIndex = 6
        '
        'btnViewHistory
        '
        Me.btnViewHistory.BorderColor = System.Drawing.Color.Sienna
        Me.btnViewHistory.BorderRadius = 5
        Me.btnViewHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnViewHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnViewHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnViewHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnViewHistory.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnViewHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnViewHistory.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnViewHistory.Location = New System.Drawing.Point(61, 319)
        Me.btnViewHistory.Name = "btnViewHistory"
        Me.btnViewHistory.Size = New System.Drawing.Size(135, 44)
        Me.btnViewHistory.TabIndex = 7
        Me.btnViewHistory.Text = "View History"
        '
        'btnManage
        '
        Me.btnManage.BorderColor = System.Drawing.Color.Sienna
        Me.btnManage.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnManage, 2)
        Me.btnManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnManage.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnManage.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnManage.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnManage.Location = New System.Drawing.Point(231, 319)
        Me.btnManage.Name = "btnManage"
        Me.btnManage.Size = New System.Drawing.Size(134, 44)
        Me.btnManage.TabIndex = 8
        Me.btnManage.Text = "Manage"
        '
        'btnRemove
        '
        Me.btnRemove.BorderColor = System.Drawing.Color.Sienna
        Me.btnRemove.BorderRadius = 5
        Me.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRemove.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnRemove.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRemove.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnRemove.Location = New System.Drawing.Point(400, 319)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(135, 44)
        Me.btnRemove.TabIndex = 9
        Me.btnRemove.Text = "Remove"
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TableLayoutPanel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'BorrowerProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 380)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BorrowerProfile"
        Me.Text = "BorrowerProfile"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.imgBorrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents imgBorrower As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtboxName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxCourse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblCredits As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtboxContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnViewHistory As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnManage As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRemove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
End Class
