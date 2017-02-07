' The Blank Page item template is documented at http:'go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    ''' <summary>
    ''' Invoked when this page is about to be displayed in a Frame.
    ''' </summary>
    ''' <param name="e">Event data that describes how this page was reached.  The Parameter
    ''' property is typically used to configure the page.</param>
    Protected Overrides Sub OnNavigatedTo(e As Navigation.NavigationEventArgs)

    End Sub


    ' <SnippetStartAndStop>
    Private receiver As Windows.Media.PlayTo.PlayToReceiver
    Private display As Windows.System.Display.DisplayRequest
    Private seeking As Boolean = False

    Private Async Sub StartReceiverButton_Click()
        Try
            If receiver Is Nothing Then
                receiver = New Windows.Media.PlayTo.PlayToReceiver()
            End If

            ' Add Play To Receiver events and properties
            AddHandler receiver.CurrentTimeChangeRequested, AddressOf receiver_CurrentTimeChangeRequested
            AddHandler receiver.MuteChangeRequested, AddressOf receiver_MuteChangeRequested
            AddHandler receiver.PauseRequested, AddressOf receiver_PauseRequested
            AddHandler receiver.PlaybackRateChangeRequested, AddressOf receiver_PlaybackRateChangeRequested
            AddHandler receiver.PlayRequested, AddressOf receiver_PlayRequested
            AddHandler receiver.SourceChangeRequested, AddressOf receiver_SourceChangeRequested
            AddHandler receiver.StopRequested, AddressOf receiver_StopRequested
            AddHandler receiver.TimeUpdateRequested, AddressOf receiver_TimeUpdateRequested
            AddHandler receiver.VolumeChangeRequested, AddressOf receiver_VolumeChangeRequested

            ' <SnippetProperties>
            receiver.FriendlyName = "Sample Play To Receiver"
            receiver.SupportsAudio = False
            receiver.SupportsVideo = True
            receiver.SupportsImage = False
            ' </SnippetProperties>

            ' Add MediaElement events
            AddHandler VideoPlayer.CurrentStateChanged, AddressOf VideoPlayer_CurrentStateChanged
            AddHandler VideoPlayer.MediaEnded, AddressOf VideoPlayer_MediaEnded
            AddHandler VideoPlayer.MediaFailed, AddressOf VideoPlayer_MediaFailed
            AddHandler VideoPlayer.MediaOpened, AddressOf VideoPlayer_MediaOpened
            AddHandler VideoPlayer.RateChanged, AddressOf VideoPlayer_RateChanged
            AddHandler VideoPlayer.SeekCompleted, AddressOf VideoPlayer_SeekCompleted
            AddHandler VideoPlayer.VolumeChanged, AddressOf VideoPlayer_VolumeChanged

            ' <SnippetStartAsync>
            ' Advertise the receiver on the local network and start receiving commands
            Await receiver.StartAsync()

            ' Prevent the screen from locking
            If display Is Nothing Then
                display = New Windows.System.Display.DisplayRequest()
                display.RequestActive()

                StatusTextBlock.Text = "'" & receiver.FriendlyName & "' started."
            End If
            ' </SnippetStartAsync>
        Catch
            receiver = Nothing
            StatusTextBlock.Text = "Failed to start receiver. "
        End Try
    End Sub

    Private Async Sub StopReceiverButton_Click()
        Try
            ' <SnippetStopAsync>
            If receiver IsNot Nothing Then
                Await receiver.StopAsync()

                If display IsNot Nothing Then display.RequestRelease()

                ' Remove Play To Receiver events
                RemoveHandler receiver.CurrentTimeChangeRequested, AddressOf receiver_CurrentTimeChangeRequested
                RemoveHandler receiver.MuteChangeRequested, AddressOf receiver_MuteChangeRequested
                RemoveHandler receiver.PauseRequested, AddressOf receiver_PauseRequested
                RemoveHandler receiver.PlaybackRateChangeRequested, AddressOf receiver_PlaybackRateChangeRequested
                RemoveHandler receiver.PlayRequested, AddressOf receiver_PlayRequested
                RemoveHandler receiver.SourceChangeRequested, AddressOf receiver_SourceChangeRequested
                RemoveHandler receiver.StopRequested, AddressOf receiver_StopRequested
                RemoveHandler receiver.TimeUpdateRequested, AddressOf receiver_TimeUpdateRequested
                RemoveHandler receiver.VolumeChangeRequested, AddressOf receiver_VolumeChangeRequested

                '  Remove MediaElement events
                VideoPlayer.Pause()

                RemoveHandler VideoPlayer.CurrentStateChanged, AddressOf VideoPlayer_CurrentStateChanged
                RemoveHandler VideoPlayer.MediaEnded, AddressOf VideoPlayer_MediaEnded
                RemoveHandler VideoPlayer.MediaFailed, AddressOf VideoPlayer_MediaFailed
                RemoveHandler VideoPlayer.MediaOpened, AddressOf VideoPlayer_MediaOpened
                RemoveHandler VideoPlayer.RateChanged, AddressOf VideoPlayer_RateChanged
                RemoveHandler VideoPlayer.SeekCompleted, AddressOf VideoPlayer_SeekCompleted
                RemoveHandler VideoPlayer.VolumeChanged, AddressOf VideoPlayer_VolumeChanged

                StatusTextBlock.Text = "Stopped '" & receiver.FriendlyName & "'."
            End If
            ' </SnippetStopAsync>
        Catch
            StatusTextBlock.Text = "Failed to stop '" & receiver.FriendlyName & "'."
        End Try
    End Sub
    ' </SnippetStartAndStop>

    ' <SnippetReceiverEvents>
    ' <SnippetCurrentTimeChangeRequested>
    Async Sub receiver_CurrentTimeChangeRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Windows.Media.PlayTo.CurrentTimeChangeRequestedEventArgs)
        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.Position = args.Time
                receiver.NotifySeeking()
                seeking = True
            End Sub)
    End Sub
    ' </SnippetCurrentTimeChangeRequested>

    ' <SnippetMuteChangeRequested>
    Async Sub receiver_MuteChangeRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Windows.Media.PlayTo.MuteChangeRequestedEventArgs)
        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.IsMuted = args.Mute
            End Sub)
    End Sub
    ' </SnippetMuteChangeRequested>

    ' <SnippetPauseRequested>
    Async Sub receiver_PauseRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Object)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.Pause()
            End Sub)
    End Sub
    ' </SnippetPauseRequested>

    ' <SnippetPlaybackRateChangeRequested>
    Async Sub receiver_PlaybackRateChangeRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Windows.Media.PlayTo.PlaybackRateChangeRequestedEventArgs)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.PlaybackRate = args.Rate
            End Sub)
    End Sub
    ' </SnippetPlaybackRateChangeRequested>

    ' <SnippetPlayRequested>
    Async Sub receiver_PlayRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Object)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.Play()
            End Sub)
    End Sub
    ' </SnippetPlayRequested>

    ' <SnippetSourceChangeRequested>
    Async Sub receiver_SourceChangeRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Windows.Media.PlayTo.SourceChangeRequestedEventArgs)

        If args.Stream IsNot Nothing Then
            Await Dispatcher.RunAsync(
                Windows.UI.Core.CoreDispatcherPriority.Normal,
                Sub()
                    Dim stream = TryCast(args.Stream, Windows.Storage.Streams.IRandomAccessStream)
                    VideoPlayer.SetSource(stream, args.Stream.ContentType)
                End Sub)
        End If
    End Sub
    ' </SnippetSourceChangeRequested>

    ' <SnippetStopRequested>
    Async Sub receiver_StopRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Object)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()

                VideoPlayer.Stop()
            End Sub)
    End Sub
    ' </SnippetStopRequested>

    ' <SnippetTimeUpdateRequested>
    Async Sub receiver_TimeUpdateRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Object)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                receiver.NotifyTimeUpdate(VideoPlayer.Position)
            End Sub)
    End Sub
    ' </SnippetTimeUpdateRequested>

    ' <SnippetVolumeChangeRequested>
    Async Sub receiver_VolumeChangeRequested(
        sender As Windows.Media.PlayTo.PlayToReceiver,
        args As Windows.Media.PlayTo.VolumeChangeRequestedEventArgs)

        Await Dispatcher.RunAsync(
            Windows.UI.Core.CoreDispatcherPriority.Normal,
            Sub()
                VideoPlayer.Volume = args.Volume
            End Sub)
    End Sub
    ' </SnippetVolumeChangeRequested>
    ' </SnippetReceiverEvents>

    ' <SnippetPlayerEvents>
    ' <SnippetNotifyPlayPauseStopError>
    Sub VideoPlayer_CurrentStateChanged()

        If receiver IsNot Nothing Then
            Select Case VideoPlayer.CurrentState
                Case MediaElementState.Playing
                    receiver.NotifyPlaying()
                Case MediaElementState.Paused
                    receiver.NotifyPaused()
                Case MediaElementState.Stopped
                    receiver.NotifyStopped()
            End Select
        End If
    End Sub

    Sub VideoPlayer_MediaFailed()
        If receiver IsNot Nothing Then receiver.NotifyError()
    End Sub
    ' </SnippetNotifyPlayPauseStopError>

    ' <SnippetNotifyEnded>
    Sub VideoPlayer_MediaEnded()
        If receiver IsNot Nothing Then
            receiver.NotifyEnded()
            VideoPlayer.Stop()
        End If
    End Sub
    ' </SnippetNotifyEnded>

    ' <SnippetNotifyDurationChange>
    Sub VideoPlayer_MediaOpened()
        If receiver IsNot Nothing Then
            receiver.NotifyDurationChange(VideoPlayer.NaturalDuration.TimeSpan)
            receiver.NotifyLoadedMetadata()
        End If
    End Sub
    ' </SnippetNotifyDurationChange>

    ' <SnippetNotifyRateChange>
    Sub VideoPlayer_RateChanged()
        If receiver IsNot Nothing Then
            receiver.NotifyRateChange(VideoPlayer.PlaybackRate)
        End If
    End Sub
    ' </SnippetNotifyRateChange>

    ' <SnippetNotifySeek>
    Sub VideoPlayer_SeekCompleted()
        If receiver IsNot Nothing Then
            If Not seeking Then
                receiver.NotifySeeking()
                receiver.NotifySeeked()
                seeking = False
            End If
        End If
    End Sub
    ' </SnippetNotifySeek>

    ' <SnippetNotifyVolumeChanged>
    Sub VideoPlayer_VolumeChanged()
        If receiver IsNot Nothing Then
            receiver.NotifyVolumeChange(VideoPlayer.Volume, VideoPlayer.IsMuted)
        End If
    End Sub
    ' </SnippetNotifyVolumeChanged>
    ' </SnippetPlayerEvents>
End Class
