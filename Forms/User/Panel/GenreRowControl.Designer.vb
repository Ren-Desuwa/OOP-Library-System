<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GenreRowControl
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
        Me.lblGenreTitle = New System.Windows.Forms.Label()
        Me.flpBooks = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'lblGenreTitle
        '
        Me.lblGenreTitle.AutoSize = True
        Me.lblGenreTitle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblGenreTitle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreTitle.Location = New System.Drawing.Point(15, 10) ' Position title
        Me.lblGenreTitle.Margin = New System.Windows.Forms.Padding(15, 10, 3, 0)
        Me.lblGenreTitle.Name = "lblGenreTitle"
        Me.lblGenreTitle.Size = New System.Drawing.Size(111, 25)
        Me.lblGenreTitle.TabIndex = 0
        Me.lblGenreTitle.Text = "Genre Title"
        '
        'flpBooks
        '
        Me.flpBooks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.flpBooks.AutoScroll = False ' Disable scrolling on this panel itself
        Me.flpBooks.Location = New System.Drawing.Point(15, 40) ' Position below title
        Me.flpBooks.Margin = New System.Windows.Forms.Padding(15, 5, 15, 5)
        Me.flpBooks.Name = "flpBooks"
        Me.flpBooks.Size = New System.Drawing.Size(770, 210) ' Size for book items (adjust height if BookItemControl changes)
        Me.flpBooks.TabIndex = 1
        Me.flpBooks.WrapContents = False ' Keep books in a single horizontal row
        '
        'GenreRowControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent ' Make transparent if needed
        Me.Controls.Add(Me.flpBooks)
        Me.Controls.Add(Me.lblGenreTitle)
        Me.Name = "GenreRowControl"
        Me.Size = New System.Drawing.Size(800, 265) ' Overall height (Title + Panel + Margins) - Adjust this for 2.5 effect
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGenreTitle As Label
    Friend WithEvents flpBooks As FlowLayoutPanel

End Class