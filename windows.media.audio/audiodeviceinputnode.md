---
-api-id: T:Windows.Media.Audio.AudioDeviceInputNode
-api-type: winrt class
---

<!-- Class syntax.
public class AudioDeviceInputNode : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioDeviceInputNode, Windows.Media.Audio.IAudioInputNode, Windows.Media.Audio.IAudioInputNode2, Windows.Media.Audio.IAudioNode
-->

# Windows.Media.Audio.AudioDeviceInputNode

## -description

Represents a node in an audio graph node that inputs audio data into the graph from an audio device such as a microphone or external audio interface.

## -remarks

Get an instance of this class by calling [AudioGraph.CreateDeviceInputNodeAsync](audiograph_createdeviceinputnodeasync_1285412965.md) and then accessing the [CreateAudioDeviceInputNodeResult.DeviceInputNode](createaudiodeviceinputnoderesult_deviceinputnode.md) property.

## -examples

## -see-also

[IAudioInputNode](iaudioinputnode.md), [IAudioNode](iaudionode.md), [IClosable](../windows.foundation/iclosable.md), [AudioGraph sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCreation)