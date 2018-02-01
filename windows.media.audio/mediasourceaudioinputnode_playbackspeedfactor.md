---
-api-id: P:Windows.Media.Audio.MediaSourceAudioInputNode.PlaybackSpeedFactor
-api-type: winrt property
---

<!-- Property syntax.
public double PlaybackSpeedFactor { get;  set; }
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.PlaybackSpeedFactor

## -description
Gets or sets the playback speed factor for the **MediaSource** audio input node.

## -property-value
A value indicating the playback speed factor.

## -remarks
This is a linear scale of the playback speed. So, for example a value of .5 will result in half-speed playback and a value of 2.0 will play the audio back at double speed.

The value you specify for this property is clamped to the value of the [MaxPlaybackSpeedFactor](audiographsettings_maxplaybackspeedfactor.md) property of the [AudioGraphSettings](audiographsettings.md) object used to initialize the audio graph to which the node belongs. The default maximum value is 1024.

> [!Important] 
> When an audio graph supports a playback speed factor greater than 1, the system must allocate additional memory in order to maintain a sufficient buffer of audio data. For this reason, setting **MaxPlaybackSpeedFactor** to the lowest value required by your app will reduce the memory consumption of your app. If your app will only play back content at normal speed, it is recommended that you set **MaxPlaybackSpeedFactor** to 1.

## -see-also

## -examples

