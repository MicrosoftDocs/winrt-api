---
-api-id: M:Windows.Media.Audio.MediaSourceAudioInputNode.Seek(Windows.Foundation.TimeSpan)
-api-type: winrt method
---

<!-- Method syntax.
public void MediaSourceAudioInputNode.Seek(TimeSpan position)
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.Seek

## -description
Moves the playback position of the node to the specified time within the media content.

## -parameters
### -param position
A value indicating the position to which the node should seek.

## -remarks
You can't seek to a time that is greater than the duration of the file. If the [StartTime](mediasourceaudioinputnode_starttime.md) or [EndTime](mediasourceaudioinputnode_endtime.md) properties have been set, you can't seek to a position before the **StartTime** or after the **EndTime**. Attempting to do so will result in an illegal argument error.

## -see-also

## -examples

