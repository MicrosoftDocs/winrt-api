---
-api-id: T:Windows.Devices.Display.Core.DisplayManagerOptions
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum DisplayManagerOptions : uint 
-->

# Windows.Devices.Display.Core.DisplayManagerOptions

## -description
Defines constants that specify options for the [DisplayManager](displaymanager.md).

## -enum-fields

### -field None:0
Specifies no options.

### -field EnforceSourceOwnership:1
Restricts scanout to devices created by this [DisplayManager](displaymanager.md) object, or to [DisplaySource](displaysource.md) objects created using a shared handle provided by a path owned by this **DisplayManager**.

### -field VirtualRefreshRateAware: 2
Specifies that the client is virtual refresh rate aware, and can handle more advanced definitions of refresh rate. This lets you better use operating system functionality to virtualize refresh rate if the graphics stack supports it.

## -remarks

## -see-also

## -examples
