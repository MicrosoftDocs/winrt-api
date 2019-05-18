---
-api-id: M:Windows.Media.Capture.LowLagMediaRecording.FinishAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction FinishAsync()
-->

# Windows.Media.Capture.LowLagMediaRecording.FinishAsync

## -description
Asynchronously releases the [LowLagMediaRecording](lowlagmediarecording.md) object and resources used by the media recording operation.

## -returns
Object that is used to control the asynchronous operation.

## -remarks
FinishAsync stops the media recording operation and releases the [LowLagMediaRecording](lowlagmediarecording.md) object and resources used by the media recording operation. If you want to restart the recording after calling FinishAsync, you will need to call one of the **PrepareLowLagRecord** methods to initialize a new [LowLagMediaRecording](lowlagmediarecording.md) object.

## -examples

## -see-also
