Partial Public Class MainPage
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub




    ' <SnippetQuinticEase_code>
    ' When the user clicks the rectangle, the animation
    ' begins. 
    Private Sub Pointer_Clicked(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetQuinticEase_code>


End Class