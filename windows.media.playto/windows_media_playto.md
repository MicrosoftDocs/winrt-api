---
-api-id: N:Windows.Media.PlayTo
-api-type: winrt namespace
---

# Windows.Media.PlayTo

## -description
Supports <?xm-insertion_mark_start author="v-shawja" time="20120127T143136-0800"?> the <?xm-insertion_mark_end?> streaming <?xm-insertion_mark_start author="v-shawja" time="20120127T143139-0800"?> of <?xm-insertion_mark_end?> audio, video, and images to remote devices.

## -remarks
<?xm-insertion_mark_start author="v-shawja" time="20120127T150504-0800"?>
<!--{annotation author="v-shawja" time="1/27/2012 3:05:04 PM"}This section uses "target" twice. Note that MSTP generally prefers "destination" over "target". Please make that change if it would be accurate. In both cases in this section, "device" alone might also work as a replacement. Also note that toward the end of this section, I changed "passed to" to "that was passed to" for clarity. Please confirm that this edit is accurate. And for the one instance of "addEventHandler", it would be better to add a descriptor after it.-->
<?xm-insertion_mark_end?>You can use Play To to enable users to easily stream audio, video, or images from their computer to devices in their home network. For example, a user who<?xm-insertion_mark_start author="v-shawja" time="20120127T144254-0800"?> '<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T144255-0800" data=" i"?> s watching a video in your application can stream that video to <?xm-insertion_mark_start author="v-shawja" time="20120127T151305-0800"?> his or her<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T151307-0800" data="their"?> TV <?xm-insertion_mark_start author="v-shawja" time="20120127T144312-0800"?> so that<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T144315-0800" data="for"?> everyone in the room <?xm-insertion_mark_start author="v-shawja" time="20120127T144327-0800"?> can<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T144329-0800" data="to"?> view<?xm-insertion_mark_start author="v-shawja" time="20120127T144330-0800"?> it<?xm-insertion_mark_end?>.

Play To streams audio, video, or images to a certified Play To receiver<?xm-deletion_mark author="v-shawja" time="20120127T144733-0800" data=" "?>.

Play To is part of the **Devices** charm. For applications that contain audio, video, or images, <?xm-deletion_mark author="v-shawja" time="20120127T151647-0800" data="the "?> user<?xm-insertion_mark_start author="v-shawja" time="20120127T151650-0800"?> s<?xm-insertion_mark_end?> open<?xm-deletion_mark author="v-shawja" time="20120127T151651-0800" data="s"?> the **Devices** charm <?xm-insertion_mark_start author="v-shawja" time="20120127T144955-0800"?> to select<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T145001-0800" data="and is presented with"?> devices from their home network that they can stream the media content to.


<!-- Add an image of the Connect charm showing PlayTo targets -->
To enable Play To in your application, register for the [SourceRequested](playtomanager_sourcerequested.md) event. To register for the [SourceRequested](playtomanager_sourcerequested.md) event, get a reference to the current [PlayToManager](playtomanager.md)<?xm-insertion_mark_start author="v-shawja" time="20120127T145421-0800"?> class <?xm-insertion_mark_end?> by calling the [GetForCurrentView](playtomanager_getforcurrentview.md) method. You can then call addEventHandler on the [PlayToManager](playtomanager.md)<?xm-insertion_mark_start author="v-shawja" time="20120127T145528-0800"?> class <?xm-insertion_mark_end?> to associate your event handler with the [SourceRequested](playtomanager_sourcerequested.md) event. In your event handler, pass the media element from your application to the [SetSource](playtosourcerequest_setsource.md) method of the [PlayToSourceRequestedEventArgs](playtosourcerequestedeventargs.md) object <?xm-insertion_mark_start author="v-shawja" time="20120127T150429-0800"?> that was <?xm-insertion_mark_end?> passed to the event handler.

When a user selects a Play To target from the **Devices** charm, Play To <?xm-deletion_mark author="v-shawja" time="20120127T150717-0800" data="will "?><?xm-insertion_mark_start author="v-shawja" time="20120127T150726-0800"?> fires<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T150727-0800" data="raise"?> the [SourceRequested](playtomanager_sourcerequested.md) event. Play To then streams the media element <?xm-insertion_mark_start author="v-shawja" time="20120127T150749-0800"?> that was <?xm-insertion_mark_end?> passed to the [SetSource](playtosourcerequest_setsource.md) method to the target device <?xm-insertion_mark_start author="v-shawja" time="20120127T150813-0800"?> that the user has <?xm-insertion_mark_end?> selected<?xm-deletion_mark author="v-shawja" time="20120127T150818-0800" data=" by the user"?>.

For an example of <?xm-insertion_mark_start author="v-shawja" time="20120127T150934-0800"?> how to use<?xm-insertion_mark_end?><?xm-deletion_mark author="v-shawja" time="20120127T150936-0800" data="using"?> Play To in an application, see [Quickstart: Using Play To in applications (JavaScript)](http://msdn.microsoft.com/library/90ee116a-ee6d-4e1d-8b91-8f7f4f958b9c) or [PlayReady DRM](http://msdn.microsoft.com/library/dd8ffa8c-dff0-41e3-8f7a-345c5a248fc2).

## -examples


[!code-cs[SourceRequested](../windows.media.playto/code/PlayTo_Reference/csharp/MainPage.xaml.cs#SnippetSourceRequested)][!code-js[SourceRequested](../windows.media.playto/code/PlayTo_Reference/javascript/default.js#SnippetSourceRequested)][!code-vb[SourceRequested](../windows.media.playto/code/PlayTo_Reference/vbnet/MainPage.xaml.vb#SnippetSourceRequested)]

## -see-also
[Play To sample](http://go.microsoft.com/fwlink/p/?linkid=245166), [PlayToReceiver sample](http://go.microsoft.com/fwlink/p/?linkid=245167), [Media Server sample](http://go.microsoft.com/fwlink/p/?linkid=245168)
soft.com/fwlink/p/?linkid=245168)
