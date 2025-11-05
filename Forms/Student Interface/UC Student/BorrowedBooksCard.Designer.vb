<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BorrowedBooksCard
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlStatus = New Guna.UI2.WinForms.Guna2Panel()
        Me.lblBookTitle = New System.Windows.Forms.Label()
        Me.lblDueDate = New System.Windows.Forms.Label()
        Me.lblBorrowedDate = New System.Windows.Forms.Label()
        Me.picbox_bookcover = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.picbox_bookcover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2Panel1.BorderRadius = 8
        Me.Guna2Panel1.BorderThickness = 2
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(10, 10)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(10)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Padding = New System.Windows.Forms.Padding(10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1905, 130)
        Me.Guna2Panel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.85185!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.14815!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.picbox_bookcover, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(10, 10)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1885, 110)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.pnlStatus, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBookTitle, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblDueDate, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblBorrowedDate, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(377, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.61538!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1505, 104)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'pnlStatus
        '
        Me.pnlStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlStatus.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.pnlStatus.Location = New System.Drawing.Point(1485, 2)
        Me.pnlStatus.Margin = New System.Windows.Forms.Padding(2)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(18, 20)
        Me.pnlStatus.TabIndex = 1
        '
        'lblBookTitle
        '
        Me.lblBookTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblBookTitle.AutoSize = True
        Me.lblBookTitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold)
        Me.lblBookTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblBookTitle.Location = New System.Drawing.Point(3, 15)
        Me.lblBookTitle.Name = "lblBookTitle"
        Me.lblBookTitle.Size = New System.Drawing.Size(143, 37)
        Me.lblBookTitle.TabIndex = 0
        Me.lblBookTitle.Text = "One Piece"
        '
        'lblDueDate
        '
        Me.lblDueDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDueDate.AutoSize = True
        Me.lblDueDate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblDueDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblDueDate.Location = New System.Drawing.Point(752, 84)
        Me.lblDueDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblDueDate.Name = "lblDueDate"
        Me.lblDueDate.Size = New System.Drawing.Size(78, 20)
        Me.lblDueDate.TabIndex = 2
        Me.lblDueDate.Text = "Due Date:"
        Me.lblDueDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblBorrowedDate
        '
        Me.lblBorrowedDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBorrowedDate.AutoSize = True
        Me.lblBorrowedDate.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblBorrowedDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblBorrowedDate.Location = New System.Drawing.Point(0, 84)
        Me.lblBorrowedDate.Margin = New System.Windows.Forms.Padding(0)
        Me.lblBorrowedDate.Name = "lblBorrowedDate"
        Me.lblBorrowedDate.Size = New System.Drawing.Size(115, 20)
        Me.lblBorrowedDate.TabIndex = 1
        Me.lblBorrowedDate.Text = "Borrowed Date"
        Me.lblBorrowedDate.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'picbox_bookcover
        '
        Me.picbox_bookcover.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.picbox_bookcover.BorderRadius = 10
        Me.picbox_bookcover.FillColor = System.Drawing.Color.Transparent
        Me.picbox_bookcover.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picbox_bookcover.ImageRotate = 0!
        Me.picbox_bookcover.Location = New System.Drawing.Point(143, 3)
        Me.picbox_bookcover.MaximumSize = New System.Drawing.Size(87, 104)
        Me.picbox_bookcover.Name = "picbox_bookcover"
        Me.picbox_bookcover.Size = New System.Drawing.Size(87, 104)
        Me.picbox_bookcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_bookcover.TabIndex = 0
        Me.picbox_bookcover.TabStop = False
        '
        'BorrowedBooksCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "BorrowedBooksCard"
        Me.Size = New System.Drawing.Size(1714, 150)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.picbox_bookcover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents picbox_bookcover As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lblBookTitle As Label
    Friend WithEvents lblBorrowedDate As Label
    Friend WithEvents lblDueDate As Label
    Friend WithEvents pnlStatus As Guna.UI2.WinForms.Guna2Panel
End Class
