---
-api-id: T:Windows.Devices.Display.Core.DisplayManagerResult
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayManagerResult : int 
-->

# Windows.Devices.Display.Core.DisplayManagerResult

## -description
Defines constants that specify the result of a [DisplayManager](displaymanager.md) operation.

## -enum-fields

### -field RemoteSessionNotSupported:4
Indicates that the operation failed because the current session is currently in an unsupported remote desktop session that does not allow access to the display stack.

### -field Success:0
Indicates that the operation succeeded.

### -field TargetAccessDenied:2
Indicates that the operation failed becaused a specified target could not be acquired, either due to another component currently owning it, or due to target ownership restrictions.

### -field TargetStale:3
Indicates that the operation failed because a specified target is stale and should be re-enumerated.

### -field UnknownFailure:1
Indicates that the operation failed for an unknown reason.

## -remarks

## -see-also

## -examples
