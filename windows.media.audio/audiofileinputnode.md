---
-api-id: T:Windows.Media.Audio.AudioFileInputNode
-api-type: winrt class
---

<!-- Class syntax.
public class AudioFileInputNode : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioFileInputNode, Windows.Media.Audio.IAudioInputNode, Windows.Media.Audio.IAudioInputNode2, Windows.Media.Audio.IAudioNode
-->

# Windows.Media.Audio.AudioFileInputNode

## -description

Represents a node in an audio graph node that inputs audio data into the graph from an audio file.

## -remarks

Get an instance of this class by calling [AudioGraph::CreateFileInputNodeAsync](audiograph_createfileinputnodeasync.md) and then accessing the [CreateFileInputNodeResult::FileInputNode](createaudiofileinputnoderesult_fileinputnode.md) property.

The [MediaSourceAudioInputNode](mediasourceaudioinputnode.md) is another way of inputing audio data from a file into a graph. The [MediaSource](../windows.media.core/mediasource.md) class also allows you to use other sources of audio, such as a network stream.

## -examples

## -see-also

[IAudioInputNode](iaudioinputnode.md), [IAudioNode](iaudionode.md), [IClosable](../windows.foundation/iclosable.md), [AudioGraph sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCreation)