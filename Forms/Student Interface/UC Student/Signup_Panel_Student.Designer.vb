<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Signup_Panel_Student
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation1 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Signup_Panel_Student))
        Dim Animation2 As Guna.UI2.AnimatorNS.Animation = New Guna.UI2.AnimatorNS.Animation()
        Me.title_panel = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.signup_form_container = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.UC_welcome_message1_student1 = New OOP_Library_System.UC_welcome_message1_student()
        Me.UC_signup_step1_student1 = New OOP_Library_System.UC_signup_step1_student()
        Me.UC_signup_step2_student1 = New OOP_Library_System.UC_signup_step2_student()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Transition1 = New Guna.UI2.WinForms.Guna2Transition()
        Me.Guna2Transition2 = New Guna.UI2.WinForms.Guna2Transition()
        Me.title_panel.SuspendLayout()
        Me.signup_form_container.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_panel
        '
        Me.title_panel.Controls.Add(Me.signup_form_container)
        Me.title_panel.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2Transition2.SetDecoration(Me.title_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.title_panel, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.title_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.title_panel.FillColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.title_panel.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.title_panel.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.title_panel.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.title_panel.Location = New System.Drawing.Point(0, 0)
        Me.title_panel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.title_panel.Name = "title_panel"
        Me.title_panel.Size = New System.Drawing.Size(1248, 705)
        Me.title_panel.TabIndex = 1
        '
        'signup_form_container
        '
        Me.signup_form_container.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.signup_form_container.BackColor = System.Drawing.Color.Transparent
        Me.signup_form_container.BorderColor = System.Drawing.Color.Transparent
        Me.signup_form_container.BorderRadius = 30
        Me.signup_form_container.Controls.Add(Me.UC_welcome_message1_student1)
        Me.signup_form_container.Controls.Add(Me.UC_signup_step1_student1)
        Me.signup_form_container.Controls.Add(Me.UC_signup_step2_student1)
        Me.Guna2Transition2.SetDecoration(Me.signup_form_container, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me.signup_form_container, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.signup_form_container.FillColor = System.Drawing.Color.FloralWhite
        Me.signup_form_container.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.signup_form_container.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.signup_form_container.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.signup_form_container.Location = New System.Drawing.Point(100, 98)
        Me.signup_form_container.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.signup_form_container.MaximumSize = New System.Drawing.Size(1048, 505)
        Me.signup_form_container.Name = "signup_form_container"
        Me.signup_form_container.Size = New System.Drawing.Size(1048, 505)
        Me.signup_form_container.TabIndex = 14
        '
        'UC_welcome_message1_student1
        '
        Me.UC_welcome_message1_student1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.UC_welcome_message1_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.UC_welcome_message1_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UC_welcome_message1_student1.Dock = System.Windows.Forms.DockStyle.Left
        Me.UC_welcome_message1_student1.Location = New System.Drawing.Point(0, 0)
        Me.UC_welcome_message1_student1.Name = "UC_welcome_message1_student1"
        Me.UC_welcome_message1_student1.Size = New System.Drawing.Size(525, 505)
        Me.UC_welcome_message1_student1.TabIndex = 2
        '
        'UC_signup_step1_student1
        '
        Me.UC_signup_step1_student1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.UC_signup_step1_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.UC_signup_step1_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UC_signup_step1_student1.Location = New System.Drawing.Point(520, 0)
        Me.UC_signup_step1_student1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.UC_signup_step1_student1.Name = "UC_signup_step1_student1"
        Me.UC_signup_step1_student1.Size = New System.Drawing.Size(525, 505)
        Me.UC_signup_step1_student1.TabIndex = 0
        '
        'UC_signup_step2_student1
        '
        Me.UC_signup_step2_student1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.UC_signup_step2_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.UC_signup_step2_student1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.UC_signup_step2_student1.Location = New System.Drawing.Point(520, 0)
        Me.UC_signup_step2_student1.Name = "UC_signup_step2_student1"
        Me.UC_signup_step2_student1.Size = New System.Drawing.Size(525, 505)
        Me.UC_signup_step2_student1.TabIndex = 1
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Transition1.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition2.SetDecoration(Me.Guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.OOP_Library_System.My.Resources.Resources.titi_ni_ren_baluktot_nakita_ko
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(1248, 705)
        Me.Guna2PictureBox1.TabIndex = 17
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2Transition1
        '
        Me.Guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition1.Cursor = Nothing
        Animation1.AnimateOnlyDifferences = True
        Animation1.BlindCoeff = CType(resources.GetObject("Animation1.BlindCoeff"), System.Drawing.PointF)
        Animation1.LeafCoeff = 0!
        Animation1.MaxTime = 1.0!
        Animation1.MinTime = 0!
        Animation1.MosaicCoeff = CType(resources.GetObject("Animation1.MosaicCoeff"), System.Drawing.PointF)
        Animation1.MosaicShift = CType(resources.GetObject("Animation1.MosaicShift"), System.Drawing.PointF)
        Animation1.MosaicSize = 0
        Animation1.Padding = New System.Windows.Forms.Padding(0)
        Animation1.RotateCoeff = 0!
        Animation1.RotateLimit = 0!
        Animation1.ScaleCoeff = CType(resources.GetObject("Animation1.ScaleCoeff"), System.Drawing.PointF)
        Animation1.SlideCoeff = CType(resources.GetObject("Animation1.SlideCoeff"), System.Drawing.PointF)
        Animation1.TimeCoeff = 0!
        Animation1.TransparencyCoeff = 1.0!
        Me.Guna2Transition1.DefaultAnimation = Animation1
        '
        'Guna2Transition2
        '
        Me.Guna2Transition2.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent
        Me.Guna2Transition2.Cursor = Nothing
        Animation2.AnimateOnlyDifferences = True
        Animation2.BlindCoeff = CType(resources.GetObject("Animation2.BlindCoeff"), System.Drawing.PointF)
        Animation2.LeafCoeff = 0!
        Animation2.MaxTime = 1.0!
        Animation2.MinTime = 0!
        Animation2.MosaicCoeff = CType(resources.GetObject("Animation2.MosaicCoeff"), System.Drawing.PointF)
        Animation2.MosaicShift = CType(resources.GetObject("Animation2.MosaicShift"), System.Drawing.PointF)
        Animation2.MosaicSize = 0
        Animation2.Padding = New System.Windows.Forms.Padding(0)
        Animation2.RotateCoeff = 0!
        Animation2.RotateLimit = 0!
        Animation2.ScaleCoeff = CType(resources.GetObject("Animation2.ScaleCoeff"), System.Drawing.PointF)
        Animation2.SlideCoeff = CType(resources.GetObject("Animation2.SlideCoeff"), System.Drawing.PointF)
        Animation2.TimeCoeff = 0!
        Animation2.TransparencyCoeff = 1.0!
        Me.Guna2Transition2.DefaultAnimation = Animation2
        '
        'Signup_Panel_Student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 705)
        Me.Controls.Add(Me.title_panel)
        Me.Guna2Transition2.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.Guna2Transition1.SetDecoration(Me, Guna.UI2.AnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Signup_Panel_Student"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.title_panel.ResumeLayout(False)
        Me.signup_form_container.ResumeLayout(False)
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents title_panel As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Transition1 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents signup_form_container As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2Transition2 As Guna.UI2.WinForms.Guna2Transition
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents UC_signup_step1_student1 As UC_signup_step1_student
    Friend WithEvents UC_signup_step2_student1 As UC_signup_step2_student
    Friend WithEvents UC_welcome_message1_student1 As UC_welcome_message1_student
End Class