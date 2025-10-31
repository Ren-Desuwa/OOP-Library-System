Imports System.Windows.Forms

Public Module Program

    ' --- Central Storage for all your services ---
    Public ReadOnly mainDbConnection As DBcon
    Public ReadOnly AuthSvc As AuthService
    Public ReadOnly CatSvc As CatalougeService
    Public ReadOnly OtpSvc As OtpService
    Public ReadOnly NotifSvc As NotificationService
    Public ReadOnly RegSvc As registrationService
    ' ... other services ...

    ' --- Static Constructor (Runs ONCE) ---
    ' This Sub New now ONLY handles non-UI services
    Sub New()
        Try
            ' 1. Create the ONE database connection object
            mainDbConnection = New DBcon("ooplibrary")

            ' 2. Create all services
            AuthSvc = New AuthService(mainDbConnection)
            CatSvc = New CatalougeService(mainDbConnection)
            OtpSvc = New OtpService(mainDbConnection)
            NotifSvc = New NotificationService()
            RegSvc = New registrationService(mainDbConnection, OtpSvc, NotifSvc)

        Catch ex As Exception
            ' If this fails, the app can't run
            MessageBox.Show("Fatal Error: Could not initialize services." & vbCrLf & ex.Message,
                         "Application Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub


    ' --- Panels (Forms) ---
    ' Declare them here, but create them in Main
    Private GuestPanel As Home_Panel_Guest
    Private LoginPanel As Login_Panel_Student
    Private SignupPanel As Signup_Panel_Student
    Private StudentPanel As Home_Panel_Students
    Private currentAccount As Account


    ' --- Main Entry Point ---
    <STAThread>
    Sub Main()
        ' --- MOVED FROM Sub New ---
        ' 1. Set application styles FIRST (This fixes the crash)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Try
            ' 2. Initialize the main forms
            GuestPanel = New Home_Panel_Guest()
            LoginPanel = New Login_Panel_Student()
            SignupPanel = New Signup_Panel_Student()
            StudentPanel = New Home_Panel_Students() ' Assumes Home_Panel_Students exists

            ' 3. Wire up event handlers for navigation
            AddHandler GuestPanel.OpenLogin, AddressOf ShowLoginPanel
            'AddHandler LoginPanel.RegisterClicked, AddressOf ShowSignupPanel ' Assumes LoginPanel raises 'RegisterClicked'
            'AddHandler SignupPanel.LoginClicked, AddressOf ShowLoginPanelFromSignup ' Handles "Back to Login"
            'AddHandler LoginPanel.LoginSuccess, AddressOf ShowStudentPanel ' Assumes LoginPanel raises 'LoginSuccess' with Account info
            ' AddHandler StudentPanel.LogoutClicked, AddressOf ShowGuestPanel ' Assumes StudentPanel raises 'LogoutClicked'

            ' 4. Start by showing the Guest Panel
            Dim panel As New EditProfile()
            Application.Run(panel)

        Catch ex As Exception
            MessageBox.Show("Fatal Error: Could not initialize application UI." & vbCrLf & ex.Message,
                         "Application Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        ' --- END OF MOVED CODE ---

    End Sub

    ' --- Navigation Subroutines (These are all correct) ---

    Private Sub ShowLoginPanel(sender As Object, e As EventArgs)
        GuestPanel.Hide()
        LoginPanel.Show() ' Use Show() instead of ShowDialog() for main navigation
    End Sub

    ' From Login Panel "Register" Button -> Signup Panel
    Private Sub ShowSignupPanel(sender As Object, e As EventArgs)
        LoginPanel.Hide()
        SignupPanel.Show()
    End Sub

    ' From Signup Panel "Back to Login" Button -> Login Panel
    Private Sub ShowLoginPanelFromSignup(sender As Object, e As EventArgs)
        SignupPanel.Hide()
        LoginPanel.Show()
    End Sub

    ' From Login Panel (Successful Login) -> Student Panel
    Private Sub ShowStudentPanel(sender As Object, loggedInAccount As Account)
        currentAccount = loggedInAccount ' Store the logged-in user
        LoginPanel.Hide()
        ' StudentPanel.SetCurrentUser(currentAccount)
        StudentPanel.Show()
    End Sub

    ' From Student Panel (Logout) -> Guest Panel
    Private Sub ShowGuestPanel(sender As Object, e As EventArgs)
        currentAccount = Nothing ' Clear logged-in user
        StudentPanel.Hide()
        GuestPanel.Show()
    End Sub

    ' This Sub looks like a mistake or old code.
    ' The AddHandler in your Main Sub is already pointing to "ShowLoginPanel"
    ' You can probably delete this one.
    Sub HandlesOpenLogin(sender As Object, e As EventArgs)
        MessageBox.Show("Opening Login Panel")
        GuestPanel.Hide()
        Dim loginForm As New Login_Panel_Student()
        loginForm.ShowDialog()
        GuestPanel.Show()
    End Sub

End Module