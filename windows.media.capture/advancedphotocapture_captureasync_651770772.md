---
-api-id: M:Windows.Media.Capture.AdvancedPhotoCapture.CaptureAsync(System.Object)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.AdvancedCapturedPhoto> CaptureAsync(System.Object context)
-->

# Windows.Media.Capture.AdvancedPhotoCapture.CaptureAsync

## -description
Asynchronously performs an advanced photo capture passing the provided app-defined context object to the result of the operation.

## -parameters
### -param context
An app-defined context object that passes context information to the result of the operation.

## -returns
An asynchronous operation that returns an [AdvancedCapturedPhoto](advancedcapturedphoto.md) upon successful completion.

## -remarks
[MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync.md) must be called before calling **CaptureAsync**.

Concurrently recording video and photo capture using [AdvancedPhotoCapture](advancedphotocapture.md) is not supported.

## -examples

## -see-also
[MediaCapture.PrepareAdvancedPhotoCaptureAsync](mediacapture_prepareadvancedphotocaptureasync.md), [CaptureAsync](advancedphotocapture_captureasync_2078018041.md)