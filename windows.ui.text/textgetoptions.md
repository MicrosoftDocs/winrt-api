---
-api-id: T:Windows.UI.Text.TextGetOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.TextGetOptions : uint
-->

# TextGetOptions

## -description
Specifies options for retrieving the text in a document or text range.



## -enum-fields
### -field None:0
None of the following options is used.

### -field AdjustCrlf:1
If the starting character position is in the middle of a construct such as a CRLF (U+000D U+000A), surrogate pair, variation-selector sequence, or table-row delimiter, move to the beginning of the construct.

### -field UseCrlf:2
Use carriage return/line feed (CR/LF) in place of a carriage return.

### -field UseObjectText:4
Retrieve text including the alternate text for the images in the range.

### -field AllowFinalEop:8
Allow retrieving the final end-of-paragraph (EOP) if it’s included in the range. This EOP exists in all rich-text controls and cannot be deleted. It does not exist in plain-text controls.

### -field NoHidden:32
Don't include hidden text.

### -field IncludeNumbering:64
Include list numbers.

### -field FormatRtf:8192
Retrieve Rich Text Format (RTF) instead of plain text. Rich Text Format (RTF) is a BYTE (8-bit) format, but because [ITextRange.GetText](itextrange_gettext_518428927.md) returns a string, the Rich Text Format (RTF) is returned as WCHARs (16-bit or UTF-16), not bytes, when you call [ITextRange.GetText](itextrange_gettext_518428927.md) with the **FormatRtf** value. When you call [ITextRange.SetText](itextrange_settext_522499431.md) with **FormatRtf**, the method accepts an string containing either bytes or WCHARs, but other Rich Text Format (RTF) readers only understand bytes.

### -field UseLf:16777216
Use line feed (LF) in place of all carriage returns.


## -remarks
If both UseLf and UseCrLf are used an invalid argument exception is thrown. 

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | UseLf |

## -examples

## -see-also
[ITextDocument.GetText](itextdocument_gettext_518428927.md), [ITextDocument.SaveToStream](itextdocument_savetostream_748724562.md), [ITextRange.GetTextViaStream](itextrange_gettextviastream_1369580261.md), [ITextRange.SetTextViaStream](itextrange_settextviastream_1369572373.md), [ITextRange.GetText](itextrange_gettext_518428927.md)
