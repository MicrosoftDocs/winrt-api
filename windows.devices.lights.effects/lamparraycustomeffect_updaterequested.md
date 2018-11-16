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

## -see-also

## -examples

