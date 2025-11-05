Imports MySql.Data.MySqlClient

Public Class AnnouncementService

    Private ReadOnly _dbCon As DBcon

    Public Sub New(dbConnector As DBcon)
        _dbCon = dbConnector
    End Sub

    ''' <summary>
    ''' Gets a list of all announcements that are currently active and not expired.
    ''' This is the primary method for showing announcements to users.
    ''' </summary>
    Public Function GetActiveAnnouncements() As List(Of Announcement)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            ' 1. Initialize the DAO
            Dim announcementDAO As New AnnouncementDAO(transaction)

            ' 2. Get the data
            Dim announcements = announcementDAO.GetActiveAnnouncements()

            ' 3. This was a read-only operation, so roll back
            transaction.Rollback()
            Return announcements

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error fetching active announcements: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ' --- ADMIN/LIBRARIAN METHODS ---

    ''' <summary>
    ''' Creates a new announcement and logs the action.
    ''' </summary>
    ''' <param name="announcement">The Announcement object to create.</param>
    ''' <param name="adminAccountId">The ID of the admin creating the post (for logging).</param>
    ''' <returns>The ID of the newly created announcement.</returns>
    Public Function CreateAnnouncement(announcement As Announcement, adminAccountId As Integer) As Integer
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim announcementDAO As New AnnouncementDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Create the announcement
            Dim newId As Integer = announcementDAO.Create(announcement)
            announcement.AnnouncementID = newId

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Announcement Create", $"New announcement created: '{announcement.Title}'", "Info"))

            ' 3. Commit
            transaction.Commit()
            Return newId

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error creating announcement: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Function

    ''' <summary>
    ''' Updates an existing announcement and logs the action.
    ''' </summary>
    ''' <param name="announcement">The Announcement object with updated details.</param>
    ''' <param name="adminAccountId">The ID of the admin making the change (for logging).</param>
    Public Sub UpdateAnnouncement(announcement As Announcement, adminAccountId As Integer)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim announcementDAO As New AnnouncementDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Update the announcement
            announcementDAO.Update(announcement)

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Announcement Update", $"Announcement updated: '{announcement.Title}' (ID: {announcement.AnnouncementID})", "Info"))

            ' 3. Commit
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error updating announcement: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub


    ''' <summary>
    ''' Deletes an announcement and logs the action.
    ''' </summary>
    ''' <param name="announcementId">The ID of the announcement to delete.</param>
    ''' <param name="adminAccountId">The ID of the admin deleting the post (for logging).</param>
    ''' <param name="announcementTitle">The title of the post (for logging purposes).</param>
    Public Sub DeleteAnnouncement(announcementId As Integer, adminAccountId As Integer, announcementTitle As String)
        If Not _dbCon.OpenConnection() Then
            Throw New Exception("Could not connect to the database.")
        End If

        Dim transaction As MySqlTransaction = _dbCon.GetConnection().BeginTransaction()

        Try
            Dim announcementDAO As New AnnouncementDAO(transaction)
            Dim logDAO As New LogDAO(transaction)

            ' 1. Delete the announcement
            announcementDAO.Delete(announcementId)

            ' 2. Log the action
            logDAO.Create(Log.RecordAction(adminAccountId, "Announcement Delete", $"Announcement deleted: '{announcementTitle}' (ID: {announcementId})", "Warning"))

            ' 3. Commit
            transaction.Commit()

        Catch ex As Exception
            transaction.Rollback()
            Throw New Exception("Error deleting announcement: " & ex.Message)
        Finally
            _dbCon.CloseConnection()
        End Try
    End Sub

End Class