<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catalouge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.picUserIcon = New System.Windows.Forms.PictureBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.pnlMainContent = New System.Windows.Forms.Panel()
        Me.flpVerticalStack = New System.Windows.Forms.FlowLayoutPanel() ' This will hold the dynamic content
        Me.pnlHeader.SuspendLayout()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainContent.SuspendLayout() ' Added this line
        Me.SuspendLayout()
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.BurlyWood
        Me.pnlHeader.Controls.Add(Me.picUserIcon)
        Me.pnlHeader.Controls.Add(Me.lblUser)
        Me.pnlHeader.Controls.Add(Me.txtSearch)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(1008, 60)
        Me.pnlHeader.TabIndex = 0
        '
        'picUserIcon
        '
        Me.picUserIcon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picUserIcon.BackColor = System.Drawing.Color.DeepSkyBlue ' Placeholder color
        Me.picUserIcon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picUserIcon.Location = New System.Drawing.Point(956, 10)
        Me.picUserIcon.Name = "picUserIcon"
        Me.picUserIcon.Size = New System.Drawing.Size(40, 40)
        Me.picUserIcon.TabIndex = 2
        Me.picUserIcon.TabStop = False
        ' Add Cursor property if you want it to look clickable
        Me.picUserIcon.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'lblUser
        '
        Me.lblUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(895, 19)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(51, 21)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Guest"
        ' Add Cursor property if you want it to look clickable
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Hand
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 15)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(347, 29)
        Me.txtSearch.TabIndex = 0
        Me.txtSearch.Text = "Search Bar" ' Placeholder text
        '
        'pnlMainContent
        '
        Me.pnlMainContent.AutoScroll = True ' Enable scrolling for dynamic content
        Me.pnlMainContent.BackColor = System.Drawing.Color.AntiqueWhite
        Me.pnlMainContent.Controls.Add(Me.flpVerticalStack) ' Add the main container
        Me.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill ' Fill the remaining space
        Me.pnlMainContent.Location = New System.Drawing.Point(0, 60) ' Position below header
        Me.pnlMainContent.Name = "pnlMainContent"
        Me.pnlMainContent.Size = New System.Drawing.Size(1008, 669) ' Adjust size as needed
        Me.pnlMainContent.TabIndex = 1 ' Changed TabIndex since sidebar is gone
        '
        'flpVerticalStack
        '
        Me.flpVerticalStack.AutoSize = True ' Allow it to grow vertically
        Me.flpVerticalStack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.flpVerticalStack.Dock = System.Windows.Forms.DockStyle.Top ' Dock to top of pnlMainContent initially
        Me.flpVerticalStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpVerticalStack.Location = New System.Drawing.Point(0, 0)
        Me.flpVerticalStack.Name = "flpVerticalStack"
        Me.flpVerticalStack.Size = New System.Drawing.Size(1008, 0) ' Initial size, width matches parent
        Me.flpVerticalStack.TabIndex = 0
        Me.flpVerticalStack.WrapContents = False
        ' Anchor to resize horizontally
        Me.flpVerticalStack.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        'Catalouge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.pnlMainContent) ' Add Main Content Panel
        Me.Controls.Add(Me.pnlHeader)      ' Add Header Panel
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Catalouge"
        Me.Text = "Library Catalogue" ' Changed Title
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.picUserIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainContent.ResumeLayout(False) ' Added this line
        Me.pnlMainContent.PerformLayout()   ' Added this line
        Me.ResumeLayout(False)

    End Sub

    ' --- Keep declarations ONLY for controls remaining in the designer ---
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents picUserIcon As PictureBox
    Friend WithEvents lblUser As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents pnlMainContent As Panel
    Friend WithEvents flpVerticalStack As FlowLayoutPanel

End Class