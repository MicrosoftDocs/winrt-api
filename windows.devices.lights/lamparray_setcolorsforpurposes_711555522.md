---
-api-id: M:Windows.Devices.Lights.LampArray.SetColorsForPurposes(Windows.UI.Color,Windows.Devices.Lights.LampPurposes)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArray.SetColorsForPurposes(Color desiredColor, LampPurposes purposes)
-->

# Windows.Devices.Lights.LampArray.SetColorsForPurposes

## -description
Sets the color of multiple lamps, corresponding to [LampPurposes](lamppurposes.md).
## -parameters
### -param desiredColor
Array of desired colors.

### -param purposes
Array of corresponding [LampPurposes](lamppurposes.md) to modify.

## -remarks
If the lamp doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

