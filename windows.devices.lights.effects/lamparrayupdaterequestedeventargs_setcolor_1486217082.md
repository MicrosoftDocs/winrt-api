---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColor(Windows.UI.Color)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayUpdateRequestedEventArgs.SetColor(Color desiredColor)
-->

# Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColor

## -description
Sets every lamp index specified in the effect to the desired color.

## -parameters
### -param desiredColor
Desired color to set every lamp to.

## -remarks
If a lamp doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

