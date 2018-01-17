---
-api-id: P:Windows.Media.Audio.MediaSourceAudioInputNode.StartTime
-api-type: winrt property
---

<!-- Property syntax.
public IReference<TimeSpan> StartTime { get;  set; }
-->

# Windows.Media.Audio.MediaSourceAudioInputNode.StartTime

## -description
Gets or sets the start time for the **MediaSource** input node.

## -property-value
A value indicating the start time.

## -remarks
**StartTime** defines where in the file playback begins. If **StartTime** is **null**, playback will start at the beginning of the file. **StartTime** can't be set to a time greater than the duration of the media content. Attempting to do so will result in an invalid argument error.

## -see-also

## -examples

