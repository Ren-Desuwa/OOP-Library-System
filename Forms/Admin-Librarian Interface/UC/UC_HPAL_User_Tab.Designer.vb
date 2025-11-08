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
        Me.lbl_allusercount = New System.Windows.Forms.Label()
        Me.btn_AddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_DeleteUser = New Guna.UI2.WinForms.Guna2Button()
        Me.flow_panel_users = New System.Windows.Forms.FlowLayoutPanel()
        Me.UC_Librarian_container1 = New OOP_Library_System.UC_Librarian_container()
        Me.UC_Librarian_container2 = New OOP_Library_System.UC_Librarian_container()
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
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_allusercount, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_AddUser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_DeleteUser, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UC_Librarian_container1, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UC_Librarian_container2, 4, 0)
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 624)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1008, 64)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'lbl_allusercount
        '
        Me.lbl_allusercount.AutoSize = True
        Me.lbl_allusercount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_allusercount.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lbl_allusercount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_allusercount.Location = New System.Drawing.Point(4, 0)
        Me.lbl_allusercount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_allusercount.Name = "lbl_allusercount"
        Me.lbl_allusercount.Size = New System.Drawing.Size(496, 64)
        Me.lbl_allusercount.TabIndex = 0
        Me.lbl_allusercount.Text = "No. of Users:"
        Me.lbl_allusercount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_AddUser
        '
        Me.btn_AddUser.BorderRadius = 10
        Me.btn_AddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_AddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_AddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_AddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_AddUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_AddUser.FillColor = System.Drawing.Color.White
        Me.btn_AddUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_AddUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_AddUser.Location = New System.Drawing.Point(508, 4)
        Me.btn_AddUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_AddUser.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_AddUser.Name = "btn_AddUser"
        Me.btn_AddUser.Size = New System.Drawing.Size(184, 52)
        Me.btn_AddUser.TabIndex = 1
        Me.btn_AddUser.Text = "Add User"
        Me.btn_AddUser.Visible = False
        '
        'btn_DeleteUser
        '
        Me.btn_DeleteUser.BorderRadius = 10
        Me.btn_DeleteUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_DeleteUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_DeleteUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_DeleteUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_DeleteUser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_DeleteUser.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_DeleteUser.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_DeleteUser.ForeColor = System.Drawing.Color.White
        Me.btn_DeleteUser.Location = New System.Drawing.Point(759, 4)
        Me.btn_DeleteUser.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_DeleteUser.MaximumSize = New System.Drawing.Size(184, 52)
        Me.btn_DeleteUser.Name = "btn_DeleteUser"
        Me.btn_DeleteUser.Size = New System.Drawing.Size(184, 52)
        Me.btn_DeleteUser.TabIndex = 2
        Me.btn_DeleteUser.Text = "Remove"
        '
        'flow_panel_users
        '
        Me.flow_panel_users.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flow_panel_users.AutoScroll = True
        Me.flow_panel_users.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flow_panel_users.Location = New System.Drawing.Point(0, 0)
        Me.flow_panel_users.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.flow_panel_users.Name = "flow_panel_users"
        Me.flow_panel_users.Size = New System.Drawing.Size(1008, 616)
        Me.flow_panel_users.TabIndex = 3
        Me.flow_panel_users.WrapContents = False
        '
        'UC_Librarian_container1
        '
        Me.UC_Librarian_container1.BackColor = System.Drawing.Color.Transparent
        Me.UC_Librarian_container1.IsSelected = False
        Me.UC_Librarian_container1.Location = New System.Drawing.Point(711, 6)
        Me.UC_Librarian_container1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UC_Librarian_container1.Name = "UC_Librarian_container1"
        Me.UC_Librarian_container1.Size = New System.Drawing.Size(38, 52)
        Me.UC_Librarian_container1.TabIndex = 3
        '
        'UC_Librarian_container2
        '
        Me.UC_Librarian_container2.BackColor = System.Drawing.Color.Transparent
        Me.UC_Librarian_container2.IsSelected = False
        Me.UC_Librarian_container2.Location = New System.Drawing.Point(962, 6)
        Me.UC_Librarian_container2.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UC_Librarian_container2.Name = "UC_Librarian_container2"
        Me.UC_Librarian_container2.Size = New System.Drawing.Size(40, 52)
        Me.UC_Librarian_container2.TabIndex = 4
        '
        'UC_HPAL_User_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.flow_panel_users)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "UC_HPAL_User_Tab"
        Me.Size = New System.Drawing.Size(1008, 688)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_allusercount As Label
    Friend WithEvents btn_AddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_DeleteUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents flow_panel_users As FlowLayoutPanel
    Friend WithEvents UC_Librarian_container1 As UC_Librarian_container
    Friend WithEvents UC_Librarian_container2 As UC_Librarian_container
End Class
