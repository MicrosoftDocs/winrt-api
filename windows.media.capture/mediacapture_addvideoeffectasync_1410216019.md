---
-api-id: M:Windows.Media.Capture.MediaCapture.AddVideoEffectAsync(Windows.Media.Effects.IVideoEffectDefinition,Windows.Media.Capture.MediaStreamType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.IMediaExtension> AddVideoEffectAsync(Windows.Media.Effects.IVideoEffectDefinition definition, Windows.Media.Capture.MediaStreamType mediaStreamType)
-->

# Windows.Media.Capture.MediaCapture.AddVideoEffectAsync

## -description
Adds a video effect to the capture pipeline.

## -parameters
### -param definition
The object containing the definition of the effect to be added.

### -param mediaStreamType
Specifies the streams to which the effect will be applied.

## -returns
An asynchronous operation that returns an [IMediaExtension](../windows.media/imediaextension.md) upon successful completion.

## -remarks
For how-to guidance on adding effects to the camera capture and preview streams, see [Effects for video capture](https://msdn.microsoft.com/library/e0189423-1df3-4052-ab2e-846ea18254c4).

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
