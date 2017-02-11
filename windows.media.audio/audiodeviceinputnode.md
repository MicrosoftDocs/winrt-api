---
-api-id: T:Windows.Media.Audio.AudioDeviceInputNode
-api-type: winrt class
---

<!-- Class syntax.
public class AudioDeviceInputNode : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioDeviceInputNode, Windows.Media.Audio.IAudioInputNode, Windows.Media.Audio.IAudioInputNode2, Windows.Media.Audio.IAudioNode
-->

# Windows.Media.Audio.AudioDeviceInputNode

## -description
Represents an audio device input node.

## -remarks
Get an instance of this class by calling [AudioGraph::CreateDeviceInputNodeAsync](audiograph_createdeviceinputnodeasync.md) and then accessing the [CreateAudioDeviceInputNodeResult::DeviceInputNode](createaudiodeviceinputnoderesult_deviceinputnode.md) property.

## -examples

## -see-also
[IAudioInputNode](iaudioinputnode.md), [IAudioNode](iaudionode.md), [IClosable](../windows.foundation/iclosable.md)