---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.TargetResolution
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public IReference<SizeInt32> TargetResolution { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.TargetResolution

## -description
Gets or sets an optional value for the size of the frame provided to the target's monitor. This can differ from the size of the "source" frame buffer, in which case the display pipeline transforms the content using the [Rotation](displaypath_rotation.md) and [Scaling](displaypath_scaling.md) properties.

## -property-value
A value indicating the size of the frame provided to the target's monitor.

## -remarks
This property can remain unset (null) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
