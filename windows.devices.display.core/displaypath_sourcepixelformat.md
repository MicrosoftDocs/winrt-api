---
-api-id: P:Windows.Devices.Display.Core.DisplayPath.SourcePixelFormat
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public DirectXPixelFormat SourcePixelFormat { get;  set; }
-->

# Windows.Devices.Display.Core.DisplayPath.SourcePixelFormat

## -description
Gets or sets the pixel format of the surfaces that will be allowed to present to this [DisplayPath](displaypath.md).

## -property-value
A [DirectXPixelFormat](../windows.graphics.directx/directxpixelformat.md) value.

## -remarks
This property can remain at its default value (**DirectXPixelFormat::Unknown**) in order to allow the system to fill it in during a call to [TryApply](displaystate_tryapply_634222246.md) or [TryFunctionalize](displaystate_tryfunctionalize_741039460.md).

## -see-also

## -examples
