Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Windows.Forms

Partial Public Class UC_Librarian_container
    Inherits UserControl

    ' --- Public event and selection property used by the parent tab ---
    Public Event Selected As EventHandler

    Private _isSelected As Boolean = False
    Public Property IsSelected As Boolean
        Get
            Return _isSelected
        End Get
        Set(value As Boolean)
            If _isSelected = value Then Return
            _isSelected = value
            UpdateVisualSelection()
        End Set
    End Property

    ' Colors (tweak to taste)
    Private ReadOnly SelectedColor As Color = Color.FromArgb(191, 220, 220, 220)
    Private ReadOnly DefaultColor As Color = Color.Transparent

    Public Sub New()
        InitializeComponent()
        ' ensure initial visuals are correct
        ApplyColor(DefaultColor)
    End Sub

    ' Called when selection changes
    Private Sub UpdateVisualSelection()
        If _isSelected Then
            ApplyColor(SelectedColor)
        Else
            ApplyColor(DefaultColor)
        End If
    End Sub

    ' Apply color to control and its children so labels/panels don't obscure it
    Private Sub ApplyColor(col As Color)
        Me.BackColor = col
        For Each c As Control In Me.Controls
            ' Only change background of controls that allow it
            Try
                c.BackColor = col
            Catch
                ' ignore controls that throw
            End Try
        Next
    End Sub

    ' Ensure all clicks inside the usercontrol (including child controls) trigger selection
    Private Sub UC_Librarian_container_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddClickHandlerRecursive(Me)
    End Sub

    Private Sub AddClickHandlerRecursive(parent As Control)
        ' attach to parent first
        RemoveHandler parent.Click, AddressOf Container_Clicked
        AddHandler parent.Click, AddressOf Container_Clicked

        For Each c As Control In parent.Controls
            AddClickHandlerRecursive(c)
        Next
    End Sub

    Private Sub Container_Clicked(sender As Object, e As EventArgs)
        MessageBox.Show("Librarian container clicked: " & Me.lbl_name.Text)
        RaiseEvent Selected(Me, EventArgs.Empty)
    End Sub

    ' Add this code inside your "Partial Public Class UC_Librarian_container"
    '

    ' --- Public Properties for setting data ---

    <Category("Data")>
    Public Property LibrarianName As String
        Get
            ' Assumes your label is named lbl_name, as seen in
            Return Me.lbl_name.Text
        End Get
        Set(value As String)
            Me.lbl_name.Text = value
        End Set
    End Property

    <Category("Data")>
    Public Property Email As String
        Get
            ' Assumes your label is named lbl_email based on
            Return Me.lbl_email.Text
        End Get
        Set(value As String)
            Me.lbl_email.Text = value
        End Set
    End Property

    <Category("Data")>
    Public Property Status As String
        Get
            ' Assumes your label is named Label1 based on
            Return Me.Label1.Text
        End Get
        Set(value As String)
            Me.Label1.Text = value
        End Set
    End Property

End Class
