Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetPointanimation_cs>
    ' Start the animation when the object loads
    Private Sub Start_Animation(ByVal sender As Object, ByVal e As EventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetPointanimation_cs>


End Class