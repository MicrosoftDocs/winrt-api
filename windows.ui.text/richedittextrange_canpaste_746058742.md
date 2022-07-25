---
-api-id: M:Windows.UI.Text.RichEditTextRange.CanPaste(System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public bool RichEditTextRange.CanPaste(Int32 format)
-->

# Windows.UI.Text.RichEditTextRange.CanPaste

## -description

Determines whether the Clipboard contains content that can be pasted, using a specified format, into the current text range.



## -parameters
### -param format

The clipboard format. Zero represents the best format, which usually is Rich Text Format (RTF), but CF_UNICODETEXT and other formats are also possible. The default value is zero.

## -returns

**true** if the Clipboard content can be pasted into the text range in the specified format; otherwise, **false**.

## -remarks

## -see-also

## -examples

