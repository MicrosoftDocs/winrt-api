---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayEffectStartMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampArrayEffectStartMode : int 
-->

# Windows.Devices.Lights.Effects.LampArrayEffectStartMode

## -description

Defines constants that specify the starting behavior of effects in a playlist.

## -enum-fields

### -field Sequential:0

Specifies that effects should be started one at a time, in the order in which they were added.

### -field Simultaneous:1

Specifies that effects should be started all at the same time.

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

[LampArrayEffectPlaylist.EffectStartMode](lamparrayeffectplaylist_effectstartmode.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)
