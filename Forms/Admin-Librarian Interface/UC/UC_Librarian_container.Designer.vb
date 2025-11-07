<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_Librarian_container
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_Email = New System.Windows.Forms.Label()
        Me.pnl_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.pnl_container.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.32353!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.52941!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.14706!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_Email, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(611, 69)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(458, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Verified-ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name
        '
        Me.lbl_name.AutoEllipsis = True
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(2, 0)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(60, 21)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Name:"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_Email
        '
        Me.lbl_Email.AutoEllipsis = True
        Me.lbl_Email.AutoSize = True
        Me.lbl_Email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_Email.Location = New System.Drawing.Point(254, 0)
        Me.lbl_Email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Email.Name = "lbl_Email"
        Me.lbl_Email.Size = New System.Drawing.Size(57, 21)
        Me.lbl_Email.TabIndex = 8
        Me.lbl_Email.Text = "Email:"
        Me.lbl_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pnl_container
        '
        Me.pnl_container.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl_container.BackColor = System.Drawing.Color.Transparent
        Me.pnl_container.BorderColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.pnl_container.BorderRadius = 10
        Me.pnl_container.BorderThickness = 3
        Me.pnl_container.Controls.Add(Me.TableLayoutPanel1)
        Me.pnl_container.FillColor = System.Drawing.Color.Transparent
        Me.pnl_container.ForeColor = System.Drawing.Color.Transparent
        Me.pnl_container.Location = New System.Drawing.Point(0, 0)
        Me.pnl_container.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_container.Name = "pnl_container"
        Me.pnl_container.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.pnl_container.ShadowDecoration.Depth = 15
        Me.pnl_container.ShadowDecoration.Enabled = True
        Me.pnl_container.Size = New System.Drawing.Size(611, 69)
        Me.pnl_container.TabIndex = 13
        '
        'UC_Librarian_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnl_container)
        Me.Name = "UC_Librarian_container"
        Me.Size = New System.Drawing.Size(611, 74)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.pnl_container.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_Email As Label
    Friend WithEvents pnl_container As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
End Class
