---
-api-id: M:Windows.Devices.Lights.LampArray.SetColor(Windows.UI.Color)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArray.SetColor(Color desiredColor)
-->

# Windows.Devices.Lights.LampArray.SetColor

## -description
Sets every lamp belonging to the LampArray to the desired color.

## -parameters
### -param desiredColor
Desired color to set every lamp to.

## -remarks
If a lamp doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

