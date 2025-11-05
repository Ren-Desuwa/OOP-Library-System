' (Modified)
Imports Classes.Models

Public Class UC_announcementBox

    ''' <summary>
    ''' Populates the user control's fields with data from an Announcement object.
    ''' </summary>
    ''' <param name="announcement">The Announcement object containing the data.</param>
    Public Sub Populate(ByVal announcement As Announcement)
        ' Assuming your controls are named Title, Message, and DatePosted
        ' (based on your original code in UC_HPS_home_tab.vb)
        Me.Title.Text = announcement.Title           '
        Me.Message.Text = announcement.Message         '
        Me.DatePosted.Text = announcement.DatePosted.ToShortDateString() '
    End Sub

End Class