---
-api-id: M:Windows.Media.Capture.LowLagPhotoCapture.CaptureAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.CapturedPhoto> CaptureAsync()
-->

# Windows.Media.Capture.LowLagPhotoCapture.CaptureAsync

## -description
Asynchronously captures a low shutter lag photo.

## -returns
When this method completes, a [CapturedPhoto](capturedphoto.md) object is returned which contains the captured photo.

## -remarks
[MediaCapture.PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync.md) must be called before [CaptureAsync](lowlagphotocapture_captureasync.md).

When this asynchronous method completes, a [CapturedPhoto](capturedphoto.md) object is returned which contains the captured photo.

## -examples

## -see-also
[PrepareLowLagPhotoCaptureAsync](mediacapture_preparelowlagphotocaptureasync.md)