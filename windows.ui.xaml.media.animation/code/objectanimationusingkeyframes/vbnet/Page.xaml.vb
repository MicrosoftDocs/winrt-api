Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetObjectanimationusingkeyframes_cs>
    ' When the rectangle loads, begin the animation.
    Private Sub Rectangle_Loaded(ByVal sender As Object, ByVal e As EventArgs)
        myStoryboard.Begin()
    End Sub
    ' </SnippetObjectanimationusingkeyframes_cs>
End Class