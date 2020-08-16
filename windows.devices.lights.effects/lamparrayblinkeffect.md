---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayBlinkEffect
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class LampArrayBlinkEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayBlinkEffect

## -description
Blinks lamp/s a color for a specific duration.  Timing of attack/sustain/decay phases can be defined.

## -remarks
Always starts from off/[Black](../windows.ui/colors_black.md), attacks to a defined color, sustains at peak color intensity, then decays back to off/[Black](../windows.ui/colors_black.md)

Will always set the state of lamp/s to off/[Black](../windows.ui/colors_black.md) when effect completes, regardless of progress.

Before you can play an effect, you must append it to a **LampArrayEffectPlaylist** (see [Append](lamparrayeffectplaylist_append_292269384.md)).

All lamps within the effect behave identically, subject to contraints of the lamp indexes (for example, color channels). Best effort will always be done to accommodate lamp index constraints.

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a LampArrayBlinkEffect and it disconnects, progress of the effect continues as a no-op. No exception/error is thrown/returned.

## -see-also

## -examples

