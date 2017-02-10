---
-api-id: T:Windows.Media.Core.VideoTrackSupportInfo
-api-type: winrt class
---

<!-- Class syntax.
public class VideoTrackSupportInfo : Windows.Media.Core.IVideoTrackSupportInfo
-->

# Windows.Media.Core.VideoTrackSupportInfo

## -description
Provides support information for a [VideoTrack](videotrack.md). This information includes the status of the video decoder and the status of the [MediaSource](mediasource.md) with which the video track is associated.

## -remarks
If a failure occurs when a [VideoTrack](videotrack.md) is opened, you can get detailed status and failure information by handling the [OpenFailed](videotrack_openfailed.md) event and checking the [SupportInfo](videotrack_supportinfo.md) property of the **VideoTrack** passed into the event as the sender.

## -examples

## -see-also
