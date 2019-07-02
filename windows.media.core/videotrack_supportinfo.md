---
-api-id: P:Windows.Media.Core.VideoTrack.SupportInfo
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Core.VideoTrackSupportInfo SupportInfo { get; }
-->

# Windows.Media.Core.VideoTrack.SupportInfo

## -description
Gets support information for the [VideoTrack](videotrack.md). This information includes the status of the video decoder and the status of the [MediaSource](mediasource.md) with which the video track is associated.

## -property-value
The support information for the [VideoTrack](videotrack.md).

## -remarks
If a failure occurs when a [VideoTrack](videotrack.md) is opened, you can get detailed status and failure information by handling the [OpenFailed](videotrack_openfailed.md) event and checking the **SupportInfo** property of the **VideoTrack** passed into the event as the sender.

## -examples

## -see-also
