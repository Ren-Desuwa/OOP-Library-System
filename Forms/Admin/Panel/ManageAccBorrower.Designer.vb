<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccBorrower
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.lblUser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.borrowedGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.lblCreditScore = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnPenalties = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotalBorrow = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblOverdue = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.btnRenew = New Guna.UI2.WinForms.Guna2Button()
        Me.btnLost = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.borrowedGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(600, 380)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 10
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76235!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.76235!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.5347!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.90098!))
        Me.TableLayoutPanel1.Controls.Add(Me.lblUser, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.borrowedGrid, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2ControlBox1, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCreditScore, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnPenalties, 7, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblTotalBorrow, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblOverdue, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btnReturn, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRenew, 4, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLost, 7, 7)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 9
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76882!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.879812!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.64544!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.349765!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.649035!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.649035!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.769623!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.75882!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.529647!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(600, 380)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.TableLayoutPanel1
        Me.Guna2DragControl1.TransparentWhileDrag = False
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblUser, 2)
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.Black
        Me.lblUser.Location = New System.Drawing.Point(32, 22)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(34, 19)
        Me.lblUser.TabIndex = 0
        Me.lblUser.Text = "User:"
        '
        'borrowedGrid
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.borrowedGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.borrowedGrid.BackgroundColor = System.Drawing.Color.AntiqueWhite
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.borrowedGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.borrowedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableLayoutPanel1.SetColumnSpan(Me.borrowedGrid, 8)
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.borrowedGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.borrowedGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.borrowedGrid.GridColor = System.Drawing.Color.SaddleBrown
        Me.borrowedGrid.Location = New System.Drawing.Point(32, 54)
        Me.borrowedGrid.Name = "borrowedGrid"
        Me.borrowedGrid.RowHeadersVisible = False
        Me.borrowedGrid.Size = New System.Drawing.Size(532, 167)
        Me.borrowedGrid.TabIndex = 1
        Me.borrowedGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.borrowedGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.borrowedGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.borrowedGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.borrowedGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.borrowedGrid.ThemeStyle.BackColor = System.Drawing.Color.AntiqueWhite
        Me.borrowedGrid.ThemeStyle.GridColor = System.Drawing.Color.SaddleBrown
        Me.borrowedGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.borrowedGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.borrowedGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowedGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.borrowedGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.borrowedGrid.ThemeStyle.HeaderStyle.Height = 4
        Me.borrowedGrid.ThemeStyle.ReadOnly = False
        Me.borrowedGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.borrowedGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.borrowedGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowedGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.borrowedGrid.ThemeStyle.RowsStyle.Height = 22
        Me.borrowedGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.borrowedGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(570, 3)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(27, 38)
        Me.Guna2ControlBox1.TabIndex = 2
        '
        'lblCreditScore
        '
        Me.lblCreditScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblCreditScore.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblCreditScore, 2)
        Me.lblCreditScore.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditScore.Location = New System.Drawing.Point(231, 24)
        Me.lblCreditScore.Name = "lblCreditScore"
        Me.lblCreditScore.Size = New System.Drawing.Size(75, 17)
        Me.lblCreditScore.TabIndex = 3
        Me.lblCreditScore.Text = "Credit Score:"
        '
        'btnPenalties
        '
        Me.btnPenalties.BorderColor = System.Drawing.Color.Sienna
        Me.btnPenalties.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnPenalties, 2)
        Me.btnPenalties.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPenalties.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPenalties.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPenalties.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPenalties.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnPenalties.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnPenalties.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPenalties.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnPenalties.Location = New System.Drawing.Point(400, 235)
        Me.btnPenalties.Name = "btnPenalties"
        Me.btnPenalties.Size = New System.Drawing.Size(164, 30)
        Me.btnPenalties.TabIndex = 4
        Me.btnPenalties.Text = "View Penalties"
        '
        'lblTotalBorrow
        '
        Me.lblTotalBorrow.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalBorrow.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblTotalBorrow, 2)
        Me.lblTotalBorrow.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBorrow.Location = New System.Drawing.Point(32, 248)
        Me.lblTotalBorrow.Name = "lblTotalBorrow"
        Me.lblTotalBorrow.Size = New System.Drawing.Size(93, 17)
        Me.lblTotalBorrow.TabIndex = 5
        Me.lblTotalBorrow.Text = "Total Borrowed:"
        '
        'lblOverdue
        '
        Me.lblOverdue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOverdue.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.SetColumnSpan(Me.lblOverdue, 2)
        Me.lblOverdue.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverdue.Location = New System.Drawing.Point(32, 284)
        Me.lblOverdue.Name = "lblOverdue"
        Me.lblOverdue.Size = New System.Drawing.Size(55, 17)
        Me.lblOverdue.TabIndex = 6
        Me.lblOverdue.Text = "Overdue:"
        '
        'btnReturn
        '
        Me.btnReturn.BorderColor = System.Drawing.Color.Sienna
        Me.btnReturn.BorderRadius = 5
        Me.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReturn.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnReturn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnReturn.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnReturn.Location = New System.Drawing.Point(61, 321)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(135, 38)
        Me.btnReturn.TabIndex = 7
        Me.btnReturn.Text = "Return"
        '
        'btnRenew
        '
        Me.btnRenew.BorderColor = System.Drawing.Color.Sienna
        Me.btnRenew.BorderRadius = 5
        Me.TableLayoutPanel1.SetColumnSpan(Me.btnRenew, 2)
        Me.btnRenew.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRenew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRenew.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRenew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRenew.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnRenew.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnRenew.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnRenew.Location = New System.Drawing.Point(231, 321)
        Me.btnRenew.Name = "btnRenew"
        Me.btnRenew.Size = New System.Drawing.Size(134, 38)
        Me.btnRenew.TabIndex = 8
        Me.btnRenew.Text = "Renew"
        '
        'btnLost
        '
        Me.btnLost.BorderColor = System.Drawing.Color.Sienna
        Me.btnLost.BorderRadius = 5
        Me.btnLost.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnLost.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnLost.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnLost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnLost.FillColor = System.Drawing.Color.AntiqueWhite
        Me.btnLost.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLost.ForeColor = System.Drawing.Color.SaddleBrown
        Me.btnLost.Location = New System.Drawing.Point(400, 321)
        Me.btnLost.Name = "btnLost"
        Me.btnLost.Size = New System.Drawing.Size(135, 38)
        Me.btnLost.TabIndex = 9
        Me.btnLost.Text = "Mark Lost"
        '
        'ManageAccBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 380)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAccBorrower"
        Me.Text = "ManageAccBorrower"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.borrowedGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents lblUser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents borrowedGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents lblCreditScore As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnPenalties As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblTotalBorrow As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblOverdue As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents btnReturn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnRenew As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnLost As Guna.UI2.WinForms.Guna2Button
End Class
