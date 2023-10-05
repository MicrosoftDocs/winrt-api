---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayCustomEffect
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayCustomEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayCustomEffect

## -description
This effect provides an entry-point for developer-defined custom effects into the effect framework; allowing it to be included and scheduled within playlists.

## -remarks
Similar to [BitmapEffect](lamparraybitmapeffect.md), a developer specifies the subset of lamp indexes to affect and then subscribes to the [UpdateRequested](lamparraycustomeffect_updaterequested.md) event to modify lamp state at a recurring interval.

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


