Imports MySql.Data.MySqlClient

Public Class OtpService
    Private ReadOnly _dbCon As DBcon
    Private Shared ReadOnly Rng As New Random()

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Generates a 6-digit OTP string.
    ''' </summary>
    Private Function GenerateOtpCode() As String
        Return Rng.Next(100000, 999999).ToString("D6")
    End Function

    ' ##################################################################
    ' --- FOR EXISTING USERS (e.g., Forgot Password) ---
    ' ##################################################################

    ''' <summary>
    ''' Generates and stores an OTP for an *existing user* based on their ID.
    ''' </summary>
    ''' <returns>The 6-digit OTP code, or Nothing if DB op failed.</returns>
    Public Function GenerateOtpForUser(userId As Integer, Optional expiresInMinutes As Integer = 5) As String
        Dim otpCode As String = GenerateOtpCode()
        Dim expiresAt As DateTime = DateTime.Now.AddMinutes(expiresInMinutes)

        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim dao As New OtpDAO(transaction)

            ' 1. Invalidate old codes for this user
            dao.InvalidateByUserId(userId)

            ' 2. Insert the new code
            dao.InsertForUser(userId, otpCode, expiresAt)

            ' 3. Commit
            transaction.Commit()
            Return otpCode

        Catch ex As Exception
            transaction.Rollback()
            Debug.WriteLine("Failed to generate user OTP: " & ex.Message)
            Return Nothing
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Verifies an OTP for an *existing user* based on their ID.
    ''' </summary>
    Public Function VerifyOtpForUser(userId As Integer, userOtpInput As String) As Boolean
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim dao As New OtpDAO(transaction)

            ' 1. Find the code
            Dim record As OtpRecord? = dao.FindActiveOtpByUser(userId, userOtpInput)

            ' 2. Check validity
            If record Is Nothing Then
                transaction.Rollback()
                Return False ' Code not found
            End If

            If record.Value.IsUsed Then
                transaction.Rollback()
                Return False ' Code already used
            End If

            If DateTime.Now > record.Value.ExpiresAt Then
                transaction.Rollback()
                Return False ' Code expired
            End If

            ' 3. Success! Mark as used and commit
            dao.MarkOtpAsUsed(record.Value.ID)
            transaction.Commit()
            Return True

        Catch ex As Exception
            transaction.Rollback()
            Debug.WriteLine("Failed to verify user OTP: " & ex.Message)
            Return False
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' ##################################################################
    ' --- FOR NEW REGISTRATIONS (e.g., Verify Email) ---
    ' ##################################################################

    ''' <summary>
    ''' Generates and stores an OTP for a *new registration* based on their email or phone.
    ''' </summary>
    ''' <returns>The 6-digit OTP code, or Nothing if DB op failed.</returns>
    Public Function GenerateOtpForRegistration(targetEmailOrPhone As String, Optional expiresInMinutes As Integer = 5) As String
        Dim otpCode As String = GenerateOtpCode()
        Dim expiresAt As DateTime = DateTime.Now.AddMinutes(expiresInMinutes)

        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim dao As New OtpDAO(transaction)

            ' 1. Invalidate old codes for this *specific email/phone*
            dao.InvalidateByTarget(targetEmailOrPhone)

            ' 2. Insert the new code
            dao.InsertForTarget(targetEmailOrPhone, otpCode, expiresAt)

            ' 3. Commit
            transaction.Commit()
            Return otpCode

        Catch ex As Exception
            transaction.Rollback()
            Debug.WriteLine("Failed to generate registration OTP: " & ex.Message)
            Return Nothing
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Verifies an OTP for a *new registration* based on their email or phone.
    ''' </summary>
    Public Function VerifyOtpForRegistration(targetEmailOrPhone As String, userOtpInput As String) As Boolean
        If Not _dbCon.OpenConnection() Then Throw New Exception("Could not connect to the database.")
        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim dao As New OtpDAO(transaction)

            ' 1. Find the code
            Dim record As OtpRecord? = dao.FindActiveOtpByTarget(targetEmailOrPhone, userOtpInput)

            ' 2. Check validity
            If record Is Nothing Then
                transaction.Rollback()
                Return False ' Code not found
            End If

            If record.Value.IsUsed Then
                transaction.Rollback()
                Return False ' Code already used
            End If

            If DateTime.Now > record.Value.ExpiresAt Then
                transaction.Rollback()
                Return False ' Code expired
            End If

            ' 3. Success! Mark as used and commit
            dao.MarkOtpAsUsed(record.Value.ID)
            transaction.Commit()
            Return True

        Catch ex As Exception
            transaction.Rollback()
            Debug.WriteLine("Failed to verify registration OTP: " & ex.Message)
            Return False
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

End Class