---
-api-id: T:Windows.Networking.Connectivity.ConnectionProfileDeleteStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum ConnectionProfileDeleteStatus : int 
-->

# Windows.Networking.Connectivity.ConnectionProfileDeleteStatus

## -description
Defines values that indicate the result of an attempt to delete a connection profile.

## -enum-fields
### -field UnknownError:3
The deletion failed due to an unknown error.

### -field Success:0
The deletion succeeded.

### -field DeniedByUser:1
The deletion failed because it was denied by the user, through the user interface (UI).

### -field DeniedBySystem:2
The deletion failed because it was denied by the system.

## -remarks

## -see-also

[TryDeleteAsync](connectionprofile_trydeleteasync_41251962.md)

## -examples
