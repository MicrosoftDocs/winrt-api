---
-api-id: E:Windows.Devices.Lights.Effects.LampArrayBitmapEffect.BitmapRequested
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler BitmapRequested<LampArrayBitmapEffect, LampArrayBitmapRequestedEventArgs>
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect.BitmapRequested

## -description
Event triggered by the system to indicate a new image should be supplied to the effect.

## -remarks
- Once a playlist starts the effect, it will immediately trigger the `BitmapRequested` event.
- If a playlist pauses the effect, it will temporarily stop further event triggers. Will resume when the playlist is started again.
- If a playlist stops the effect, no further event triggers will occur until the playlist starts again.
- The event will trigger a final time when the [Duration](lamparraybitmapeffect_duration.md) has expired. This should be used by the caller to set any final state before the effect completes.

Behavior of multiple handlers registered with this event is undefined.

## -see-also

## -examples

