
Public Class UserProfile

    ' This private variable will hold the account passed in from the home panel
    Private _account As Account
    Private editForm As EditProfile = Nothing

    ''' <summary>
    ''' This is the new constructor.
    ''' It requires an Account object to be passed in.
    ''' </summary>
    Public Sub New(ByVal account As Account)
        ' This call is required by the designer.
        InitializeComponent()

        ' Store the account object for the Load event to use
        Me._account = account
    End Sub

    ''' <summary>
    ''' This event now populates all labels AND the new book display.
    ''' </summary>
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Safeguard in case no account was passed
        If _account Is Nothing Then
            MessageBox.Show("Error: No account information was loaded.", "Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        ' 1. Populate the labels with data from the account object
        lbl_username.Text = _account.Username
        lbl_fullname.Text = _account.Name
        lbl_email.Text = If(Not String.IsNullOrWhiteSpace(_account.Email), _account.Email, "N/A")

        ' 2. Handle nullable Birthday and calculate Age
        If _account.Birthday.HasValue Then
            lbl_birthdate.Text = _account.Birthday.Value.ToString("MMMM dd, yyyy")

            ' Calculate age
            Dim today As Date = Date.Today
            Dim age As Integer = today.Year - _account.Birthday.Value.Year
            If _account.Birthday.Value.Date > today.AddYears(-age) Then
                age -= 1
            End If
            lbl_age.Text = age.ToString()
        Else
            ' Handle users who haven't set a birthday
            lbl_birthdate.Text = "N/A"
            lbl_age.Text = "N/A"
        End If

        ' TODO: Populate Credit Score
        ' Guna2ProgressBar_CreditsPoints.Value = ...


        ' --- 3. NEW LOGIC: Load the new Displayed Books control ---
        LoadDisplayedBooks()

    End Sub

    ' --- NEW: This function loads the 1-3 displayed books ---
    Private Sub LoadDisplayedBooks()
        Dim booksToDisplay As New List(Of Book)

        Try
            booksToDisplay = Program.AccountSvc.GetDisplayedBooksForAccount(_account.AccountID)
        Catch ex As Exception
            MessageBox.Show("Error loading displayed books: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        ' --- 4. Create and add the new User Control ---
        Dim profileDisplayUC As New UC_ProfileBookDisplay()
        profileDisplayUC.Dock = DockStyle.Fill
        profileDisplayUC.LoadBooks(booksToDisplay) ' Pass the list of books

        Display_Book_container.Controls.Clear() ' Remove the old control
        Display_Book_container.Controls.Add(profileDisplayUC)
        profileDisplayUC.BringToFront()
    End Sub

    ' --- (Your original event handlers) ---

    Private Sub Guna2PictureBox1_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint
    End Sub

    Private Sub Guna2PictureBox1_Click_1(sender As Object, e As EventArgs)
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs) Handles picBox_profile.Click
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint
    End Sub

    Private Sub TableLayoutPanel5_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel5.Paint
    End Sub

    Private Sub TableLayoutPanel6_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel6.Paint
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_username.Click
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lbl_email.Click
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_fullname.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles lbl_birthdate.Click
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles lbl_age.Click
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub TableLayoutPanel7_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel7.Paint
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim message As String =
    "📘 Credit Score (CP) Info" & vbCrLf & vbCrLf &
    "Your CP shows how responsible you are in borrowing and returning books." & vbCrLf & vbCrLf &
    "✅ On-time/Early Return: +5 CP" & vbCrLf &
    "⚠️ Max: 100 CP" & vbCrLf & vbCrLf &
    "Penalties:" & vbCrLf &
    "• Lost Book: -50 CP & ₱500 Fine" & vbCrLf &
    "  (Paying restores +20 CP, total 70 CP)" & vbCrLf &
    "• Damaged Book: -30 CP" & vbCrLf &
    "• Overdue Book: -10 CP" & vbCrLf & vbCrLf &
    "Keep your CP high — return books on time!"
        MessageBox.Show(message, "Credit Score Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub GGuna2ProgressBar1_ValueChanged(sender As Object, e As EventArgs) Handles Guna2ProgressBar_CreditsPoints.ValueChanged
    End Sub

    Private Sub TableLayoutPanel1_Paint_1(sender As Object, e As PaintEventArgs)
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btn_editbookpreview.Click
        ' Show the edit form
        Using edit As New editDisplayedBooks(_account)
            ' Use ShowDialog() to make it modal (blocks user from clicking profile)
            If edit.ShowDialog() = DialogResult.OK Then
                ' --- NEW: Refresh the books after the edit form closes ---
                LoadDisplayedBooks()
            End If
        End Using
    End Sub

    Private Sub btn_Books_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If editForm Is Nothing OrElse editForm.IsDisposed Then
            editForm = New EditProfile()
        End If

        ' Show the form and bring it to front
        editForm.Show()
        editForm.BringToFront()
    End Sub

    Private Sub GGuna2Button4_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class