---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColorForIndex(System.Int32,Windows.UI.Color)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayUpdateRequestedEventArgs.SetColorForIndex(Int32 lampIndex, Color desiredColor)
-->

# Windows.Devices.Lights.Effects.LampArrayUpdateRequestedEventArgs.SetColorForIndex

## -description
Sets the lamp corresponding to the index to the desired color.

## -parameters
### -param lampIndex
The lamp index.

### -param desiredColor
The desired color.

## -remarks
If the lamp at the index doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

If the index does not exist on the device or was not specified in the effect, the call fails silently.

[Black](../windows.ui/colors_black.md) is equivalent to a lamp being 'off'.

## -see-also

## -examples

