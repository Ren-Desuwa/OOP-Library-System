Imports MySql.Data.MySqlClient

Public Class TransactionDAO
    Private ReadOnly _transaction As MySqlTransaction

    Public Sub New(transaction As MySqlTransaction)
        If transaction Is Nothing Then Throw New ArgumentNullException("transaction")
        _transaction = transaction
    End Sub

    Private Function MapToTransaction(reader As MySqlDataReader) As Transaction
        Return New Transaction With {
            .TransactionID = reader.GetInt32("transaction_id"),
            .AccountID = reader.GetInt32("account_id"),
            .CopyID = If(reader.IsDBNull(reader.GetOrdinal("copy_id")), 0, reader.GetInt32("copy_id")),
            .TransactionType = reader.GetString("transaction_type"),
            .DateBorrowed = If(reader.IsDBNull(reader.GetOrdinal("date_borrowed")), CType(Nothing, DateTime?), reader.GetDateTime("date_borrowed")),
            .DateDue = If(reader.IsDBNull(reader.GetOrdinal("date_due")), CType(Nothing, DateTime?), reader.GetDateTime("date_due")),
            .DateReturned = If(reader.IsDBNull(reader.GetOrdinal("date_returned")), CType(Nothing, DateTime?), reader.GetDateTime("date_returned")),
            .Fine = reader.GetDecimal("fine"),
            .Status = reader.GetString("status")
        }
    End Function

    ' #################### CREATE ####################
    Public Function Create(tx As Transaction) As Integer
        Dim sql = "INSERT INTO transactions (account_id, copy_id, transaction_type, date_borrowed, date_due, date_returned, fine, status) " &
                  "VALUES (@AccountID, @CopyID, @TransactionType, @DateBorrowed, @DateDue, @DateReturned, @Fine, @Status); " &
                  "SELECT LAST_INSERT_ID();"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", tx.AccountID)
            cmd.Parameters.AddWithValue("@CopyID", If(tx.CopyID > 0, CType(tx.CopyID, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@TransactionType", tx.TransactionType)
            cmd.Parameters.AddWithValue("@DateBorrowed", If(tx.DateBorrowed.HasValue, CType(tx.DateBorrowed.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@DateDue", If(tx.DateDue.HasValue, CType(tx.DateDue.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@DateReturned", If(tx.DateReturned.HasValue, CType(tx.DateReturned.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Fine", tx.Fine)
            cmd.Parameters.AddWithValue("@Status", tx.Status)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    ' #################### READ ####################
    Public Function GetById(id As Integer) As Transaction
        Dim sql = "SELECT * FROM transactions WHERE transaction_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            Using reader = cmd.ExecuteReader()
                Return If(reader.Read(), MapToTransaction(reader), Nothing)
            End Using
        End Using
    End Function

    Public Function GetByAccountId(accountId As Integer) As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim sql = "SELECT * FROM transactions WHERE account_id = @AccountID ORDER BY date_borrowed DESC"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", accountId)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    Public Function GetOverdueTransactions() As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim sql = "SELECT * FROM transactions WHERE status = 'Overdue'"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Retrieves pending borrow requests with pagination.
    ''' </summary>
    Public Function GetPendingRequestsPaginated(pageNumber As Integer, pageSize As Integer) As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim offset As Integer = (pageNumber - 1) * pageSize
        Dim sql = "SELECT * FROM transactions WHERE status = 'Pending' " & vbCrLf &
                  "ORDER BY date_borrowed ASC " & vbCrLf &
                  "LIMIT @PageSize OFFSET @Offset"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@PageSize", pageSize)
            cmd.Parameters.AddWithValue("@Offset", offset)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Retrieves active loans with search and pagination, joining book and account details.
    ''' Search terms are applied against Title, Author, Borrower Name, and Transaction Status.
    ''' </summary>
    ''' <summary>

    Public Function SearchPendingRequests(searchTerm As String, pageNumber As Integer, pageSize As Integer) As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim offset As Integer = (pageNumber - 1) * pageSize
        Dim sql As String = ""

        ' Note: Using DISTINCT to avoid duplicate transactions if a book has multiple genres
        sql = "SELECT DISTINCT t.* FROM transactions t " & vbCrLf &
              "INNER JOIN book_copies bc ON t.copy_id = bc.copy_id " & vbCrLf &
              "INNER JOIN books b ON bc.book_id = b.book_id " & vbCrLf &
              "INNER JOIN accounts a ON t.account_id = a.account_id " & vbCrLf &
              "LEFT JOIN book_genres bg ON b.book_id = bg.book_id " & vbCrLf &
              "LEFT JOIN genres g ON bg.genre_id = g.genre_id " & vbCrLf &
              "WHERE (t.status = 'Pending' OR t.status = 'Approved') "

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            ' Search across book title, author, account name/username, and genre name
            sql &= "AND (b.title LIKE @SearchPattern OR b.author LIKE @SearchPattern OR a.name LIKE @SearchPattern OR a.username LIKE @SearchPattern OR g.name LIKE @SearchPattern) "
        End If

        sql &= "ORDER BY t.date_borrowed ASC " & vbCrLf &
               "LIMIT @PageSize OFFSET @Offset"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                cmd.Parameters.AddWithValue("@SearchPattern", "%" & searchTerm & "%")
            End If
            cmd.Parameters.AddWithValue("@PageSize", pageSize)
            cmd.Parameters.AddWithValue("@Offset", offset)

            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function


    ''' <summary>
    ''' Retrieves active loans with search and pagination, joining book and account details.
    ''' Search terms are applied against Borrower Name, Book Title, Author, Genre Name, and Transaction Status.
    ''' </summary>
    Public Function SearchActiveLoans(searchTerm As String, pageNumber As Integer, pageSize As Integer) As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim offset As Integer = (pageNumber - 1) * pageSize
        Dim sql As String = ""

        ' Note: Using DISTINCT to avoid duplicate transactions if a book has multiple genres
        sql = "SELECT DISTINCT t.* FROM transactions t " & vbCrLf &
              "INNER JOIN book_copies bc ON t.copy_id = bc.copy_id " & vbCrLf &
              "INNER JOIN books b ON bc.book_id = b.book_id " & vbCrLf &
              "INNER JOIN accounts a ON t.account_id = a.account_id " & vbCrLf &
              "LEFT JOIN book_genres bg ON b.book_id = bg.book_id " & vbCrLf &
              "LEFT JOIN genres g ON bg.genre_id = g.genre_id " & vbCrLf &
              "WHERE t.date_returned IS NULL AND t.status != 'Rejected' " ' Only active loans

        If Not String.IsNullOrWhiteSpace(searchTerm) Then
            ' Search across book title, author, account name/username, genre name, and status
            sql &= "AND (b.title LIKE @SearchPattern OR b.author LIKE @SearchPattern OR a.name LIKE @SearchPattern OR a.username LIKE @SearchPattern OR g.name LIKE @SearchPattern OR t.status LIKE @SearchPattern) "
        End If

        sql &= "ORDER BY t.date_due ASC " & vbCrLf &
               "LIMIT @PageSize OFFSET @Offset"

        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            If Not String.IsNullOrWhiteSpace(searchTerm) Then
                cmd.Parameters.AddWithValue("@SearchPattern", "%" & searchTerm & "%")
            End If
            cmd.Parameters.AddWithValue("@PageSize", pageSize)
            cmd.Parameters.AddWithValue("@Offset", offset)

            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ' #################### UPDATE ####################
    Public Sub Update(tx As Transaction)
        Dim sql = "UPDATE transactions SET " &
                  "account_id = @AccountID, copy_id = @CopyID, transaction_type = @TransactionType, " &
                  "date_borrowed = @DateBorrowed, date_due = @DateDue, date_returned = @DateReturned, " &
                  "fine = @Fine, status = @Status " &
                  "WHERE transaction_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@AccountID", tx.AccountID)
            cmd.Parameters.AddWithValue("@CopyID", If(tx.CopyID > 0, CType(tx.CopyID, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@TransactionType", tx.TransactionType)
            cmd.Parameters.AddWithValue("@DateBorrowed", If(tx.DateBorrowed.HasValue, CType(tx.DateBorrowed.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@DateDue", If(tx.DateDue.HasValue, CType(tx.DateDue.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@DateReturned", If(tx.DateReturned.HasValue, CType(tx.DateReturned.Value, Object), DBNull.Value))
            cmd.Parameters.AddWithValue("@Fine", tx.Fine)
            cmd.Parameters.AddWithValue("@Status", tx.Status)
            cmd.Parameters.AddWithValue("@Id", tx.TransactionID)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' --- (REMOVED) ---
    ' The problematic 'UpdateTransactionStatusAsync' function was here.
    ' It has been removed as it is inconsistent and not used by the new service logic.
    ' -----------------

    ' #################### DELETE ####################
    Public Sub Delete(id As Integer)
        Dim sql = "DELETE FROM transactions WHERE transaction_id = @Id"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Id", id)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    ' #################### READ - Specialized ####################

    Public Function GetByStatus(status As String) As List(Of Transaction)
        Dim list As New List(Of Transaction)
        Dim sql = "SELECT * FROM transactions WHERE status = @Status"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            cmd.Parameters.AddWithValue("@Status", status)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function

    ''' <summary>
    ''' Retrieves all active loans, meaning the book has not been officially returned 
    ''' and the original request was not rejected.
    ''' Used for the Librarian's "Book Returns" tab.
    ''' </summary>
    Public Function GetActiveLoans() As List(Of Transaction)
        Dim list As New List(Of Transaction)
        ' Filter for transactions where date_returned is NULL (still on loan) 
        ' AND status is not 'Rejected' (to exclude canceled requests).
        Dim sql = "SELECT * FROM transactions WHERE date_returned IS NULL AND status != 'Rejected'"
        Using cmd As New MySqlCommand(sql, _transaction.Connection, _transaction)
            Using reader = cmd.ExecuteReader()
                While reader.Read()
                    list.Add(MapToTransaction(reader))
                End While
            End Using
        End Using
        Return list
    End Function
End Class