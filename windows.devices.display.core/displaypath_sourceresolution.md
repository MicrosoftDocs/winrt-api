---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.SourceResolution
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<SizeInt32> SourceResolution { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.SourceResolution

## -description
Gets or sets an optional value for the size of the pixel buffer used for scanout, before it is transformed to fit into the target resolution.

## -property-value
A value indicating the size of the pixel buffer used for scanout.

## -remarks
This property can remain unset (null) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
