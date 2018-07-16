---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayBitmapEffect
-api-type: winrt class
---

<!-- Class syntax.
public class LampArrayBitmapEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect

## -description
Renders a series of images to selected lamp indexes on the device.

## -remarks
Effect captures the Series of images by caller subscribing to the [BitmapRequested](lamparraybitmapeffect_bitmaprequested.md) event and calling [UpdateBitmap](lamparraybitmaprequestedeventargs_updatebitmap_191710798.md) when triggered. This allows for images created on-the-fly to be supplied to the effect.

Best effort is done to create a 2D composition of requested lamps and scale up/down images.

## -see-also

## -examples

