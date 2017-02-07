Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetColoranimationusingkeyframes_cs>
    ' Start the animation when the object loads
    Private Sub Start_Animation(ByVal sender As Object, ByVal e As EventArgs)
        colorStoryboard.Begin()
    End Sub
    ' </SnippetColoranimationusingkeyframes_cs>

End Class