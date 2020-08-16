---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayColorRampEffect.CompletionBehavior
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public LampArrayEffectCompletionBehavior CompletionBehavior { get;  set; }
-->

# Windows.Devices.Lights.Effects.LampArrayColorRampEffect.CompletionBehavior

## -description
Gets or sets the behavior when effect completes.

## -property-value
Default is [ClearState](lamparrayeffectcompletionbehavior.md)

## -remarks
If within an [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), behavior will be applied every time playlist repeats.

After you've appended (see [Append](lamparrayeffectplaylist_append_292269384.md)) an effect to a [LampArrayEffectPlaylist](lamparrayeffectplaylist.md), the value of this property is locked, and you can no longer change it.

## -see-also

## -examples

