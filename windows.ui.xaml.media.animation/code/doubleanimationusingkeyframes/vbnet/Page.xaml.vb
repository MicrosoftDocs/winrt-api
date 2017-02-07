Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetDoubleanimationusingkeyframes_cs>
    ' When the user clicks the Rectangle, the animation
    ' begins.
    Private Sub Pointer_Clicked(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetDoubleanimationusingkeyframes_cs>


End Class