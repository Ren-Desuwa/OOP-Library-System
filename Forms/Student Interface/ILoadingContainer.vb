Public Interface ILoadingContainer
    ''' <summary>
    ''' A method to show or hide a loading panel.
    ''' </summary>
    Sub ToggleLoading(isLoading As Boolean, Optional message As String = "Loading...")
End Interface
