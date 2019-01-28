---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayCustomEffect.UpdateInterval
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public TimeSpan UpdateInterval { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayCustomEffect.UpdateInterval

## -description
Gets or sets the interval between the triggering of the [UpdateRequested](lamparraycustomeffect_updaterequested.md) event.  The supplied image will be displayed until the event is next triggered.

## -property-value
Time span value of the update interval. Default value is 0.

## -remarks
Once the effect has been [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value is locked and is no longer possible to set the value.

## -see-also

## -examples

