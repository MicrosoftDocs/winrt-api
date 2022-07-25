---
-api-id: P:Windows.UI.Text.ITextCharacterFormat.ProtectedText
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FormatEffect ProtectedText { get;  set; }
-->

# Windows.UI.Text.ITextCharacterFormat.ProtectedText

## -description
Gets or sets whether the characters are protected against attempts to modify them.



## -property-value
The protected state.

## -remarks
In general, calling methods in the [Windows.UI.Text](windows_ui_text.md) namespace that attempt to change the formatting or content of a text range will fail if any part of the range is protected, or if the document is read-only. To change protected text, an app should attempt to turn off the protection of the text to be modified. The owner of the document might permit this to happen.

## -examples

## -see-also
