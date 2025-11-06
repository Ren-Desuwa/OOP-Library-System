<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HPAL_Logs_Tab
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDateTime = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.genre_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.RequestsTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CustomGradientPanel3 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.RichTextBoxLogs = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.genre_panel.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Guna2CustomGradientPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'lblDateTime
        '
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDateTime.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblDateTime.Location = New System.Drawing.Point(52, 3)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(11, 32)
        Me.lblDateTime.TabIndex = 0
        Me.lblDateTime.Text = "-"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.646091!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 96.84499!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.373626!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2CustomGradientPanel3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.312343!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.15366!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.282116!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(723, 387)
        Me.TableLayoutPanel1.TabIndex = 17
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.060519!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.93948!))
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(14, 373)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(695, 11)
        Me.TableLayoutPanel2.TabIndex = 17
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.28571!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.71429!))
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2CustomGradientPanel2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Guna2CustomGradientPanel1, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(14, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(695, 26)
        Me.TableLayoutPanel3.TabIndex = 19
        '
        'genre_panel
        '
        Me.genre_panel.Controls.Add(Me.TableLayoutPanel1)
        Me.genre_panel.CustomizableEdges.BottomRight = False
        Me.genre_panel.CustomizableEdges.TopRight = False
        Me.genre_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.genre_panel.FillColor = System.Drawing.Color.Transparent
        Me.genre_panel.FillColor2 = System.Drawing.Color.Transparent
        Me.genre_panel.FillColor3 = System.Drawing.Color.Transparent
        Me.genre_panel.FillColor4 = System.Drawing.Color.Transparent
        Me.genre_panel.Location = New System.Drawing.Point(3, 5)
        Me.genre_panel.Margin = New System.Windows.Forms.Padding(2)
        Me.genre_panel.Name = "genre_panel"
        Me.genre_panel.Size = New System.Drawing.Size(723, 387)
        Me.genre_panel.TabIndex = 18
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.RequestsTitle)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Peru
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.BurlyWood
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(236, 26)
        Me.Guna2CustomGradientPanel1.TabIndex = 17
        '
        'RequestsTitle
        '
        Me.RequestsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RequestsTitle.BackColor = System.Drawing.Color.Transparent
        Me.RequestsTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestsTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RequestsTitle.Location = New System.Drawing.Point(50, 1)
        Me.RequestsTitle.Name = "RequestsTitle"
        Me.RequestsTitle.Size = New System.Drawing.Size(122, 27)
        Me.RequestsTitle.TabIndex = 2
        Me.RequestsTitle.Text = "Admin Logs"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.GhostWhite
        Me.Label2.Location = New System.Drawing.Point(5, 5)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(226, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "-"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel2.BorderRadius = 10
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel2.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Peru
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.BurlyWood
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(459, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Padding = New System.Windows.Forms.Padding(5)
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(236, 26)
        Me.Guna2CustomGradientPanel2.TabIndex = 18
        '
        'Guna2CustomGradientPanel3
        '
        Me.Guna2CustomGradientPanel3.BackColor = System.Drawing.Color.Tomato
        Me.Guna2CustomGradientPanel3.Controls.Add(Me.RichTextBoxLogs)
        Me.Guna2CustomGradientPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel3.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel3.Location = New System.Drawing.Point(11, 32)
        Me.Guna2CustomGradientPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2CustomGradientPanel3.Name = "Guna2CustomGradientPanel3"
        Me.Guna2CustomGradientPanel3.Padding = New System.Windows.Forms.Padding(3)
        Me.Guna2CustomGradientPanel3.Size = New System.Drawing.Size(701, 338)
        Me.Guna2CustomGradientPanel3.TabIndex = 20
        '
        'RichTextBoxLogs
        '
        Me.RichTextBoxLogs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBoxLogs.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxLogs.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBoxLogs.Name = "RichTextBoxLogs"
        Me.RichTextBoxLogs.Size = New System.Drawing.Size(695, 332)
        Me.RichTextBoxLogs.TabIndex = 19
        Me.RichTextBoxLogs.Text = ""
        '
        'UC_HPAL_Logs_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = Global.OOP_Library_System.My.Resources.Resources.BooksDesignBG3
        Me.Controls.Add(Me.genre_panel)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_HPAL_Logs_Tab"
        Me.Padding = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Size = New System.Drawing.Size(729, 397)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.genre_panel.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDateTime As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents genre_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents RequestsTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CustomGradientPanel3 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents RichTextBoxLogs As RichTextBox
End Class
