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

Best effort is done to create a 2D composition of requested lamps and scale up/down images.

Must be [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) before can be played.

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArrayBitmapEffect and it disconnects, progress of the effect continues as a no-op.  No exception/error is thrown/returned.
## -see-also

## -examples

