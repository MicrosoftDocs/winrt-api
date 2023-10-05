---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.GetMany(System.UInt32,Windows.Devices.Lights.Effects.ILampArrayEffect[])
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public uint LampArrayEffectPlaylist.GetMany(UInt32 startIndex, ILampArrayEffect[] items)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.GetMany

## -description

Retrieves a range of lamp array effects, beginning at the specified index within a playlist.

## -parameters

### -param startIndex

The zero-based index of the first lamp array effect to retrieve.

### -param items

An array of [ILampArrayEffect](ilamparrayeffect.md), which the method will update with the requested effects.

## -returns

The number of effects returned in *items*.

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
