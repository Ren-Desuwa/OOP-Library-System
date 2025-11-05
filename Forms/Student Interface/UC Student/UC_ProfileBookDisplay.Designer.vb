<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ProfileBookDisplay
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
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.picBook1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picBook2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.picBook3 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.tlpMain.SuspendLayout()
        CType(Me.picBook1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBook3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.BackColor = System.Drawing.Color.Transparent
        Me.tlpMain.ColumnCount = 2
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Controls.Add(Me.picBook3, 0, 1)
        Me.tlpMain.Controls.Add(Me.picBook1, 0, 0)
        Me.tlpMain.Controls.Add(Me.picBook2, 1, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(0, 0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 2
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tlpMain.Size = New System.Drawing.Size(345, 313)
        Me.tlpMain.TabIndex = 0
        '
        'picBook1
        '
        Me.picBook1.BackColor = System.Drawing.Color.Transparent
        Me.picBook1.BorderRadius = 10
        Me.picBook1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBook1.FillColor = System.Drawing.Color.Transparent
        Me.picBook1.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picBook1.ImageRotate = 0!
        Me.picBook1.Location = New System.Drawing.Point(3, 3)
        Me.picBook1.Name = "picBook1"
        Me.picBook1.Size = New System.Drawing.Size(166, 150)
        Me.picBook1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook1.TabIndex = 0
        Me.picBook1.TabStop = False
        '
        'picBook2
        '
        Me.picBook2.BackColor = System.Drawing.Color.Transparent
        Me.picBook2.BorderRadius = 10
        Me.picBook2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBook2.FillColor = System.Drawing.Color.Transparent
        Me.picBook2.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picBook2.ImageRotate = 0!
        Me.picBook2.Location = New System.Drawing.Point(175, 159)
        Me.picBook2.Name = "picBook2"
        Me.picBook2.Size = New System.Drawing.Size(167, 151)
        Me.picBook2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook2.TabIndex = 1
        Me.picBook2.TabStop = False
        '
        'picBook3
        '
        Me.picBook3.BackColor = System.Drawing.Color.Transparent
        Me.picBook3.BorderRadius = 10
        Me.picBook3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picBook3.FillColor = System.Drawing.Color.Transparent
        Me.picBook3.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picBook3.ImageRotate = 0!
        Me.picBook3.Location = New System.Drawing.Point(3, 159)
        Me.picBook3.Name = "picBook3"
        Me.picBook3.Size = New System.Drawing.Size(166, 151)
        Me.picBook3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBook3.TabIndex = 2
        Me.picBook3.TabStop = False
        '
        'UC_ProfileBookDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.tlpMain)
        Me.Name = "UC_ProfileBookDisplay"
        Me.Size = New System.Drawing.Size(345, 313)
        Me.tlpMain.ResumeLayout(False)
        CType(Me.picBook1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBook3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tlpMain As TableLayoutPanel
    Friend WithEvents picBook1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents picBook3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents picBook2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
