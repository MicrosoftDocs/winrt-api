---
-api-id: T:Windows.Devices.Lights.Effects.LampArrayEffectCompletionBehavior
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum LampArrayEffectCompletionBehavior : int 
-->

# Windows.Devices.Lights.Effects.LampArrayEffectCompletionBehavior

## -description
Behavior when an effect completes.

## -enum-fields
### -field ClearState:0
Clears the state of all lamps when effect completes for the start of the next effect in the playlist. This is the typical case for most effects.

### -field KeepState:1
Maintains the state of all lamps when effect completes, so state is preserved for start of the next effect in the playlist. Use to seamlessly connect effects when the end state is known.

## -remarks

## -see-also

## -examples

