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

Before you can play an effect, you must append it to a **LampArrayEffectPlaylist** (see [Append](lamparrayeffectplaylist_append_292269384.md)).

All lamps within the effect behave identically, subject to constraints of the lamp indexes (for example, color channels). Best effort will always be done to accommodate lamp index constraints.

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArraySolidEffect and it disconnects, progress of the effect continues as a no-op. No exception/error is thrown/returned.

## -see-also

## -examples

