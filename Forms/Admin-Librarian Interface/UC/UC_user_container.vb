Imports System.Drawing
Imports System.Windows.Forms

Public Class UC_user_container

    Private _account As Account
    Private _isSelected As Boolean = False

    ''' <summary>
    ''' Raised when this control is clicked.
    ''' </summary>
    Public Event Selected As EventHandler

    ''' <summary>
    ''' Exposes the Account object this control represents.
    ''' </summary>
    Public ReadOnly Property Account As Account
        Get
            Return _account
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
            ' (Assuming your main panel is named pnl_container)
            If _isSelected Then
                pnl_container.FillColor = Color.Gainsboro ' Selected color
            Else
                pnl_container.FillColor = Color.Transparent ' Default color
            End If
        End Set
    End Property

    ''' <summary>
    ''' Stores the account data AND applies it to the UI controls.
    ''' This MUST be called from the UI thread.
    ''' </summary>
    Public Sub SetData(ByVal account As Account)
        _account = account ' Store the account object

        If _account IsNot Nothing Then
            ' Set the text for the labels based on the Account's properties
            ' (Assuming your label names are lbl_Name, lbl_StudentID, lbl_Email)
            lbl_name.Text = "Name: " & _account.Name
            lbl_StudentID.Text = "Student ID: " & If(String.IsNullOrEmpty(_account.StudentID), "N/A", _account.StudentID)
            lbl_email.Text = "Email: " & If(String.IsNullOrEmpty(_account.Email), "N/A", _account.Email)
        Else
            ' Set default text if no account data
            lbl_name.Text = "Name: N/A"
            lbl_StudentID.Text = "Student ID: N/A"
            lbl_email.Text = "Email: N/A"
        End If
    End Sub

    ''' <summary>
    ''' Handles clicks on the main panel AND LABELS and raises the Selected event.
    ''' </summary>
    Private Sub Control_Click(sender As Object, e As EventArgs) Handles Me.Click,
                                                                        pnl_container.Click,
                                                                        lbl_name.Click,
                                                                        lbl_StudentID.Click,
                                                                        lbl_email.Click
        ' (Add any other clickable controls like TableLayoutPanels here)

        RaiseEvent Selected(Me, EventArgs.Empty)
    End Sub

End Class