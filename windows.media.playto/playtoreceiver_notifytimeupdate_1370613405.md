---
-api-id: M:Windows.Media.PlayTo.PlayToReceiver.NotifyTimeUpdate(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void NotifyTimeUpdate(Windows.Foundation.TimeSpan currentTime)
-->

# Windows.Media.PlayTo.PlayToReceiver.NotifyTimeUpdate

## -description
Notifies the Play To receiver that the time location of the audio or video playback has changed.

## -parameters
### -param currentTime
The new time location of the playback.

## -remarks
For an example of creating a software Play To receiver, see [Media casting](/windows/uwp/audio-video-camera/media-casting).



[!code-csharp[TimeUpdateRequested](../windows.media.playto/code/PlayTo_Receiver1/csharp/MainPage.xaml.cs#SnippetTimeUpdateRequested)]

[!code-vb[TimeUpdateRequested](../windows.media.playto/code/PlayTo_Receiver1/vbnet/MainPage.xaml.vb#SnippetTimeUpdateRequested)]

## -examples

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)

## -capabilities
privateNetworkClientServer