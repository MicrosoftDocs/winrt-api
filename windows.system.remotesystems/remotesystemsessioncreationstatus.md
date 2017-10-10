---
-api-id: T:Windows.System.RemoteSystems.RemoteSystemSessionCreationStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RemoteSystemSessionCreationStatus : int 
-->

# Windows.System.RemoteSystems.RemoteSystemSessionCreationStatus

## -description
Describes the status of an attempt to create a remote session.

## -enum-fields
### -field Success:0
The remote session was created successfully.

### -field SessionLimitsExceeded:1
The remote session was not created because this device is already a participant in the maximum allowed number of sessions.

### -field OperationAborted:2
The creation attempt failed for an unknown reason.

## -remarks

## -see-also

## -examples


## -capabilities
remoteSystem
