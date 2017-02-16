---
-api-id: E:Windows.UI.Xaml.Controls.MediaElement.MediaFailed
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.ExceptionRoutedEventHandler MediaFailed
-->

# Windows.UI.Xaml.Controls.MediaElement.MediaFailed

## -description
Occurs when there is an error associated with the media [Source](mediaelement_source.md).

## -xaml-syntax
```xaml
<MediaElement MediaFailed="eventhandler" .../>
```


## -remarks
It is a best practice to always handle the [MediaFailed](mediaelement_mediafailed.md) event and take appropriate action.

## -examples
The following code creates a [MediaFailed](mediaelement_mediafailed.md) event handler that calls a helper function to retrieve the **HRESULT** from the event arguments.



[!code-csharp[MediaPlayer_MediaFailedHandlers](../windows.ui.xaml/code/MediaPlayerQuickStart/csharp/MainPage.xaml.cs#SnippetMediaPlayer_MediaFailedHandlers)]

## -see-also
