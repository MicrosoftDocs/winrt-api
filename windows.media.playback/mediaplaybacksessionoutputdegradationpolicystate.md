---
-api-id: T:Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState
-api-type: winrt class
---

<!-- Class syntax.
public class MediaPlaybackSessionOutputDegradationPolicyState 
-->

# Windows.Media.Playback.MediaPlaybackSessionOutputDegradationPolicyState

## -description
Expresses the current output degradation policy state of a [MediaPlaybackSession](mediaplaybacksession.md).

## -remarks
Get an instance of this class by calling [MediaPlaybackSession.GetOutputDegradationPolicyState](mediaplaybacksession_getoutputdegradationpolicystate_882169610.md). 

In some circumstances the system may degrade the playback of a media item, such as reducing the resolution (constriction), based on a policy rather than a performance issue. The object retrieved with this property allows you to determine if and why this policy-based degredation is occurring for telemetry purposes.

## -see-also
[MediaPlaybackSession](mediaplaybacksession.md),
[MediaPlaybackSession.GetOutputDegradationPolicyState](mediaplaybacksession_getoutputdegradationpolicystate_882169610.md)

## -examples

