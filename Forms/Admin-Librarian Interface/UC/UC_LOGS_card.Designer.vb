<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_LOGS_card
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
        Me.Title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DatePosted = New System.Windows.Forms.Label()
        Me.Severity = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FloralWhite
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(124, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 6
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(717, 142)
        Me.Guna2Panel1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.958678!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.20661!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.24242!))
        Me.TableLayoutPanel1.Controls.Add(Me.Title, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DatePosted, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Severity, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.42105!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.22807!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.91228!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(717, 142)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Title.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(38, 26)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(174, 94)
        Me.Title.TabIndex = 3
        Me.Title.Text = "Date"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Title.UseCompatibleTextRendering = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(320, 94)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Action"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseCompatibleTextRendering = True
        '
        'DatePosted
        '
        Me.DatePosted.AutoSize = True
        Me.DatePosted.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DatePosted.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePosted.Location = New System.Drawing.Point(544, 26)
        Me.DatePosted.Name = "DatePosted"
        Me.DatePosted.Size = New System.Drawing.Size(170, 94)
        Me.DatePosted.TabIndex = 5
        Me.DatePosted.Text = "Date"
        Me.DatePosted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.DatePosted.UseCompatibleTextRendering = True
        '
        'Severity
        '
        Me.Severity.AutoSize = True
        Me.Severity.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Severity.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Severity.Location = New System.Drawing.Point(38, 0)
        Me.Severity.Name = "Severity"
        Me.Severity.Size = New System.Drawing.Size(174, 26)
        Me.Severity.TabIndex = 6
        Me.Severity.Text = "Severity"
        Me.Severity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UC_LOGS_card
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Margin = New System.Windows.Forms.Padding(30)
        Me.Name = "UC_LOGS_card"
        Me.Size = New System.Drawing.Size(717, 142)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DatePosted As Label
    Friend WithEvents Severity As Label
End Class
