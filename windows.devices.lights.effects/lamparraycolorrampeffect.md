---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayColorRampEffect
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayColorRampEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayColorRampEffect

## -description
Transitions lamp/s from their existing color (whatever last set to), to the prescribed color.

## -remarks
Transition is via a simple linear curve over the prescribed [RampDuration](lamparraycolorrampeffect_rampduration.md).

Behavior across lamps is not guaranteed to be identical as lamp/s can start from different colors.

Before you can play an effect, you must append it to a **LampArrayEffectPlaylist** (see [Append](lamparrayeffectplaylist_append_292269384.md)).

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArrayColorRampEffect and it disconnects, progress of the effect continues as a no-op. No exception/error is thrown/returned.

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


