---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFrameOutputNode(Windows.Media.MediaProperties.AudioEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioFrameOutputNode CreateFrameOutputNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties)
-->

# Windows.Media.Audio.AudioGraph.CreateFrameOutputNode

## -description
Creates a new [AudioFrameOutputNode](audioframeoutputnode.md), with the specified encoding properties, that outputs audio data from the audio graph to app-implemented code.

## -parameters
### -param encodingProperties
An object representing the audio encoding properties for the frame output node which specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -returns
An audio frame output node.

## -remarks


## -examples

## -see-also
[CreateFrameOutputNode](audiograph_createframeoutputnode_1936992142.md)
## -capabilities
backgroundMediaRecording
