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
        Me.lbl_justsoyouknow = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_justsoyouknow
        '
        Me.lbl_justsoyouknow.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_justsoyouknow.AutoSize = True
        Me.lbl_justsoyouknow.BackColor = System.Drawing.Color.Transparent
        Me.lbl_justsoyouknow.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_justsoyouknow.ForeColor = System.Drawing.Color.Black
        Me.lbl_justsoyouknow.Location = New System.Drawing.Point(228, 228)
        Me.lbl_justsoyouknow.Name = "lbl_justsoyouknow"
        Me.lbl_justsoyouknow.Size = New System.Drawing.Size(470, 32)
        Me.lbl_justsoyouknow.TabIndex = 15
        Me.lbl_justsoyouknow.Text = "This is where Penalty Tab should be"
        Me.lbl_justsoyouknow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UC_HPS_penalty_tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_justsoyouknow)
        Me.Name = "UC_HPS_penalty_tab"
        Me.Size = New System.Drawing.Size(918, 489)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_justsoyouknow As Label
End Class
