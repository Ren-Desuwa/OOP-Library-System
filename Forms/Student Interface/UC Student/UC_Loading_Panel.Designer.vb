<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class UC_Loading_Panel
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
        Me.lbl_LoadingText = New System.Windows.Forms.Label()
        Me.tmr_Animate = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.pic_LoadingGif = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.pic_LoadingGif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_LoadingText
        '
        Me.lbl_LoadingText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_LoadingText.AutoSize = True
        Me.lbl_LoadingText.BackColor = System.Drawing.Color.Transparent
        Me.lbl_LoadingText.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_LoadingText.ForeColor = System.Drawing.Color.Black
        Me.lbl_LoadingText.Location = New System.Drawing.Point(3, 301)
        Me.lbl_LoadingText.Name = "lbl_LoadingText"
        Me.lbl_LoadingText.Size = New System.Drawing.Size(912, 32)
        Me.lbl_LoadingText.TabIndex = 16
        Me.lbl_LoadingText.Text = "Loading"
        Me.lbl_LoadingText.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tmr_Animate
        '
        Me.tmr_Animate.Interval = 150
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_LoadingText, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.pic_LoadingGif, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 602)
        Me.TableLayoutPanel1.TabIndex = 18
        '
        'pic_LoadingGif
        '
        Me.pic_LoadingGif.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pic_LoadingGif.BackColor = System.Drawing.Color.Transparent
        Me.pic_LoadingGif.FillColor = System.Drawing.Color.Transparent
        Me.pic_LoadingGif.Image = Global.OOP_Library_System.My.Resources.Resources.Loading_Circle1
        Me.pic_LoadingGif.ImageRotate = 0!
        Me.pic_LoadingGif.Location = New System.Drawing.Point(419, 218)
        Me.pic_LoadingGif.MaximumSize = New System.Drawing.Size(80, 80)
        Me.pic_LoadingGif.Name = "pic_LoadingGif"
        Me.pic_LoadingGif.Size = New System.Drawing.Size(80, 80)
        Me.pic_LoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_LoadingGif.TabIndex = 17
        Me.pic_LoadingGif.TabStop = False
        Me.pic_LoadingGif.UseTransparentBackground = True
        '
        'UC_Loading_Panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "UC_Loading_Panel"
        Me.Size = New System.Drawing.Size(918, 602)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.pic_LoadingGif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_LoadingText As Label
    Friend WithEvents tmr_Animate As Timer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents pic_LoadingGif As Guna.UI2.WinForms.Guna2PictureBox
End Class
