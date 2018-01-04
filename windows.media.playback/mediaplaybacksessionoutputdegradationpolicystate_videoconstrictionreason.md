---
-api-id: P:Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState.VideoConstrictionReason
-api-type: winrt property
---

<!-- Property syntax.
public MediaPlaybackSessionVideoConstrictionReason VideoConstrictionReason { get; }
-->

# Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState.VideoConstrictionReason

## -description
Gets a value from the [MediaPlaybackSessionVideoConstrictionReason](mediaplaybacksessionvideoconstrictionreason.md) enumeration specifying the reason why video is being constricted, if known.

## -property-value
The reason why video is being constricted.

## -remarks
In some circumstances the system may reduce the resolution (constrict) the output of a media item based on a policy rather than a performance issue. The value retrieved with this property specifies the reason this policy-based degredation is occurring for telemetry purposes. A value of **None** indicates that the content is not currently being constricted.

## -see-also

## -examples

