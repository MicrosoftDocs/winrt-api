---
-api-id: M:Windows.Devices.Display.Core.DisplayDevice.CreateScanoutSource(Windows.Devices.Display.Core.DisplayTarget)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public DisplaySource DisplayDevice.CreateScanoutSource(DisplayTarget target)
-->

# Windows.Devices.Display.Core.DisplayDevice.CreateScanoutSource

## -description
Creates a [DisplaySource](displaysource.md) object, which provides the ability to directly scan out/present to the [DisplayTarget](displaytarget.md) object or objects currently connected to this source.

## -parameters
### -param target
An active [DisplayTarget](displaytarget.md) for which to create a display source.

## -returns
A [DisplaySource](displaysource.md) value.

## -remarks
Creating a [DisplaySource](displaysource.md) object implicitly takes ownership of the source, and prevents others from presenting content to the screen.

## -see-also

## -examples
