---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcherStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemSessionParticipantWatcherStatus : int 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionParticipantWatcherStatus

## -description
Contains values that describe the operational status of a participant watcher object.

## -enum-fields
### -field Stopping:3
The watcher is in the process of stopping.

### -field Stopped:4
The watcher has stopped looking for session participants.

### -field Started:1
The watcher has started looking for session participants.

### -field EnumerationCompleted:2
The initial enumeration of session participants has completed.

### -field Created:0
The watcher has been created but has not yet been started.

### -field Aborted:5
The watching operation was aborted for an unknown reason.

## -remarks

## -see-also

## -examples


## -capabilities
remoteSystem
