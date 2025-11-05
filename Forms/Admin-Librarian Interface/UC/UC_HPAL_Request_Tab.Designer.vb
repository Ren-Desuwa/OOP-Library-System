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
        Me.RequestsPanels = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Guna2GradientTileButton2 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2GradientTileButton1 = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.UserReqBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.BorrowReqBtn = New Guna.UI2.WinForms.Guna2GradientTileButton()
        Me.RequestsPanels.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RequestsPanels
        '
        Me.RequestsPanels.BackColor = System.Drawing.Color.Transparent
        Me.RequestsPanels.ColumnCount = 1
        Me.RequestsPanels.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RequestsPanels.Controls.Add(Me.TableLayoutPanel2, 0, 2)
        Me.RequestsPanels.Controls.Add(Me.Guna2Panel1, 0, 0)
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
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2GradientTileButton2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Guna2GradientTileButton1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 502)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(756, 57)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Guna2GradientTileButton2
        '
        Me.Guna2GradientTileButton2.CustomBorderColor = System.Drawing.Color.Maroon
        Me.Guna2GradientTileButton2.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2GradientTileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientTileButton2.FillColor = System.Drawing.Color.Tomato
        Me.Guna2GradientTileButton2.FillColor2 = System.Drawing.Color.Firebrick
        Me.Guna2GradientTileButton2.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientTileButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton2.Location = New System.Drawing.Point(381, 3)
        Me.Guna2GradientTileButton2.Name = "Guna2GradientTileButton2"
        Me.Guna2GradientTileButton2.Size = New System.Drawing.Size(372, 51)
        Me.Guna2GradientTileButton2.TabIndex = 1
        Me.Guna2GradientTileButton2.Text = "Reject"
        '
        'Guna2GradientTileButton1
        '
        Me.Guna2GradientTileButton1.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2GradientTileButton1.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.Guna2GradientTileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2GradientTileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2GradientTileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2GradientTileButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientTileButton1.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2GradientTileButton1.FillColor2 = System.Drawing.Color.Green
        Me.Guna2GradientTileButton1.Font = New System.Drawing.Font("Yu Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GradientTileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2GradientTileButton1.Location = New System.Drawing.Point(3, 3)
        Me.Guna2GradientTileButton1.Name = "Guna2GradientTileButton1"
        Me.Guna2GradientTileButton1.Size = New System.Drawing.Size(372, 51)
        Me.Guna2GradientTileButton1.TabIndex = 0
        Me.Guna2GradientTileButton1.Text = "Approve"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2Panel1.Controls.Add(Me.UserReqBtn)
        Me.Guna2Panel1.Controls.Add(Me.BorrowReqBtn)
        Me.Guna2Panel1.Location = New System.Drawing.Point(487, 0)
        Me.Guna2Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(269, 27)
        Me.Guna2Panel1.TabIndex = 1
        '
        'UserReqBtn
        '
        Me.UserReqBtn.AutoRoundedCorners = True
        Me.UserReqBtn.BorderRadius = 11
        Me.UserReqBtn.BorderThickness = 1
        Me.UserReqBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UserReqBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.UserReqBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UserReqBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UserReqBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UserReqBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UserReqBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UserReqBtn.FillColor = System.Drawing.Color.MediumTurquoise
        Me.UserReqBtn.FillColor2 = System.Drawing.Color.DarkSlateGray
        Me.UserReqBtn.Font = New System.Drawing.Font("Yu Gothic Medium", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserReqBtn.ForeColor = System.Drawing.Color.White
        Me.UserReqBtn.Location = New System.Drawing.Point(15, 1)
        Me.UserReqBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.UserReqBtn.Name = "UserReqBtn"
        Me.UserReqBtn.Size = New System.Drawing.Size(243, 25)
        Me.UserReqBtn.TabIndex = 2
        Me.UserReqBtn.Text = "User Requests"
        '
        'BorrowReqBtn
        '
        Me.BorrowReqBtn.BorderRadius = 15
        Me.BorrowReqBtn.BorderThickness = 1
        Me.BorrowReqBtn.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BorrowReqBtn.CustomBorderThickness = New System.Windows.Forms.Padding(2)
        Me.BorrowReqBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BorrowReqBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BorrowReqBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BorrowReqBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BorrowReqBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BorrowReqBtn.FillColor = System.Drawing.Color.BlueViolet
        Me.BorrowReqBtn.FillColor2 = System.Drawing.Color.Indigo
        Me.BorrowReqBtn.Font = New System.Drawing.Font("Yu Gothic Medium", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BorrowReqBtn.ForeColor = System.Drawing.Color.White
        Me.BorrowReqBtn.Location = New System.Drawing.Point(16, 1)
        Me.BorrowReqBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.BorrowReqBtn.Name = "BorrowReqBtn"
        Me.BorrowReqBtn.Size = New System.Drawing.Size(243, 25)
        Me.BorrowReqBtn.TabIndex = 1
        Me.BorrowReqBtn.Text = "Borrow Requests"
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
        Me.RequestsPanels.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RequestsPanels As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Guna2GradientTileButton1 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2GradientTileButton2 As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents BorrowReqBtn As Guna.UI2.WinForms.Guna2GradientTileButton
    Friend WithEvents UserReqBtn As Guna.UI2.WinForms.Guna2GradientTileButton
End Class
