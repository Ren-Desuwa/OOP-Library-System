<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home_Panel_Guest
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
        Me.title_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_user = New System.Windows.Forms.Label()
        Me.btn_profile = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.txtBox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.UC_Loading_Panel1 = New OOP_Library_System.UC_Loading_Panel()
        Me.UC_HPS_catalouge_tab1 = New OOP_Library_System.UC_HPS_catalouge_tab()
        Me.title_panel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_panel
        '
        Me.title_panel.Controls.Add(Me.TableLayoutPanel1)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.title_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.title_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.title_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.title_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.title_panel.Location = New System.Drawing.Point(0, 0)
        Me.title_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(688, 52)
        Me.title_panel.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.OOP_Library_System.My.Resources.Resources.titi_ni_ren_baluktot_nakita_ko
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.502869!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.0249!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.79998!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.16548!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.506778!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_user, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_profile, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtBox_username, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(688, 52)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Guna2PictureBox1.ErrorImage = Nothing
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big1
        Me.Guna2PictureBox1.ImageLocation = ""
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(16, 2)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(47, 48)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 11
        Me.Guna2PictureBox1.TabStop = False
        Me.Guna2PictureBox1.UseTransparentBackground = True
        '
        'lbl_user
        '
        Me.lbl_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user.AutoSize = True
        Me.lbl_user.BackColor = System.Drawing.Color.Transparent
        Me.lbl_user.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_user.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lbl_user.Location = New System.Drawing.Point(478, 13)
        Me.lbl_user.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(141, 26)
        Me.lbl_user.TabIndex = 12
        Me.lbl_user.Text = "Guest"
        Me.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_profile
        '
        Me.btn_profile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_profile.BackColor = System.Drawing.Color.Transparent
        Me.btn_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_profile.ErrorImage = Nothing
        Me.btn_profile.FillColor = System.Drawing.Color.Transparent
        Me.btn_profile.Image = Global.OOP_Library_System.My.Resources.Resources.Accountwhite0_icon
        Me.btn_profile.ImageLocation = ""
        Me.btn_profile.ImageRotate = 0!
        Me.btn_profile.Location = New System.Drawing.Point(623, 2)
        Me.btn_profile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(44, 48)
        Me.btn_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_profile.TabIndex = 18
        Me.btn_profile.TabStop = False
        Me.btn_profile.UseTransparentBackground = True
        '
        'txtBox_username
        '
        Me.txtBox_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.txtBox_username.Location = New System.Drawing.Point(67, 8)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Search"
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(175, 36)
        Me.txtBox_username.TabIndex = 19
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'UC_Loading_Panel1
        '
        Me.UC_Loading_Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UC_Loading_Panel1.Location = New System.Drawing.Point(0, 52)
        Me.UC_Loading_Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_Loading_Panel1.Name = "UC_Loading_Panel1"
        Me.UC_Loading_Panel1.Size = New System.Drawing.Size(688, 394)
        Me.UC_Loading_Panel1.TabIndex = 8
        Me.UC_Loading_Panel1.Visible = False
        '
        'UC_HPS_catalouge_tab1
        '
        Me.UC_HPS_catalouge_tab1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_HPS_catalouge_tab1.BackColor = System.Drawing.Color.Transparent
        Me.UC_HPS_catalouge_tab1.IsGuestMode = False
        Me.UC_HPS_catalouge_tab1.Location = New System.Drawing.Point(0, 46)
        Me.UC_HPS_catalouge_tab1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_HPS_catalouge_tab1.Name = "UC_HPS_catalouge_tab1"
        Me.UC_HPS_catalouge_tab1.Size = New System.Drawing.Size(688, 397)
        Me.UC_HPS_catalouge_tab1.TabIndex = 7
        '
        'Home_Panel_Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FloralWhite
        Me.ClientSize = New System.Drawing.Size(688, 446)
        Me.Controls.Add(Me.UC_Loading_Panel1)
        Me.Controls.Add(Me.title_panel)
        Me.Controls.Add(Me.UC_HPS_catalouge_tab1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Home_Panel_Guest"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.title_panel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_user As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_profile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UC_HPS_catalouge_tab1 As UC_HPS_catalouge_tab
    Friend WithEvents UC_Loading_Panel1 As UC_Loading_Panel
End Class
