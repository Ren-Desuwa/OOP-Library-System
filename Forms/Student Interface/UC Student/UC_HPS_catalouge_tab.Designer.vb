<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_HPS_catalouge_tab
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
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UC_HPS_catalouge_tab))
        Me.genre_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.flow_genre_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.container_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnToggleSidebar = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Back = New Guna.UI2.WinForms.Guna2Button()
        Me.flow_main_book_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.UC_pagination_controls1 = New OOP_Library_System.UC_pagination_controls()
        Me.genre_panel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.container_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'genre_panel
        '
        Me.genre_panel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.genre_panel.Controls.Add(Me.TableLayoutPanel1)
        Me.genre_panel.CustomizableEdges.BottomRight = False
        Me.genre_panel.CustomizableEdges.TopRight = False
        Me.Guna2Transition1.SetDecoration(Me.genre_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.genre_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.genre_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.genre_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.genre_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.genre_panel.Location = New System.Drawing.Point(448, 792)
        Me.genre_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.genre_panel.Name = "genre_panel"
        Me.genre_panel.Size = New System.Drawing.Size(584, 903)
        Me.genre_panel.TabIndex = 8
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.682858!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.35616!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.993151!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.flow_genre_panel, 1, 3)
        Me.Guna2Transition1.SetDecoration(Me.TableLayoutPanel1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.301075!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.918919!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.513514!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.51351!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(584, 903)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Guna2Transition1.SetDecoration(Me.Label1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(507, 35)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "    GENRES:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'flow_genre_panel
        '
        Me.flow_genre_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_genre_panel.AutoScroll = True
        Me.flow_genre_panel.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.flow_genre_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.flow_genre_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_genre_panel.Location = New System.Drawing.Point(36, 106)
        Me.flow_genre_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flow_genre_panel.Name = "flow_genre_panel"
        Me.flow_genre_panel.Size = New System.Drawing.Size(509, 795)
        Me.flow_genre_panel.TabIndex = 0
        Me.flow_genre_panel.WrapContents = False
        '
        'container_panel
        '
        Me.container_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.container_panel.BackColor = System.Drawing.Color.Transparent
        Me.container_panel.Controls.Add(Me.btnToggleSidebar)
        Me.container_panel.Controls.Add(Me.btn_Back)
        Me.container_panel.Controls.Add(Me.genre_panel)
        Me.container_panel.Controls.Add(Me.UC_pagination_controls1)
        Me.container_panel.Controls.Add(Me.flow_main_book_panel)
        Me.container_panel.CustomizableEdges.BottomLeft = False
        Me.container_panel.CustomizableEdges.TopLeft = False
        Me.Guna2Transition1.SetDecoration(Me.container_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.container_panel.FillColor = System.Drawing.Color.FloralWhite
        Me.container_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.container_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.container_panel.FillColor4 = System.Drawing.Color.Wheat
        Me.container_panel.Location = New System.Drawing.Point(3, 0)
        Me.container_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.container_panel.Name = "container_panel"
        Me.container_panel.Size = New System.Drawing.Size(1141, 916)
        Me.container_panel.TabIndex = 9
        '
        'btnToggleSidebar
        '
        Me.Guna2Transition1.SetDecoration(Me.btnToggleSidebar, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btnToggleSidebar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleSidebar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnToggleSidebar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnToggleSidebar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnToggleSidebar.FillColor = System.Drawing.Color.Transparent
        Me.btnToggleSidebar.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleSidebar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnToggleSidebar.Location = New System.Drawing.Point(105, 16)
        Me.btnToggleSidebar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnToggleSidebar.Name = "btnToggleSidebar"
        Me.btnToggleSidebar.Size = New System.Drawing.Size(139, 79)
        Me.btnToggleSidebar.TabIndex = 16
        Me.btnToggleSidebar.Text = ">>>>>"
        '
        'btn_Back
        '
        Me.Guna2Transition1.SetDecoration(Me.btn_Back, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Back.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_Back.ForeColor = System.Drawing.Color.White
        Me.btn_Back.Location = New System.Drawing.Point(1087, 41)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(240, 55)
        Me.btn_Back.TabIndex = 17
        Me.btn_Back.Text = "Guna2Button1"
        '
        'flow_main_book_panel
        '
        Me.flow_main_book_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Transition1.SetDecoration(Me.flow_main_book_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.flow_main_book_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_main_book_panel.Location = New System.Drawing.Point(271, 30)
        Me.flow_main_book_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flow_main_book_panel.Name = "flow_main_book_panel"
        Me.flow_main_book_panel.Size = New System.Drawing.Size(752, 658)
        Me.flow_main_book_panel.TabIndex = 0
        Me.flow_main_book_panel.WrapContents = False
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'UC_pagination_controls1
        '
        Me.UC_pagination_controls1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_pagination_controls1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.UC_pagination_controls1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UC_pagination_controls1.Location = New System.Drawing.Point(36, 678)
        Me.UC_pagination_controls1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UC_pagination_controls1.Name = "UC_pagination_controls1"
        Me.UC_pagination_controls1.Size = New System.Drawing.Size(1133, 97)
        Me.UC_pagination_controls1.TabIndex = 15
        '
        'UC_HPS_catalouge_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.container_panel)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_HPS_catalouge_tab"
        Me.Size = New System.Drawing.Size(1105, 918)
        Me.genre_panel.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.container_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents genre_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flow_genre_panel As FlowLayoutPanel
    Friend WithEvents container_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flow_main_book_panel As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UC_pagination_controls1 As UC_pagination_controls
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents btnToggleSidebar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Back As Guna.UI2.WinForms.Guna2Button
End Class
