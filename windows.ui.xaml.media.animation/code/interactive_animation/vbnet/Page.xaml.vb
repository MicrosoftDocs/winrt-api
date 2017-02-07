Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <SnippetInteractive_animation_cs>
    Private Sub Animation_Begin(sender As Object, e As RoutedEventArgs)
        myStoryboard.Begin()
    End Sub

    Private Sub Animation_Pause(sender As Object, e As RoutedEventArgs)
        myStoryboard.Pause()
    End Sub

    Private Sub Animation_Resume(sender As Object, e As RoutedEventArgs)
        myStoryboard.Resume()
    End Sub

    Private Sub Animation_Stop(sender As Object, e As RoutedEventArgs)
        myStoryboard.Stop()
    End Sub
    ' </SnippetInteractive_animation_cs>

End Class