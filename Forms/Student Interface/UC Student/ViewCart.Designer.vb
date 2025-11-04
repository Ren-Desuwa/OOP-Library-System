<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewCart
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
        Me.title_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.picbox_logo = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.picbox_profile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtbox_search = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Table_container = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_back = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_borrow = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_remove = New Guna.UI2.WinForms.Guna2Button()
        Me.flowlayout_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.tlpViewCart = New System.Windows.Forms.TableLayoutPanel()
        Me.Flow_BookCartList = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        Me.title_panel.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.picbox_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picbox_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Table_container.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.flowlayout_container.SuspendLayout()
        Me.tlpViewCart.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Tan
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.title_panel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 59)
        Me.Panel1.TabIndex = 0
        '
        'title_panel
        '
        Me.title_panel.Controls.Add(Me.TableLayoutPanel2)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.title_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.title_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.title_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.title_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.title_panel.Location = New System.Drawing.Point(0, 0)
        Me.title_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(800, 58)
        Me.title_panel.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 5
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.502869!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0249!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.79998!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16548!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.506778!))
        Me.TableLayoutPanel2.Controls.Add(Me.picbox_logo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblUsername, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.picbox_profile, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtbox_search, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(800, 58)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'picbox_logo
        '
        Me.picbox_logo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picbox_logo.BackColor = System.Drawing.Color.Transparent
        Me.picbox_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picbox_logo.ErrorImage = Nothing
        Me.picbox_logo.FillColor = System.Drawing.Color.Transparent
        Me.picbox_logo.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big1
        Me.picbox_logo.ImageLocation = ""
        Me.picbox_logo.ImageRotate = 0!
        Me.picbox_logo.Location = New System.Drawing.Point(27, 2)
        Me.picbox_logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picbox_logo.Name = "picbox_logo"
        Me.picbox_logo.Size = New System.Drawing.Size(47, 54)
        Me.picbox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_logo.TabIndex = 11
        Me.picbox_logo.TabStop = False
        Me.picbox_logo.UseTransparentBackground = True
        '
        'lblUsername
        '
        Me.lblUsername.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(556, 16)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(165, 26)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "User"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'picbox_profile
        '
        Me.picbox_profile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picbox_profile.BackColor = System.Drawing.Color.Transparent
        Me.picbox_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picbox_profile.ErrorImage = Nothing
        Me.picbox_profile.FillColor = System.Drawing.Color.Transparent
        Me.picbox_profile.Image = Global.OOP_Library_System.My.Resources.Resources.Accountwhite0_icon
        Me.picbox_profile.ImageLocation = ""
        Me.picbox_profile.ImageRotate = 0!
        Me.picbox_profile.Location = New System.Drawing.Point(725, 2)
        Me.picbox_profile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picbox_profile.Name = "picbox_profile"
        Me.picbox_profile.Size = New System.Drawing.Size(44, 54)
        Me.picbox_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picbox_profile.TabIndex = 18
        Me.picbox_profile.TabStop = False
        Me.picbox_profile.UseTransparentBackground = True
        '
        'txtbox_search
        '
        Me.txtbox_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtbox_search.BackColor = System.Drawing.Color.Transparent
        Me.txtbox_search.BorderColor = System.Drawing.Color.DarkGray
        Me.txtbox_search.BorderRadius = 10
        Me.txtbox_search.BorderThickness = 2
        Me.txtbox_search.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_search.DefaultText = ""
        Me.txtbox_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_search.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbox_search.ForeColor = System.Drawing.Color.Black
        Me.txtbox_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_search.Location = New System.Drawing.Point(78, 11)
        Me.txtbox_search.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtbox_search.Name = "txtbox_search"
        Me.txtbox_search.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtbox_search.PlaceholderText = "Search in Cart"
        Me.txtbox_search.SelectedText = ""
        Me.txtbox_search.Size = New System.Drawing.Size(204, 36)
        Me.txtbox_search.TabIndex = 19
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2GradientPanel1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.18919!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2GradientPanel1
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Guna2GradientPanel1, 2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Table_container)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.Tan
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.BurlyWood
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 59)
        Me.Guna2GradientPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Guna2GradientPanel1, 3)
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(800, 391)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Table_container
        '
        Me.Table_container.BackColor = System.Drawing.Color.Transparent
        Me.Table_container.Controls.Add(Me.TableLayoutPanel3)
        Me.Table_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Table_container.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Table_container.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Table_container.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Table_container.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Table_container.ForeColor = System.Drawing.Color.Transparent
        Me.Table_container.Location = New System.Drawing.Point(0, 0)
        Me.Table_container.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Table_container.Name = "Table_container"
        Me.Table_container.Size = New System.Drawing.Size(800, 391)
        Me.Table_container.TabIndex = 9
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.flowlayout_container, 1, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.829268!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.17073!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(800, 391)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.26456!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.86772!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.769!))
        Me.TableLayoutPanel4.Controls.Add(Me.btn_back, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_borrow, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btn_remove, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(20, 333)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(760, 58)
        Me.TableLayoutPanel4.TabIndex = 1
        '
        'btn_back
        '
        Me.btn_back.BorderRadius = 20
        Me.btn_back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_back.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_back.FillColor = System.Drawing.Color.White
        Me.btn_back.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_back.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_back.Location = New System.Drawing.Point(2, 2)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_back.MaximumSize = New System.Drawing.Size(128, 42)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(128, 42)
        Me.btn_back.TabIndex = 6
        Me.btn_back.Text = "Back"
        '
        'btn_borrow
        '
        Me.btn_borrow.BorderRadius = 20
        Me.btn_borrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_borrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_borrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_borrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_borrow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_borrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_borrow.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_borrow.ForeColor = System.Drawing.Color.White
        Me.btn_borrow.Location = New System.Drawing.Point(625, 2)
        Me.btn_borrow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_borrow.MaximumSize = New System.Drawing.Size(128, 42)
        Me.btn_borrow.Name = "btn_borrow"
        Me.btn_borrow.Size = New System.Drawing.Size(128, 42)
        Me.btn_borrow.TabIndex = 4
        Me.btn_borrow.Text = "Borrow"
        '
        'btn_remove
        '
        Me.btn_remove.BorderRadius = 20
        Me.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_remove.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_remove.FillColor = System.Drawing.Color.White
        Me.btn_remove.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_remove.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_remove.Location = New System.Drawing.Point(490, 2)
        Me.btn_remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_remove.MaximumSize = New System.Drawing.Size(128, 42)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(128, 42)
        Me.btn_remove.TabIndex = 5
        Me.btn_remove.Text = "Remove"
        '
        'flowlayout_container
        '
        Me.flowlayout_container.BackColor = System.Drawing.Color.WhiteSmoke
        Me.flowlayout_container.BorderRadius = 5
        Me.flowlayout_container.Controls.Add(Me.tlpViewCart)
        Me.flowlayout_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flowlayout_container.Location = New System.Drawing.Point(20, 22)
        Me.flowlayout_container.Margin = New System.Windows.Forms.Padding(0)
        Me.flowlayout_container.Name = "flowlayout_container"
        Me.flowlayout_container.Size = New System.Drawing.Size(760, 311)
        Me.flowlayout_container.TabIndex = 2
        '
        'tlpViewCart
        '
        Me.tlpViewCart.ColumnCount = 1
        Me.tlpViewCart.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpViewCart.Controls.Add(Me.Flow_BookCartList, 0, 0)
        Me.tlpViewCart.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpViewCart.Location = New System.Drawing.Point(0, 0)
        Me.tlpViewCart.Name = "tlpViewCart"
        Me.tlpViewCart.RowCount = 1
        Me.tlpViewCart.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpViewCart.Size = New System.Drawing.Size(760, 311)
        Me.tlpViewCart.TabIndex = 0
        '
        'Flow_BookCartList
        '
        Me.Flow_BookCartList.AutoScroll = True
        Me.Flow_BookCartList.BackColor = System.Drawing.Color.Transparent
        Me.Flow_BookCartList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Flow_BookCartList.Location = New System.Drawing.Point(3, 3)
        Me.Flow_BookCartList.Name = "Flow_BookCartList"
        Me.Flow_BookCartList.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
        Me.Flow_BookCartList.Size = New System.Drawing.Size(754, 305)
        Me.Flow_BookCartList.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'ViewCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ViewCart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ViewCart"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.title_panel.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.picbox_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picbox_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Table_container.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.flowlayout_container.ResumeLayout(False)
        Me.tlpViewCart.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents flowlayout_container As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents tlpViewCart As TableLayoutPanel
    Friend WithEvents Flow_BookCartList As FlowLayoutPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents picbox_logo As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents picbox_profile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents txtbox_search As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_borrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_remove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Table_container As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class