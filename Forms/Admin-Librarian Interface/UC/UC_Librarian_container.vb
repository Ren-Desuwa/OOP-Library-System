Public Class UC_Librarian_container
    Inherits UserControl ' Assuming this inherits from System.Windows.Forms.UserControl

    ' Define custom event the parent tab will listen to
    Public Event Selected As EventHandler

    ' Define colors for selection state
    Private ReadOnly SelectedColor As Color = Color.LightSkyBlue
    Private ReadOnly DefaultColor As Color = SystemColors.ControlLightLight ' A neutral, standard color

    ' Private field for the selection state
    Private _isSelected As Boolean = False

    ''' <summary>
    ''' Public property to get/set the selection state.
    ''' Setting this property triggers the visual color change.
    ''' </summary>
    Public Property IsSelected() As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            If _isSelected = value Then Return

            _isSelected = value

            ' Apply the appropriate color for the new state
            ApplyColor(If(_isSelected, SelectedColor, DefaultColor))
        End Set
    End Property

    ''' <summary>
    ''' Helper to recursively apply color to the container and all its children.
    ''' This prevents labels from hiding the background color.
    ''' </summary>
    Private Sub ApplyColor(ByVal color As Color)
        Me.BackColor = color

        ' IMPORTANT: Change the back color of all child controls as well
        For Each ctrl As Control In Me.Controls
            ' Use TryCast for safety, though it should handle all controls
            ctrl.BackColor = color

            ' If you have nested containers (e.g., Panels inside the UserControl),
            ' you might need to recursively call this for them too, 
            ' but for simple labels, this direct call is sufficient.
        Next
    End Sub

    ' --- Event Forwarding ---

    Private Sub UC_Librarian_container_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial default color
        ApplyColor(DefaultColor)

        ' Attach the main click handler to the container itself
        AddHandler Me.Click, AddressOf Container_Clicked

        ' Attach the main click handler to all child controls 
        ' This ensures clicking on a label or text also counts as a click on the container
        For Each c As Control In Me.Controls
            AddHandler c.Click, AddressOf Container_Clicked
        Next
    End Sub

    ''' <summary>
    ''' Handles any click event fired by the container or its children, 
    ''' and forwards it as a custom 'Selected' event.
    ''' </summary>
    Private Sub Container_Clicked(sender As Object, e As EventArgs)
        RaiseEvent Selected(Me, EventArgs.Empty)
        MessageBox.Show("Librarian container clicked.")
    End Sub

    Private Sub lbl_name_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class