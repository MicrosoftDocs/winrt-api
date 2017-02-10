---
-api-id: M:Windows.Media.Capture.LowLagMediaRecording.PauseWithResultAsync(Windows.Media.Devices.MediaCapturePauseBehavior)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.MediaCapturePauseResult> PauseWithResultAsync(Windows.Media.Devices.MediaCapturePauseBehavior behavior)
-->

# Windows.Media.Capture.LowLagMediaRecording.PauseWithResultAsync

## -description
Pauses an ongoing low lag media record operation and provides a [MediaCapturePauseResult](mediacapturepauseresult.md) that can be used to help the user align the camera with the last captured frame when resuming recording.

## -parameters
### -param behavior
A value indicating whether the media capture hardware resources should be preserved or released while recording is paused.

## -returns
An asynchronous action that returns a [MediaCapturePauseResult](mediacapturepauseresult.md) upon completion.

## -remarks

## -examples

## -see-also
