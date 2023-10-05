---
-api-id: M:Windows.Devices.Lights.LampArray.GetIndicesForPurposes(Windows.Devices.Lights.LampPurposes)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public int[] LampArray.GetIndicesForPurposes(LampPurposes purposes)
-->

# Windows.Devices.Lights.LampArray.GetIndicesForPurposes

## -description
Searches for all lamp indices that are bound to the specified [LampPurposes](lamppurposes.md).

## -parameters
### -param purposes
The [LampPurposes](lamppurposes.md).

## -returns
Array of all lamp indices that are bound to the specific [LampPurposes](lamppurposes.md).  Array is empty if no lamp indices are found bound to the [LampPurposes](lamppurposes.md).

## -remarks
Lamp indices can be (optionally) bound by the device to multiple [LampPurposes](lamppurposes.md).

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
