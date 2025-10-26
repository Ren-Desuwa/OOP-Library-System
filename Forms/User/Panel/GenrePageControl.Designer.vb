<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenrePageControl
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
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblGenreTitleFull = New System.Windows.Forms.Label()
        Me.flpAllBooks = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Me.btnBack)
        Me.pnlHeader.Controls.Add(Me.lblGenreTitleFull)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(800, 50) ' Height for header
        Me.pnlHeader.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(15, 10)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 30)
        Me.btnBack.TabIndex = 1
        Me.btnBack.Text = "← Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblGenreTitleFull
        '
        Me.lblGenreTitleFull.AutoSize = True
        Me.lblGenreTitleFull.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreTitleFull.Location = New System.Drawing.Point(100, 10) ' Position after back button
        Me.lblGenreTitleFull.Name = "lblGenreTitleFull"
        Me.lblGenreTitleFull.Size = New System.Drawing.Size(126, 30)
        Me.lblGenreTitleFull.TabIndex = 0
        Me.lblGenreTitleFull.Text = "Genre Title"
        '
        'flpAllBooks
        '
        Me.flpAllBooks.AutoScroll = True ' Enable scrolling for all books
        Me.flpAllBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flpAllBooks.Location = New System.Drawing.Point(0, 50) ' Below header
        Me.flpAllBooks.Name = "flpAllBooks"
        Me.flpAllBooks.Padding = New System.Windows.Forms.Padding(15) ' Padding around books
        Me.flpAllBooks.Size = New System.Drawing.Size(800, 550) ' Fill remaining space
        Me.flpAllBooks.TabIndex = 1
        ' WrapContents defaults to True, which is good here
        '
        'GenrePageControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite ' Match main panel background
        Me.Controls.Add(Me.flpAllBooks)
        Me.Controls.Add(Me.pnlHeader)
        Me.Name = "GenrePageControl"
        Me.Size = New System.Drawing.Size(800, 600)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnBack As Button
    Friend WithEvents lblGenreTitleFull As Label
    Friend WithEvents flpAllBooks As FlowLayoutPanel

End Class