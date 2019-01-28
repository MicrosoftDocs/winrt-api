---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.PresentationRate
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<DisplayPresentationRate> PresentationRate { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.PresentationRate

## -description
Gets or sets an optional value for the refresh rate, also known as the vertical sync rate, of this path's target mode.

## -property-value
A [DisplayPresentationRate](displaypresentationrate.md) value.

## -remarks
This property can remain unset (null) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
