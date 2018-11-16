---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColorsForIndices(Windows.UI.Color[],System.Int32[])
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayUpdateRequestedEventArgs.SetColorsForIndices(Color[] desiredColors, Int32[] lampIndexes)
-->

# Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColorsForIndices

## -description
Sets the color for multiple lamps. Position within each array maps lamp index to desired color.

## -parameters
### -param desiredColors
Array of desired colors.

### -param lampIndexes
Array of corresponding lamp indexes to modify.

## -remarks
Size of desiredColors and lampIndexes arrays must be identical or call will fail.

If the lamp doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

If an index does not exist on the device or was not specified in the effect, it is ignored and the remaining are still applied.

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

