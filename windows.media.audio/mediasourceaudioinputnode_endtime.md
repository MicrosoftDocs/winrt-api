---
-api-id: P:Windows.Media.Audio.MediaSourceAudioInputNode.EndTime
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> EndTime { get;  set; }
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.EndTime

## -description
Gets or sets the end time for the **MediaSource** input node, which determines when playback of the media content ends.

## -property-value
A value indicating the end time.

## -remarks
**EndTime** defines the point within the media content represented by the **MediaSource** ends. If **EndTime** is **null**, playback will stop when the end of the media content is reached. **EndTime** can't be set to a time greater than the duration of the media content. Attempting to do so will result in an invalid argument error.

Set the point within the media content at which playback starts with the [StartTime](mediasourceaudioinputnode_starttime.md) property.

## -see-also

## -examples