<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_pagination_controls
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
        Me.btn_Prev = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Next = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_PageInfo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Prev
        '
        Me.btn_Prev.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Prev.BackColor = System.Drawing.Color.Transparent
        Me.btn_Prev.BorderRadius = 10
        Me.btn_Prev.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Prev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Prev.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Prev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Prev.FillColor = System.Drawing.Color.Tan
        Me.btn_Prev.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Prev.ForeColor = System.Drawing.Color.Black
        Me.btn_Prev.Location = New System.Drawing.Point(3, 2)
        Me.btn_Prev.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Prev.MaximumSize = New System.Drawing.Size(135, 37)
        Me.btn_Prev.Name = "btn_Prev"
        Me.btn_Prev.Size = New System.Drawing.Size(117, 37)
        Me.btn_Prev.TabIndex = 4
        Me.btn_Prev.Text = "Previous"
        '
        'btn_Next
        '
        Me.btn_Next.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Next.BackColor = System.Drawing.Color.Transparent
        Me.btn_Next.BorderRadius = 10
        Me.btn_Next.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Next.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Next.FillColor = System.Drawing.Color.Tan
        Me.btn_Next.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Next.ForeColor = System.Drawing.Color.Black
        Me.btn_Next.Location = New System.Drawing.Point(246, 2)
        Me.btn_Next.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Next.MaximumSize = New System.Drawing.Size(135, 37)
        Me.btn_Next.Name = "btn_Next"
        Me.btn_Next.Size = New System.Drawing.Size(118, 37)
        Me.btn_Next.TabIndex = 5
        Me.btn_Next.Text = "Next"
        '
        'lbl_PageInfo
        '
        Me.lbl_PageInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_PageInfo.AutoSize = True
        Me.lbl_PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PageInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PageInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_PageInfo.Location = New System.Drawing.Point(124, 0)
        Me.lbl_PageInfo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_PageInfo.Name = "lbl_PageInfo"
        Me.lbl_PageInfo.Size = New System.Drawing.Size(118, 46)
        Me.lbl_PageInfo.TabIndex = 13
        Me.lbl_PageInfo.Text = "Page"
        Me.lbl_PageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Next, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Prev, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_PageInfo, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 13)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 46)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'UC_pagination_controls
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_pagination_controls"
        Me.Size = New System.Drawing.Size(418, 79)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_Prev As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Next As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_PageInfo As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
