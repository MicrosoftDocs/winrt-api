---
-api-id: T:Windows.Media.PlayTo.PlayToSourceDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class PlayToSourceDeferral : Windows.Media.PlayTo.IPlayToSourceDeferral
-->

# Windows.Media.PlayTo.PlayToSourceDeferral

## -description
Represents a deferred operation when you're supplying a source media element for Play To.

## -remarks
You can use a deferral when you want to make an asynchronous call to retrieve the media element to stream. Play To will then wait for you to supply the media element until you mark the deferral as complete.



To create a deferral, call the [GetDeferral](playtosourcerequest_getdeferral_254836512.md) method to instruct the [PlayToManager](playtomanager.md) class to wait to receive a source media element to stream to the Play To target. After you've supplied the source media element to the [SetSource](playtosourcerequest_setsource_1024738425.md) method, call the [Complete](playtosourcedeferral_complete_1807836922.md) method to end the deferral. If you create a deferral and the wait time exceeds the [Deadline](playtosourcerequest_deadline.md) property, Play To will continue without a source element from your app.

For an example of how to use Play To in an application, see [PlayReady DRM](/windows/uwp/audio-video-camera/playready-client-sdk).

## -examples

[!code-csharp[Deferral](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetDeferral)]

[!code-vb[Deferral](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetDeferral)]

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [Media Server sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Server%20client%20sample%20(Windows%208)/C%2B%2B)
