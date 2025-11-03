Imports System.Windows.Forms
Imports System.Threading.Tasks

Public Module Program

    ' --- Central Storage for all your services ---
    Public ReadOnly mainDbConnection As DBcon
    Public ReadOnly AuthSvc As AuthService
    Public ReadOnly CatSvc As CatalougeService
    Public ReadOnly OtpSvc As OtpService
    Public ReadOnly NotifSvc As NotificationService
    Public ReadOnly RegSvc As registrationService
    Public ReadOnly CartSvc As New CartService()
    Public ReadOnly BorrowSvc As BorrowService
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
            BorrowSvc = New BorrowService(mainDbConnection)

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
    Public currentAccount As Account


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

            ' --- 3. MODIFIED: Wire up all event handlers ---
            AddHandler GuestPanel.OpenLogin, AddressOf ShowLoginPanel

            ' Connect to the new events from LoginPanel
            AddHandler LoginPanel.RegisterClicked, AddressOf ShowSignupPanel
            AddHandler LoginPanel.LoginSuccess, AddressOf ShowStudentPanel

            ' We now listen for our custom "Back" event
            AddHandler SignupPanel.BackToLoginClicked, AddressOf ShowLoginPanelFromSignup

            ' Connect to the (assumed) Logout button from StudentPanel
            ' AddHandler StudentPanel.LogoutClicked, AddressOf ShowGuestPanel

            ' 4. Start by showing the Guest Panel
            ' --- EDITED THIS LINE ---
            ' Dim panel As New EditProfile() ' (This line seemed to be for testing, I've commented it out)
            Application.Run(GuestPanel)

        Catch ex As Exception
            MessageBox.Show("Fatal Error: Could not initialize application UI." & vbCrLf & ex.Message,
                          "Application Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
        ' --- END OF MOVED CODE ---

    End Sub

    ' --- 4. MODIFIED: All Navigation Subroutines are now Async ---

    ' This is the one you specifically asked for!
    Private Async Sub ShowLoginPanel(sender As Object, e As EventArgs)
        ' Get the form that is currently open
        Dim guestForm = CType(sender, Home_Panel_Guest)

        ' 1. Show the loading panel on the CURRENT form
        guestForm.ToggleLoading(True, "Loading...")

        Try
            ' 2. Show the LoginPanel (it's invisible, but this triggers its "Shown" event)
            LoginPanel.Show()

            ' 3. PAUSE here and wait for LoginPanel to signal it's done
            Await LoginPanel.AwaitLoadingAsync()

            ' 4. --- Loading is Complete ---
            ' Hide the old GuestPanel
            guestForm.Hide()

            ' 5. Bring the fully loaded LoginPanel to the front
            LoginPanel.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Error loading login panel: " & ex.Message)
            LoginPanel.Hide() ' Hide the broken panel
            guestForm.Show() ' Show the guest panel again
        Finally
            ' 6. ALWAYS hide the loading panel
            guestForm.ToggleLoading(False)
        End Try
    End Sub

    ' From Login Panel "Register" Button -> Signup Panel
    Private Async Sub ShowSignupPanel(sender As Object, e As EventArgs)
        ' 1. Show the loading panel on the CURRENT form (LoginPanel)
        ' NOTE: LoginPanel does not have a loading panel.
        ' We will just hide/show it. For forms without loading panels,
        ' the transition will be fast but still correct.
        LoginPanel.Hide()

        Try
            ' 2. Show the SignupPanel (triggers "Shown")
            SignupPanel.Show()

            ' 3. Wait for it to be ready
            Await SignupPanel.AwaitLoadingAsync()

            ' 4. Bring it to the front (it's already the only one)
            SignupPanel.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Error loading signup panel: " & ex.Message)
            SignupPanel.Hide()
            LoginPanel.Show() ' Show login panel again
        End Try
    End Sub

    ' --- THIS IS THE FIXED SUBROUTINE ---
    ' From Signup Panel "Back to Login" Button -> Login Panel
    Private Async Sub ShowLoginPanelFromSignup(sender As Object, e As EventArgs)
        ' 1. The "sender" is the SignupPanel
        Dim signupForm = CType(sender, Signup_Panel_Student)

        ' 2. Hide the signup form
        signupForm.Hide()

        ' 3. Now, we run the SAME logic as your previous fix
        Try
            LoginPanel.Show()
            Await LoginPanel.AwaitLoadingAsync()
            LoginPanel.BringToFront()
        Catch ex As Exception
            MessageBox.Show("Error re-loading login panel: " & ex.Message)
        End Try
    End Sub

    ' From Login Panel (Successful Login) -> Student Panel
    Private Async Sub ShowStudentPanel(sender As Object, loggedInAccount As Account)
        currentAccount = loggedInAccount ' Store the logged-in user

        ' 1. Show a loading message on the LoginPanel
        ' (Again, no loading panel, so we'll just hide it)
        LoginPanel.Hide()

        Try
            ' 2. Show the StudentPanel (triggers "Shown")
            StudentPanel.Show()

            ' --- NEW LINE ADDED ---
            ' Use the method we created to set the student's name on the panel
            StudentPanel.SetStudentName(currentAccount.Name)
            ' --- END OF NEW LINE ---

            ' 3. Home_Panel_Students ALREADY has an async loading method!
            ' We will wait for its *internal* loading to finish.
            Await StudentPanel.UC_HPS_catalouge_tab1.AwaitInitialLoad()

            ' 4. --- Loading is Complete ---
            StudentPanel.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Error loading student panel: " & ex.Message)
            StudentPanel.Hide()
            LoginPanel.Show() ' Show login panel again
        Finally
            ' 5. Hide the loading screen (if StudentPanel had one)
            ' StudentPanel.ToggleLoading(False)
        End Try
    End Sub

    ' From Student Panel (Logout) -> Guest Panel
    Private Async Sub ShowGuestPanel(sender As Object, e As EventArgs)
        currentAccount = Nothing ' Clear logged-in user

        ' 1. Get the StudentPanel and show its loading screen
        Dim studentForm = CType(sender, Home_Panel_Students)
        studentForm.ToggleLoading(True, "Logging out...")

        Try
            ' 2. Show the GuestPanel (triggers "Shown")
            GuestPanel.Show()

            ' 3. Wait for GuestPanel's catalogue to load
            ' (We'll use its AwaitInitialLoad, just like the student panel)
            Await GuestPanel.UC_HPS_catalouge_tab1.AwaitInitialLoad()

            ' 4. --- Loading is Complete ---
            studentForm.Hide()
            GuestPanel.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Error loading guest panel: " & ex.Message)
            GuestPanel.Hide()
            studentForm.Show()
        Finally
            ' 5. Always hide the student panel's loading screen
            studentForm.ToggleLoading(False)
        End Try
    End Sub

End Module