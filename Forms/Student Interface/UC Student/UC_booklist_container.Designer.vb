<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_booklist_container
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
        Me.booklist_container_panel = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_SeeAll = New Guna.UI2.WinForms.Guna2Button()
        Me.flow_book_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.pnl_genre_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.booklist_container_panel.SuspendLayout()
        Me.pnl_genre_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'booklist_container_panel
        '
        Me.booklist_container_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.booklist_container_panel.BackColor = System.Drawing.Color.Transparent
        Me.booklist_container_panel.Controls.Add(Me.pnl_genre_container)
        Me.booklist_container_panel.Controls.Add(Me.btn_SeeAll)
        Me.booklist_container_panel.Controls.Add(Me.flow_book_panel)
        Me.booklist_container_panel.Location = New System.Drawing.Point(0, 0)
        Me.booklist_container_panel.Name = "booklist_container_panel"
        Me.booklist_container_panel.Size = New System.Drawing.Size(616, 354)
        Me.booklist_container_panel.TabIndex = 11
        '
        'btn_SeeAll
        '
        Me.btn_SeeAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_SeeAll.BorderRadius = 10
        Me.btn_SeeAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_SeeAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_SeeAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_SeeAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_SeeAll.FillColor = System.Drawing.Color.Tan
        Me.btn_SeeAll.Font = New System.Drawing.Font("Segoe UI", 10.2!)
        Me.btn_SeeAll.ForeColor = System.Drawing.Color.Black
        Me.btn_SeeAll.Location = New System.Drawing.Point(440, 8)
        Me.btn_SeeAll.Name = "btn_SeeAll"
        Me.btn_SeeAll.Size = New System.Drawing.Size(164, 24)
        Me.btn_SeeAll.TabIndex = 12
        Me.btn_SeeAll.Text = "See All"
        Me.btn_SeeAll.Visible = False
        '
        'flow_book_panel
        '
        Me.flow_book_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_book_panel.Location = New System.Drawing.Point(8, 40)
        Me.flow_book_panel.Name = "flow_book_panel"
        Me.flow_book_panel.Size = New System.Drawing.Size(600, 305)
        Me.flow_book_panel.TabIndex = 12
        '
        'lbl_genre
        '
        Me.lbl_genre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_genre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_genre.Location = New System.Drawing.Point(0, 0)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(248, 40)
        Me.lbl_genre.TabIndex = 13
        Me.lbl_genre.Text = "Genre"
        Me.lbl_genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnl_genre_container
        '
        Me.pnl_genre_container.BackColor = System.Drawing.Color.Transparent
        Me.pnl_genre_container.BorderRadius = 10
        Me.pnl_genre_container.Controls.Add(Me.lbl_genre)
        Me.pnl_genre_container.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.pnl_genre_container.ForeColor = System.Drawing.Color.Transparent
        Me.pnl_genre_container.Location = New System.Drawing.Point(8, 0)
        Me.pnl_genre_container.Name = "pnl_genre_container"
        Me.pnl_genre_container.Size = New System.Drawing.Size(248, 40)
        Me.pnl_genre_container.TabIndex = 14
        '
        'UC_booklist_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.booklist_container_panel)
        Me.Name = "UC_booklist_container"
        Me.Size = New System.Drawing.Size(616, 354)
        Me.booklist_container_panel.ResumeLayout(False)
        Me.pnl_genre_container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents booklist_container_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_genre As Label
    Friend WithEvents flow_book_panel As FlowLayoutPanel
    Friend WithEvents btn_SeeAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pnl_genre_container As Guna.UI2.WinForms.Guna2Panel
End Class
