---
-api-id: M:Windows.UI.Text.ITextRange.Paste(System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public void Paste(System.Int32 format)
-->

# Windows.UI.Text.ITextRange.Paste

## -description
Pastes text from the Clipboard into the text range.



## -parameters
### -param format
The clipboard format to use in the paste operation. Zero represents the best format, which usually is Rich Text Format (RTF), but CF_UNICODETEXT and other formats are also possible. The default value is zero.

## -remarks
> [!NOTE]
> On Windows Phone, this method throws an exception. Programmatic access to the clipboard is not supported on Windows Phone.

## -examples

## -see-also
[ITextRange.CanPaste](itextrange_canpaste_746058742.md), [ITextRange.Copy](itextrange_copy_4862135.md), [ITextRange.Cut](itextrange_cut_1740700893.md)
