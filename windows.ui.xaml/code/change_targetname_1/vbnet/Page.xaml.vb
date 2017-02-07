Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetChange_targetname_1_cs>
    Private Sub Start_Animation(ByVal sender As Object, ByVal e As PointerRoutedEventArgs)
        ' If the Storyboard is running and you try to change
        ' properties of its animation objects programmatically, 
        ' an error will occur.
        myStoryboard.Stop()
        ' Get a reference to the rectangle that was clicked.
        Dim myRect As Rectangle = CType(sender, Rectangle)
        ' Change the TargetName of the animation to the name of the
        ' rectangle that was clicked.
        myDoubleAnimation.SetValue(Storyboard.TargetNameProperty, myRect.Name)
        ' Begin the animation.
        myStoryboard.Begin()
    End Sub
    ' </SnippetChange_targetname_1_cs>
End Class