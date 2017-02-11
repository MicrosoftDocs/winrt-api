---
-api-id: M:Windows.Media.Audio.AudioGraph.CreateFrameInputNode(Windows.Media.MediaProperties.AudioEncodingProperties)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Media.Audio.AudioFrameInputNode CreateFrameInputNode(Windows.Media.MediaProperties.AudioEncodingProperties encodingProperties)
-->

# Windows.Media.Audio.AudioGraph.CreateFrameInputNode

## -description
Creates an audio frame input node with the specified encoding properties.

## -parameters
### -param encodingProperties
An object representing encoding properties.

## -returns
An audio frame input node.

## -remarks
The *encodingProperties* parameter specifies the sample rate at which the created node will operate. Only uncompressed PCM and float formats are allowed.

## -examples

## -see-also
[CreateFrameInputNode](audiograph_createframeinputnode_80496994.md)