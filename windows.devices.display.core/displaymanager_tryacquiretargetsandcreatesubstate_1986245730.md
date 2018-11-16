---
-api-id: M:Windows.Devices.Display.Core.DisplayManager.TryAcquireTargetsAndCreateSubstate(Windows.Devices.Display.Core.DisplayState,Windows.Foundation.Collections.IIterable{Windows.Devices.Display.Core.DisplayTarget})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplayManagerResultWithState DisplayManager.TryAcquireTargetsAndCreateSubstate(DisplayState existingState, IIterable<DisplayTarget> targets)
-->

# Windows.Devices.Display.Core.DisplayManager.TryAcquireTargetsAndCreateSubstate

## -description
Attempts to acquire exclusive ownership of a collection of [DisplayTarget](displaytarget.md) objects, and carves out a subset of a given [DisplayState](displaystate.md) for only the targets passed to this method. The resulting state can be modified and applied.

## -parameters
### -param existingState
An existing [DisplayState](displaystate.md) object to carve out a subset of paths to create the new [DisplayState](displaystate.md) result.

### -param targets
A collection of [DisplayTarget](displaytarget.md) objects whose ownership will be attempted to be acquired.

## -returns
A [DisplayManagerResultWithState](displaymanagerresultwithstate.md) value.

## -remarks

## -see-also

## -examples
