<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Borrow_Container
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DueDate_Lbl = New System.Windows.Forms.Label()
        Me.BorrowDate_Lbl = New System.Windows.Forms.Label()
        Me.Borrower_Lbl = New System.Windows.Forms.Label()
        Me.BookName_Lbl = New System.Windows.Forms.Label()
        Me.StatusPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.btn_viewbook = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(4)
        Me.Guna2Panel1.Size = New System.Drawing.Size(927, 85)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Tan
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.11905!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.5006!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.24195!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88439!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 81.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DueDate_Lbl, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BorrowDate_Lbl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Borrower_Lbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BookName_Lbl, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.StatusPanel, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_viewbook, 4, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 77)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DueDate_Lbl
        '
        Me.DueDate_Lbl.AutoSize = True
        Me.DueDate_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DueDate_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDate_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DueDate_Lbl.Location = New System.Drawing.Point(454, 2)
        Me.DueDate_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DueDate_Lbl.Name = "DueDate_Lbl"
        Me.DueDate_Lbl.Size = New System.Drawing.Size(183, 73)
        Me.DueDate_Lbl.TabIndex = 3
        Me.DueDate_Lbl.Text = "DueDate"
        '
        'BorrowDate_Lbl
        '
        Me.BorrowDate_Lbl.AutoSize = True
        Me.BorrowDate_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorrowDate_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowDate_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BorrowDate_Lbl.Location = New System.Drawing.Point(284, 2)
        Me.BorrowDate_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BorrowDate_Lbl.Name = "BorrowDate_Lbl"
        Me.BorrowDate_Lbl.Size = New System.Drawing.Size(160, 73)
        Me.BorrowDate_Lbl.TabIndex = 2
        Me.BorrowDate_Lbl.Text = "BorrowDate"
        '
        'Borrower_Lbl
        '
        Me.Borrower_Lbl.AutoSize = True
        Me.Borrower_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Borrower_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrower_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Borrower_Lbl.Location = New System.Drawing.Point(173, 2)
        Me.Borrower_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Borrower_Lbl.Name = "Borrower_Lbl"
        Me.Borrower_Lbl.Size = New System.Drawing.Size(101, 73)
        Me.Borrower_Lbl.TabIndex = 1
        Me.Borrower_Lbl.Text = "Borrower"
        '
        'BookName_Lbl
        '
        Me.BookName_Lbl.AutoSize = True
        Me.BookName_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookName_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookName_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookName_Lbl.Location = New System.Drawing.Point(6, 2)
        Me.BookName_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.BookName_Lbl.Name = "BookName_Lbl"
        Me.BookName_Lbl.Size = New System.Drawing.Size(157, 73)
        Me.BookName_Lbl.TabIndex = 0
        Me.BookName_Lbl.Text = "BookName"
        '
        'StatusPanel
        '
        Me.StatusPanel.Controls.Add(Me.StatusLbl)
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusPanel.FillColor = System.Drawing.Color.LightSeaGreen
        Me.StatusPanel.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.StatusPanel.FillColor3 = System.Drawing.Color.WhiteSmoke
        Me.StatusPanel.FillColor4 = System.Drawing.Color.DeepSkyBlue
        Me.StatusPanel.Location = New System.Drawing.Point(833, 2)
        Me.StatusPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(84, 73)
        Me.StatusPanel.TabIndex = 4
        '
        'StatusLbl
        '
        Me.StatusLbl.AutoSize = True
        Me.StatusLbl.BackColor = System.Drawing.Color.Transparent
        Me.StatusLbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLbl.ForeColor = System.Drawing.Color.White
        Me.StatusLbl.Location = New System.Drawing.Point(0, 0)
        Me.StatusLbl.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusLbl.Name = "StatusLbl"
        Me.StatusLbl.Size = New System.Drawing.Size(30, 29)
        Me.StatusLbl.TabIndex = 4
        Me.StatusLbl.Text = "P"
        '
        'btn_viewbook
        '
        Me.btn_viewbook.BorderRadius = 10
        Me.btn_viewbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_viewbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_viewbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_viewbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_viewbook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_viewbook.FillColor = System.Drawing.Color.White
        Me.btn_viewbook.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_viewbook.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_viewbook.Location = New System.Drawing.Point(647, 6)
        Me.btn_viewbook.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_viewbook.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_viewbook.Name = "btn_viewbook"
        Me.btn_viewbook.Size = New System.Drawing.Size(180, 52)
        Me.btn_viewbook.TabIndex = 5
        Me.btn_viewbook.Text = "View"
        '
        'UC_Borrow_Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UC_Borrow_Container"
        Me.Size = New System.Drawing.Size(927, 85)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Borrower_Lbl As Label
    Friend WithEvents BookName_Lbl As Label
    Friend WithEvents DueDate_Lbl As Label
    Friend WithEvents BorrowDate_Lbl As Label
    Friend WithEvents StatusPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents StatusLbl As Label
    Friend WithEvents btn_viewbook As Guna.UI2.WinForms.Guna2Button
End Class
