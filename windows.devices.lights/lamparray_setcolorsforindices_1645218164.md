---
-api-id: M:Windows.Devices.Lights.LampArray.SetColorsForIndices(Windows.UI.Color[],System.Int32[])
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArray.SetColorsForIndices(Color[] desiredColors, Int32[] lampIndexes)
-->

# Windows.Devices.Lights.LampArray.SetColorsForIndices

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

If an index does not exist on the device, it is ignored and the remaining are still applied.

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
