---
-api-id: M:Windows.Devices.Lights.LampArray.SetColorsForKeys(Windows.UI.Color[],Windows.System.VirtualKey[])
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArray.SetColorsForKeys(Color[] desiredColors, VirtualKey[] keys)
-->

# Windows.Devices.Lights.LampArray.SetColorsForKeys

## -description
Sets the color of multiple lamps, corresponding to mapped [keys](../windows.system/virtualkey.md).  Position within each array maps [keys](../windows.system/virtualkey.md) to desired color.

## -parameters
### -param desiredColors
Array of desired colors.

### -param keys
Array of corresponding [VirtualKeys](../windows.system/virtualkey.md) to modify.

## -remarks
If the lamp index doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

If a [VirtualKey](../windows.system/virtualkey.md) is not bound to any lamp on the device, it is ignored and the remaining are still applied.

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

