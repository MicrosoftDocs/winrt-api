---
-api-id: M:Windows.Media.Protection.PlayReady.NDStreamParserNotifier.OnSampleParsed(System.UInt32,Windows.Media.Protection.PlayReady.NDMediaStreamType,Windows.Media.Core.MediaStreamSample,System.Int64,Windows.Media.Protection.PlayReady.NDClosedCaptionFormat,System.Byte[])
-api-type: winrt method
---

<!-- Method syntax
public void OnSampleParsed(System.UInt32 streamID, Windows.Media.Protection.PlayReady.NDMediaStreamType streamType, Windows.Media.Core.MediaStreamSample streamSample, System.Int64 pts, Windows.Media.Protection.PlayReady.NDClosedCaptionFormat ccFormat, System.Byte[] ccDataBytes)
-->

# Windows.Media.Protection.PlayReady.NDStreamParserNotifier.OnSampleParsed

## -description
Called when the stream parser parses a sample from the media stream.

## -parameters
### -param streamID
The identifier for the media stream that is being parsed.

### -param streamType
The type of the media stream. This value can be **Audio** or **Video**.

### -param streamSample
The array of stream samples.

### -param pts
The presentation timestamp that indicates when to play the sample, in milliseconds. This value is relative to previous samples in the presentation. For example, if a given sample has a presentation time stamp of 1000 and some later sample has a presentation time stamp of 2000, the later sample occurs one second (1000ms) after the given sample.

### -param ccFormat
The closed caption format. This value can be **ATSC**, **SCTE20**, or **Unknown**.

### -param ccDataBytes
An array that contains the closed caption data.

## -remarks

## -examples

## -see-also
