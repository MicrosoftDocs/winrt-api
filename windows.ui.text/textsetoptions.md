---
-api-id: T:Windows.UI.Text.TextSetOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.TextSetOptions : uint
-->

# TextSetOptions

## -description
Specifies options for setting the text in a text range.



## -enum-fields
### -field None:0
No text setting option is specified.

### -field UnicodeBidi:1
Use the Unicode bidirectional algorithm.

### -field Unlink:8
Don't include text as part of a hyperlink.

### -field Unhide:16
Don't insert as hidden text.

### -field CheckTextLimit:32
Obey the current text limit instead of increasing the limit to fit.

### -field FormatRtf:8192
Treat input text as Rich Text Format (RTF) (the Rich Text Format (RTF) text will be validated).

### -field ApplyRtfDocumentDefaults:16384
Apply the Rich Text Format (RTF) default settings for the document. Rich Text Format (RTF) often contains document default properties. These properties are typically ignored when inserting Rich Text Format (RTF) (as distinguished from opening an Rich Text Format (RTF) file).


## -remarks

## -examples

## -see-also
[ITextDocument.LoadFromStream](itextdocument_loadfromstream_1957374177.md), [ITextDocument.SetText](itextdocument_settext_522499431.md), [ITextRange.SetText](itextrange_settext_522499431.md), [ITextRange.SetTextViaStream](itextrange_settextviastream_1369572373.md)
