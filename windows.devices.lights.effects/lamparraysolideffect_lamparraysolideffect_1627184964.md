---
-api-id: M:Windows.Devices.Lights.Effects.LampArraySolidEffect.#ctor(Windows.Devices.Lights.LampArray,System.Int32[])
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public LampArraySolidEffect.LampArraySolidEffect(LampArray lampArray, Int32[] lampIndexes)
-->

# Windows.Devices.Lights.Effects.LampArraySolidEffect.LampArraySolidEffect

## -description
Creates and initializes a new instance of the effect.
## -parameters
### -param lampArray
The [LampArray](../windows.devices.lights/lamparray.md) the effect is played on.

### -param lampIndexes
Subset of lamp indexes that effect will apply to.

## -remarks
Effect creation does not start the effect.
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


