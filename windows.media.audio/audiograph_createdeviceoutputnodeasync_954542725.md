---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateDeviceOutputNodeAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Audio.CreateAudioDeviceOutputNodeResult> CreateDeviceOutputNodeAsync()
-->

# Windows.Media.Audio.AudioGraph.CreateDeviceOutputNodeAsync

## -description
Creates a new [AudioDeviceOutputNode](audiodeviceoutputnode.md) that outputs audio data from the audio graph to the system's default output device, such as speakers or headphones.

## -returns
An asynchronous operation that returns a [CreateAudioDeviceOutputNodeResult](createaudiodeviceoutputnoderesult.md) on completion. This object exposes a [Status](createaudiodeviceoutputnoderesult_status.md) property, that indicates either that the operation was successful or the reason why the operation failed. The [DeviceOutputNode](createaudiodeviceoutputnoderesult_deviceoutputnode.md) property provides a reference to the created output node on success.

## -remarks

## -examples

## -see-also

## -capabilities
backgroundMediaRecording
