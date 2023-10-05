---
-api-id: T:Windows.Devices.Lights.LampArray
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArray 
-->

# Windows.Devices.Lights.LampArray

## -description
Represents a LampArray device attached the system.  Currently, only [HID LampArrays](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf) are supported.
## -remarks
LampArray devices have one or more lamp indexes (for example, lights/LEDs/bulbs, etc…) whose color state can be directly manipulated.  Static information (retrieved from the device) describe supported colors, geometric positions and intended purposes for each lamp index.

These devices can be found as part of composite devices (for example, keyboard with RGB lighting) or as standalone.

An application can set lamp state at any time, but state will only be applied by the system while application is in focus.

LampArrays are enumerated by [DeviceWatcher](../windows.devices.enumeration/devicewatcher.md), and retrieved via [FromIdAsync](lamparray_fromidasync_1322863552.md).

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
