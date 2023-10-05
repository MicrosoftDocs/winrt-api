---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayRepetitionMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampArrayRepetitionMode : int 
-->

# Windows.Devices.Lights.Effects.LampArrayRepetitionMode

## -description
Defines constants that specify the repetition behavior for effect/playlist.

## -enum-fields
### -field Occurrences:0
Specifies that the effect/playlist is run for the defined number of times.

### -field Forever:1
Specifies that the effect/playlist is run forever. Can only be stopped by stopping the playlist.

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

[LampArrayBlinkEffect.RepetitionMode](lamparrayblinkeffect_repetitionmode.md), [LampArrayEffectPlaylist.RepetitionMode](lamparrayeffectplaylist_repetitionmode.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)


