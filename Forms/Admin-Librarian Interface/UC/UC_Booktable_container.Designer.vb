<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Booktable_container
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
        Me.lbl_book_title = New System.Windows.Forms.Label()
        Me.lbl_book_author = New System.Windows.Forms.Label()
        Me.lbl_book_count = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_Genre = New System.Windows.Forms.Label()
        Me.pnl_table_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnl_table_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_book_title
        '
        Me.lbl_book_title.AutoEllipsis = True
        Me.lbl_book_title.AutoSize = True
        Me.lbl_book_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_book_title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_book_title.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_book_title.Location = New System.Drawing.Point(3, 0)
        Me.lbl_book_title.Name = "lbl_book_title"
        Me.lbl_book_title.Size = New System.Drawing.Size(248, 85)
        Me.lbl_book_title.TabIndex = 7
        Me.lbl_book_title.Text = "Book Title:"
        Me.lbl_book_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_book_author
        '
        Me.lbl_book_author.AutoEllipsis = True
        Me.lbl_book_author.AutoSize = True
        Me.lbl_book_author.BackColor = System.Drawing.Color.Transparent
        Me.lbl_book_author.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_book_author.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_author.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_book_author.Location = New System.Drawing.Point(257, 0)
        Me.lbl_book_author.Name = "lbl_book_author"
        Me.lbl_book_author.Size = New System.Drawing.Size(248, 85)
        Me.lbl_book_author.TabIndex = 8
        Me.lbl_book_author.Text = "Book Author:"
        Me.lbl_book_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_book_count
        '
        Me.lbl_book_count.AutoEllipsis = True
        Me.lbl_book_count.AutoSize = True
        Me.lbl_book_count.BackColor = System.Drawing.Color.Transparent
        Me.lbl_book_count.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_book_count.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_count.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_book_count.Location = New System.Drawing.Point(735, 0)
        Me.lbl_book_count.Name = "lbl_book_count"
        Me.lbl_book_count.Size = New System.Drawing.Size(168, 85)
        Me.lbl_book_count.TabIndex = 9
        Me.lbl_book_count.Text = "Book Count: "
        Me.lbl_book_count.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.03532!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.14569!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.72406!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.09492!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Genre, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_book_title, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_book_count, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_book_author, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(906, 85)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'lbl_Genre
        '
        Me.lbl_Genre.AutoEllipsis = True
        Me.lbl_Genre.AutoSize = True
        Me.lbl_Genre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Genre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Genre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Genre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_Genre.Location = New System.Drawing.Point(511, 0)
        Me.lbl_Genre.Name = "lbl_Genre"
        Me.lbl_Genre.Size = New System.Drawing.Size(218, 85)
        Me.lbl_Genre.TabIndex = 10
        Me.lbl_Genre.Text = "Genre:"
        Me.lbl_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_table_container
        '
        Me.pnl_table_container.BackColor = System.Drawing.Color.Transparent
        Me.pnl_table_container.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnl_table_container.BorderRadius = 10
        Me.pnl_table_container.BorderThickness = 3
        Me.pnl_table_container.Controls.Add(Me.TableLayoutPanel1)
        Me.pnl_table_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl_table_container.FillColor = System.Drawing.Color.Transparent
        Me.pnl_table_container.ForeColor = System.Drawing.Color.Transparent
        Me.pnl_table_container.Location = New System.Drawing.Point(0, 0)
        Me.pnl_table_container.Name = "pnl_table_container"
        Me.pnl_table_container.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.pnl_table_container.ShadowDecoration.Depth = 15
        Me.pnl_table_container.ShadowDecoration.Enabled = True
        Me.pnl_table_container.Size = New System.Drawing.Size(906, 85)
        Me.pnl_table_container.TabIndex = 11
        '
        'UC_Booktable_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnl_table_container)
        Me.Name = "UC_Booktable_container"
        Me.Size = New System.Drawing.Size(906, 85)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnl_table_container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_book_title As Label
    Friend WithEvents lbl_book_author As Label
    Friend WithEvents lbl_book_count As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_Genre As Label
    Friend WithEvents pnl_table_container As Guna.UI2.WinForms.Guna2Panel
End Class
