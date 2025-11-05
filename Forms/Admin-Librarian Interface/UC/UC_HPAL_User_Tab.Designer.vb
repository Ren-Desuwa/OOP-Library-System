<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HPAL_User_Tab
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_number = New System.Windows.Forms.Label()
        Me.btn_add = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_remove = New Guna.UI2.WinForms.Guna2Button()
        Me.flow_panel_container = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_number, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_remove, 3, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 369)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(522, 52)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lbl_number
        '
        Me.lbl_number.AutoSize = True
        Me.lbl_number.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_number.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_number.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_number.Location = New System.Drawing.Point(3, 0)
        Me.lbl_number.Name = "lbl_number"
        Me.lbl_number.Size = New System.Drawing.Size(255, 52)
        Me.lbl_number.TabIndex = 0
        Me.lbl_number.Text = "No. of Users:"
        Me.lbl_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_add
        '
        Me.btn_add.BorderRadius = 10
        Me.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_add.FillColor = System.Drawing.Color.White
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_add.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_add.Location = New System.Drawing.Point(264, 3)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(98, 45)
        Me.btn_add.TabIndex = 1
        Me.btn_add.Text = "Add User"
        '
        'btn_remove
        '
        Me.btn_remove.BorderRadius = 10
        Me.btn_remove.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_remove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_remove.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_remove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_remove.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_remove.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_remove.ForeColor = System.Drawing.Color.White
        Me.btn_remove.Location = New System.Drawing.Point(394, 3)
        Me.btn_remove.Name = "btn_remove"
        Me.btn_remove.Size = New System.Drawing.Size(98, 45)
        Me.btn_remove.TabIndex = 2
        Me.btn_remove.Text = "Remove"
        '
        'flow_panel_container
        '
        Me.flow_panel_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_panel_container.AutoScroll = True
        Me.flow_panel_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_panel_container.Location = New System.Drawing.Point(0, 0)
        Me.flow_panel_container.Margin = New System.Windows.Forms.Padding(2)
        Me.flow_panel_container.Name = "flow_panel_container"
        Me.flow_panel_container.Size = New System.Drawing.Size(522, 364)
        Me.flow_panel_container.TabIndex = 3
        Me.flow_panel_container.WrapContents = False
        '
        'UC_HPAL_User_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.flow_panel_container)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "UC_HPAL_User_Tab"
        Me.Size = New System.Drawing.Size(756, 559)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_number As Label
    Friend WithEvents btn_add As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_remove As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flow_panel_container As FlowLayoutPanel
End Class
