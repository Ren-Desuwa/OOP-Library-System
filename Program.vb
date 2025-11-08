Imports System.Windows.Forms
Imports System.Threading.Tasks

Public Module Program

    ' --- Central Storage for all your services ---
    Public ReadOnly mainDbConnection As DBcon
    Public ReadOnly AuthSvc As AuthService
    Public ReadOnly CatSvc As CatalougeService
    Public ReadOnly OtpSvc As OtpService
    Public ReadOnly NotifSvc As NotificationService
    Public ReadOnly CartSvc As New CartService()
    Public ReadOnly BorrowSvc As BorrowService
    Public ReadOnly AnnounceSvc As AnnouncementService
    Public ReadOnly AccountSvc As AccountService
    Public ReadOnly LogSvc As LogService
    Public ReadOnly PenaltySvc As PenaltyService
    ' === ADDED FOR CREDIT SCORE ===
    Public ReadOnly CreditScoreSvc As CreditScoreService
    ' ==============================

    ' ... other services ...

    ' --- Static Constructor (Runs ONCE) ---
    ' This Sub New now ONLY handles non-UI services
    Sub New()
        Try
            ' 1. Create the ONE database connection object
            mainDbConnection = New DBcon("ooplibrary")

            ' 2. Create all services
            CatSvc = New CatalougeService(mainDbConnection)
            OtpSvc = New OtpService(mainDbConnection)
            NotifSvc = New NotificationService()
            AuthSvc = New AuthService(mainDbConnection, OtpSvc, NotifSvc)
            BorrowSvc = New BorrowService(mainDbConnection)
            AnnounceSvc = New AnnouncementService(mainDbConnection)
            AccountSvc = New AccountService(mainDbConnection)
            LogSvc = New LogService(mainDbConnection)
            PenaltySvc = New PenaltyService(mainDbConnection)
            ' === ADDED FOR CREDIT SCORE ===
            CreditScoreSvc = New CreditScoreService(mainDbConnection)
            ' ==============================

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
    ' --- ADD THIS DECLARATION ---
    Private AdminLibrarianPanel As Home_Panel_Admin_Librarian

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
            StudentPanel = New Home_Panel_Students()
            ' --- ADD THIS INITIALIZATION ---
            AdminLibrarianPanel = New Home_Panel_Admin_Librarian()

            ' --- 3. MODIFIED: Wire up all event handlers ---
            AddHandler GuestPanel.OpenLogin, AddressOf ShowLoginPanel

            ' Connect to the new events from LoginPanel
            AddHandler LoginPanel.RegisterClicked, AddressOf ShowSignupPanel
            ' --- MODIFIED THIS HANDLER ---
            AddHandler LoginPanel.LoginSuccess, AddressOf HandleLoginSuccess

            ' We now listen for our custom "Back" event
            AddHandler SignupPanel.BackToLoginClicked, AddressOf ShowLoginPanelFromSignup
            AddHandler StudentPanel.LogoutClicked, AddressOf ShowGuestPanel

            ' --- ADD THIS HANDLER FOR ADMIN LOGOUT ---
            AddHandler AdminLibrarianPanel.LogoutClicked, AddressOf ShowGuestPanelFromAdmin

            ' 4. Start by showing the Guest Panel
            Application.Run(GuestPanel)

        Catch ex As Exception
            MessageBox.Show("Fatal Error: Could not initialize application UI." & vbCrLf & ex.Message,
                          "Application Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try
    End Sub

    ' --- 4. MODIFIED: All Navigation Subroutines are now Async ---

    ' From Guest Panel -> Login Panel
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

    ' --- THIS IS THE MODIFIED SUBROUTINE ---
    ' From Login Panel (Successful Login) -> Student OR Admin Panel
    Private Async Sub HandleLoginSuccess(sender As Object, loggedInAccount As Account)

        currentAccount = loggedInAccount ' Store the logged-in user

        ' 1. Hide the LoginPanel
        LoginPanel.Hide()

        ' 2. Check the user's role and navigate
        Try
            ' --- ROLE CHECKING LOGIC ---
            If loggedInAccount.Role.Equals("Admin", StringComparison.OrdinalIgnoreCase) OrElse
               loggedInAccount.Role.Equals("Librarian", StringComparison.OrdinalIgnoreCase) Then
                Program.mainDbConnection.ElevateToAdminConnection()
                ' --- ADMIN/LIBRARIAN PATH ---
                ' 1. Show the AdminPanel (triggers "Shown")
                AdminLibrarianPanel.Show()

                ' 2. (ASSUMPTION) No async load, so just bring to front.
                ' If AdminLibrarianPanel gets an AwaitInitialLoad, add it here.
                AdminLibrarianPanel.BringToFront()

            ElseIf loggedInAccount.Role.Equals("Student", StringComparison.OrdinalIgnoreCase) Then

                ' --- STUDENT PATH (Original Code) ---
                ' 2. Show the StudentPanel (triggers "Shown")
                StudentPanel.Show()

                ' --- *** MODIFICATION HERE *** ---
                ' Use the new method to set all student info at once
                StudentPanel.SetStudentName(currentAccount.Name)
                ' --- *** END MODIFICATION *** ---

                ' 3. Home_Panel_Students ALREADY has an async loading method!
                Await StudentPanel.UC_HPS_catalouge_tab1.AwaitInitialLoad()

                ' 4. --- Loading is Complete ---
                StudentPanel.BringToFront()

            Else
                ' --- FALLBACK for unknown roles ---
                MessageBox.Show($"Error: Unknown user role '{loggedInAccount.Role}'. Please contact support.",
                                 "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                LoginPanel.Show() ' Show login panel again
                currentAccount = Nothing ' Clear the invalid account
            End If

            ' --- END OF ROLE CHECKING ---

        Catch ex As Exception
            MessageBox.Show("Error loading user panel: " & ex.Message)
            ' Hide all panels and show login again as a failsafe
            StudentPanel.Hide()
            AdminLibrarianPanel.Hide()
            LoginPanel.Show()
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

    ' --- ADD THIS NEW SUBROUTINE ---
    ' From Admin Panel (Logout) -> Guest Panel
    Private Async Sub ShowGuestPanelFromAdmin(sender As Object, e As EventArgs)
        currentAccount = Nothing ' Clear logged-in user

        ' 1. Get the AdminPanel
        Dim adminForm = CType(sender, Home_Panel_Admin_Librarian)
        mainDbConnection.RevertToKioskConnection()
        ' (ASSUMPTION) Admin panel doesn't have a loading screen
        ' If it did, you would toggle it here.
        ' adminForm.ToggleLoading(True, "Logging out...")

        Try
            ' 2. Show the GuestPanel (triggers "Shown")
            GuestPanel.Show()

            ' 3. Wait for GuestPanel's catalogue to load
            Await GuestPanel.UC_HPS_catalouge_tab1.AwaitInitialLoad()

            ' 4. --- Loading is Complete ---
            adminForm.Hide()
            GuestPanel.BringToFront()

        Catch ex As Exception
            MessageBox.Show("Error loading guest panel: " & ex.Message)
            GuestPanel.Hide()
            adminForm.Show() ' Show admin panel again
        Finally
            ' 5. Hide loading screen (if admin panel had one)
            ' adminForm.ToggleLoading(False)
        End Try
    End Sub

End Module