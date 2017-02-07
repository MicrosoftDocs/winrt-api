Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub
    ' <SnippetAnimation_ovw_intro_code>
    ' When the user clicks the Rectangle, the animation
    ' begins.
    Private Sub Pointer_Clicked(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetAnimation_ovw_intro_code>
End Class