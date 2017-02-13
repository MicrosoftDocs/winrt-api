---
-api-id: P:Windows.Media.Audio.AudioFileInputNode.LoopCount
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<int> LoopCount { get;  set; }
-->

# Windows.Media.Audio.AudioFileInputNode.LoopCount

## -description
Gets or sets the loop count of the audio file input node.

## -property-value
A reference to the loop count.

## -remarks
The **LoopCount** property specifies the number of times that the node will seek back to the [StartTime](audiofileinputnode_starttime.md), or the beginning of the file if [StartTime](audiofileinputnode_starttime.md) is not set, and replay the content of the file. This value does not include the initial playback of the file, so using the default value of 0 will result in the file being played once, and setting the value to 5 will result in the file being played 6 times in total. Setting this value to **null** will cause the file to be looped indefinitely. To break out of the infinite loop, set **LoopCount** back to 0.

## -examples

## -see-also
