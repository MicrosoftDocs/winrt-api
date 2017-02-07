---
-api-id: T:Windows.Media.Core.AudioDecoderDegradation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Core.AudioDecoderDegradation : int
-->

# AudioDecoderDegradation

## -description
Specifies the type of degredation, if any, applied to an [AudioTrack](audiotrack.md) by the audio decoder.

## -enum-fields
### -field None:0
The audio track is not degraded and is played as encoded.

### -field DownmixTo2Channels:1
The audio track is downmixed from the number of channels in the encoding to two channels.

### -field DownmixTo6Channels:2
The audio track is downmixed from the number of channels in the encoding to six channels.

### -field DownmixTo8Channels:3
The audio track is downmixed from the number of channels in the encoding to eight channels.


## -remarks
Get the **AudioDecoderDegradation** value for an audio track by checking the [Degradation](audiotracksupportinfo_degradation.md) property of the track's [SupportInfo](audiotrack_supportinfo.md) property.

## -examples

## -see-also