---
-api-id: M:Windows.Media.Capture.MediaCapture.RemoveEffectAsync(Windows.Media.IMediaExtension)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RemoveEffectAsync(Windows.Media.IMediaExtension effect)
-->

# Windows.Media.Capture.MediaCapture.RemoveEffectAsync

## -description
Removes the specified effect from the capture pipeline.

## -parameters
### -param effect
The effect to remove from the capture pipeline.

## -returns
Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
Pass the effect instance returned by [AddVideoEffectAsync](mediacapture_addvideoeffectasync.md) or [AddAudioEffectAsync](mediacapture_addaudioeffectasync.md) into this method to remove the effect from the pipeline.

## -examples

## -see-also
