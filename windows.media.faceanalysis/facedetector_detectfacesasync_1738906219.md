---
-api-id: M:Windows.Media.FaceAnalysis.FaceDetector.DetectFacesAsync(Windows.Graphics.Imaging.SoftwareBitmap)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVector<Windows.Media.FaceAnalysis.DetectedFace>> DetectFacesAsync(Windows.Graphics.Imaging.SoftwareBitmap image)
-->

# Windows.Media.FaceAnalysis.FaceDetector.DetectFacesAsync

## -description
Asynchronously detects faces in the provided [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md).

## -parameters
### -param image
The image data to be processed for face detection.

## -returns
An asynchronous operation that returns a list of [DetectedFace](detectedface.md) objects upon successful completion.

## -remarks
The provided [SoftwareBitmap](../windows.graphics.imaging/softwarebitmap.md) must be in a supported pixel format for this method and its overloads. Use [GetSupportedBitmapPixelFormats](facedetector_getsupportedbitmappixelformats_1649246406.md) to retrieve a list of supported pixel formats for the current device. Use [IsBitmapPixelFormatSupported](facedetector_isbitmappixelformatsupported_1650024551.md) to test whether a given pixel format is supported.

## -examples

## -see-also
[DetectFacesAsync(SoftwareBitmap, BitmapBounds)](facedetector_detectfacesasync_194268695.md)