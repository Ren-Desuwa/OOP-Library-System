<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddBorrower
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddBorrower))
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.addBorrrower = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtboxFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxLastName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtboxMiddleName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cmbboxSuffix = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.dtpBirthDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel8 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel9 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel10 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtboxStudentID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxCourseYr = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxContact = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.cancelButton = New Guna.UI2.WinForms.Guna2Button()
        Me.confirmButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.imgButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2HtmlLabel11 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel12 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtboxPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtboxConfirmPass = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.addBorrrower
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'addBorrrower
        '
        Me.addBorrrower.AutoSize = True
        Me.addBorrrower.Dock = System.Windows.Forms.DockStyle.Fill
        Me.addBorrrower.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBorrrower.ForeColor = System.Drawing.Color.Transparent
        Me.addBorrrower.Location = New System.Drawing.Point(2, 0)
        Me.addBorrrower.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.addBorrrower.Name = "addBorrrower"
        Me.addBorrrower.Size = New System.Drawing.Size(696, 61)
        Me.addBorrrower.TabIndex = 0
        Me.addBorrrower.Text = "Add Borrower"
        Me.addBorrrower.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.addBorrrower, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(700, 61)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(700, 61)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'txtboxFirstName
        '
        Me.txtboxFirstName.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxFirstName, 2)
        Me.txtboxFirstName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxFirstName.DefaultText = ""
        Me.txtboxFirstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxFirstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxFirstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxFirstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxFirstName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxFirstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxFirstName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxFirstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxFirstName.Location = New System.Drawing.Point(54, 108)
        Me.txtboxFirstName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxFirstName.Name = "txtboxFirstName"
        Me.txtboxFirstName.PlaceholderText = ""
        Me.txtboxFirstName.SelectedText = ""
        Me.txtboxFirstName.Size = New System.Drawing.Size(288, 23)
        Me.txtboxFirstName.TabIndex = 11
        '
        'txtboxLastName
        '
        Me.txtboxLastName.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxLastName, 2)
        Me.txtboxLastName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxLastName.DefaultText = ""
        Me.txtboxLastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxLastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxLastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxLastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxLastName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxLastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxLastName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxLastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxLastName.Location = New System.Drawing.Point(54, 54)
        Me.txtboxLastName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxLastName.Name = "txtboxLastName"
        Me.txtboxLastName.PlaceholderText = ""
        Me.txtboxLastName.SelectedText = ""
        Me.txtboxLastName.Size = New System.Drawing.Size(288, 23)
        Me.txtboxLastName.TabIndex = 10
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.040404!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14141!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.31313!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.010101!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14141!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65657!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.65657!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.040404!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxLastName, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxFirstName, 1, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxMiddleName, 1, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.cmbboxSuffix, 1, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.dtpBirthDate, 1, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel1, 1, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel2, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel3, 4, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel4, 4, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel5, 4, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel7, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel8, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel9, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel10, 1, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxStudentID, 4, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxCourseYr, 4, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxContact, 4, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxEmail, 4, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.cancelButton, 5, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.confirmButton, 6, 14)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel6, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.imgButton, 1, 12)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel11, 4, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2HtmlLabel12, 4, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxPass, 4, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.txtboxConfirmPass, 4, 12)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 61)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 16
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.250893!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.375817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.125968!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.375817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.125968!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.375817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.125968!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.375817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125969!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.375817!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.125969!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.372961!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.123112!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.248035!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.24713!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.248943!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(700, 439)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtboxMiddleName
        '
        Me.txtboxMiddleName.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxMiddleName, 2)
        Me.txtboxMiddleName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxMiddleName.DefaultText = ""
        Me.txtboxMiddleName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxMiddleName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxMiddleName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxMiddleName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxMiddleName.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxMiddleName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxMiddleName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxMiddleName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxMiddleName.Location = New System.Drawing.Point(54, 162)
        Me.txtboxMiddleName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxMiddleName.Name = "txtboxMiddleName"
        Me.txtboxMiddleName.PlaceholderText = ""
        Me.txtboxMiddleName.SelectedText = ""
        Me.txtboxMiddleName.Size = New System.Drawing.Size(288, 23)
        Me.txtboxMiddleName.TabIndex = 12
        '
        'cmbboxSuffix
        '
        Me.cmbboxSuffix.BackColor = System.Drawing.Color.Transparent
        Me.cmbboxSuffix.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.cmbboxSuffix, 2)
        Me.cmbboxSuffix.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmbboxSuffix.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbboxSuffix.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbboxSuffix.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxSuffix.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbboxSuffix.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.cmbboxSuffix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.cmbboxSuffix.ItemHeight = 30
        Me.cmbboxSuffix.Location = New System.Drawing.Point(54, 208)
        Me.cmbboxSuffix.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.cmbboxSuffix.Name = "cmbboxSuffix"
        Me.cmbboxSuffix.Size = New System.Drawing.Size(288, 36)
        Me.cmbboxSuffix.TabIndex = 13
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.BorderRadius = 5
        Me.dtpBirthDate.Checked = True
        Me.TableLayoutPanel2.SetColumnSpan(Me.dtpBirthDate, 2)
        Me.dtpBirthDate.Dock = System.Windows.Forms.DockStyle.Right
        Me.dtpBirthDate.FillColor = System.Drawing.Color.LightSalmon
        Me.dtpBirthDate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.dtpBirthDate.Location = New System.Drawing.Point(54, 273)
        Me.dtpBirthDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpBirthDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.Size = New System.Drawing.Size(288, 29)
        Me.dtpBirthDate.TabIndex = 14
        Me.dtpBirthDate.Value = New Date(2025, 10, 26, 12, 54, 28, 632)
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(31, 250)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(71, 17)
        Me.Guna2HtmlLabel1.TabIndex = 15
        Me.Guna2HtmlLabel1.Text = "Birth Date:"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.BottomRight
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(355, 30)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(74, 17)
        Me.Guna2HtmlLabel2.TabIndex = 16
        Me.Guna2HtmlLabel2.Text = "Student ID:"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(355, 84)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(92, 17)
        Me.Guna2HtmlLabel3.TabIndex = 17
        Me.Guna2HtmlLabel3.Text = "Course/Yr./Sec.:"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(355, 138)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(67, 17)
        Me.Guna2HtmlLabel4.TabIndex = 18
        Me.Guna2HtmlLabel4.Text = "Contact #:"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(355, 192)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(44, 13)
        Me.Guna2HtmlLabel5.TabIndex = 19
        Me.Guna2HtmlLabel5.Text = "Email:"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(31, 138)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(92, 17)
        Me.Guna2HtmlLabel7.TabIndex = 21
        Me.Guna2HtmlLabel7.Text = "Middle Name:"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel8
        '
        Me.Guna2HtmlLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel8.Location = New System.Drawing.Point(31, 84)
        Me.Guna2HtmlLabel8.Name = "Guna2HtmlLabel8"
        Me.Guna2HtmlLabel8.Size = New System.Drawing.Size(77, 17)
        Me.Guna2HtmlLabel8.TabIndex = 22
        Me.Guna2HtmlLabel8.Text = "First Name:"
        '
        'Guna2HtmlLabel9
        '
        Me.Guna2HtmlLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel9.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel9.Location = New System.Drawing.Point(31, 30)
        Me.Guna2HtmlLabel9.Name = "Guna2HtmlLabel9"
        Me.Guna2HtmlLabel9.Size = New System.Drawing.Size(76, 17)
        Me.Guna2HtmlLabel9.TabIndex = 23
        Me.Guna2HtmlLabel9.Text = "Last Name:"
        Me.Guna2HtmlLabel9.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel10
        '
        Me.Guna2HtmlLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel10.Location = New System.Drawing.Point(31, 192)
        Me.Guna2HtmlLabel10.Name = "Guna2HtmlLabel10"
        Me.Guna2HtmlLabel10.Size = New System.Drawing.Size(43, 13)
        Me.Guna2HtmlLabel10.TabIndex = 24
        Me.Guna2HtmlLabel10.Text = "Suffix:          "
        Me.Guna2HtmlLabel10.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtboxStudentID
        '
        Me.txtboxStudentID.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxStudentID, 3)
        Me.txtboxStudentID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxStudentID.DefaultText = ""
        Me.txtboxStudentID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxStudentID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxStudentID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxStudentID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxStudentID.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxStudentID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxStudentID.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxStudentID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxStudentID.Location = New System.Drawing.Point(381, 54)
        Me.txtboxStudentID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxStudentID.Name = "txtboxStudentID"
        Me.txtboxStudentID.PlaceholderText = ""
        Me.txtboxStudentID.SelectedText = ""
        Me.txtboxStudentID.Size = New System.Drawing.Size(284, 23)
        Me.txtboxStudentID.TabIndex = 25
        '
        'txtboxCourseYr
        '
        Me.txtboxCourseYr.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxCourseYr, 3)
        Me.txtboxCourseYr.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxCourseYr.DefaultText = ""
        Me.txtboxCourseYr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxCourseYr.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxCourseYr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourseYr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxCourseYr.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxCourseYr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourseYr.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxCourseYr.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxCourseYr.Location = New System.Drawing.Point(381, 108)
        Me.txtboxCourseYr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxCourseYr.Name = "txtboxCourseYr"
        Me.txtboxCourseYr.PlaceholderText = ""
        Me.txtboxCourseYr.SelectedText = ""
        Me.txtboxCourseYr.Size = New System.Drawing.Size(284, 23)
        Me.txtboxCourseYr.TabIndex = 26
        '
        'txtboxContact
        '
        Me.txtboxContact.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxContact, 3)
        Me.txtboxContact.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxContact.DefaultText = ""
        Me.txtboxContact.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxContact.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxContact.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxContact.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxContact.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxContact.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxContact.Location = New System.Drawing.Point(381, 162)
        Me.txtboxContact.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxContact.Name = "txtboxContact"
        Me.txtboxContact.PlaceholderText = ""
        Me.txtboxContact.SelectedText = ""
        Me.txtboxContact.Size = New System.Drawing.Size(284, 23)
        Me.txtboxContact.TabIndex = 27
        '
        'txtboxEmail
        '
        Me.txtboxEmail.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxEmail, 3)
        Me.txtboxEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxEmail.DefaultText = ""
        Me.txtboxEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxEmail.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxEmail.Location = New System.Drawing.Point(381, 212)
        Me.txtboxEmail.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxEmail.Name = "txtboxEmail"
        Me.txtboxEmail.PlaceholderText = ""
        Me.txtboxEmail.SelectedText = ""
        Me.txtboxEmail.Size = New System.Drawing.Size(284, 27)
        Me.txtboxEmail.TabIndex = 28
        '
        'cancelButton
        '
        Me.cancelButton.BorderRadius = 10
        Me.cancelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.cancelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.cancelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.cancelButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cancelButton.FillColor = System.Drawing.Color.Tan
        Me.cancelButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cancelButton.ForeColor = System.Drawing.Color.Black
        Me.cancelButton.Location = New System.Drawing.Point(453, 380)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(103, 38)
        Me.cancelButton.TabIndex = 32
        Me.cancelButton.Text = "Cancel"
        '
        'confirmButton
        '
        Me.confirmButton.BorderRadius = 10
        Me.confirmButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.confirmButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.confirmButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.confirmButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.confirmButton.Dock = System.Windows.Forms.DockStyle.Fill
        Me.confirmButton.FillColor = System.Drawing.Color.Sienna
        Me.confirmButton.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.confirmButton.ForeColor = System.Drawing.Color.White
        Me.confirmButton.Location = New System.Drawing.Point(562, 380)
        Me.confirmButton.Name = "confirmButton"
        Me.confirmButton.Size = New System.Drawing.Size(103, 38)
        Me.confirmButton.TabIndex = 31
        Me.confirmButton.Text = "Confirm"
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(31, 308)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(47, 17)
        Me.Guna2HtmlLabel6.TabIndex = 20
        Me.Guna2HtmlLabel6.Text = "Image:"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'imgButton
        '
        Me.imgButton.BackColor = System.Drawing.Color.LightSalmon
        Me.imgButton.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.TableLayoutPanel2.SetColumnSpan(Me.imgButton, 2)
        Me.imgButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.imgButton.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgButton.Image = CType(resources.GetObject("imgButton.Image"), System.Drawing.Image)
        Me.imgButton.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgButton.ImageRotate = 0!
        Me.imgButton.Location = New System.Drawing.Point(54, 331)
        Me.imgButton.Name = "imgButton"
        Me.imgButton.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgButton.Size = New System.Drawing.Size(288, 25)
        Me.imgButton.TabIndex = 29
        '
        'Guna2HtmlLabel11
        '
        Me.Guna2HtmlLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel11.Location = New System.Drawing.Point(355, 250)
        Me.Guna2HtmlLabel11.Name = "Guna2HtmlLabel11"
        Me.Guna2HtmlLabel11.Size = New System.Drawing.Size(69, 17)
        Me.Guna2HtmlLabel11.TabIndex = 33
        Me.Guna2HtmlLabel11.Text = "Password:"
        Me.Guna2HtmlLabel11.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'Guna2HtmlLabel12
        '
        Me.Guna2HtmlLabel12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel12.Location = New System.Drawing.Point(355, 308)
        Me.Guna2HtmlLabel12.Name = "Guna2HtmlLabel12"
        Me.Guna2HtmlLabel12.Size = New System.Drawing.Size(92, 17)
        Me.Guna2HtmlLabel12.TabIndex = 34
        Me.Guna2HtmlLabel12.Text = "Confirm Pass:"
        Me.Guna2HtmlLabel12.TextAlignment = System.Drawing.ContentAlignment.BottomCenter
        '
        'txtboxPass
        '
        Me.txtboxPass.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxPass, 3)
        Me.txtboxPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxPass.DefaultText = ""
        Me.txtboxPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxPass.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxPass.Location = New System.Drawing.Point(381, 274)
        Me.txtboxPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxPass.Name = "txtboxPass"
        Me.txtboxPass.PlaceholderText = ""
        Me.txtboxPass.SelectedText = ""
        Me.txtboxPass.Size = New System.Drawing.Size(284, 27)
        Me.txtboxPass.TabIndex = 35
        '
        'txtboxConfirmPass
        '
        Me.txtboxConfirmPass.BorderRadius = 5
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtboxConfirmPass, 3)
        Me.txtboxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtboxConfirmPass.DefaultText = ""
        Me.txtboxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtboxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtboxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtboxConfirmPass.Dock = System.Windows.Forms.DockStyle.Right
        Me.txtboxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxConfirmPass.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtboxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtboxConfirmPass.Location = New System.Drawing.Point(381, 332)
        Me.txtboxConfirmPass.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtboxConfirmPass.Name = "txtboxConfirmPass"
        Me.txtboxConfirmPass.PlaceholderText = ""
        Me.txtboxConfirmPass.SelectedText = ""
        Me.txtboxConfirmPass.Size = New System.Drawing.Size(284, 23)
        Me.txtboxConfirmPass.TabIndex = 36
        '
        'AddBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "AddBorrower"
        Me.Text = "AddBorrower"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents addBorrrower As Label
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtboxLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxMiddleName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents cmbboxSuffix As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dtpBirthDate As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel8 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel9 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel10 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtboxStudentID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxCourseYr As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxContact As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents imgButton As Guna.UI2.WinForms.Guna2ImageButton
    Friend WithEvents confirmButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents cancelButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel11 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel12 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtboxPass As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtboxConfirmPass As Guna.UI2.WinForms.Guna2TextBox
End Class
