---
-api-id: P:Windows.Media.Core.AudioTrack.SupportInfo
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Core.AudioTrackSupportInfo SupportInfo { get; }
-->

# Windows.Media.Core.AudioTrack.SupportInfo

## -description
Gets support information for the [AudioTrack](audiotrack.md). This information includes the status of the audio decoder, information about any audio degradation applied by the decoder, and the status of the [MediaSource](mediasource.md) with which the audio track is associated.

## -property-value
The support information for the [AudioTrack](audiotrack.md).

## -remarks
If a failure occurs when an [AudioTrack](audiotrack.md) is opened, you can get detailed status and failure information by handling the [OpenFailed](audiotrack_openfailed.md) event and checking the **SupportInfo** property of the **AudioTrack** passed into the event as the sender.

## -examples

## -see-also
