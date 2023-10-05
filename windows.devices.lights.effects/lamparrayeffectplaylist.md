---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayEffectPlaylist : IIterable<ILampArrayEffect>, IVectorView<ILampArrayEffect>
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist

## -description

Used to either chain multiple effects together, or to start effects simultaneously.

## -remarks
 
Before you can play an effect, you must append it to a **LampArrayEffectPlaylist** (see [Append](lamparrayeffectplaylist_append_292269384.md)).

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
