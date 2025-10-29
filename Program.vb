Imports System.Windows.Forms

Public Module Program

    ' --- Central Storage for all your services ---
    ' Members of a Module are already shared, so we just declare them.
    Public ReadOnly mainDbConnection As DBcon
    Public ReadOnly AuthSvc As AuthService
    Public ReadOnly CatSvc As CatalougeService
    Public ReadOnly OtpSvc As OtpService
    Public ReadOnly NotifSvc As NotificationService
    Public ReadOnly RegSvc As registrationService
    ' ... other services ...

    ' --- Static Constructor (Runs ONCE) ---
    ' "Shared Sub New" IS correct for a Module.
    Sub New()
        Try
            ' 1. Create the ONE database connection object
            mainDbConnection = New DBcon("ooplibrary")

            ' 2. Create all services and INJECT dependencies
            AuthSvc = New AuthService(mainDbConnection)
            CatSvc = New CatalougeService(mainDbConnection)
            OtpSvc = New OtpService(mainDbConnection)
            NotifSvc = New NotificationService()
            RegSvc = New registrationService(mainDbConnection, OtpSvc, NotifSvc)

        Catch ex As Exception
            ' If this fails, the app can't run. Show error and exit.
            MessageBox.Show("Fatal Error: Could not initialize services." & vbCrLf & ex.Message,
                            "Application Startup Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            ' End the application
            End
        End Try
    End Sub


    ' --- Main Entry Point ---
    <STAThread>
    Sub Main()
        ' This makes your forms look modern
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        ' --- Logic to decide which form to launch ---
        Dim result = MessageBox.Show(
            "Are you a staff member?" & vbCrLf & vbCrLf &
            "Click 'Yes' for Admin/Librarian Login" & vbCrLf &
            "Click 'No' for the User Kiosk",
            "Select Application Mode",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        )

        If result = DialogResult.Yes Then
            ' --- Run the ADMIN/LIBRARIAN App ---
            ' Make sure your Frm_Login constructor is updated
            Dim adminLoginForm As New Login_Panel_Student()
            Application.Run(adminLoginForm)
        Else
            ' --- Run the KIOSK App ---
            ' Make sure your Frm_Kiosk_Main constructor is updated
            Dim kioskMainForm As New Login_Panel_Student()
            Application.Run(kioskMainForm)
        End If

    End Sub

End Module