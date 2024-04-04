---
-api-id: T:Windows.Media.PlayTo.PlayToManager
-api-type: winrt class
---

<!-- Class syntax.
public class PlayToManager : Windows.Media.PlayTo.IPlayToManager
-->

# Windows.Media.PlayTo.PlayToManager

## -description
Provides access to Play To capabilities.

## -remarks

If your application includes audio, video, or image elements, users can stream the media source for those elements to a Play To target device. You can use the PlayToManager class to customize the Play To experience for users. You can disable the default behavior by using the [DefaultSourceSelection](playtomanager_defaultsourceselection.md) property.You can select which media is streamed by using the [SourceRequested](playtomanager_sourcerequested.md) event. And you can display the Play To UI in place of the **Devices** charm by using the [ShowPlayToUI](playtomanager_showplaytoui_77103824.md) method.

In Play To, video starts from the current position. If you want to start the video from the beginning, simply seek to the beginning of the video as soon as the Play To connection is established.

PlayTo apps will not be suspended as long as video or music is playing on the Play To receiver or images are continuously sent to the Play To receiver. Apps have approximately 10 seconds to send a new image after the current one is displayed and approximately 10 seconds to send the next audio or video after the current one has ended.

For an example of how to use Play To in an application, see [PlayReady DRM](/windows/uwp/audio-video-camera/playready-client-sdk).

## -examples


[!code-csharp[SourceRequested](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetSourceRequested)]

[!code-vb[SourceRequested](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetSourceRequested)]

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)
