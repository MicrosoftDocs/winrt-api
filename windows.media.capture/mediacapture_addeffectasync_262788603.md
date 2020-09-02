---
-api-id: M:Windows.Media.Capture.MediaCapture.AddEffectAsync(Windows.Media.Capture.MediaStreamType,System.String,Windows.Foundation.Collections.IPropertySet)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction AddEffectAsync(Windows.Media.Capture.MediaStreamType mediaStreamType, System.String effectActivationID, Windows.Foundation.Collections.IPropertySet effectSettings)
-->

# Windows.Media.Capture.MediaCapture.AddEffectAsync

## -description
Adds an audio or video effect.

## -parameters
### -param mediaStreamType
Specifies the streams to which the effect will be applied.

### -param effectActivationID
The class identifier of the activatable runtime class that implements the effect. The runtime class must implement the [IMediaExtension](../windows.media/imediaextension.md) interface.

### -param effectSettings
Configuration parameters for the effect.

## -returns
Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control the asynchronous operation.

## -remarks
As of Windows 10, this method is deprecated. Use [AddAudioEffectAsync](mediacapture_addaudioeffectasync_182168147.md) or [AddVideoEffectAsync](mediacapture_addvideoeffectasync_1410216019.md) instead. For how-to guidance on adding effects to the camera capture and preview streams, see [Effects for video capture](/windows/uwp/audio-video-camera/effects-for-video-capture).

## -examples

## -see-also


## -capabilities
backgroundMediaRecording
microphone, webcam
