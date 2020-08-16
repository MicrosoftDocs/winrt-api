---
-api-id: P:Windows.Devices.Lights.Effects.LampArraySolidEffect.StartDelay
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public TimeSpan StartDelay { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArraySolidEffect.StartDelay

## -description
Gets or sets the duration to delay before starting the effect.

## -property-value
Time value of the start delay. Default value is 0.

## -remarks
If within an [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), delay will be evaluated every time playlist repeats.

After you've appended (see [Append](lamparrayeffectplaylist_append_292269384.md)) an effect to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value of this property is locked, and you can no longer change it.

## -see-also

## -examples

