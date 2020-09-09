---
-api-id: M:Windows.Media.PlayTo.PlayToSourceRequest.GetDeferral
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.PlayTo.PlayToSourceDeferral GetDeferral()
-->

# Windows.Media.PlayTo.PlayToSourceRequest.GetDeferral

## -description
Defers connecting a media source to a Play To target.

## -returns
A deferral object that you can use to identify when the deferral is complete.

## -remarks
You can use a deferral when you want to make an asynchronous call to retrieve the media element to stream. Play To will then wait for you to supply the media element until you mark the deferral as complete.



To create a deferral, call the GetDeferral method to instruct the [PlayToManager](playtomanager.md) class to wait to receive a source media element to stream to the Play To target. After you have supplied the source media element to the [SetSource](playtosourcerequest_setsource_1024738425.md) method, call the [Complete](playtosourcedeferral_complete_1807836922.md) method to end the deferral. If you create a deferral and the wait time exceeds the [Deadline](playtosourcerequest_deadline.md) property, Play To will continue without a source element from your app.

For an example of how to use Play To in an application, see [Quickstart: Using Play To in applications (JavaScript)](/previous-versions/windows/apps/hh465184(v=win.10)) or [PlayReady DRM](/windows/uwp/audio-video-camera/playready-client-sdk).

## -examples


[!code-csharp[Deferral](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetDeferral)]

[!code-js[Deferral](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetDeferral)]

[!code-vb[Deferral](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetDeferral)]

## -see-also
[Play To sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/Media%20Play%20To%20sample%20(Windows%208)), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
