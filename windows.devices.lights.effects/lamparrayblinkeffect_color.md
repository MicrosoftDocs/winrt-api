---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayBlinkEffect.Color
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Color Color { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayBlinkEffect.Color

## -description
Gets or sets the color of peak intensity for the effect. Duration color is visible defined by [SustainDuration](lamparrayblinkeffect_sustainduration.md).

## -property-value
Default is [Black](../windows.ui/colors_black.md)

## -remarks
After you've appended (see [Append](lamparrayeffectplaylist_append_292269384.md)) an effect to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value of this property is locked, and you can no longer change it.

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


