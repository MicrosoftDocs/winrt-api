Partial Public Class Page
    Inherits UserControl

    Public Sub New()
        InitializeComponent()
    End Sub

    ' <Snippetmedia_ovw_controlling_media_with_currentstate_code>
    Private Sub StopMedia(ByVal sender As Object, ByVal e As RoutedEventArgs)
        media.Stop()
    End Sub

    Private Sub PauseMedia(ByVal sender As Object, ByVal e As RoutedEventArgs)
        media.Pause()
    End Sub

    Private Sub PlayMedia(ByVal sender As Object, ByVal e As RoutedEventArgs)
        media.Play()
    End Sub
    Private Sub Media_State_Changed(ByVal sender As Object, ByVal e As EventArgs)
        mediaStateTextBlock.Text = media.CurrentState.ToString
    End Sub
    ' </Snippetmedia_ovw_controlling_media_with_currentstate_code>

End Class