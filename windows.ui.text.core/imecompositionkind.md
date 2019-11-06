---
-api-id: T:Windows.UI.Text.Core.ImeCompositionKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum ImeCompositionKind : int 
-->

# Windows.UI.Text.Core.ImeCompositionKind

## -description

Specifies the UI experience during text composition (before the string is finalized).

## -enum-fields

### -field TextSuggestion:1

Use inline prediction/text suggestion.

### -field Ime:0

Use Input Method Editor (IME) feedback.

## -remarks

Useful for UI Automation clients (such as screen readers) to check the user's preferred experience before announcing the string. The IME composition APIs let the screen reader spell out the character contents of IME composition text or announce suggested strings for inline prediction/suggestion, depending on user settings.

The user can set their preferred string composition experience in Settings -> Devices -> Typing -> Hardware keyboard.

## -see-also

[CoreTextServicesManager.ImeCompositionKind](coretextservicesmanager_imecompositionkind.md), [CoreTextServicesManager.ImeCompositionKindChanged](coretextservicesmanager_imecompositionkindchanged.md)

## -examples
