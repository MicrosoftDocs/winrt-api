---
-api-id: P:Windows.UI.Text.Core.CoreTextServicesManager.ImeCompositionKind
-api-type: winrt property
---

<!-- Property syntax.
public ImeCompositionKind ImeCompositionKind { get; }
-->

# Windows.UI.Text.Core.CoreTextServicesManager.ImeCompositionKind

## -description

Gets the user setting for their preferred UI experience during text composition (before the string is finalized).

## -property-value

The text composition user experience setting.

## -remarks

Useful for UI Automation clients (such as screen readers) to check the user's preferred experience before announcing the string. The IME composition APIs let the screen reader spell out the character contents of IME composition text or announce suggested strings for inline prediction/suggestion, depending on user settings.

The user can set their preferred string composition experience in Settings -> Devices -> Typing -> Hardware keyboard.

## -see-also

[CoreTextServicesManager.ImeCompositionKindChanged](coretextservicesmanager_imecompositionkindchanged.md), [ImeCompositionKind](imecompositionkind.md)

## -examples
