---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioSubmixNode CreateSubmixNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties)
-->

# Windows.Media.Audio.AudioGraph.CreateSubmixNode

## -description
Creates an audio graph submix node that mixes the output of one or more nodes into single output that can be connected to output nodes or other submix nodes.

## -parameters
### -param encodingProperties
An object representing audio encoding properties.

## -returns
An audio submix node.

## -remarks
The *encodingProperties* parameter specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -examples

## -see-also
[CreateSubmixNode](audiograph_createsubmixnode_1505743305.md)