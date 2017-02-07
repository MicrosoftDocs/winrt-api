Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetColoranimation_direct_targeting_cs>
    ' Start the animation when the object loads
    Private Sub Start_Animation(ByVal sender As Object, ByVal e As EventArgs)
        colorStoryboard.Begin()
    End Sub
    ' </SnippetColoranimation_direct_targeting_cs>
End Class