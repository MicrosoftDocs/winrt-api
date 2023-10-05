---
-api-id: M:Windows.Devices.Lights.LampArray.SetColorsForKey(Windows.UI.Color,Windows.System.VirtualKey)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArray.SetColorsForKey(Color desiredColor, VirtualKey key)
-->

# Windows.Devices.Lights.LampArray.SetColorsForKey

## -description
Sets the color for all lamps that map to the [key](../windows.system/virtualkey.md). Multiple lamps can map to the same [key](../windows.system/virtualkey.md).

## -parameters
### -param desiredColor
The desired color.

### -param key
The [VirtualKey](../windows.system/virtualkey.md).

## -remarks
If the lamp doesn't support the desired color, it is set to the [NearestSupportedColor](lampinfo_getnearestsupportedcolor_1689565521.md)

If the key is not bound to any lamp, the call fails silently.

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
