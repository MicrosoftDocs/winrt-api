---
-api-id: M:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.IndexOf(Windows.Devices.Lights.Effects.ILampArrayEffect,System.UInt32@)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool LampArrayEffectPlaylist.IndexOf(ILampArrayEffect value, UInt32 index)
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.IndexOf

## -description

Retrieves the index, within a playlist, of the specified lamp array effect.

## -parameters

### -param value

An [ILampArrayEffect](ilamparrayeffect.md) representing the lamp array effect whose index to retrieve.

### -param index

The index of the effect within the playlist, as an out parameter. If the *value* is found, then the method will update *index* with the zero-based index of the effect within the playlist.

## -returns

`true` if the effect is found, otherwise `false`.

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
