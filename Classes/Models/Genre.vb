Public Class Genre
    Public Property GenreID As Integer
    Public Property Name As String
    Public Sub New()
    End Sub
    Public Sub New(name As String)
        Me.Name = name
    End Sub

End Class