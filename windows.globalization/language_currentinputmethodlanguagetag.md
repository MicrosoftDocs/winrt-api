---
-api-id: P:Windows.Globalization.Language.CurrentInputMethodLanguageTag
-api-type: winrt property
---

<!-- Property syntax
public string CurrentInputMethodLanguageTag { get; }
-->

# Windows.Globalization.Language.CurrentInputMethodLanguageTag

## -description

Gets the [BCP-47](https://tools.ietf.org/html/bcp47) language tag for the currently enabled keyboard layout or Input Method Editor (IME).

## -property-value

The [BCP-47](https://tools.ietf.org/html/bcp47) language tag.

## -remarks

This property returns a value for the currently active input method on the thread with keyboard input focus. Calling this on a background thread may not return the expected results.

## -examples

## -see-also

[BCP-47 language tags](https://tools.ietf.org/html/bcp47)
