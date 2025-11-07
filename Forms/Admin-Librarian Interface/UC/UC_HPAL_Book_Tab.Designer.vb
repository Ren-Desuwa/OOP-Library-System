<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HPAL_Book_Tab
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.flow_panel_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_Editbook = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Addbooks = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_allbookcount = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_previous = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_next = New Guna.UI2.WinForms.Guna2Button()
        Me.lbl_PageInfo = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'flow_panel_container
        '
        Me.flow_panel_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_panel_container.AutoScroll = True
        Me.flow_panel_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_panel_container.Location = New System.Drawing.Point(0, 0)
        Me.flow_panel_container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flow_panel_container.Name = "flow_panel_container"
        Me.flow_panel_container.Size = New System.Drawing.Size(1008, 616)
        Me.flow_panel_container.TabIndex = 0
        Me.flow_panel_container.WrapContents = False
        '
        'btn_Editbook
        '
        Me.btn_Editbook.BorderRadius = 20
        Me.btn_Editbook.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Editbook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Editbook.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Editbook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Editbook.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Editbook.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Editbook.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Editbook.ForeColor = System.Drawing.Color.White
        Me.btn_Editbook.Location = New System.Drawing.Point(841, 2)
        Me.btn_Editbook.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Editbook.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_Editbook.Name = "btn_Editbook"
        Me.btn_Editbook.Size = New System.Drawing.Size(164, 52)
        Me.btn_Editbook.TabIndex = 5
        Me.btn_Editbook.Text = "Edit"
        '
        'btn_Addbooks
        '
        Me.btn_Addbooks.BorderRadius = 20
        Me.btn_Addbooks.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Addbooks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Addbooks.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Addbooks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Addbooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_Addbooks.FillColor = System.Drawing.Color.White
        Me.btn_Addbooks.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Addbooks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Addbooks.Location = New System.Drawing.Point(672, 2)
        Me.btn_Addbooks.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Addbooks.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_Addbooks.Name = "btn_Addbooks"
        Me.btn_Addbooks.Size = New System.Drawing.Size(163, 52)
        Me.btn_Addbooks.TabIndex = 4
        Me.btn_Addbooks.Text = "Add"
        '
        'lbl_allbookcount
        '
        Me.lbl_allbookcount.AutoEllipsis = True
        Me.lbl_allbookcount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_allbookcount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_allbookcount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_allbookcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_allbookcount.Location = New System.Drawing.Point(3, 0)
        Me.lbl_allbookcount.MaximumSize = New System.Drawing.Size(432, 57)
        Me.lbl_allbookcount.Name = "lbl_allbookcount"
        Me.lbl_allbookcount.Size = New System.Drawing.Size(286, 57)
        Me.lbl_allbookcount.TabIndex = 6
        Me.lbl_allbookcount.Text = "Number of Books:"
        Me.lbl_allbookcount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.00211!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.46105!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.76685!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.76999!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_allbookcount, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Editbook, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_Addbooks, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 624)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 64)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel2.Controls.Add(Me.btn_previous, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btn_next, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lbl_PageInfo, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(295, 2)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TableLayoutPanel2.MaximumSize = New System.Drawing.Size(488, 57)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(371, 57)
        Me.TableLayoutPanel2.TabIndex = 15
        '
        'btn_previous
        '
        Me.btn_previous.BorderRadius = 20
        Me.btn_previous.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_previous.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_previous.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_previous.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_previous.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_previous.FillColor = System.Drawing.Color.Wheat
        Me.btn_previous.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_previous.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_previous.Location = New System.Drawing.Point(3, 2)
        Me.btn_previous.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_previous.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_previous.Name = "btn_previous"
        Me.btn_previous.Size = New System.Drawing.Size(117, 52)
        Me.btn_previous.TabIndex = 15
        Me.btn_previous.Text = "Previous"
        '
        'btn_next
        '
        Me.btn_next.BorderRadius = 20
        Me.btn_next.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_next.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_next.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_next.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_next.FillColor = System.Drawing.Color.Wheat
        Me.btn_next.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(249, 2)
        Me.btn_next.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_next.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(119, 52)
        Me.btn_next.TabIndex = 14
        Me.btn_next.Text = "Next"
        '
        'lbl_PageInfo
        '
        Me.lbl_PageInfo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_PageInfo.AutoSize = True
        Me.lbl_PageInfo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_PageInfo.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PageInfo.ForeColor = System.Drawing.Color.Black
        Me.lbl_PageInfo.Location = New System.Drawing.Point(126, 0)
        Me.lbl_PageInfo.MaximumSize = New System.Drawing.Size(156, 57)
        Me.lbl_PageInfo.Name = "lbl_PageInfo"
        Me.lbl_PageInfo.Size = New System.Drawing.Size(117, 57)
        Me.lbl_PageInfo.TabIndex = 13
        Me.lbl_PageInfo.Text = "Page"
        Me.lbl_PageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UC_HPAL_Book_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.flow_panel_container)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_HPAL_Book_Tab"
        Me.Size = New System.Drawing.Size(1008, 688)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents flow_panel_container As FlowLayoutPanel
    Friend WithEvents btn_Editbook As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Addbooks As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbl_allbookcount As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents lbl_PageInfo As Label
    Friend WithEvents btn_previous As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_next As Guna.UI2.WinForms.Guna2Button
End Class
