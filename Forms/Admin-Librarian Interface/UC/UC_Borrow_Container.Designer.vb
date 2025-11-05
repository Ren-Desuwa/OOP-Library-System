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
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(3)
        Me.Guna2Panel1.Size = New System.Drawing.Size(695, 69)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Tan
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DueDate_Lbl, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BorrowDate_Lbl, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Borrower_Lbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BookName_Lbl, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(10)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(689, 63)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DueDate_Lbl
        '
        Me.DueDate_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DueDate_Lbl.AutoSize = True
        Me.DueDate_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DueDate_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DueDate_Lbl.Location = New System.Drawing.Point(518, 19)
        Me.DueDate_Lbl.Name = "DueDate_Lbl"
        Me.DueDate_Lbl.Size = New System.Drawing.Size(90, 24)
        Me.DueDate_Lbl.TabIndex = 3
        Me.DueDate_Lbl.Text = "DueDate"
        '
        'BorrowDate_Lbl
        '
        Me.BorrowDate_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BorrowDate_Lbl.AutoSize = True
        Me.BorrowDate_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowDate_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BorrowDate_Lbl.Location = New System.Drawing.Point(347, 19)
        Me.BorrowDate_Lbl.Name = "BorrowDate_Lbl"
        Me.BorrowDate_Lbl.Size = New System.Drawing.Size(118, 24)
        Me.BorrowDate_Lbl.TabIndex = 2
        Me.BorrowDate_Lbl.Text = "BorrowDate"
        '
        'Borrower_Lbl
        '
        Me.Borrower_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Borrower_Lbl.AutoSize = True
        Me.Borrower_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Borrower_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Borrower_Lbl.Location = New System.Drawing.Point(176, 19)
        Me.Borrower_Lbl.Name = "Borrower_Lbl"
        Me.Borrower_Lbl.Size = New System.Drawing.Size(95, 24)
        Me.Borrower_Lbl.TabIndex = 1
        Me.Borrower_Lbl.Text = "Borrower"
        '
        'BookName_Lbl
        '
        Me.BookName_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.BookName_Lbl.AutoSize = True
        Me.BookName_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookName_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BookName_Lbl.Location = New System.Drawing.Point(5, 19)
        Me.BookName_Lbl.Name = "BookName_Lbl"
        Me.BookName_Lbl.Size = New System.Drawing.Size(112, 24)
        Me.BookName_Lbl.TabIndex = 0
        Me.BookName_Lbl.Text = "BookName"
        '
        'UC_Borrow_Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "UC_Borrow_Container"
        Me.Size = New System.Drawing.Size(695, 69)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Borrower_Lbl As Label
    Friend WithEvents BookName_Lbl As Label
    Friend WithEvents DueDate_Lbl As Label
    Friend WithEvents BorrowDate_Lbl As Label
End Class
