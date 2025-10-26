Public Class Signup_Panel_Student

    ' --- 1. Variables to store data from all steps ---
    Private studentUsername As String
    Private studentID As String
    Private studentPassword As String

    ' This event runs when the FORM loads
    Private Sub Signup_Panel_Student_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' --- Fix for the SLIDE animation (Guna2Transition1) ---
        Guna2Transition1.DefaultAnimation.SlideCoeff = New System.Drawing.PointF(1.0F, 0F)

        ' --- 2. Connect to Step 1 Control (UC_Signup_student1) ---
        AddHandler UC_Signup_student1.ValidationPassed, AddressOf HandleValidationPassed
        AddHandler UC_Signup_student1.LoginClicked, AddressOf HandleLoginClicked

        ' --- 3. Connect to Step 2 Control (UC_Signup2_student1) ---
        AddHandler UC_Signup2_student1.BackClicked, AddressOf HandleBackClicked
        AddHandler UC_Signup2_student1.ConfirmClicked, AddressOf HandleConfirmClicked

        ' --- 4. Set Initial State ---
        UC_Signup2_student1.Visible = True
        UC_Signup_student1.BringToFront()
        UC_Signup2_student1.Visible = False

    End Sub

    ' Runs when Step 1's "Next" button is clicked
    Private Sub HandleValidationPassed(sender As Object, e As EventArgs)

        ' --- 5. Get and Store Data from Step 1 ---
        studentUsername = UC_Signup_student1.txtBox_username.Text
        studentID = UC_Signup_student1.txtBox_studentid.Text
        studentPassword = UC_Signup_student1.txtBox_password.Text

        ' --- 6. Run the "Next" Animation ---

        ' Use .Show and .Hide to run animations at the SAME time
        Guna2Transition2.Show(UC_Signup2_student1) ' Starts fading in
        Guna2Transition1.Hide(UC_Signup_student1) ' Starts sliding out

        UC_Signup2_student1.SendToBack()

        ' (I have removed the MessageBox.Show(...) line, 
        ' which was also pausing your program.)

    End Sub

    ' Runs when Step 2's "Back" button is clicked
    Private Sub HandleBackClicked(sender As Object, e As EventArgs)

        ' --- 7. Run the "Back" Animation ---

        ' Use .Show and .Hide to run animations at the SAME time
        Guna2Transition1.Show(UC_Signup_student1) ' Starts sliding in
        UC_Signup_student1.BringToFront()
        Guna2Transition2.Hide(UC_Signup2_student1) ' Starts fading out

    End Sub

    ' Runs when Step 1's "Back to Login" button is clicked
    Private Sub HandleLoginClicked(sender As Object, e As EventArgs)
        ' Close this signup form and return to the login form
        Me.Close()
    End Sub

    Private Sub HandleConfirmClicked(sender As Object, e As EventArgs)

    End Sub

End Class