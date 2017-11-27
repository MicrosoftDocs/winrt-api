---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioSubmixNode CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties)
-->

# Windows.Media.Audio.AudioGraph.CreateSubmixNode

## -description
Creates an [AudioSubmixNode](audiosubmixnode.md) that mixes the output of one or more audio graph nodes into a single output that can be connected to output nodes or other submix nodes.

## -parameters
### -param encodingProperties
An object representing the audio encoding properties for the submix node which specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -returns
An audio submix node.

## -remarks
The *encodingProperties* parameter specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -examples

## -see-also
[CreateSubmixNode](audiograph_createsubmixnode_1505743305.md)
## -capabilities
backgroundMediaRecording
