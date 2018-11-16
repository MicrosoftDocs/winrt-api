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

Once the effect has been [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value is locked and is no longer possible to set the value.

## -see-also

## -examples

