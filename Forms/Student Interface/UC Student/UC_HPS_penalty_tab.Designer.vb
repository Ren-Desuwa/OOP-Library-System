<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HPS_penalty_tab
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.gbSummary = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblScoreTitle = New System.Windows.Forms.Label()
        Me.lblScoreValue = New System.Windows.Forms.Label()
        Me.pbScore = New Guna.UI2.WinForms.Guna2ProgressBar()
        Me.gbActions = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.lblActionSummary = New System.Windows.Forms.Label()
        Me.rtbActions = New System.Windows.Forms.RichTextBox()
        Me.gbHistory = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.dgvPenalties = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.gbSummary.SuspendLayout()
        Me.gbActions.SuspendLayout()
        Me.gbHistory.SuspendLayout()
        CType(Me.dgvPenalties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbSummary
        '
        Me.gbSummary.Controls.Add(Me.pbScore)
        Me.gbSummary.Controls.Add(Me.lblScoreValue)
        Me.gbSummary.Controls.Add(Me.lblScoreTitle)
        Me.gbSummary.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gbSummary.Location = New System.Drawing.Point(10, 10)
        Me.gbSummary.Name = "gbSummary"
        Me.gbSummary.Size = New System.Drawing.Size(444, 150)
        Me.gbSummary.TabIndex = 0
        Me.gbSummary.Text = "Credit Score Summary"
        '
        'lblScoreTitle
        '
        Me.lblScoreTitle.AutoSize = True
        Me.lblScoreTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreTitle.Location = New System.Drawing.Point(3, 40)
        Me.lblScoreTitle.Name = "lblScoreTitle"
        Me.lblScoreTitle.Size = New System.Drawing.Size(180, 22)
        Me.lblScoreTitle.TabIndex = 1
        Me.lblScoreTitle.Text = "Current Credit Score:"
        '
        'lblScoreValue
        '
        Me.lblScoreValue.AutoSize = True
        Me.lblScoreValue.BackColor = System.Drawing.Color.Transparent
        Me.lblScoreValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScoreValue.Location = New System.Drawing.Point(189, 40)
        Me.lblScoreValue.Name = "lblScoreValue"
        Me.lblScoreValue.Size = New System.Drawing.Size(40, 22)
        Me.lblScoreValue.TabIndex = 2
        Me.lblScoreValue.Text = "100"
        '
        'pbScore
        '
        Me.pbScore.Location = New System.Drawing.Point(7, 65)
        Me.pbScore.Name = "pbScore"
        Me.pbScore.Size = New System.Drawing.Size(414, 25)
        Me.pbScore.TabIndex = 3
        Me.pbScore.Text = "Guna2ProgressBar1"
        Me.pbScore.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'gbActions
        '
        Me.gbActions.Controls.Add(Me.rtbActions)
        Me.gbActions.Controls.Add(Me.lblActionSummary)
        Me.gbActions.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbActions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gbActions.Location = New System.Drawing.Point(464, 10)
        Me.gbActions.Name = "gbActions"
        Me.gbActions.Size = New System.Drawing.Size(444, 150)
        Me.gbActions.TabIndex = 1
        Me.gbActions.Text = "How to Improve Score"
        '
        'lblActionSummary
        '
        Me.lblActionSummary.AutoSize = True
        Me.lblActionSummary.BackColor = System.Drawing.Color.Transparent
        Me.lblActionSummary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblActionSummary.Location = New System.Drawing.Point(3, 44)
        Me.lblActionSummary.Name = "lblActionSummary"
        Me.lblActionSummary.Size = New System.Drawing.Size(314, 22)
        Me.lblActionSummary.TabIndex = 2
        Me.lblActionSummary.Text = "Total Fines: $0.00. Overdue Books: 0."
        '
        'rtbActions
        '
        Me.rtbActions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbActions.Location = New System.Drawing.Point(16, 67)
        Me.rtbActions.Name = "rtbActions"
        Me.rtbActions.ReadOnly = True
        Me.rtbActions.Size = New System.Drawing.Size(414, 80)
        Me.rtbActions.TabIndex = 2
        Me.rtbActions.Text = ""
        '
        'gbHistory
        '
        Me.gbHistory.Controls.Add(Me.dgvPenalties)
        Me.gbHistory.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.gbHistory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.gbHistory.Location = New System.Drawing.Point(10, 166)
        Me.gbHistory.Name = "gbHistory"
        Me.gbHistory.Size = New System.Drawing.Size(898, 309)
        Me.gbHistory.TabIndex = 2
        Me.gbHistory.Text = "Penalty History "
        '
        'dgvPenalties
        '
        Me.dgvPenalties.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgvPenalties.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPenalties.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPenalties.BackgroundColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvPenalties.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvPenalties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPenalties.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvPenalties.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPenalties.Location = New System.Drawing.Point(20, 48)
        Me.dgvPenalties.Name = "dgvPenalties"
        Me.dgvPenalties.ReadOnly = True
        Me.dgvPenalties.RowHeadersVisible = False
        Me.dgvPenalties.RowHeadersWidth = 51
        Me.dgvPenalties.RowTemplate.Height = 24
        Me.dgvPenalties.Size = New System.Drawing.Size(857, 249)
        Me.dgvPenalties.TabIndex = 0
        Me.dgvPenalties.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPenalties.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgvPenalties.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgvPenalties.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgvPenalties.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgvPenalties.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke
        Me.dgvPenalties.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPenalties.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPenalties.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvPenalties.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvPenalties.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgvPenalties.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenalties.ThemeStyle.HeaderStyle.Height = 4
        Me.dgvPenalties.ThemeStyle.ReadOnly = True
        Me.dgvPenalties.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgvPenalties.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgvPenalties.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dgvPenalties.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.dgvPenalties.ThemeStyle.RowsStyle.Height = 24
        Me.dgvPenalties.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgvPenalties.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'UC_HPS_penalty_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.Controls.Add(Me.gbHistory)
        Me.Controls.Add(Me.gbActions)
        Me.Controls.Add(Me.gbSummary)
        Me.Name = "UC_HPS_penalty_tab"
        Me.Size = New System.Drawing.Size(918, 489)
        Me.gbSummary.ResumeLayout(False)
        Me.gbSummary.PerformLayout()
        Me.gbActions.ResumeLayout(False)
        Me.gbActions.PerformLayout()
        Me.gbHistory.ResumeLayout(False)
        CType(Me.dgvPenalties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbSummary As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents lblScoreTitle As Label
    Friend WithEvents lblScoreValue As Label
    Friend WithEvents pbScore As Guna.UI2.WinForms.Guna2ProgressBar
    Friend WithEvents gbActions As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents rtbActions As RichTextBox
    Friend WithEvents lblActionSummary As Label
    Friend WithEvents gbHistory As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents dgvPenalties As Guna.UI2.WinForms.Guna2DataGridView
End Class
