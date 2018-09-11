---
-api-id: T:Windows.Media.Audio.AudioFileOutputNode
-api-type: winrt class
---

<!-- Class syntax.
public class AudioFileOutputNode : Windows.Foundation.IClosable, Windows.Media.Audio.IAudioFileOutputNode, Windows.Media.Audio.IAudioNode
-->

# Windows.Media.Audio.AudioFileOutputNode

## -description

Represents a node in an audio graph node that outputs audio data from the graph to an audio file.

## -remarks

Get an instance of this class by calling [AudioGraph.CreateFileOutputNodeAsync](audiograph_createfileoutputnodeasync_1127853521.md) and then accessing the [CreateFileOutputNodeResult.FileOutputNode](createaudiofileoutputnoderesult_fileoutputnode.md) property.

## -examples

## -see-also

[IAudioNode](iaudionode.md), [IClosable](../windows.foundation/iclosable.md), [AudioGraph sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/AudioCreation)
