---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionJoinStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemSessionJoinStatus : int 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionJoinStatus

## -description
Contains values which describe the result of this device's attempt to join a remote session.

## -enum-fields
### -field Success:0
The join attempt was successful.

### -field SessionUnavailable:3
The connection to the remote session was lost.

### -field SessionLimitsExceeded:1
The join request failed because this device is already a participant in the maximum allowed number of sessions.

### -field RejectedByController:4
The join request was rejected by the device controlling this session.

### -field OperationAborted:2
The join attempt failed for an unknown reason.

## -remarks

## -see-also

## -examples

