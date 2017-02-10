---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFrameInputNode(Windows.Media.MediaProperties.AudioEncodingProperties,Windows.Media.Audio.AudioNodeEmitter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioFrameInputNode CreateFrameInputNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties, Windows.Media.Audio.AudioNodeEmitter emitter)
-->

# Windows.Media.Audio.AudioGraph.CreateFrameInputNode

## -description
Creates an audio frame input node with the specified encoding properties that supports spatial audio.

## -parameters
### -param encodingProperties
An object representing encoding properties.

### -param emitter
An object that describes the position and other physical characteristics of the emitter from which the node's audio is emitted when spatial audio processing is used.

## -returns
An audio frame input node.

## -remarks
The *encodingProperties* parameter specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -examples

## -see-also
[CreateFrameInputNode](audiograph_createframeinputnode_80496994.md), [CreateFrameInputNode(AudioEncodingProperties)](audiograph_createframeinputnode_772246878.md)