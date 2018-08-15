---
-api-id: M:Windows.Media.Audio.MediaSourceAudioInputNode.Reset
-api-type: winrt method
---

<!-- Method syntax.
public void MediaSourceAudioInputNode.Reset()
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.Reset

## -description
Resets the **MediaSource** audio input node.

## -remarks
This method causes the node to reset the playback position back to the beginning of the media content, or to the time specified by the [StartTime](mediasourceaudioinputnode_starttime.md) property if it has been set. Calling this method causes [DiscardQueuedFrames](../windows.media.effects/ibasicaudioeffect_discardqueuedframes_1358903059.md) to be called on any audio effects applied to the [MediaSourceAudioInputNode](mediasourceaudioinputnode.md).

## -see-also

## -examples

