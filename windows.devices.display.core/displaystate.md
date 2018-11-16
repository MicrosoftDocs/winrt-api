---
-api-id: T:Windows.Devices.Display.Core.DisplayState
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class DisplayState 
-->

# Windows.Devices.Display.Core.DisplayState

## -description
Represents a slice in time of display pipeline state for a subset of the system's display targets. If [IsReadOnly](displaystate_isreadonly.md) is `false`, then this object can be modified by connecting targets that are owned by the caller's [DisplayManager](displaymanager.md), or by modifying path properties. Modifying a **DisplayState** object, or its child objects, does not directly modify the system's display state until you call [TryApply](displaystate_tryapply_634222246.md).

## -remarks

## -see-also

## -examples
