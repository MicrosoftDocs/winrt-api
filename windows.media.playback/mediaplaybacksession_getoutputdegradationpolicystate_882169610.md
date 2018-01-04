---
-api-id: M:Windows.Media.Playback.MediaPlaybackSession.GetOutputDegradationPolicyState
-api-type: winrt method
---

<!-- Method syntax.
public MediaPlaybackSessionOutputDegradationPolicyState MediaPlaybackSession.GetOutputDegradationPolicyState()
-->

# Windows.Media.Playback.MediaPlaybackSession.GetOutputDegradationPolicyState

## -description
Gets an object that expresses the current output degradation policy state of the [MediaPlaybackSession](mediaplaybacksession.md).

## -returns
A [MediaPlaybackSessionOutputDegradationPolicyState](mediaplaybacksessionoutputdegradationpolicystate.md) object that expresses the current output degradation policy state.

## -remarks
In some circumstances the system may degrade the playback of a media item, such as reducing the resolution (constriction), based on a policy rather than a performance issue. The object retrieved with this property allows you to determine if and why this policy-based degredation is occurring for telemetry purposes.

## -see-also

## -examples

