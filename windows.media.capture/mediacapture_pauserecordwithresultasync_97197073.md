---
-api-id: M:Windows.Media.Capture.MediaCapture.PauseRecordWithResultAsync(Windows.Media.Devices.MediaCapturePauseBehavior)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.MediaCapturePauseResult> PauseRecordWithResultAsync(Windows.Media.Devices.MediaCapturePauseBehavior behavior)
-->

# Windows.Media.Capture.MediaCapture.PauseRecordWithResultAsync

## -description
Pauses an ongoing media record operation and provides a [MediaCapturePauseResult](mediacapturepauseresult.md) that can be used to help the user align the camera with the last captured frame when resuming recording.

## -parameters
### -param behavior
A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.

## -returns
An asynchronous action that returns a [MediaCapturePauseResult](mediacapturepauseresult.md) upon completion.

## -remarks

## -examples

## -see-also
