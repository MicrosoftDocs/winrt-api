---
-api-id: T:Windows.Media.Core.AudioTrackSupportInfo
-api-type: winrt class
---

<!-- Class syntax.
public class AudioTrackSupportInfo : Windows.Media.Core.IAudioTrackSupportInfo
-->

# Windows.Media.Core.AudioTrackSupportInfo

## -description
Provides support information for an [AudioTrack](audiotrack.md). This information includes the status of the audio decoder, information about any audio degradation applied by the decoder, and the status of the [MediaSource](mediasource.md) with which the audio track is associated.

## -remarks
If a failure occurs when an [AudioTrack](audiotrack.md) is opened, you can get detailed status and failure information by handling the [OpenFailed](audiotrack_openfailed.md) event and checking the [SupportInfo](audiotrack_supportinfo.md) property of the **AudioTrack** passed into the event as the sender.

## -examples

## -see-also
