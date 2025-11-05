Imports System.Drawing

Public Class UC_Librarian_container

    ' Stores the data for this specific control
    ' We use the Account model, as a "Librarian" is an Account with a specific role
    Private _librarian As Account '
    Private _isSelected As Boolean = False

    ''' <summary>
    ''' Raised when this control is clicked.
    ''' </summary>
    Public Event Selected As EventHandler

    ''' <summary>
    ''' Exposes the Account object this control represents.
    ''' </summary>
    Public ReadOnly Property Librarian As Account
        Get
            Return _librarian
        End Get
    End Property

    ''' <summary>
    ''' Gets or sets the selection state, updating the UI.
    ''' </summary>
    Public Property IsSelected As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            _isSelected = value
            ' Change color based on selection
            If _isSelected Then
                pnl_table_container.FillColor = Color.Gainsboro ' Selected color [cite: 264]
            Else
                pnl_table_container.FillColor = Color.Transparent ' Default color [cite: 264]
            End If
        End Set
    End Property

    ''' <summary>
    ''' Stores the librarian data AND applies it to the UI controls.
    ''' This MUST be called from the UI thread.
    ''' </summary>
    Public Sub SetData(ByVal lib As Account)
        _librarian = lib ' Store the librarian object

        If _librarian IsNot Nothing Then
            ' Set the text for the labels based on the Account's properties
            lbl_name.Text = "Name: " + _librarian.Name ' [cite: 267]
            lbl_birthday.Text = "Birthday: " + If(_librarian.Birthday.HasValue, _librarian.Birthday.Value.ToShortDateString(), "N/A") ' [cite: 269]
            lbl_email.Text = "Email: " + _librarian.Email ' [cite: 271]
            lbl_contact.Text = "Contact: " + _librarian.ContactNumber ' [cite: 273]
        Else
            ' Set default text if no data
            lbl_name.Text = "Name: N/A" ' [cite: 267]
            lbl_birthday.Text = "Birthday: N/A" ' [cite: 269]
            lbl_email.Text = "Email: N/A" ' [cite: 271]
            lbl_contact.Text = "Contact: N/A" ' [cite: 273]
        End If
    End Sub

    ''' <summary>
    ''' Handles clicks on the main panel AND LABELS and raises the Selected event.
    ''' </summary>
    Private Sub Control_Click(sender As Object, e As EventArgs) Handles pnl_table_container.Click,
                                                                        TableLayoutPanel1.Click,
                                                                        lbl_name.Click,
                                                                        lbl_birthday.Click,
                                                                        lbl_email.Click,
                                                                        lbl_contact.Click,
                                                                        Me.Click
        ' Raise the event so the parent (UC_HPAL_Librarian_Tab) can handle it
        RaiseEvent Selected(Me, EventArgs.Empty)
    End Sub
End Class