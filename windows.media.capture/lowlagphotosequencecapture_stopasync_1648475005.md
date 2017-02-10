---
-api-id: M:Windows.Media.Capture.LowLagPhotoSequenceCapture.StopAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction StopAsync()
-->

# Windows.Media.Capture.LowLagPhotoSequenceCapture.StopAsync

## -description
Asynchronously stops capturing photos.

## -returns
Object that is used to control the asynchronous operation.

## -remarks
[StopAsync](lowlagphotosequencecapture_stopasync.md) stops the operation, which can be restarted with [StartAsync](lowlagphotosequencecapture_startasync.md).

[FinishAsync](lowlagphotosequencecapture_finishasync.md) stops the photo sequence capture operation and releases the [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object and resources used by the photo sequence operation. If you want to restart the photo sequence operation after calling [FinishAsync](lowlagphotosequencecapture_finishasync.md), you must call [MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync.md) to initialize a new [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object.

## -examples

## -see-also
