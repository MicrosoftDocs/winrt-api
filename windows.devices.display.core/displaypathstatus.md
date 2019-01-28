---
-api-id: T:Windows.Devices.Display.Core.DisplayPathStatus
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayPathStatus : int 
-->

# Windows.Devices.Display.Core.DisplayPathStatus

## -description
Defines constants that specify the last status of the path in the system, captured when the [DisplayState](displaystate.md) was last created or applied.

## -enum-fields

### -field Failed:3
Indicates that a path failed synchronously during a [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md) call.

### -field FailedAsync:4
Indicates that the display hardware has asynchronously failed the path, either due to changing bandwidth allocations, or due to driver errors during another mode change. This path should be re-evaluated and re-applied by the owner.

### -field InvalidatedAsync:5
Indicates that the path is likely still valid in hardware, but requires applying a mode again in order to reset pending software state. A path in this state typically shows a black screen on the output.

### -field Pending:2
Indicates that the last apply operation was completed successfully, but the driver has indicated that it is still applying the path to the hardware asynchronously.

### -field Succeeded:1
Indicates that the path has been successfully applied, and was currently active when the [DisplayState](displaystate.md) was last created or applied.

### -field Unknown:0
Used for newly created paths that have not been applied.

## -remarks

## -see-also

## -examples
