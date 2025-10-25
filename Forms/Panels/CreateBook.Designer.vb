<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateBook
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
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.txtImage = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.Label()
        Me.txtbxTitle = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtbxAuthor = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtISBN = New System.Windows.Forms.Label()
        Me.txtbxISBN = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDescription = New System.Windows.Forms.Label()
        Me.txtbxDescription = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCreate = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCancel = New Guna.UI2.WinForms.Guna2Button()
        Me.imgButton = New Guna.UI2.WinForms.Guna2ImageButton()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.lbl_title
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(3, 0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(794, 100)
        Me.lbl_title.TabIndex = 13
        Me.lbl_title.Text = "Create Book"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(800, 119)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_title, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 100)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.375!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.625!))
        Me.TableLayoutPanel2.Controls.Add(Me.txtImage, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.txtTitle, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAuthor, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.txtbxTitle, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.txtbxAuthor, 0, 6)
        Me.TableLayoutPanel2.Controls.Add(Me.txtISBN, 0, 7)
        Me.TableLayoutPanel2.Controls.Add(Me.txtbxISBN, 0, 8)
        Me.TableLayoutPanel2.Controls.Add(Me.txtDescription, 0, 9)
        Me.TableLayoutPanel2.Controls.Add(Me.txtbxDescription, 0, 10)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCreate, 1, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.btnCancel, 2, 11)
        Me.TableLayoutPanel2.Controls.Add(Me.imgButton, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 119)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 12
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 681)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'txtImage
        '
        Me.txtImage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtImage.AutoSize = True
        Me.txtImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImage.Location = New System.Drawing.Point(119, 40)
        Me.txtImage.Name = "txtImage"
        Me.txtImage.Size = New System.Drawing.Size(54, 27)
        Me.txtImage.TabIndex = 0
        Me.txtImage.Text = "Image:"
        Me.txtImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.AutoSize = True
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(128, 114)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(45, 27)
        Me.txtTitle.TabIndex = 1
        Me.txtTitle.Text = "Title:"
        Me.txtTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.AutoSize = True
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(118, 202)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(55, 27)
        Me.txtAuthor.TabIndex = 2
        Me.txtAuthor.Text = "Author:"
        Me.txtAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxTitle
        '
        Me.txtbxTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtbxTitle, 3)
        Me.txtbxTitle.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxTitle.DefaultText = ""
        Me.txtbxTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxTitle.Location = New System.Drawing.Point(97, 145)
        Me.txtbxTitle.Margin = New System.Windows.Forms.Padding(5, 4, 20, 4)
        Me.txtbxTitle.Name = "txtbxTitle"
        Me.txtbxTitle.PlaceholderText = ""
        Me.txtbxTitle.SelectedText = ""
        Me.txtbxTitle.Size = New System.Drawing.Size(683, 53)
        Me.txtbxTitle.TabIndex = 3
        '
        'txtbxAuthor
        '
        Me.txtbxAuthor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtbxAuthor, 3)
        Me.txtbxAuthor.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxAuthor.DefaultText = ""
        Me.txtbxAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxAuthor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxAuthor.Location = New System.Drawing.Point(97, 233)
        Me.txtbxAuthor.Margin = New System.Windows.Forms.Padding(5, 4, 20, 4)
        Me.txtbxAuthor.Name = "txtbxAuthor"
        Me.txtbxAuthor.PlaceholderText = ""
        Me.txtbxAuthor.SelectedText = ""
        Me.txtbxAuthor.Size = New System.Drawing.Size(683, 53)
        Me.txtbxAuthor.TabIndex = 4
        '
        'txtISBN
        '
        Me.txtISBN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtISBN.AutoSize = True
        Me.txtISBN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtISBN.Location = New System.Drawing.Point(127, 290)
        Me.txtISBN.Name = "txtISBN"
        Me.txtISBN.Size = New System.Drawing.Size(46, 27)
        Me.txtISBN.TabIndex = 5
        Me.txtISBN.Text = "ISBN:"
        Me.txtISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxISBN
        '
        Me.txtbxISBN.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtbxISBN, 3)
        Me.txtbxISBN.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxISBN.DefaultText = ""
        Me.txtbxISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxISBN.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxISBN.Location = New System.Drawing.Point(97, 321)
        Me.txtbxISBN.Margin = New System.Windows.Forms.Padding(5, 4, 20, 4)
        Me.txtbxISBN.Name = "txtbxISBN"
        Me.txtbxISBN.PlaceholderText = ""
        Me.txtbxISBN.SelectedText = ""
        Me.txtbxISBN.Size = New System.Drawing.Size(683, 46)
        Me.txtbxISBN.TabIndex = 6
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescription.AutoSize = True
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(68, 371)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(105, 27)
        Me.txtDescription.TabIndex = 7
        Me.txtDescription.Text = "Description:"
        Me.txtDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtbxDescription
        '
        Me.txtbxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.SetColumnSpan(Me.txtbxDescription, 3)
        Me.txtbxDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbxDescription.DefaultText = ""
        Me.txtbxDescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbxDescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbxDescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxDescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbxDescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtbxDescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbxDescription.Location = New System.Drawing.Point(97, 402)
        Me.txtbxDescription.Margin = New System.Windows.Forms.Padding(5, 4, 20, 4)
        Me.txtbxDescription.Name = "txtbxDescription"
        Me.txtbxDescription.PlaceholderText = ""
        Me.txtbxDescription.SelectedText = ""
        Me.txtbxDescription.Size = New System.Drawing.Size(683, 189)
        Me.txtbxDescription.TabIndex = 8
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCreate.FillColor = System.Drawing.Color.Tan
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Location = New System.Drawing.Point(211, 607)
        Me.btnCreate.Margin = New System.Windows.Forms.Padding(35, 12, 12, 18)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(180, 56)
        Me.btnCreate.TabIndex = 11
        Me.btnCreate.Text = "Create"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCancel.FillColor = System.Drawing.Color.Tan
        Me.btnCancel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(455, 607)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(12, 12, 12, 18)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(180, 56)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        '
        'imgButton
        '
        Me.imgButton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.imgButton.CheckedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.TableLayoutPanel2.SetColumnSpan(Me.imgButton, 2)
        Me.imgButton.HoverState.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgButton.ImageOffset = New System.Drawing.Point(0, 0)
        Me.imgButton.ImageRotate = 0!
        Me.imgButton.Location = New System.Drawing.Point(100, 71)
        Me.imgButton.Margin = New System.Windows.Forms.Padding(5, 4, 0, 4)
        Me.imgButton.Name = "imgButton"
        Me.imgButton.PressedState.ImageSize = New System.Drawing.Size(64, 64)
        Me.imgButton.Size = New System.Drawing.Size(343, 39)
        Me.imgButton.TabIndex = 12
        '
        'CreateBook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 800)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateBook"
        Me.Text = "CreateBook"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lbl_title As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents txtImage As Label
    Friend WithEvents txtTitle As Label
    Friend WithEvents txtAuthor As Label
    Friend WithEvents txtbxTitle As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtbxAuthor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtISBN As Label
    Friend WithEvents txtbxISBN As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtDescription As Label
    Friend WithEvents txtbxDescription As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCreate As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCancel As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents imgButton As Guna.UI2.WinForms.Guna2ImageButton
End Class
