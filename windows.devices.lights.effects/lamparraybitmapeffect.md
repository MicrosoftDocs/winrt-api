---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayBitmapEffect
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayBitmapEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect

## -description
Renders a series of images to selected lamp indexes on the device.

## -remarks
Effect captures a series of images, by the caller subscribing to the [BitmapRequested](lamparraybitmapeffect_bitmaprequested.md) event and calling [UpdateBitmap](lamparraybitmaprequestedeventargs_updatebitmap_191710798.md) when triggered. This allows for images created on-the-fly to be supplied to the effect.

Best effort is made to create a 2D composition of requested lamps and scale up/down images.

Before you can play an effect, you must append it to a **LampArrayEffectPlaylist** (see [Append](lamparrayeffectplaylist_append_292269384.md)).

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArrayBitmapEffect and it disconnects, progress of the effect continues as a no-op.  No exception/error is thrown/returned.
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


