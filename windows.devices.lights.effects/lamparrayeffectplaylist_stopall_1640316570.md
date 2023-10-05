---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StopAll(Windows.Foundation.Collections.IIterable{Windows.Devices.Lights.Effects.LampArrayEffectPlaylist})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void LampArrayEffectPlaylist.StopAll(IIterable<LampArrayEffectPlaylist> value)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.StopAll

## -description
Guarantees that all playlists will stop at the same time.

## -parameters
### -param value
Playlists to stop simultaneously.

## -remarks
This removes the small lag time that occurs if called on each [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) from within a for-loop.

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


