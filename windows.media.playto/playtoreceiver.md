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
You can use the [PlayToReceiver](playtoreceiver.md) class to create a custom software Play To receiver that is a digital media renderer for computers on your network. You can include a [PlayToReceiver](playtoreceiver.md) object in your app to handle communication with Play To client computers, and then play or display content streamed from those computers using your own media elements or controls.

The members of the [PlayToReceiver](playtoreceiver.md) class consist of the following:
+ The [FriendlyName](playtoreceiver_friendlyname.md) property that identifies the name of the Play To receiver when it is advertised on the network.
+ Properties that identify the type of media that your Play To receiver supports: [SupportsAudio](playtoreceiver_supportsaudio.md), [SupportsVideo](playtoreceiver_supportsvideo.md), [SupportsImage](playtoreceiver_supportsimage.md).
+ The [StartAsync](playtoreceiver_startasync.md) method that starts the Play To receiver and advertises it on the network as a digital media renderer. The [StopAsync](playtoreceiver_stopasync.md) method that stops the Play To receiver and stops advertising it on the network.
+ The [SourceChangeRequested](playtoreceiver_sourcechangerequested.md) event that occurs when you receive a media stream from a computer, and events that occur when an action is requested by the Play To client computer such as a volume change, or a change in the playback location of the streamed media: [CurrentTimeChangeRequested](playtoreceiver_currenttimechangerequested.md), [MuteChangeRequested](playtoreceiver_mutechangerequested.md), [PauseRequested](playtoreceiver_pauserequested.md), [PlayRequested](playtoreceiver_playrequested.md), [StopRequested](playtoreceiver_stoprequested.md), [VolumeChangeRequested](playtoreceiver_volumechangerequested.md), [TimeUpdateRequested](playtoreceiver_timeupdaterequested.md).
+ Methods that you can call to notify the Play To client when a change occurs for your Play To receiver: [NotifyDurationChange](playtoreceiver_notifydurationchange.md), [NotifyEnded](playtoreceiver_notifyended.md), [NotifyError](playtoreceiver_notifyerror.md), [NotifyLoadedMetadata](playtoreceiver_notifyloadedmetadata.md), [NotifyPaused](playtoreceiver_notifypaused.md), [NotifyPlaying](playtoreceiver_notifyplaying.md), [NotifyRateChange](playtoreceiver_notifyratechange.md), [NotifySeeked](playtoreceiver_notifyseeked.md), [NotifySeeking](playtoreceiver_notifyseeking.md), [NotifyStopped](playtoreceiver_notifystopped.md), [NotifyTimeUpdate](playtoreceiver_notifytimeupdate.md), [NotifyVolumeChange](playtoreceiver_notifyvolumechange.md).


In Play To, video starts from the current position. If you want to start the video from the beginning, simply seek to the beginning of the video as soon as the Play To connection is established.

For an example of creating a software Play To receiver, see [Media casting](http://msdn.microsoft.com/library/40b97e0c-eb1b-40c2-a022-1ab95dfb085e) or [Media casting](http://msdn.microsoft.com/library/40b97e0c-eb1b-40c2-a022-1ab95dfb085e).



[!code-js[StartAndStop_JS](../windows.media.playto/code/PlayTo_Receiver1/javascript/default.js#SnippetStartAndStop_JS)]

[!code-csharp[StartAndStop](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetStartAndStop)]

[!code-vb[StartAndStop](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetStartAndStop)]

PlayTo apps will not be suspended as long as video or music is playing on the Play To receiver or images are continuously sent to the Play To receiver. Apps have approximately 10 seconds to send a new image after the current one is displayed and approximately 10 seconds to send the next audio or video after the current one has ended.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

## -examples

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)

## -capabilities
privateNetworkClientServer
ities
privateNetworkClientServer
