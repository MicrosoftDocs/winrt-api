---
-api-id: P:Windows.Media.Audio.AudioGraphSettings.MaxPlaybackSpeedFactor
-api-type: winrt property
---

<!-- Property syntax.
public double MaxPlaybackSpeedFactor { get;  set; }
-->

# Windows.Media.Audio.AudioGraphSettings.MaxPlaybackSpeedFactor

## -description
Gets or sets the maximum playback speed of input nodes in the [AudioGraph](audiograph.md).

## -property-value
The maximum playback speed of the associated [AudioGraph](audiograph.md), as a multiplier of the normal speed of the content. So, a value of 2 represents twice the normal speed and a value of 3 represents three times the normal speed. This value must be in the range of 1 to 1024, inclusive. The default value is 1024.

## -remarks
Properties that set the playback speed of a node, such as [AudioFileInputNode.PlaybackSpeedFactor](audiofileinputnode_playbackspeedfactor.md), [AudioFrameInputNode.PlaybackSpeedFactor](audioframeinputnode_playbackspeedfactor.md), or [MediaSourceAudioInputNode.PlaybackSpeedFactor](../windows.media.audio/mediasourceaudioinputnode_playbackspeedfactor.md), will be clamped to the maximum value specified by **MaxPlaybackSpeedFactor** when the audio graph was created. 

> [!Important] 
> When an audio graph supports a playback speed factor greater than 1, the system must allocate additional memory in order to maintain a sufficient buffer of audio data. For this reason, setting **MaxPlaybackSpeedFactor** to the lowest value required by your app will reduce the memory consumption of your app. If your app will only play back content at normal speed, it is recommended that you set **MaxPlaybackSpeedFactor** to 1.

## -see-also
[AudioFileInputNode.PlaybackSpeedFactor](audiofileinputnode_playbackspeedfactor.md)
[MediaSourceaudioInputNode.PlaybackSpeedFactor](../windows.media.audio/mediasourceaudioinputnode_playbackspeedfactor.md)

## -examples

