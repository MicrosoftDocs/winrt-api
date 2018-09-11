---
-api-id: T:Windows.Media.Core.AudioDecoderDegradationReason
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Core.AudioDecoderDegradationReason : int
-->

# AudioDecoderDegradationReason

## -description
Specifies the reason that the audio decoder degraded an [AudioTrack](audiotrack.md).

## -enum-fields
### -field None:0
No reason is specified or no audio degradation has been applied to the track.

### -field LicensingRequirement:1
The audio track was degraded due to a licensing requirement.


### -field SpatialAudioNotSupported:2


## -remarks
Get the **AudioDecoderDegradation** value for an audio track by checking the [DegradationReason](audiotracksupportinfo_degradationreason.md) property of the track's [SupportInfo](audiotrack_supportinfo.md) property.

### Version history

| Version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | SpatialAudioNotSupported |

## -examples

## -see-also
