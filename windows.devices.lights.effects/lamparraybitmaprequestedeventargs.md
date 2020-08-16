---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayBitmapRequestedEventArgs
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayBitmapRequestedEventArgs 
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapRequestedEventArgs

## -description
Provides event data for the [BitmapRequested](lamparraybitmapeffect_bitmaprequested.md) event.

## -remarks
Cannot call any methods on the object given by the event handler, outside of the event handler.

No effect progress can continue until the event handler has returned, so ensure the minimal time is spent within it.  (for example, do not load images from disk during the event handler).

## -see-also

## -examples

