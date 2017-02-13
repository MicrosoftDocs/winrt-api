---
-api-id: M:Windows.Media.Audio.AudioFileInputNode.Reset
-api-type: winrt method
---

<!-- Method syntax
public void Reset()
-->

# Windows.Media.Audio.AudioFileInputNode.Reset

## -description
Resets the audio file input node.

## -remarks
This method causes the node to reset the playback position back to the beginning of the file, or to the time specified by the [StartTime](audiofileinputnode_starttime.md) property if it has been set. Calling this method causes [DiscardQueuedFrames](../windows.media.effects/ibasicaudioeffect_discardqueuedframes.md) to be called on any audio effects applied to the [AudioFileInputNode](audiofileinputnode.md).

## -examples

## -see-also
