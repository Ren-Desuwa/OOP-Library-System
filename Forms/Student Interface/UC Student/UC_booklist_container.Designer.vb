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
        Me.flow_book_panel = New System.Windows.Forms.FlowLayoutPanel()
        Me.lbl_genre = New System.Windows.Forms.Label()
        Me.booklist_container_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'booklist_container_panel
        '
        Me.booklist_container_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.booklist_container_panel.BackColor = System.Drawing.Color.Transparent
        Me.booklist_container_panel.Controls.Add(Me.flow_book_panel)
        Me.booklist_container_panel.Controls.Add(Me.lbl_genre)
        Me.booklist_container_panel.Location = New System.Drawing.Point(0, 0)
        Me.booklist_container_panel.Name = "booklist_container_panel"
        Me.booklist_container_panel.Size = New System.Drawing.Size(616, 319)
        Me.booklist_container_panel.TabIndex = 11
        '
        'flow_book_panel
        '
        Me.flow_book_panel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_book_panel.Location = New System.Drawing.Point(8, 40)
        Me.flow_book_panel.Name = "flow_book_panel"
        Me.flow_book_panel.Size = New System.Drawing.Size(600, 270)
        Me.flow_book_panel.TabIndex = 12
        '
        'lbl_genre
        '
        Me.lbl_genre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_genre.AutoSize = True
        Me.lbl_genre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_genre.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_genre.ForeColor = System.Drawing.Color.DimGray
        Me.lbl_genre.Location = New System.Drawing.Point(8, 8)
        Me.lbl_genre.Name = "lbl_genre"
        Me.lbl_genre.Size = New System.Drawing.Size(98, 32)
        Me.lbl_genre.TabIndex = 13
        Me.lbl_genre.Text = "Genre"
        Me.lbl_genre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UC_booklist_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.booklist_container_panel)
        Me.Name = "UC_booklist_container"
        Me.Size = New System.Drawing.Size(616, 319)
        Me.booklist_container_panel.ResumeLayout(False)
        Me.booklist_container_panel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents booklist_container_panel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_genre As Label
    Friend WithEvents flow_book_panel As FlowLayoutPanel
End Class
