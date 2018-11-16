---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.WireFormat
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DisplayWireFormat WireFormat { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.WireFormat

## -description
Gets or sets an optional value for the exact hardware representation used to scan out; such as the pixel encoding, bits per channel, color space, and HDR metadata format.

## -property-value
A [DisplayWireFormat](displaywireformat.md) value.

## -remarks
This property can remain unset (null) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
