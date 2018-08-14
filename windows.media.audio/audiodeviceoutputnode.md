---
-api-id: T:Windows.Media.Audio.AudioDeviceOutputNode
-api-type: winrt class
---

<!-- Class syntax.
public class AudioDeviceOutputNode : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioDeviceOutputNode, Windows.Media.Audio.IAudioNode, Windows.Media.Audio.IAudioNodeWithListener
-->

# Windows.Media.Audio.AudioDeviceOutputNode

## -description

Represents a node in an audio graph node that outputs audio data from the graph to an audio device such as a speaker or external audio interface.

## -remarks

Get an instance of this class by calling [AudioGraph.CreateDeviceOutputNodeAsync](audiograph_createdeviceoutputnodeasync_954542725.md) and then accessing the [CreateAudioDeviceOutputNodeResult.DeviceOutputNode](createaudiodeviceoutputnoderesult_deviceoutputnode.md) property.

## -examples

## -see-also

[IAudioNode](iaudionode.md), [IClosable](../windows.foundation/iclosable.md), [AudioGraph sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCreation)