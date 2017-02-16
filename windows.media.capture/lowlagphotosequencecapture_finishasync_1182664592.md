---
-api-id: M:Windows.Media.Capture.LowLagPhotoSequenceCapture.FinishAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction FinishAsync()
-->

# Windows.Media.Capture.LowLagPhotoSequenceCapture.FinishAsync

## -description
Asynchronously releases the [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object and resources used by the photo sequence capture operation.

## -returns
Object that is used to control the asynchronous operation.

## -remarks
[FinishAsync](lowlagphotosequencecapture_finishasync.md) stops the photo sequence capture operation and releases the [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object and resources used by the photo sequence operation. If you want to restart the photo sequence operation after calling [FinishAsync](lowlagphotosequencecapture_finishasync.md), you must call [MediaCapture.PrepareLowLagPhotoSequenceCaptureAsync](mediacapture_preparelowlagphotosequencecaptureasync.md) to initialize a new [LowLagPhotoSequenceCapture](lowlagphotosequencecapture.md) object.

[StopAsync](lowlagphotosequencecapture_stopasync.md) stops the operation, which can be restarted with [StartAsync](lowlagphotosequencecapture_startasync.md).

## -examples

## -see-also
