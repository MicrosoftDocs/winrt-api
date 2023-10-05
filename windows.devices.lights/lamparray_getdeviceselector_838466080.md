---
-api-id: M:Windows.Devices.Lights.LampArray.GetDeviceSelector
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public string LampArray.GetDeviceSelector()
-->

# Windows.Devices.Lights.LampArray.GetDeviceSelector

## -description
Retrieves an Advanced Query Syntax (AQS) string encompassing all LampArray devices on the system. 

## -returns
An AQS string encompassing all LampArray devices on the system.

## -remarks
You can use this string with the [DeviceInformation.FindAllAsync](/uwp/api/windows.devices.enumeration.deviceinformation.findallasync) method or [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md) to get [DeviceInformation](../windows.devices.enumeration/deviceinformation_findallasync_1257462890.md) objects for those LampArrays

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
