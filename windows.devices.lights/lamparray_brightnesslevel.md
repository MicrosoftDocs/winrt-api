---
-api-id: P:Windows.Devices.Lights.LampArray.BrightnessLevel
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public double BrightnessLevel { get;  set; }
-->

# Windows.Devices.Lights.LampArray.BrightnessLevel

## -description
Gets or sets the overall brightness of the LampArray, where 0.0 is completely off and 1.0 is maximum brightness.

Every lamp is scaled equally by the brightness.

## -property-value
The current brightness level of the LampArray. Default is 1.0.

## -remarks
Values must be between 0.0 and 1.0 (inclusive).

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
