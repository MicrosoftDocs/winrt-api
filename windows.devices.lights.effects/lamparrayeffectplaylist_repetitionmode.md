---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.RepetitionMode
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public LampArrayRepetitionMode RepetitionMode { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayEffectPlaylist.RepetitionMode

## -description

Gets or sets the repetition behavior for playlist.

## -property-value

A [LampArrayRepetitionMode](lamparrayrepetitionmode.md) value. Default is **Occurrences**.

## -remarks

After playlist has started, the value is locked and it's no longer possible to set the value.

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


