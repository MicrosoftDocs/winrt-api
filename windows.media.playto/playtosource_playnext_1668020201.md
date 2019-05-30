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

For an example of using the [Next](playtosource_next.md) property, see [Streaming a slide show using Play To
(JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh770876(v=win.10)) or [Media casting](https://docs.microsoft.com/windows/uwp/audio-video-camera/media-casting).

## -examples


[!code-csharp[SlideShow](../windows.media.playto/code/PlayTo_SlideShow1/csharp/MainPage.xaml.cs#SnippetSlideShow_CS)]

[!code-js[SlideShow](../windows.media.playto/code/PlayTo_SlideShow1/javascript/default.js#SnippetSlideShow)]

[!code-vb[SlideShow](../windows.media.playto/code/PlayTo_SlideShow1/vbnet/MainPage.xaml.vb#SnippetSlideShow_CS)]

## -see-also
[Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
