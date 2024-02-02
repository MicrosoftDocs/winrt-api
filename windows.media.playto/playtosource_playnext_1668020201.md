---
-api-id: M:Windows.Media.PlayTo.PlayToSource.PlayNext
-api-type: winrt method
---

<!-- Method syntax
public void PlayNext()
-->

# Windows.Media.PlayTo.PlayToSource.PlayNext

## -description
Connects the next Play To source element to the Play To target.

## -remarks
You can use the PlayNext method to stop streaming the current Play To source media to the target and then start streaming the Play To source identified by the [Next](playtosource_next.md) property to the Play To target.

For an example of using the [Next](playtosource_next.md) property, see [Media casting](/windows/uwp/audio-video-camera/media-casting).

## -examples


[!code-csharp[SlideShow](../windows.media.playto/code/PlayTo_SlideShow1/csharp/MainPage.xaml.cs#SnippetSlideShow_CS)]

[!code-vb[SlideShow](../windows.media.playto/code/PlayTo_SlideShow1/vbnet/MainPage.xaml.vb#SnippetSlideShow_CS)]

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)
