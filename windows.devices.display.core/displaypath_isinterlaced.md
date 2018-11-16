---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.IsInterlaced
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<bool> IsInterlaced { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.IsInterlaced

## -description
Gets or sets an optional value for whether the target mode for this path is interlaced.

## -property-value
`true` if the target mode for this path is interlaced, otherwise `false`.

## -remarks
This property can remain unset (null) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
