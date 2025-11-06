<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_UserRequest_Container
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
        Me.StatusPanel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.StatusLbl = New System.Windows.Forms.Label()
        Me.DateCreated_Lbl = New System.Windows.Forms.Label()
        Me.UserName_Lbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.StatusPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Tan
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.StatusPanel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DateCreated_Lbl, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.UserName_Lbl, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(13, 12, 13, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(919, 77)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'StatusPanel
        '
        Me.StatusPanel.Controls.Add(Me.StatusLbl)
        Me.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusPanel.FillColor = System.Drawing.Color.LightSeaGreen
        Me.StatusPanel.FillColor2 = System.Drawing.Color.LightSkyBlue
        Me.StatusPanel.FillColor3 = System.Drawing.Color.WhiteSmoke
        Me.StatusPanel.FillColor4 = System.Drawing.Color.DeepSkyBlue
        Me.StatusPanel.Location = New System.Drawing.Point(862, 2)
        Me.StatusPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.StatusPanel.Name = "StatusPanel"
        Me.StatusPanel.Size = New System.Drawing.Size(55, 73)
        Me.StatusPanel.TabIndex = 5
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
        'DateCreated_Lbl
        '
        Me.DateCreated_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateCreated_Lbl.AutoSize = True
        Me.DateCreated_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateCreated_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.DateCreated_Lbl.Location = New System.Drawing.Point(436, 24)
        Me.DateCreated_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DateCreated_Lbl.Name = "DateCreated_Lbl"
        Me.DateCreated_Lbl.Size = New System.Drawing.Size(160, 29)
        Me.DateCreated_Lbl.TabIndex = 1
        Me.DateCreated_Lbl.Text = "DateCreated"
        '
        'UserName_Lbl
        '
        Me.UserName_Lbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UserName_Lbl.AutoSize = True
        Me.UserName_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName_Lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.UserName_Lbl.Location = New System.Drawing.Point(6, 24)
        Me.UserName_Lbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.UserName_Lbl.Name = "UserName_Lbl"
        Me.UserName_Lbl.Size = New System.Drawing.Size(165, 29)
        Me.UserName_Lbl.TabIndex = 0
        Me.UserName_Lbl.Text = "UserRequest"
        '
        'UC_UserRequest_Container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "UC_UserRequest_Container"
        Me.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Size = New System.Drawing.Size(927, 85)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.StatusPanel.ResumeLayout(False)
        Me.StatusPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents StatusPanel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents StatusLbl As Label
    Friend WithEvents DateCreated_Lbl As Label
    Friend WithEvents UserName_Lbl As Label
End Class
