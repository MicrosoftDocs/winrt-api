---
-api-id: M:Windows.Media.Capture.AdvancedPhotoCapture.CaptureAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.AdvancedCapturedPhoto> CaptureAsync()
-->

# Windows.Media.Capture.AdvancedPhotoCapture.CaptureAsync

## -description
Asynchronously performs an advanced photo capture.

## -returns
An asynchronous operation that returns an [AdvancedCapturedPhoto](advancedcapturedphoto.md) upon successful completion.

## -remarks
[MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync.md) must be called before calling **CaptureAsync**.

Concurrently recording video and photo capture using [AdvancedPhotoCapture](advancedphotocapture.md) is not supported.

## -examples

## -see-also
[MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync.md), [CaptureAsync(Object)](advancedphotocapture_captureasync_651770772.md)