Imports MySql.Data.MySqlClient

Public Class AccountDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToAccount(reader As MySqlDataReader) As Account
        ' Get ordinals for safety, especially for nullable fields
        Dim colEmail = reader.GetOrdinal("email")
        Dim colContactNumber = reader.GetOrdinal("contact_number")
        Dim colBirthday = reader.GetOrdinal("birthday")
        Dim colFavBookDesign = reader.GetOrdinal("fav_book_design")
        Dim colStudentID = reader.GetOrdinal("student_id")

        Return New Account With {
            .AccountID = reader.GetInt32("account_id"),
            .Username = reader.GetString("username"),
            .PasswordHash = reader.GetString("password_hash"),
            .Role = reader.GetString("role"),
            .Name = reader.GetString("name"),
            .StudentID = If(reader.IsDBNull(colStudentID), Nothing, reader.GetString(colStudentID)),
            .Email = If(reader.IsDBNull(colEmail), Nothing, reader.GetString(colEmail)),
            .ContactNumber = If(reader.IsDBNull(colContactNumber), Nothing, reader.GetString(colContactNumber)),
            .Birthday = If(reader.IsDBNull(colBirthday), CType(Nothing, Date?), reader.GetDateTime(colBirthday)),
            .FavBookDesign = If(reader.IsDBNull(colFavBookDesign), False, reader.GetBoolean(colFavBookDesign)),
            .DateCreated = reader.GetDateTime("date_created"),
            .IsActive = reader.GetBoolean("is_active")
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(account As Account) As Integer
        ' --- REFACTORED SQL STRING ---
        Dim sql = "INSERT INTO accounts (username, password_hash, role, name, student_id, email, contact_number, birthday, fav_book_design, date_created, is_active) " & vbCrLf &
                  "VALUES (@Username, @PasswordHash, @Role, @Name, @StudentID, @Email, @ContactNumber, @Birthday, @FavBookDesign, @DateCreated, @IsActive);" & vbCrLf &
                  "SELECT LAST_INSERT_ID();"
        ' ----------------------------
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Username", account.Username)
            cmd.Parameters.AddWithValue("@PasswordHash", account.PasswordHash)
            cmd.Parameters.AddWithValue("@Role", account.Role)
            cmd.Parameters.AddWithValue("@Name", account.Name)
            cmd.Parameters.AddWithValue("@StudentID", If(account.StudentID Is Nothing, CType(DBNull.Value, Object), account.StudentID))
            ' Handle null values correctly for email and phone
            cmd.Parameters.AddWithValue("@Email", If(account.Email Is Nothing, CType(DBNull.Value, Object), account.Email))
            cmd.Parameters.AddWithValue("@ContactNumber", If(account.ContactNumber Is Nothing, CType(DBNull.Value, Object), account.ContactNumber))
            cmd.Parameters.AddWithValue("@Birthday", If(account.Birthday.HasValue, CType(account.Birthday.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@FavBookDesign", account.FavBookDesign)
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

    Public Function GetByStudentID(student_id As String) As Account
        Dim sql = "SELECT * FROM accounts WHERE student_id = @Student_ID"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Student_ID", student_id)
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

    Public Function GetByEmail(email As String) As Account
        Dim sql = "SELECT * FROM accounts WHERE email = @Email"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Email", email)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToAccount(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByContactNumber(contact As String) As Account
        Dim sql = "SELECT * FROM accounts WHERE contact_number = @Contact_Number"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Contact_Number", contact)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToAccount(reader), Nothing)
            End Using
        End Using
    End Function


    ' #################### READ - Specialized ####################
    ''' <summary>
    ''' Retrieves the list of books marked as "displayed" for a specific account.
    ''' NOTE: This now fetches minimal data (only for cover image display).
    ''' </summary>
    Public Function GetDisplayedBooks(accountId As Integer) As List(Of Book)
        Dim booksToDisplay As New List(Of Book)

        ' --- REFACTORED SQL STRING ---
        Dim query As String =
                "SELECT b.* " & vbCrLf &
                "FROM books b " & vbCrLf &
                "INNER JOIN favorites fav ON b.book_id = fav.book_id " & vbCrLf &
                "WHERE fav.account_id = @account_id " & vbCrLf &
                "ORDER BY fav.display_order ASC " & vbCrLf &
                "LIMIT 3"
        ' ----------------------------

        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@account_id", accountId)
            Using reader As MySqlDataReader = cmd.ExecuteReader()

                ' Get column indexes for nullable fields (still required for b.*)
                Dim colPublisher = reader.GetOrdinal("publisher")
                Dim colYearPublished = reader.GetOrdinal("year_published")
                Dim colDescription = reader.GetOrdinal("description")
                Dim colCoverUrl = reader.GetOrdinal("cover_url")

                While reader.Read()
                    ' Map data to Book object, omitting TotalCopies and AvailableCopies
                    Dim book = New Book() With {
                        .BookID = reader.GetInt32("book_id"),
                        .Title = reader.GetString("title"),
                        .Author = reader.GetString("author"),
                        .ISBN = reader.GetString("isbn"),
                        .Publisher = If(reader.IsDBNull(colPublisher), Nothing, reader.GetString(colPublisher)),
                        .YearPublished = If(reader.IsDBNull(colYearPublished), 0, reader.GetInt32(colYearPublished)),
                        .Description = If(reader.IsDBNull(colDescription), Nothing, reader.GetString(colDescription)),
                        .CoverUrl = If(reader.IsDBNull(colCoverUrl), Nothing, reader.GetString(colCoverUrl))
                    }
                    booksToDisplay.Add(book)
                End While
            End Using
        End Using

        Return booksToDisplay
    End Function

    ''' <summary>
    ''' Retrieves a list of book IDs currently marked as favorites/displayed by the account.
    ''' </summary>
    Public Function GetFavoriteBookIds(accountId As Integer) As HashSet(Of Integer)
        Dim bookIds As New HashSet(Of Integer)

        Dim query As String = "SELECT book_id FROM favorites WHERE account_id = @account_id"

        Using cmd As New MySqlCommand(query, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@account_id", accountId)
            Using reader As MySqlDataReader = cmd.ExecuteReader()
                While reader.Read()
                    bookIds.Add(reader.GetInt32("book_id"))
                End While
            End Using
        End Using

        Return bookIds
    End Function


    ' #################### UPDATE - Specialized ####################

    ''' <summary>
    ''' Performs a transactional update: deletes all current favorites for the user, then inserts the new list.
    ''' </summary>
    Public Sub UpdateDisplayedBooks(accountId As Integer, bookIds As List(Of Integer))
        ' 1. Delete all old entries for this user
        Dim deleteQuery As String = "DELETE FROM favorites WHERE account_id = @account_id"
        Using cmdDelete As New MySqlCommand(deleteQuery, _transaction.Connection, _transaction)
            cmdDelete.Parameters.AddWithValue("@account_id", accountId)
            cmdDelete.ExecuteNonQuery()
        End Using

        ' 2. Insert the new selected books (up to 3)
        If bookIds.Count > 0 Then
            Dim insertQuery As String = "INSERT INTO favorites (account_id, book_id, display_order) VALUES (@account_id, @book_id, @order)"
            Dim order As Integer = 1

            For Each bookId As Integer In bookIds
                Using cmdInsert As New MySqlCommand(insertQuery, _transaction.Connection, _transaction)
                    cmdInsert.Parameters.AddWithValue("@account_id", accountId)
                    cmdInsert.Parameters.AddWithValue("@book_id", bookId)
                    cmdInsert.Parameters.AddWithValue("@order", order)
                    cmdInsert.ExecuteNonQuery()
                End Using
                order += 1
            Next
        End If
    End Sub

    ' #################### UPDATE ####################
    Public Sub Update(account As Account)
        ' --- REFACTORED SQL STRING ---
        Dim sql = "UPDATE accounts SET " & vbCrLf &
                  "username = @Username, password_hash = @PasswordHash, role = @Role, " & vbCrLf &
                  "name = @Name, student_id = @StudentID, email = @Email, contact_number = @ContactNumber, " & vbCrLf &
                  "birthday = @Birthday, fav_book_design = @FavBookDesign, is_active = @IsActive " & vbCrLf &
                  "WHERE account_id = @Id"
        ' ----------------------------
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Username", account.Username)
            cmd.Parameters.AddWithValue("@PasswordHash", account.PasswordHash)
            cmd.Parameters.AddWithValue("@Role", account.Role)
            cmd.Parameters.AddWithValue("@Name", account.Name)
            cmd.Parameters.AddWithValue("@StudentID", If(account.StudentID Is Nothing, CType(DBNull.Value, Object), account.StudentID))
            cmd.Parameters.AddWithValue("@Email", If(account.Email Is Nothing, CType(DBNull.Value, Object), account.Email))
            cmd.Parameters.AddWithValue("@ContactNumber", If(account.ContactNumber Is Nothing, CType(DBNull.Value, Object), account.ContactNumber))
            cmd.Parameters.AddWithValue("@Birthday", If(account.Birthday.HasValue, CType(account.Birthday.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@FavBookDesign", account.FavBookDesign)
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