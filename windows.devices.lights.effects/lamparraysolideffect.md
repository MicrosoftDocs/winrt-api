---
-api-id: T:Windows.Devices.Lights.Effects.LampArraySolidEffect
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArraySolidEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArraySolidEffect

## -description
Displays a solid/static color for a specific duration.

## -remarks
Must be [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) before can be played.

All lamps within the effect behave identically, subject to constraints of the lamp indexes (e.g. color channels).  Best effort will always be done to accommodate lamp index constraints.

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArraySolidEffect and it disconnects, progress of the effect continues as a no-op.  No exception/error is thrown/returned.

## -see-also

## -examples

