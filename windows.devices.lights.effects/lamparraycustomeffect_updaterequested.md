---
-api-id: E:Windows.Devices.Lights.Effects.LampArrayCustomEffect.UpdateRequested
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler UpdateRequested<LampArrayCustomEffect, LampArrayUpdateRequestedEventArgs>
-->

# Windows.Devices.Lights.Effects.LampArrayCustomEffect.UpdateRequested

## -description
Event triggered by the system to indicate that lamp state should be modified.

## -remarks
- Once a playlist starts the effect it will immediately trigger the UpdateRequested event.
- If a playlist pauses the effect, it will temporarily stop further event triggers. Will resume when the playlist is started again.
- If a playlist stops the effect, no further event triggers will occur until the playlist starts again.
- The event will trigger a final time when the [Duration](lamparraycustomeffect_duration.md) has expired. This should be used by the caller to set any final state before the effect completes.

Behavior of multiple handlers registered with this event is undefined.

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

[LampArrayUpdateRequestedEventArgs](lamparrayupdaterequestedeventargs.md), [Lighting and Illumination (www.usb.org)](https://www.usb.org/sites/default/files/hutrr84_-_lighting_and_illumination_page.pdf), [Dynamic lighting](/windows/uwp/devices-sensors/lighting-dynamic-lamparray)


