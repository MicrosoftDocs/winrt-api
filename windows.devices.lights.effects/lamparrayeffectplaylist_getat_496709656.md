---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.GetAt(System.UInt32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public ILampArrayEffect LampArrayEffectPlaylist.GetAt(UInt32 index)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.GetAt

## -description

Retrieves the lamp array effect at the specified index within a playlist.

## -parameters

### -param index

The zero-based index of the lamp array effect to retrieve.

## -returns

An [ILampArrayEffect](ilamparrayeffect.md) representing the lamp array effect at the specified index within the playlist.

## -remarks

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
