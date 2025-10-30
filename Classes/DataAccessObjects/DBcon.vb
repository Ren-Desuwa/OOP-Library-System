' Import the correct MySQL client library
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class DBcon
    Private connection As MySqlConnection
    Private connectionString As String

    Public Sub New(databaseName As String)
        Try
            'hello
            ' --- IMPORTANT ---
            ' Make sure your port is correct. 3307 is common if you have 
            ' multiple MySQL instances, but 3306 is the default.
            '
            ' For testing, you will pass "library_test" as the databaseName.
            ' For your real app, you will pass "library".
            ' ---
            connectionString = $"Server=127.0.0.1;Port=3307;Database={databaseName};Uid=root;Pwd=;"
            connection = New MySqlConnection(connectionString)
        Catch ex As Exception
            ' Throw an exception instead of showing a message box
            Throw New Exception("Error creating connection string: " & ex.Message, ex)
        End Try
    End Sub

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
            ' Throw a specific exception that the service layer can catch
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
            ' This is not critical, so we just log it (for now)
            Console.WriteLine("Error closing connection: " & ex.Message)
            Return False
        End Try
    End Function

    Public Function GetConnection() As MySqlConnection
        If connection Is Nothing OrElse connection.State <> ConnectionState.Open Then
            ' This should not happen if OpenConnection() was called first,
            ' but it's a good safeguard.
            Throw New Exception("Connection is not open or available.")
        End If
        Return connection
    End Function

End Class
