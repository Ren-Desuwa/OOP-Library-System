<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_Librarian_container
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
        Me.pnl_table_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_birthday = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.lbl_contact = New System.Windows.Forms.Label()
        Me.pnl_table_container.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnl_table_container.Margin = New System.Windows.Forms.Padding(2)
        Me.pnl_table_container.Name = "pnl_table_container"
        Me.pnl_table_container.ShadowDecoration.Color = System.Drawing.Color.Silver
        Me.pnl_table_container.ShadowDecoration.Depth = 15
        Me.pnl_table_container.ShadowDecoration.Enabled = True
        Me.pnl_table_container.Size = New System.Drawing.Size(680, 69)
        Me.pnl_table_container.TabIndex = 12
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_contact, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_email, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_birthday, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(680, 69)
        Me.TableLayoutPanel1.TabIndex = 11
        '
        'lbl_name
        '
        Me.lbl_name.AutoEllipsis = True
        Me.lbl_name.AutoSize = True
        Me.lbl_name.BackColor = System.Drawing.Color.Transparent
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_name.Location = New System.Drawing.Point(2, 0)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(166, 69)
        Me.lbl_name.TabIndex = 7
        Me.lbl_name.Text = "Name:"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_birthday
        '
        Me.lbl_birthday.AutoEllipsis = True
        Me.lbl_birthday.AutoSize = True
        Me.lbl_birthday.BackColor = System.Drawing.Color.Transparent
        Me.lbl_birthday.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_birthday.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_birthday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_birthday.Location = New System.Drawing.Point(172, 0)
        Me.lbl_birthday.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_birthday.Name = "lbl_birthday"
        Me.lbl_birthday.Size = New System.Drawing.Size(166, 69)
        Me.lbl_birthday.TabIndex = 8
        Me.lbl_birthday.Text = "Birthday:"
        Me.lbl_birthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_email
        '
        Me.lbl_email.AutoEllipsis = True
        Me.lbl_email.AutoSize = True
        Me.lbl_email.BackColor = System.Drawing.Color.Transparent
        Me.lbl_email.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_email.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_email.Location = New System.Drawing.Point(342, 0)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(166, 69)
        Me.lbl_email.TabIndex = 9
        Me.lbl_email.Text = "Email:"
        Me.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_contact
        '
        Me.lbl_contact.AutoEllipsis = True
        Me.lbl_contact.AutoSize = True
        Me.lbl_contact.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contact.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_contact.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_contact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lbl_contact.Location = New System.Drawing.Point(512, 0)
        Me.lbl_contact.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_contact.Name = "lbl_contact"
        Me.lbl_contact.Size = New System.Drawing.Size(166, 69)
        Me.lbl_contact.TabIndex = 10
        Me.lbl_contact.Text = "Contact:"
        Me.lbl_contact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UC_Librarian_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.pnl_table_container)
        Me.Name = "UC_Librarian_container"
        Me.Size = New System.Drawing.Size(680, 69)
        Me.pnl_table_container.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnl_table_container As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_birthday As Label
    Friend WithEvents lbl_contact As Label
    Friend WithEvents lbl_email As Label
End Class
