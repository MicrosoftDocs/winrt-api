---
-api-id: M:Windows.UI.Xaml.Controls.MediaElement.SetSource(Windows.Storage.Streams.IRandomAccessStream,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetSource(Windows.Storage.Streams.IRandomAccessStream stream, System.String mimeType)
-->

# Windows.UI.Xaml.Controls.MediaElement.SetSource

## -description
Sets the [Source](mediaelement_source.md) property using the specified stream and MIME type.

## -parameters
### -param stream
The stream that contains the media to load.

### -param mimeType
The MIME type of the media resource, expressed as the string form typically seen in HTTP headers and requests. The empty string "" can be passed in as the *mimeType* value if the MIME type is unknown.

## -remarks
You can use the [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) control to get the file stream for a media file on the local system.

## -examples
Here is some code that creates [MediaElement](mediaelement.md) object and sets the media source using a [FileOpenPicker](../windows.storage.pickers/fileopenpicker.md) control.



[!code-xml[MediaElementXaml](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml#SnippetMediaElementXaml)]

[!code-csharp[PlaybackLocalFileAll](../windows.ui.xaml.media/code/MediaXamlSnippets/csharp/MainPage.xaml.cs#SnippetPlaybackLocalFileAll)]

## -see-also
[Audio, video, and camera](https://msdn.microsoft.com/library/0fc12d26-f1cf-4da7-b5a7-735a5074b74a), [Create custom transport controls](https://msdn.microsoft.com/library/6643a108-a6eb-42bc-b800-22eabd7b731b), [Supported audio and video formats](https://msdn.microsoft.com/library/6037c242-f39c-49bf-b206-c3b6a3e30165)
