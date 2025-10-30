<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home_Panel_Students
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
        Me.genre_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.flow_genre_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.container_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.flow_main_book_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.title_panel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.genre_panel.SuspendLayout()
        Me.container_panel.SuspendLayout()
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
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(918, 64)
        Me.title_panel.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
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
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 64)
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
        'Me.Guna2PictureBox1.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big1
        Me.Guna2PictureBox1.ImageLocation = ""
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(21, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(63, 58)
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
        Me.lbl_user.Location = New System.Drawing.Point(638, 16)
        Me.lbl_user.Name = "lbl_user"
        Me.lbl_user.Size = New System.Drawing.Size(188, 32)
        Me.lbl_user.TabIndex = 12
        Me.lbl_user.Text = "User"
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
        Me.btn_profile.Location = New System.Drawing.Point(832, 3)
        Me.btn_profile.Name = "btn_profile"
        Me.btn_profile.Size = New System.Drawing.Size(58, 58)
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
        Me.txtBox_username.Location = New System.Drawing.Point(90, 10)
        Me.txtBox_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtBox_username.Name = "txtBox_username"
        Me.txtBox_username.PlaceholderForeColor = System.Drawing.Color.DarkGray
        Me.txtBox_username.PlaceholderText = "Search"
        Me.txtBox_username.SelectedText = ""
        Me.txtBox_username.Size = New System.Drawing.Size(232, 44)
        Me.txtBox_username.TabIndex = 19
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'genre_panel
        '
        Me.genre_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.genre_panel.Controls.Add(Me.flow_genre_panel)
        Me.genre_panel.CustomizableEdges.BottomRight = False
        Me.genre_panel.CustomizableEdges.TopRight = False
        Me.genre_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.genre_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.genre_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.genre_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.genre_panel.Location = New System.Drawing.Point(0, 64)
        Me.genre_panel.Name = "genre_panel"
        Me.genre_panel.Size = New System.Drawing.Size(272, 489)
        Me.genre_panel.TabIndex = 7
        '
        'flow_genre_panel
        '
        Me.flow_genre_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_genre_panel.BackColor = System.Drawing.Color.Transparent
        Me.flow_genre_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_genre_panel.Location = New System.Drawing.Point(8, 8)
        Me.flow_genre_panel.Name = "flow_genre_panel"
        Me.flow_genre_panel.Size = New System.Drawing.Size(256, 464)
        Me.flow_genre_panel.TabIndex = 0
        '
        'container_panel
        '
        Me.container_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.container_panel.BackColor = System.Drawing.Color.Transparent
        Me.container_panel.Controls.Add(Me.flow_main_book_panel)
        Me.container_panel.CustomizableEdges.BottomLeft = False
        Me.container_panel.CustomizableEdges.TopLeft = False
        Me.container_panel.FillColor = System.Drawing.Color.FloralWhite
        Me.container_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.container_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.container_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.container_panel.Location = New System.Drawing.Point(272, 64)
        Me.container_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.container_panel.Name = "container_panel"
        Me.container_panel.Size = New System.Drawing.Size(645, 489)
        Me.container_panel.TabIndex = 8
        '
        'flow_main_book_panel
        '
        Me.flow_main_book_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_main_book_panel.AutoScroll = True
        Me.flow_main_book_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_main_book_panel.Location = New System.Drawing.Point(8, 8)
        Me.flow_main_book_panel.Name = "flow_main_book_panel"
        Me.flow_main_book_panel.Size = New System.Drawing.Size(624, 464)
        Me.flow_main_book_panel.TabIndex = 0
        '
        'Home_Panel_Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(918, 549)
        Me.Controls.Add(Me.title_panel)
        Me.Controls.Add(Me.genre_panel)
        Me.Controls.Add(Me.container_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home_Panel_Students"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home Panel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.title_panel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.genre_panel.ResumeLayout(False)
        Me.container_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_user As Label
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents txtBox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_profile As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents genre_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents container_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flow_genre_panel As FlowLayoutPanel
    Friend WithEvents flow_main_book_panel As FlowLayoutPanel
End Class
