---
-api-id: E:Windows.UI.Text.Core.CoreTextServicesManager.ImeCompositionKindChanged
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler ImeCompositionKindChanged<object>
-->

# Windows.UI.Text.Core.CoreTextServicesManager.ImeCompositionKindChanged

## -description

Occurs when the user setting for their preferred UI experience during text composition (before the string is finalized) changes.

## -remarks

Useful for UI Automation clients (such as screen readers) to check the user's preferred experience before announcing the string. The IME composition APIs let the screen reader spell out the character contents of IME composition text or announce suggested strings for inline prediction/suggestion, depending on user settings.

The user can set their preferred string composition experience in Settings -> Devices -> Typing -> Hardware keyboard.

## -see-also

[CoreTextServicesManager.ImeCompositionKind](coretextservicesmanager_imecompositionkind.md), [ImeCompositionKind](imecompositionkind.md)

## -examples
