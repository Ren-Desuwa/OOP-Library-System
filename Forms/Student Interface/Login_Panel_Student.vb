Imports System.Threading.Tasks
Imports System.Windows.Forms
Public Class Login_Panel_Student
    ' This event runs when the form first loads
    ' (NAME CORRECTED)
    Private Sub Login_Panel_Student__Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False

    End Sub
    ' --- 1. SIGNALS this form can send ---
    Public Event RegisterClicked As EventHandler
    Public Event LoginSuccess As EventHandler(Of Account) ' Sends the logged-in account

    ' --- 2. For Asynchronous Loading ---
    Private _loadingTcs As TaskCompletionSource(Of Boolean)

    ' --- 3. NEW: This event runs every time the form is SHOWN ---
    ' We use this to signal when loading is "done"
    Private Async Sub Login_Panel_Student_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ' Re-create the "signal" each time the form is shown
        _loadingTcs = New TaskCompletionSource(Of Boolean)()

        ' --- Simulate loading ---
        ' (Your form is fast, so we add a tiny delay
        ' to ensure the async pattern works)
        Await Task.Delay(50)
        ' --- End simulation ---

        ' Signal that loading is complete!
        _loadingTcs.SetResult(True)
    End Sub
    ' --- 4. NEW: Public function for Program.vb to "wait" on ---
    Public Function AwaitLoadingAsync() As Task
        ' If the signal hasn't been created yet, return a completed task
        If _loadingTcs Is Nothing Then
            Return Task.CompletedTask
        End If
        Return _loadingTcs.Task
    End Function

    ' --- 5. MODIFIED: Login button now raises an event ---
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        CheckLogin()
    End Sub

    ' --- 6. MODIFIED: CheckLogin raises an event on success ---
    Private Sub CheckLogin()
        Dim inputUserOrID As String = txtBox_username.Text
        Dim inputPassword As String = txtBox_password.Text
        Dim loggedInUsername As String = ""

        Dim loginAccount As Account = Program.AuthSvc.Login(inputUserOrID, inputPassword)

        If Not loginAccount Is Nothing Then
            ' --- SUCCESS: Raise the event and send the account ---
            RaiseEvent LoginSuccess(Me, loginAccount)
            txtBox_username.Text = ""
            txtBox_password.Text = ""
        Else
            ' Requirement 4: Failed login
            MessageBox.Show("Invalid Username, ID, or Password")
        End If
    End Sub

    ' --- 7. MODIFIED: Register button now raises an event ---
    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles btn_register.Click
        ' --- Raise the signal for Program.vb to handle ---
        RaiseEvent RegisterClicked(Me, EventArgs.Empty)
    End Sub

    ' (NO CHANGES - Kept as requested)
    Private Sub txtBox_username_TextChanged(sender As Object, e As EventArgs) Handles txtBox_username.TextChanged
        ' This is handled by PlaceholderText property, no code needed
        If txtBox_username.Text.Contains("-") Then
            lbl_username.Text = "Student ID"
        Else
            lbl_username.Text = "Username"
        End If
    End Sub

    Private Sub lbl_forgotpass_Click(sender As Object, e As EventArgs) Handles lbl_forgotpass.Click
        ' 1. Create an instance of the ForgotPass_Student form
        Dim forgotPassForm As New ForgotPass_Student()

        ' 2. Show it as a dialog. This will pause the login form.
        forgotPassForm.ShowDialog()

        ' 3. When the user closes the forgot password form,
        '    code execution will resume here.
    End Sub

    ' REQUIREMENT: Show/Hide Password Logic
    Private Sub img_show_Click(sender As Object, e As EventArgs) Handles img_show.Click
        txtBox_password.UseSystemPasswordChar = False
        img_show.Visible = False
        img_hide.Visible = True
    End Sub

    Private Sub img_hide_Click(sender As Object, e As EventArgs) Handles img_hide.Click
        txtBox_password.UseSystemPasswordChar = True
        img_show.Visible = True
        img_hide.Visible = False
    End Sub
End Class