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
If the lamp at the index doesn't support the desired color, it is set to the [NearestSupportedColor](../windows.devices.lights/lampinfo_getnearestsupportedcolor_1689565521.md)

If the index does not exist on the device or was not specified in the effect, the call fails silently.

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


