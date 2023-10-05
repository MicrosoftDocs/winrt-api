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

## -examples

:::row:::
    :::column:::

        [LampArray sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/LampArray)
        
        Demonstrates how to control RGB lighting of peripheral devices using the [**Windows.Devices.Lights**](/uwp/api/windows.devices.lights) and [**Windows.Devices.Lights.Effects**](/uwp/api/windows.devices.lights.effects) APIs.

    :::column-end:::
    :::column:::

        [AutoRGB Sample](https://github.com/microsoft/Dynamic-Lighting-AutoRGB)
        
        Demonstrates how to extract a single, representative color from a desktop screen and use it to illuminate LED lamps on a connected RGB device.
            
    :::column-end:::
:::row-end:::

## -see-also

[Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
