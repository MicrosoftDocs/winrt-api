---
-api-id: P:Windows.Media.Capture.PhotoConfirmationCapturedEventArgs.Frame
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Capture.CapturedFrame Frame { get; }
-->

# Windows.Media.Capture.PhotoConfirmationCapturedEventArgs.Frame

## -description
Gets the captured frame.

## -property-value
The captured frame.

## -remarks
The data returned in the Frame property is raw pixel data. In other words, it does not include an image file format header. Because of this, you can't pass the captured frame's stream to the bitmap's [SetSourceAsync](../windows.ui.xaml.media.imaging/bitmapsource_setsourceasync.md) method directly. Instead, you must copy the pixel data manually into the bitmap's pixel buffer. The following code snippets show you how to copy the image data and provide a helper class that performs the operation.

First, you need to enable photo confirmation and hook up the [PhotoConfirmationCaptured](mediacapture_photoconfirmationcaptured.md) event.





[!code-csharp[EnablePhotoConfirmation](../windows.media.capture/code/MediaCaptureVideo/csharp/MainPage.xaml.cs#SnippetEnablePhotoConfirmation)]





[!code-csharp[PhotoConfirmationCaptured](../windows.media.capture/code/MediaCaptureVideo/csharp/MainPage.xaml.cs#SnippetPhotoConfirmationCaptured)]



The following code snippet shows the helper class that defines the extension methods for the copying captured frame data into the writeable bitmap's pixel data stream. The class provides synchronous and asynchronous methods and overloads that allow you to specify a copy buffer size or use a default size.

[!code-csharp[StreamExtenstions](../windows.media.capture/code/MediaCaptureVideo/csharp/MainPage.xaml.cs#SnippetStreamExtenstions)]

## -examples

## -see-also



