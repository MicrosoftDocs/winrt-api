---
-api-id: M:Windows.Media.FaceAnalysis.FaceTracker.ProcessNextFrameAsync(Windows.Media.VideoFrame)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVector<Windows.Media.FaceAnalysis.DetectedFace>> ProcessNextFrameAsync(Windows.Media.VideoFrame videoFrame)
-->

# Windows.Media.FaceAnalysis.FaceTracker.ProcessNextFrameAsync

## -description
Asynchronously processes a [VideoFrame](../windows.media/videoframe.md) for face detection.

## -parameters
### -param videoFrame
The [VideoFrame](../windows.media/videoframe.md) in which faces are detected or tracked.

## -returns
An asynchronous operation that returns a list of [DetectedFace](detectedface.md) objects upon successful completion.

## -remarks
The provided [SoftwareBitmap](../windows.media/videoframe_softwarebitmap.md) must be in a supported pixel format. Use [GetSupportedBitmapPixelFormats](facetracker_getsupportedbitmappixelformats_1649246406.md) to retrieve a list of supported pixel formats for the current device. Use [IsBitmapPixelFormatSupported](facetracker_isbitmappixelformatsupported_1650024551.md) to test whether a given pixel format is supported.

## -examples

## -see-also
