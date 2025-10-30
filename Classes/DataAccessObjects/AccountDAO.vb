Imports MySql.Data.MySqlClient

Public Class AccountDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToAccount(reader As MySqlDataReader) As Account
        Return New Account With {
            .AccountID = reader.GetInt32("account_id"),
            .Username = reader.GetString("username"),
            .PasswordHash = reader.GetString("password_hash"),
            .Role = reader.GetString("role"),
            .Name = reader.GetString("name"),
            .Email = reader.GetString("email"),
            .DateCreated = reader.GetDateTime("date_created"),
            .IsActive = reader.GetBoolean("is_active")
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(account As Account) As Integer
        Dim sql = "INSERT INTO accounts (username, password_hash, role, name, email, date_created, is_active) " &
                  "VALUES (@Username, @PasswordHash, @Role, @Name, @Email, @DateCreated, @IsActive); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Username", account.Username)
            cmd.Parameters.AddWithValue("@PasswordHash", account.PasswordHash)
            cmd.Parameters.AddWithValue("@Role", account.Role)
            cmd.Parameters.AddWithValue("@Name", account.Name)
            cmd.Parameters.AddWithValue("@Email", account.Email)
            cmd.Parameters.AddWithValue("@DateCreated", account.DateCreated)
            cmd.Parameters.AddWithValue("@IsActive", account.IsActive)

            ' Return the new ID
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Account
        Dim sql = "SELECT * FROM accounts WHERE account_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToAccount(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByUsername(username As String) As Account
        Dim sql = "SELECT * FROM accounts WHERE username = @Username"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Username", username)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToAccount(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetAll() As List(Of Account)
        Dim list As New List(Of Account)
        Dim sql = "SELECT * FROM accounts"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToAccount(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(account As Account)
        Dim sql = "UPDATE accounts SET " &
                  "username = @Username, password_hash = @PasswordHash, role = @Role, " &
                  "name = @Name, email = @Email, is_active = @IsActive " &
                  "WHERE account_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Username", account.Username)
            cmd.Parameters.AddWithValue("@PasswordHash", account.PasswordHash)
            cmd.Parameters.AddWithValue("@Role", account.Role)
            cmd.Parameters.AddWithValue("@Name", account.Name)
            cmd.Parameters.AddWithValue("@Email", account.Email)
            cmd.Parameters.AddWithValue("@IsActive", account.IsActive)
            cmd.Parameters.AddWithValue("@Id", account.AccountID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        ' Note: ON DELETE CASCADE will handle related records
        Dim sql = "DELETE FROM accounts WHERE account_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub
End Class