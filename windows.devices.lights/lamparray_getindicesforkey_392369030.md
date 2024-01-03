---
-api-id: M:Windows.Devices.Lights.LampArray.GetIndicesForKey(Windows.System.VirtualKey)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public int[] LampArray.GetIndicesForKey(VirtualKey key)
-->

# Windows.Devices.Lights.LampArray.GetIndicesForKey

## -description
Searches for all lamp indices that are bound to the specific [VirtualKey](../windows.system/virtualkey.md)

## -parameters
### -param key
The [VirtualKey](../windows.system/virtualkey.md).

## -returns
Array of all lamp indices that are bound to the specific [VirtualKey](../windows.system/virtualkey.md).  Array is empty if no lamp indices are found bound to the [VirtualKey](../windows.system/virtualkey.md).

## -remarks
Lamp indices can be (optionally) bound by the device to only a single key.  A [VirtualKey](../windows.system/virtualkey.md) may have 1 or more indices bound to it.

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
