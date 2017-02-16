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


<!--{annotation author="v-shawja" time="1/27/2012 11:54:21 AM"}In the following paragraph, note that MSTP generally prefers "destination" over "target". Please make that change if it would be accurate. In this case, "device" might also work as a replacement. Also in the following paragraph, I added the descriptor "property", but please make sure that "the wait time exceeds the Deadline property" is accurate. It may need a little elaboration (like "the wait time exceeds the value of the Deadline property").-->
To create a deferral, call the [GetDeferral](playtosourcerequest_getdeferral.md) method to instruct the [PlayToManager](playtomanager.md) class to wait to receive a source media element to stream to the Play To target. After you've supplied the source media element to the [SetSource](playtosourcerequest_setsource.md) method, call the [Complete](playtosourcedeferral_complete.md) method to end the deferral. If you create a deferral and the wait time exceeds the [Deadline](playtosourcerequest_deadline.md) property, Play To will continue without a source element from your app.

For an example of how to use Play To in an application, see [Quickstart: Using Play To in applications (JavaScript)](http://msdn.microsoft.com/library/90ee116a-ee6d-4e1d-8b91-8f7f4f958b9c) or [PlayReady DRM](http://msdn.microsoft.com/library/dd8ffa8c-dff0-41e3-8f7a-345c5a248fc2).

## -examples


[!code-csharp[Deferral](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetDeferral)]

[!code-js[Deferral](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetDeferral)]

[!code-vb[Deferral](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetDeferral)]

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
