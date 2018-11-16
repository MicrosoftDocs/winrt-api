---
-api-id: T:Windows.Devices.Display.Core.DisplayStateOperationStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayStateOperationStatus : int 
-->

# Windows.Devices.Display.Core.DisplayStateOperationStatus

## -description
Defines constants that specify the result of a [DisplayState](displaystate.md) operation.

## -enum-fields
### -field ModesNotSupported:6
Indicates that the operation failed because one or more modes specified by a [DisplayPath](displaypath.md) are not supported in the present configuration.

### -field PartialFailure:1
Indicates that the operation failed, but some system state was modified.

### -field RemoteSessionNotSupported:7
Indicates that the operation failed because the current session is currently in an unsupported remote desktop session that does not allow access to the display stack.

### -field SystemStateChanged:4
Indicates that the operation failed because the system display state has changed since the relevant [DisplayState](displaystate.md) object was created.

### -field Success:0
Indicates that the operation succeeded.

### -field TargetOwnershipLost:3
Indicates that the operation failed because target ownership has been lost.

### -field TooManyPathsForAdapter:5
Indicates that an involved adapter cannot support the number of paths requested.

### -field UnknownFailure:2
Indicates that the operation failed for an unknown reason.

## -remarks

## -see-also

## -examples
