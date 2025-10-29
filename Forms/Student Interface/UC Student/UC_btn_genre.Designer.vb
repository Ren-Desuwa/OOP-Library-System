<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_btn_genre
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_genre = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.SuspendLayout()
        '
        'btn_genre
        '
        Me.btn_genre.BackColor = System.Drawing.Color.Transparent
        Me.btn_genre.BorderColor = System.Drawing.Color.Gray
        Me.btn_genre.BorderRadius = 10
        Me.btn_genre.BorderThickness = 1
        Me.btn_genre.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_genre.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_genre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_genre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_genre.FillColor = System.Drawing.Color.PeachPuff
        Me.btn_genre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_genre.ForeColor = System.Drawing.Color.Black
        Me.btn_genre.Location = New System.Drawing.Point(0, 0)
        Me.btn_genre.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_genre.Name = "btn_genre"
        Me.btn_genre.Size = New System.Drawing.Size(180, 32)
        Me.btn_genre.TabIndex = 5
        Me.btn_genre.Text = "Genre1"
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        '
        'UC_btn_genre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btn_genre)
        Me.Name = "UC_btn_genre"
        Me.Size = New System.Drawing.Size(180, 32)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_genre As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
End Class
