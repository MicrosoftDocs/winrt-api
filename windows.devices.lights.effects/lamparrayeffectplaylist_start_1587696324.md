---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.Start
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.Start()
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.Start

## -description
Starts this playlist from the beginning, unless it was previously paused, which will then resuming playing from the paused position.

## -remarks
Effects are played in the order appended (see [Append](lamparrayeffectplaylist_append_292269384.md)) to the playlist.

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
