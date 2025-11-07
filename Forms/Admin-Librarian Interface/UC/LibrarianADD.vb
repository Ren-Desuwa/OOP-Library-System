Public Class LibrarianADD

    Private _currentEmail As String = "" ' To store the verified email

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Guna2GradientButton4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GradientButton3_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton3.Click
        ' Validation for TextBox1 - TextBox5
        If String.IsNullOrWhiteSpace(TextBox1.Text) Then
            MessageBox.Show("Please fill in TextBox1.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox1.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Please fill in TextBox2.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox2.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox3.Text) Then
            MessageBox.Show("Please fill in TextBox3.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox3.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox4.Text) Then
            MessageBox.Show("Please fill in TextBox4.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox4.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(TextBox5.Text) Then
            MessageBox.Show("Please fill in TextBox5.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TextBox5.Focus()
            Return
        End If

        ' If all textboxes are filled, proceed here
        MessageBox.Show("All fields are filled. Proceeding...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ' --- Your next action goes here ---
    End Sub

    Private Async Sub btn_sendcode_Click(sender As Object, e As EventArgs) Handles btn_sendcode.Click
        ' txtBox_username is used for email input
        Dim email As String = TextBox2.Text.Trim()
        If String.IsNullOrWhiteSpace(email) Then
            MessageBox.Show("Please enter your email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        btn_sendcode.Enabled = False
        btn_sendcode.Text = "Sending..."

        Try
            ' Call the new service function
            Dim maskedEmail As String = Await Program.AuthSvc.RequestPasswordResetOtp(email)

            ' Success!
            MessageBox.Show($"Verification code sent to {maskedEmail}.", "Code Sent", MessageBoxButtons.OK, MessageBoxIcon.Information)

            _currentEmail = email ' Store the email for the next steps
            'StartOtpCountdown() ' Move to State 2

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            btn_sendcode.Enabled = True ' Re-enable on failure
            btn_sendcode.Text = "Send Code"
        End Try
    End Sub

    Private Sub TableLayoutPanel4_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel4.Paint

    End Sub
End Class