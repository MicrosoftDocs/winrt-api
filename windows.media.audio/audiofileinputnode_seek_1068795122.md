---
-api-id: M:Windows.Media.Audio.AudioFileInputNode.Seek(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax
public void Seek(Windows.Foundation.TimeSpan position)
-->

# Windows.Media.Audio.AudioFileInputNode.Seek

## -description
Moves the playback position of the node to the specified time within the audio input file.

## -parameters
### -param position
A value indicating the position to which the node should seek.

## -remarks
You can't seek to a time that is greater than the duration of the file. If the [StartTime](audiofileinputnode_starttime.md) or [EndTime](audiofileinputnode_endtime.md) properties have been set, you can't seek to a position before the [StartTime](audiofileinputnode_starttime.md) or after the [EndTime](audiofileinputnode_endtime.md). Attempting to do so will result in an illegal argument error.

## -examples

## -see-also
