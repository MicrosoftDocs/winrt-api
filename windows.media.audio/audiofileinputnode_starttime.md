---
-api-id: P:Windows.Media.Audio.AudioFileInputNode.StartTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.TimeSpan> StartTime { get;  set; }
-->

# Windows.Media.Audio.AudioFileInputNode.StartTime

## -description
Gets or sets the start time for the audio file input node.

## -property-value
A value indicating the start time.

## -remarks
**StartTime** defines where in the file playback begins. If **StartTime** is **null**, playback will start at the beginning of the file. **StartTime** can't be set to a time greater than the duration of the file. Attempting to do so will result in an invalid argument error.

## -examples

## -see-also
