<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Book_PopUP
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
        Me.picbox_book = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.lbl_book_title = New System.Windows.Forms.Label()
        Me.btn_AddtoCart = New Guna.UI2.WinForms.Guna2Button()
        Me.btn_Borrow = New Guna.UI2.WinForms.Guna2Button()
        Me.lblAuthorData = New System.Windows.Forms.Label()
        Me.lblISBNData = New System.Windows.Forms.Label()
        Me.lblYearData = New System.Windows.Forms.Label()
        Me.lblGenreData = New System.Windows.Forms.Label()
        Me.lblPublisherData = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.pnl_Title = New Guna.UI2.WinForms.Guna2Panel()
        Me.messagedialogAdded = New Guna.UI2.WinForms.Guna2MessageDialog()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.btn_close = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.table_container = New Guna.UI2.WinForms.Guna2Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        CType(Me.picbox_book, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_Title.SuspendLayout()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.table_container.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picbox_book
        '
        Me.picbox_book.BorderRadius = 20
        Me.picbox_book.FillColor = System.Drawing.Color.Transparent
        Me.picbox_book.Image = Global.OOP_Library_System.My.Resources.Resources.Ucc_Logo_NoBG_Big2
        Me.picbox_book.ImageRotate = 0!
        Me.picbox_book.Location = New System.Drawing.Point(18, 23)
        Me.picbox_book.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picbox_book.Name = "picbox_book"
        Me.picbox_book.Size = New System.Drawing.Size(188, 281)
        Me.picbox_book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picbox_book.TabIndex = 0
        Me.picbox_book.TabStop = False
        '
        'lbl_book_title
        '
        Me.lbl_book_title.AutoEllipsis = True
        Me.lbl_book_title.AutoSize = True
        Me.lbl_book_title.Font = New System.Drawing.Font("Segoe UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_book_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lbl_book_title.Location = New System.Drawing.Point(11, 6)
        Me.lbl_book_title.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_book_title.Name = "lbl_book_title"
        Me.lbl_book_title.Size = New System.Drawing.Size(75, 37)
        Me.lbl_book_title.TabIndex = 1
        Me.lbl_book_title.Text = "Title"
        Me.lbl_book_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_AddtoCart
        '
        Me.btn_AddtoCart.BorderRadius = 20
        Me.btn_AddtoCart.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_AddtoCart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_AddtoCart.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_AddtoCart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_AddtoCart.FillColor = System.Drawing.Color.White
        Me.btn_AddtoCart.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_AddtoCart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_AddtoCart.Location = New System.Drawing.Point(294, 318)
        Me.btn_AddtoCart.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_AddtoCart.Name = "btn_AddtoCart"
        Me.btn_AddtoCart.Size = New System.Drawing.Size(128, 42)
        Me.btn_AddtoCart.TabIndex = 2
        Me.btn_AddtoCart.Text = "Add to Cart"
        '
        'btn_Borrow
        '
        Me.btn_Borrow.BorderRadius = 20
        Me.btn_Borrow.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_Borrow.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_Borrow.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_Borrow.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_Borrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_Borrow.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btn_Borrow.ForeColor = System.Drawing.Color.White
        Me.btn_Borrow.Location = New System.Drawing.Point(516, 318)
        Me.btn_Borrow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Borrow.Name = "btn_Borrow"
        Me.btn_Borrow.Size = New System.Drawing.Size(128, 42)
        Me.btn_Borrow.TabIndex = 3
        Me.btn_Borrow.Text = "Borrow"
        '
        'lblAuthorData
        '
        Me.lblAuthorData.AutoSize = True
        Me.lblAuthorData.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthorData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.lblAuthorData.Location = New System.Drawing.Point(11, 41)
        Me.lblAuthorData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAuthorData.Name = "lblAuthorData"
        Me.lblAuthorData.Size = New System.Drawing.Size(68, 20)
        Me.lblAuthorData.TabIndex = 4
        Me.lblAuthorData.Text = "Author: "
        '
        'lblISBNData
        '
        Me.lblISBNData.AutoSize = True
        Me.lblISBNData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblISBNData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblISBNData.Location = New System.Drawing.Point(110, 64)
        Me.lblISBNData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblISBNData.Name = "lblISBNData"
        Me.lblISBNData.Size = New System.Drawing.Size(85, 15)
        Me.lblISBNData.TabIndex = 6
        Me.lblISBNData.Text = "(Place Holder)"
        '
        'lblYearData
        '
        Me.lblYearData.AutoSize = True
        Me.lblYearData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYearData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblYearData.Location = New System.Drawing.Point(110, 49)
        Me.lblYearData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblYearData.Name = "lblYearData"
        Me.lblYearData.Size = New System.Drawing.Size(85, 15)
        Me.lblYearData.TabIndex = 5
        Me.lblYearData.Text = "(Place Holder)"
        '
        'lblGenreData
        '
        Me.lblGenreData.AutoSize = True
        Me.lblGenreData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblGenreData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGenreData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblGenreData.Location = New System.Drawing.Point(110, 0)
        Me.lblGenreData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGenreData.Name = "lblGenreData"
        Me.lblGenreData.Size = New System.Drawing.Size(323, 34)
        Me.lblGenreData.TabIndex = 2
        Me.lblGenreData.Text = "(Place Holder)"
        Me.lblGenreData.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblPublisherData
        '
        Me.lblPublisherData.AutoSize = True
        Me.lblPublisherData.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublisherData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblPublisherData.Location = New System.Drawing.Point(110, 34)
        Me.lblPublisherData.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPublisherData.Name = "lblPublisherData"
        Me.lblPublisherData.Size = New System.Drawing.Size(85, 15)
        Me.lblPublisherData.TabIndex = 1
        Me.lblPublisherData.Text = "(Place Holder)"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescription.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblDescription.Location = New System.Drawing.Point(110, 94)
        Me.lblDescription.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(323, 112)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "(Place Holder)"
        '
        'pnl_Title
        '
        Me.pnl_Title.BackColor = System.Drawing.Color.Transparent
        Me.pnl_Title.BorderRadius = 10
        Me.pnl_Title.Controls.Add(Me.lbl_book_title)
        Me.pnl_Title.Controls.Add(Me.lblAuthorData)
        Me.pnl_Title.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.pnl_Title.ForeColor = System.Drawing.Color.Transparent
        Me.pnl_Title.Location = New System.Drawing.Point(220, 23)
        Me.pnl_Title.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnl_Title.Name = "pnl_Title"
        Me.pnl_Title.Size = New System.Drawing.Size(435, 65)
        Me.pnl_Title.TabIndex = 6
        '
        'messagedialogAdded
        '
        Me.messagedialogAdded.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK
        Me.messagedialogAdded.Caption = ""
        Me.messagedialogAdded.Icon = Guna.UI2.WinForms.MessageDialogIcon.None
        Me.messagedialogAdded.Parent = Nothing
        Me.messagedialogAdded.Style = Guna.UI2.WinForms.MessageDialogStyle.[Default]
        Me.messagedialogAdded.Text = "Successfully Added to Cart."
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 30
        Me.Guna2Elipse1.TargetControl = Me
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BorderRadius = 10
        Me.btn_close.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btn_close.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btn_close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btn_close.FillColor = System.Drawing.Color.Transparent
        Me.btn_close.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(664, 0)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(42, 42)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "X"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.table_container)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.pnl_Title)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_close)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_Borrow)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.picbox_book)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btn_AddtoCart)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2PictureBox1)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(166, Byte), Integer))
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(173, Byte), Integer), CType(CType(143, Byte), Integer))
        Me.Guna2CustomGradientPanel1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(706, 371)
        Me.Guna2CustomGradientPanel1.TabIndex = 8
        '
        'table_container
        '
        Me.table_container.BorderColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.table_container.BorderRadius = 20
        Me.table_container.BorderThickness = 1
        Me.table_container.Controls.Add(Me.TableLayoutPanel1)
        Me.table_container.FillColor = System.Drawing.Color.WhiteSmoke
        Me.table_container.Location = New System.Drawing.Point(222, 98)
        Me.table_container.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.table_container.Name = "table_container"
        Me.table_container.Size = New System.Drawing.Size(435, 206)
        Me.table_container.TabIndex = 9
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblYearData, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.lblISBNData, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.lblPublisherData, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblGenreData, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.lblStatus, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.lblDescription, 1, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.37164!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.62836!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(435, 206)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(2, 64)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 15)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "ISBN:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 49)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Year: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(2, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Publisher: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(2, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 34)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Genre(s):"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(2, 79)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Status:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(107, Byte), Integer), CType(CType(84, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(2, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 112)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Book Description:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.lblStatus.Location = New System.Drawing.Point(110, 79)
        Me.lblStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(85, 15)
        Me.lblStatus.TabIndex = 7
        Me.lblStatus.Text = "(Place Holder)"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2PictureBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2PictureBox1.Image = Global.OOP_Library_System.My.Resources.Resources.titi_ni_ren_baluktot_nakita_ko
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(706, 371)
        Me.Guna2PictureBox1.TabIndex = 10
        Me.Guna2PictureBox1.TabStop = False
        '
        'Book_PopUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(706, 371)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Book_PopUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picbox_book, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_Title.ResumeLayout(False)
        Me.pnl_Title.PerformLayout()
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.table_container.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picbox_book As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents lbl_book_title As Label
    Friend WithEvents btn_AddtoCart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btn_Borrow As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblAuthorData As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents pnl_Title As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents messagedialogAdded As Guna.UI2.WinForms.Guna2MessageDialog
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents btn_close As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblYearData As Label
    Friend WithEvents lblGenreData As Label
    Friend WithEvents lblPublisherData As Label
    Friend WithEvents lblISBNData As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lblStatus As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents table_container As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
