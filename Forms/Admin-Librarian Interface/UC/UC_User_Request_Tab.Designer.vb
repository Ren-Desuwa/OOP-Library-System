<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UC_User_Request_Tab
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
        Me.Borrow_Container_FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'Borrow_Container_FlowLayout
        '
        Me.Borrow_Container_FlowLayout.BackColor = System.Drawing.Color.Moccasin
        Me.Borrow_Container_FlowLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Borrow_Container_FlowLayout.Location = New System.Drawing.Point(3, 3)
        Me.Borrow_Container_FlowLayout.Name = "Borrow_Container_FlowLayout"
        Me.Borrow_Container_FlowLayout.Size = New System.Drawing.Size(689, 347)
        Me.Borrow_Container_FlowLayout.TabIndex = 1
        '
        'UC_User_Request_Tab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(111, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Controls.Add(Me.Borrow_Container_FlowLayout)
        Me.Margin = New System.Windows.Forms.Padding(10)
        Me.Name = "UC_User_Request_Tab"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(695, 353)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Borrow_Container_FlowLayout As FlowLayoutPanel
End Class
