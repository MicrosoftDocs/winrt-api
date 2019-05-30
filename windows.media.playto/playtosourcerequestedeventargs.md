---
-api-id: T:Windows.Media.PlayTo.PlayToSourceRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PlayToSourceRequestedEventArgs : Windows.Media.PlayTo.IPlayToSourceRequestedEventArgs
-->

# Windows.Media.PlayTo.PlayToSourceRequestedEventArgs

## -description
Provides information about the [SourceRequested](playtomanager_sourcerequested.md) event.

## -remarks

You use the [SourceRequest](playtosourcerequestedeventargs_sourcerequest.md) property of the  class to pass media from your application to Play To during the [SourceRequested](playtomanager_sourcerequested.md) event.

For an example of how to use Play To in an application, see [Quickstart: Using Play To in applications (JavaScript)](https://docs.microsoft.com/previous-versions/windows/apps/hh465184(v=win.10)) or [PlayReady DRM](https://docs.microsoft.com/windows/uwp/audio-video-camera/playready-client-sdk).

## -examples


[!code-csharp[SourceRequested](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetSourceRequested)]

[!code-js[SourceRequested](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetSourceRequested)]

[!code-vb[SourceRequested](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetSourceRequested)]

## -see-also
[SourceRequested](playtomanager_sourcerequested.md), [Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
