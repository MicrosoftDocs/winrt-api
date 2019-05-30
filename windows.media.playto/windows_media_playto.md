---
-api-id: N:Windows.Media.PlayTo
-api-type: winrt namespace
---

# Windows.Media.PlayTo

## -description
Supports the streaming of audio, video, and images to remote devices.

## -remarks


You can use Play To to enable users to easily stream audio, video, or images from their computer to devices in their home network. For example, a user who's watching a video in your application can stream that video to his or her TV so that everyone in the room  view it.

Play To streams audio, video, or images to a certified Play To receiver.

Play To is part of the **Devices** charm. For applications that contain audio, video, or images, users open  the **Devices** charm  to select  devices from their home network that they can stream the media content to.


<!-- Add an image of the Connect charm showing PlayTo targets -->
To enable Play To in your application, register for the [SourceRequested](playtomanager_sourcerequested.md) event. To register for the [SourceRequested](playtomanager_sourcerequested.md) event, get a reference to the current [PlayToManager](playtomanager.md) class  by calling the [GetForCurrentView](playtomanager_getforcurrentview_1363600702.md) method. You can then call addEventHandler on the [PlayToManager](playtomanager.md) class to associate your event handler with the [SourceRequested](playtomanager_sourcerequested.md) event. In your event handler, pass the media element from your application to the [SetSource](playtosourcerequest_setsource_1024738425.md) method of the [PlayToSourceRequestedEventArgs](playtosourcerequestedeventargs.md) object   that was  passed to the event handler.

When a user selects a Play To target from the **Devices** charm, Play To  fires the [SourceRequested](playtomanager_sourcerequested.md) event. Play To then streams the media element that was passed to the [SetSource](playtosourcerequest_setsource_1024738425.md) method to the target device  that the user has   selected.

For an example of how to use  Play To in an application, see [PlayReady DRM](https://docs.microsoft.com/windows/uwp/audio-video-camera/playready-client-sdk).


## -examples


[!code-csharp[SourceRequested](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetSourceRequested)]

[!code-js[SourceRequested](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetSourceRequested)]

[!code-vb[SourceRequested](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetSourceRequested)]


## -see-also
[Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](https://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](https://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
