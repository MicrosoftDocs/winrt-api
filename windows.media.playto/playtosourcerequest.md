---
-api-id: T:Windows.Media.PlayTo.PlayToSourceRequest
-api-type: winrt class
---

<!-- Class syntax.
public class PlayToSourceRequest : Windows.Media.PlayTo.IPlayToSourceRequest
-->

# Windows.Media.PlayTo.PlayToSourceRequest

## -description
Represents a request to connect a media element with a Play To target.

## -remarks
The [PlayToSourceRequest](playtosourcerequest.md) class represents a user request for source media to stream to a Play To target. You use the [SourceRequest](playtosourcerequestedeventargs_sourcerequest.md) property of the [PlayToSourceRequestedEventArgs](playtosourcerequestedeventargs.md) class to pass media from your application to Play To during the [SourceRequested](playtomanager_sourcerequested.md) event.

You can use the [GetDeferral](playtosourcerequest_getdeferral.md) method to create a deferral for when you want to make an asynchronous call to retrieve the media element to stream. Play To will then wait for you to supply the media element until you mark the deferral as complete.

For an example of how to use Play To in an application, see [Quickstart: Using Play To in applications (JavaScript)](http://msdn.microsoft.com/library/90ee116a-ee6d-4e1d-8b91-8f7f4f958b9c) or [PlayReady DRM](http://msdn.microsoft.com/library/dd8ffa8c-dff0-41e3-8f7a-345c5a248fc2).

## -examples


[!code-csharp[SourceRequested](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetSourceRequested)]

[!code-js[SourceRequested](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetSourceRequested)]

[!code-vb[SourceRequested](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetSourceRequested)]

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
