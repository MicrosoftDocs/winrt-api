---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSource.SetFormatAsync(Windows.Media.Capture.Frames.MediaFrameFormat)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetFormatAsync(Windows.Media.Capture.Frames.MediaFrameFormat format)
-->

# Windows.Media.Capture.Frames.MediaFrameSource.SetFormatAsync

## -description
Asynchronously sets the frame format of the [MediaFrameSource](mediaframesource.md).

## -parameters
### -param format
The new frame format for the media frame source.

## -returns
An asynchronous action.

## -remarks
This method is an alternative to [MediaCapture.SetEncodingPropertiesAsync](../windows.media.capture/mediacapture_setencodingpropertiesasync_1218555455.md), but unlike **SetEncodingPropertiesAsync**, this method can be used with any stream, not just the color camera preview, record, and photo capture streams.

Get the list of supported frame formats for a media frame source by accessing the [SupportedFormats](mediaframesource_supportedformats.md) property.

Get the current frame format of the media frame source by accessing the [CurrentFormat](mediaframesource_currentformat.md) property.

## -examples

## -see-also
