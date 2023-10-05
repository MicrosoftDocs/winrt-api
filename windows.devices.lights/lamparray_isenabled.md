---
-api-id: P:Windows.Devices.Lights.LampArray.IsEnabled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsEnabled { get;  set; }
-->

# Windows.Devices.Lights.LampArray.IsEnabled

## -description
Gets or sets the enabled state.

## -property-value
True if the device is enabled; otherwise false.

## -remarks
When disabled, state for a lamp index can be set internally, but will not be sent to the device. When set back to enabled, modified state is flushed to the device.

By default, LampArray is always enabled.

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
