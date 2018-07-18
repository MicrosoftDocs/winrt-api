---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayBlinkEffect.CompletionBehavior
-api-type: winrt property
---

<!-- Property syntax.
public LampArrayEffectCompletionBehavior CompletionBehavior { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayBlinkEffect.CompletionBehavior

## -description
Gets or sets the behavior when effect completes.

## -property-value
Lamp completion behavior. Default is [ClearState](lamparrayeffectcompletionbehavior.md)

## -remarks
Keeping the state can help provide a smooth transition between effects.

If within an [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), behavior will be applied every time playlist repeats.

Once the effect has been [Appended](lamparrayeffectplaylist_append_292269384.md) to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value is locked and is no longer possible to set the value.

## -see-also

## -examples

