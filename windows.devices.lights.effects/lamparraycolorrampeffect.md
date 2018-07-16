---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayColorRampEffect
-api-type: winrt class
---

<!-- Class syntax.
public class LampArrayColorRampEffect : ILampArrayEffect
-->

# Windows.Devices.Lights.Effects.LampArrayColorRampEffect

## -description
Transitions lamp/s from their existing color (whatever it was last set to), to the prescribed color.
## -remarks
Transition is via a simple linear curve over the prescribed [Duration]()

Behavior across lamps is not guaranteed to be identical as lamp/s can start from different colors.

Must be [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md) before can be played.

If a [LampArray](../windows.devices.lights/lamparray.md) is bound to a [ColorRampEffect/s](lamparraysolideffect.md) and it disconnects, progress of the effect continues as a no-op.  No exception/error is thrown/returned.
## -see-also

## -examples

