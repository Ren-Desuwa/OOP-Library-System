<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_HPAL_Request_Tab
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
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.RejectBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.ApproveBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.RequestsPanels = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.BorrowReqBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.UserReqBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.RequestsTitle = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.RequestsPanels.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.RejectBtn, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ApproveBtn, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 502)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(756, 57)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'RejectBtn
        '
        Me.RejectBtn.CustomBorderColor = System.Drawing.Color.Maroon
        Me.RejectBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.RejectBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RejectBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RejectBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RejectBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RejectBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RejectBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RejectBtn.FillColor = System.Drawing.Color.Tomato
        Me.RejectBtn.FillColor2 = System.Drawing.Color.Firebrick
        Me.RejectBtn.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RejectBtn.ForeColor = System.Drawing.Color.White
        Me.RejectBtn.Location = New System.Drawing.Point(381, 3)
        Me.RejectBtn.Name = "RejectBtn"
        Me.RejectBtn.Size = New System.Drawing.Size(372, 51)
        Me.RejectBtn.TabIndex = 1
        Me.RejectBtn.Text = "Reject"
        '
        'ApproveBtn
        '
        Me.ApproveBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ApproveBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.ApproveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ApproveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ApproveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ApproveBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ApproveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ApproveBtn.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ApproveBtn.FillColor = System.Drawing.Color.LimeGreen
        Me.ApproveBtn.FillColor2 = System.Drawing.Color.Green
        Me.ApproveBtn.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApproveBtn.ForeColor = System.Drawing.Color.White
        Me.ApproveBtn.Location = New System.Drawing.Point(3, 3)
        Me.ApproveBtn.Name = "ApproveBtn"
        Me.ApproveBtn.Size = New System.Drawing.Size(372, 51)
        Me.ApproveBtn.TabIndex = 0
        Me.ApproveBtn.Text = "Approve"
        '
        'RequestsPanels
        '
        Me.RequestsPanels.BackColor = System.Drawing.Color.Transparent
        Me.RequestsPanels.ColumnCount = 1
        Me.RequestsPanels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RequestsPanels.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.RequestsPanels.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.RequestsPanels.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RequestsPanels.Location = New System.Drawing.Point(0, 0)
        Me.RequestsPanels.Margin = New System.Windows.Forms.Padding(0)
        Me.RequestsPanels.Name = "RequestsPanels"
        Me.RequestsPanels.RowCount = 3
        Me.RequestsPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.RequestsPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.0!))
        Me.RequestsPanels.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.RequestsPanels.Size = New System.Drawing.Size(756, 559)
        Me.RequestsPanels.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Guna2CustomGradientPanel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(756, 27)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.BorrowReqBtn)
        Me.Guna2Panel1.Controls.Add(Me.UserReqBtn)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(378, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(378, 27)
        Me.Guna2Panel1.TabIndex = 4
        '
        'BorrowReqBtn
        '
        Me.BorrowReqBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BorrowReqBtn.BackColor = System.Drawing.Color.Tan
        Me.BorrowReqBtn.BorderRadius = 15
        Me.BorrowReqBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BorrowReqBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.BorrowReqBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BorrowReqBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BorrowReqBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BorrowReqBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BorrowReqBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BorrowReqBtn.FillColor = System.Drawing.Color.LimeGreen
        Me.BorrowReqBtn.FillColor2 = System.Drawing.Color.Green
        Me.BorrowReqBtn.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowReqBtn.ForeColor = System.Drawing.Color.White
        Me.BorrowReqBtn.Location = New System.Drawing.Point(157, 1)
        Me.BorrowReqBtn.Name = "BorrowReqBtn"
        Me.BorrowReqBtn.Size = New System.Drawing.Size(222, 26)
        Me.BorrowReqBtn.TabIndex = 3
        Me.BorrowReqBtn.Text = "Go To Borrow Requests"
        '
        'UserReqBtn
        '
        Me.UserReqBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UserReqBtn.BackColor = System.Drawing.Color.Tan
        Me.UserReqBtn.BorderRadius = 15
        Me.UserReqBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UserReqBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.UserReqBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UserReqBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UserReqBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UserReqBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UserReqBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UserReqBtn.FillColor = System.Drawing.Color.LimeGreen
        Me.UserReqBtn.FillColor2 = System.Drawing.Color.Green
        Me.UserReqBtn.Font = New System.Drawing.Font("Yu Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserReqBtn.ForeColor = System.Drawing.Color.White
        Me.UserReqBtn.Location = New System.Drawing.Point(157, 1)
        Me.UserReqBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.UserReqBtn.Name = "UserReqBtn"
        Me.UserReqBtn.Size = New System.Drawing.Size(222, 26)
        Me.UserReqBtn.TabIndex = 2
        Me.UserReqBtn.Text = "Go to User Requests"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel1.BorderRadius = 10
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.RequestsTitle)
        Me.Guna2CustomGradientPanel1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Guna2CustomGradientPanel1.CustomBorderThickness = New System.Windows.Forms.Padding(3)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Peru
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Tan
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.BurlyWood
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(378, 27)
        Me.Guna2CustomGradientPanel1.TabIndex = 5
        '
        'RequestsTitle
        '
        Me.RequestsTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.RequestsTitle.BackColor = System.Drawing.Color.Transparent
        Me.RequestsTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RequestsTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RequestsTitle.Location = New System.Drawing.Point(27, -1)
        Me.RequestsTitle.Name = "RequestsTitle"
        Me.RequestsTitle.Size = New System.Drawing.Size(167, 27)
        Me.RequestsTitle.TabIndex = 2
        Me.RequestsTitle.Text = "Borrow Requests"
        '
        'UC_HPAL_Request_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.BackgroundImage = Global.OOP_Library_System.My.Resources.Resources.BooksDesignBG3
        Me.Controls.Add(Me.RequestsPanels)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "UC_HPAL_Request_Tab"
        Me.Size = New System.Drawing.Size(756, 559)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.RequestsPanels.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents RejectBtn As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents ApproveBtn As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents RequestsPanels As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UserReqBtn As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents BorrowReqBtn As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents RequestsTitle As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
End Class
