---
-api-id: P:Windows.Media.Capture.Frames.MediaFrameSource.SupportedFormats
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.Frames.MediaFrameFormat> SupportedFormats { get; }
-->

# Windows.Media.Capture.Frames.MediaFrameSource.SupportedFormats

## -description
Gets a read-only list of [MediaFrameFormat](mediaframeformat.md) objects representing the frame formats supported by the [MediaFrameSource](mediaframesource.md).

## -property-value
A read-only list of frame formats supported by the media frame source.

## -remarks
Get the list of supported frame formats for a media frame source by accessing the [SupportedFormats](mediaframesource_supportedformats.md) property.

Get the current frame format of the media frame source by accessing the [CurrentFormat](mediaframesource_currentformat.md) property. Set the current frame format by calling [SetFormatAsync](mediaframesource_setformatasync_966320450.md).

## -examples

## -see-also
