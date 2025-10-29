<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookCart
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
        Me.BookTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BookCheckBox = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.BookImage = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BookImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BookTitle, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.78481!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.21519!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(180, 250)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'BookTitle
        '
        Me.BookTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BookTitle.AutoSize = True
        Me.BookTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BookTitle.Location = New System.Drawing.Point(28, 206)
        Me.BookTitle.Name = "BookTitle"
        Me.BookTitle.Size = New System.Drawing.Size(123, 29)
        Me.BookTitle.TabIndex = 0
        Me.BookTitle.Text = "Book Title"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BookCheckBox)
        Me.Panel1.Controls.Add(Me.BookImage)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(174, 200)
        Me.Panel1.TabIndex = 1
        '
        'BookCheckBox
        '
        Me.BookCheckBox.AutoSize = True
        Me.BookCheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookCheckBox.CheckedState.BorderRadius = 0
        Me.BookCheckBox.CheckedState.BorderThickness = 0
        Me.BookCheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BookCheckBox.Location = New System.Drawing.Point(156, 3)
        Me.BookCheckBox.Name = "BookCheckBox"
        Me.BookCheckBox.Size = New System.Drawing.Size(15, 14)
        Me.BookCheckBox.TabIndex = 1
        Me.BookCheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.BookCheckBox.UncheckedState.BorderRadius = 0
        Me.BookCheckBox.UncheckedState.BorderThickness = 0
        Me.BookCheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        '
        'BookImage
        '
        Me.BookImage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BookImage.Image = Global.OOP_Library_System.My.Resources.Resources.luffy
        Me.BookImage.Location = New System.Drawing.Point(0, 0)
        Me.BookImage.Name = "BookImage"
        Me.BookImage.Size = New System.Drawing.Size(174, 200)
        Me.BookImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BookImage.TabIndex = 0
        Me.BookImage.TabStop = False
        '
        'BookCart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "BookCart"
        Me.Size = New System.Drawing.Size(180, 250)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BookImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BookTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BookCheckBox As Guna.UI2.WinForms.Guna2CheckBox
    Friend WithEvents BookImage As PictureBox
End Class
