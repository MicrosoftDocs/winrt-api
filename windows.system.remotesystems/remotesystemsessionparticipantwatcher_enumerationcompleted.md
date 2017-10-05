---
-api-id: E:Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcher.EnumerationCompleted
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler EnumerationCompleted<RemoteSystemSessionParticipantWatcher,  object>
-->

# Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcher.EnumerationCompleted

## -description
Raised after the initial enumeration of participants has completed. 

## -remarks
An app may delay UI rendering for session participants until this point, so that the UI elements for many participant can be rendered at once. Participant discovery events can continue to be raised after this event.

## -see-also

## -examples


## -capabilities
remoteSystem
