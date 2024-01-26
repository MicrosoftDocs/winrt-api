---
-api-id: T:Windows.Media.PlayTo.PlayToReceiver
-api-type: winrt class
---

<!-- Class syntax.
public class PlayToReceiver : Windows.Media.PlayTo.IPlayToReceiver
-->

# Windows.Media.PlayTo.PlayToReceiver

## -description
Represents a Play To target.

## -remarks
You can use the PlayToReceiver class to create a custom software Play To receiver that is a digital media renderer for computers on your network. You can include a PlayToReceiver object in your app to handle communication with Play To client computers, and then play or display content streamed from those computers using your own media elements or controls.

The members of the PlayToReceiver class consist of the following:
+ The [FriendlyName](playtoreceiver_friendlyname.md) property that identifies the name of the Play To receiver when it is advertised on the network.
+ Properties that identify the type of media that your Play To receiver supports: [SupportsAudio](playtoreceiver_supportsaudio.md), [SupportsVideo](playtoreceiver_supportsvideo.md), [SupportsImage](playtoreceiver_supportsimage.md).
+ The [StartAsync](playtoreceiver_startasync_1931900819.md) method that starts the Play To receiver and advertises it on the network as a digital media renderer. The [StopAsync](playtoreceiver_stopasync_1648475005.md) method that stops the Play To receiver and stops advertising it on the network.
+ The [SourceChangeRequested](playtoreceiver_sourcechangerequested.md) event that occurs when you receive a media stream from a computer, and events that occur when an action is requested by the Play To client computer such as a volume change, or a change in the playback location of the streamed media: [CurrentTimeChangeRequested](playtoreceiver_currenttimechangerequested.md), [MuteChangeRequested](playtoreceiver_mutechangerequested.md), [PauseRequested](playtoreceiver_pauserequested.md), [PlayRequested](playtoreceiver_playrequested.md), [StopRequested](playtoreceiver_stoprequested.md), [VolumeChangeRequested](playtoreceiver_volumechangerequested.md), [TimeUpdateRequested](playtoreceiver_timeupdaterequested.md).
+ Methods that you can call to notify the Play To client when a change occurs for your Play To receiver: [NotifyDurationChange](playtoreceiver_notifydurationchange_1632513681.md), [NotifyEnded](playtoreceiver_notifyended_887919507.md), [NotifyError](playtoreceiver_notifyerror_1157154443.md), [NotifyLoadedMetadata](playtoreceiver_notifyloadedmetadata_50414725.md), [NotifyPaused](playtoreceiver_notifypaused_1175515486.md), [NotifyPlaying](playtoreceiver_notifyplaying_1675840659.md), [NotifyRateChange](playtoreceiver_notifyratechange_1422145476.md), [NotifySeeked](playtoreceiver_notifyseeked_1986074253.md), [NotifySeeking](playtoreceiver_notifyseeking_930196462.md), [NotifyStopped](playtoreceiver_notifystopped_1831716120.md), [NotifyTimeUpdate](playtoreceiver_notifytimeupdate_1370613405.md), [NotifyVolumeChange](playtoreceiver_notifyvolumechange_378380103.md).


In Play To, video starts from the current position. If you want to start the video from the beginning, simply seek to the beginning of the video as soon as the Play To connection is established.

For an example of creating a software Play To receiver, see [Media casting](/windows/uwp/audio-video-camera/media-casting).

[!code-csharp[StartAndStop](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetStartAndStop)]

[!code-vb[StartAndStop](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetStartAndStop)]

PlayTo apps will not be suspended as long as video or music is playing on the Play To receiver or images are continuously sent to the Play To receiver. Apps have approximately 10 seconds to send a new image after the current one is displayed and approximately 10 seconds to send the next audio or video after the current one has ended.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)

## -capabilities
privateNetworkClientServer