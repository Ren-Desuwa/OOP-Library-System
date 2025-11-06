' Import the correct MySQL client library
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DBcon
    Private connection As MySqlConnection
    Private connectionString As String
    Private currentRole As ConnectionRole

    ' --- NEW: Store these for rebuilding connections ---
    Private appDbName As String
    Private Const KIOSK_SERVER_IP As String = "10.207.186.185" ' !! PUT YOUR SERVER IP HERE !!
    Private Const KIOSK_PASSWORD As String = "bantutan123" ' !! PUT KIOSK PASSWORD HERE !!

    Public Enum ConnectionRole
        Kiosk
        Admin
    End Enum

    ' --- MODIFIED CONSTRUCTOR ---
    ' It now saves the dbName and prepares the *initial* kiosk connection
    Public Sub New(databaseName As String)
        Try
            Me.appDbName = databaseName

            ' --- The app ALWAYS starts as Kiosk ---
            Me.connectionString = BuildConnectionString(ConnectionRole.Kiosk)
            Me.currentRole = ConnectionRole.Kiosk
            Me.connection = New MySqlConnection(connectionString)

        Catch ex As Exception
            Throw New Exception("Error creating initial connection string: " & ex.Message, ex)
        End Try
    End Sub

    ' --- NEW HELPER FUNCTION ---
    ' Creates the correct connection string based on the role
    Private Function BuildConnectionString(role As ConnectionRole) As String
        Select Case role
            Case ConnectionRole.Admin


                Return $"Server=127.0.0.1;Port=3306;Database={appDbName};Uid=root;Pwd=;"
            Case Else ' Default to Kiosk

                Return $"Server={KIOSK_SERVER_IP};Port=3306;Database={appDbName};Uid=kiosk_user;Pwd={KIOSK_PASSWORD};"
        End Select
    End Function

    ' --- !!! NEW PUBLIC METHOD !!! ---
    ' This is called by AuthService AFTER a librarian logs in
    Public Sub ElevateToAdminConnection()
        If currentRole = ConnectionRole.Admin Then
            Return ' Already admin
        End If

        Try
            ' 1. Close the old (kiosk) connection
            CloseConnection()

            ' 2. Build the new (admin) connection string
            Me.connectionString = BuildConnectionString(ConnectionRole.Admin)
            Me.currentRole = ConnectionRole.Admin
            Me.connection = New MySqlConnection(connectionString)

            ' 3. Open the new connection
            OpenConnection()
            Console.WriteLine("Connection ELEVATED to Admin (root@localhost)")

        Catch ex As Exception
            Throw New Exception("Failed to elevate connection to Admin: " & ex.Message, ex)
        End Try
    End Sub

    ' --- !!! NEW PUBLIC METHOD !!! ---
    ' This is called when the librarian logs OUT
    Public Sub RevertToKioskConnection()
        If currentRole = ConnectionRole.Kiosk Then
            Return ' Already kiosk
        End If

        Try
            ' 1. Close the old (admin) connection
            CloseConnection()

            ' 2. Build the new (kiosk) connection string
            Me.connectionString = BuildConnectionString(ConnectionRole.Kiosk)
            Me.currentRole = ConnectionRole.Kiosk
            Me.connection = New MySqlConnection(connectionString)

            ' 3. Open the new connection
            OpenConnection()
            Console.WriteLine("Connection REVERTED to Kiosk")

        Catch ex As Exception
            Throw New Exception("Failed to revert connection to Kiosk: " & ex.Message, ex)
        End Try
    End Sub


    ' --- NO CHANGES to OpenConnection or CloseConnection ---
    Public Function OpenConnection() As Boolean
        Try
            If connection IsNot Nothing AndAlso connection.State <> ConnectionState.Open Then
                connection.Open()
                Return True
            ElseIf connection Is Nothing Then
                Throw New Exception("Connection object is not initialized.")
            End If

            Return True ' Already open
        Catch ex As Exception
            Throw New Exception("Cannot connect to the database. Error: " & ex.Message, ex)
        End Try
    End Function

    Public Function CloseConnection() As Boolean
        Try
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
            Return True
        Catch ex As MySqlException
            Console.WriteLine("Error closing connection: " & ex.Message)
            Return False
        End Try
    End Function

    ' --- MODIFIED GetConnection ---
    ' This is now "smarter" and will auto-open if the connection is closed.
    Public Function GetConnection() As MySqlConnection
        If connection Is Nothing Then
            Throw New Exception("Connection object is not initialized.")
        End If

        ' Auto-open if it's not open
        If connection.State <> ConnectionState.Open Then
            Try
                Console.WriteLine("Connection was closed. Re-opening...")
                connection.Open()
            Catch ex As Exception
                Throw New Exception("Connection was closed and failed to re-open. Error: " & ex.Message, ex)
            End Try
        End If

        Return connection
    End Function

End Class