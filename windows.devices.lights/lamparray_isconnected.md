---
-api-id: P:Windows.Devices.Lights.LampArray.IsConnected
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsConnected { get; }
-->

# Windows.Devices.Lights.LampArray.IsConnected

## -description
Gets a value indicating whether the LampArray device is connected to the system.

## -property-value
True if the LampArray is connected; otherwise, false.

## -remarks
Once disconnected, further calls to the object are null-ops and the object should be thrown away.  [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md) should be used to determine if the device is reconnected, and then a new LampArray instance should be created [FromIdAsync](lamparray_fromidasync_1322863552.md).

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
