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
        Me.genre_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.flow_genre_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.container_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.UC_pagination_controls1 = New OOP_Library_System.UC_pagination_controls()
        Me.btn_Back = New Guna.UI2.WinForms.Guna2Button()
        Me.flow_main_book_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.genre_panel.SuspendLayout()
        Me.container_panel.SuspendLayout()
        Me.SuspendLayout()
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
        Me.genre_panel.Location = New System.Drawing.Point(0, 0)
        Me.genre_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.genre_panel.Name = "genre_panel"
        Me.genre_panel.Size = New System.Drawing.Size(204, 397)
        Me.genre_panel.TabIndex = 8
        '
        'flow_genre_panel
        '
        Me.flow_genre_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_genre_panel.BackColor = System.Drawing.Color.Transparent
        Me.flow_genre_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_genre_panel.Location = New System.Drawing.Point(6, 6)
        Me.flow_genre_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flow_genre_panel.Name = "flow_genre_panel"
        Me.flow_genre_panel.Size = New System.Drawing.Size(192, 384)
        Me.flow_genre_panel.TabIndex = 0
        '
        'container_panel
        '
        Me.container_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.container_panel.BackColor = System.Drawing.Color.Transparent
        Me.container_panel.Controls.Add(Me.UC_pagination_controls1)
        Me.container_panel.Controls.Add(Me.btn_Back)
        Me.container_panel.Controls.Add(Me.flow_main_book_panel)
        Me.container_panel.CustomizableEdges.BottomLeft = False
        Me.container_panel.CustomizableEdges.TopLeft = False
        Me.container_panel.FillColor = System.Drawing.Color.FloralWhite
        Me.container_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.container_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.container_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.container_panel.Location = New System.Drawing.Point(204, 0)
        Me.container_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.container_panel.Name = "container_panel"
        Me.container_panel.Size = New System.Drawing.Size(275, 397)
        Me.container_panel.TabIndex = 9
        '
        'UC_pagination_controls1
        '
        Me.UC_pagination_controls1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UC_pagination_controls1.BackColor = System.Drawing.Color.Transparent
        Me.UC_pagination_controls1.Location = New System.Drawing.Point(6, 240)
        Me.UC_pagination_controls1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.UC_pagination_controls1.Name = "UC_pagination_controls1"
        Me.UC_pagination_controls1.Size = New System.Drawing.Size(269, 79)
        Me.UC_pagination_controls1.TabIndex = 15
        '
        'btn_Back
        '
        Me.btn_Back.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Back.BackColor = System.Drawing.Color.Transparent
        Me.btn_Back.BorderRadius = 10
        Me.btn_Back.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Back.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Back.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Back.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Back.FillColor = System.Drawing.Color.Tan
        Me.btn_Back.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Back.ForeColor = System.Drawing.Color.Black
        Me.btn_Back.Location = New System.Drawing.Point(107, 13)
        Me.btn_Back.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Back.Name = "btn_Back"
        Me.btn_Back.Size = New System.Drawing.Size(135, 37)
        Me.btn_Back.TabIndex = 6
        Me.btn_Back.Text = "Back"
        Me.btn_Back.Visible = False
        '
        'flow_main_book_panel
        '
        Me.flow_main_book_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_main_book_panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_main_book_panel.Location = New System.Drawing.Point(6, 6)
        Me.flow_main_book_panel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.flow_main_book_panel.Name = "flow_main_book_panel"
        Me.flow_main_book_panel.Size = New System.Drawing.Size(269, 234)
        Me.flow_main_book_panel.TabIndex = 0
        Me.flow_main_book_panel.WrapContents = False
        '
        'UC_HPS_catalouge_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.genre_panel)
        Me.Controls.Add(Me.container_panel)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_HPS_catalouge_tab"
        Me.Size = New System.Drawing.Size(693, 397)
        Me.genre_panel.ResumeLayout(False)
        Me.container_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents genre_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flow_genre_panel As FlowLayoutPanel
    Friend WithEvents container_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents flow_main_book_panel As FlowLayoutPanel
    Friend WithEvents btn_Back As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents UC_pagination_controls1 As UC_pagination_controls
End Class
