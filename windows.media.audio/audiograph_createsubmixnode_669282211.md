---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioSubmixNode CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties, Windows.Media.Audio.AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateSubmixNode

## -description
Creates a spatial audio-enabled [AudioSubmixNode](audiosubmixnode.md) that mixes the output of one or more audio graph nodes into a single output that can be connected to output nodes or other submix nodes.

## -parameters
### -param encodingProperties
An object representing the audio encoding properties for the submix node which specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

### -param emitter
An object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An audio submix node.

## -remarks

## -examples

## -see-also
[CreateSubmixNode](audiograph_createsubmixnode_1505743305.md), [CreateSubmixNode(AudioEncodingProperties)](audiograph_createsubmixnode_1936987637.md)
## -capabilities
backgroundMediaRecording
