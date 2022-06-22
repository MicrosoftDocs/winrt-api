---
-api-id: T:Windows.UI.Text.LineSpacingRule
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Text.LineSpacingRule : int
-->

# LineSpacingRule

## -description
Specifies options for line-spacing rules.



## -enum-fields
### -field Undefined:0
The line spacing is undefined.

### -field Single:1
Single space. The line-spacing value is ignored.

### -field OneAndHalf:2
One-and-a-half line spacing. The line-spacing value is ignored.

### -field Double:3
Double line spacing. The line-spacing value is ignored.

### -field AtLeast:4
The line-spacing value specifies the spacing from one line to the next. However, if the value is less than single spacing, text is single spaced.

### -field Exactly:5
The line-spacing value specifies the exact spacing from one line to the next, even if the value is less than single spacing.

### -field Multiple:6
The line-spacing value specifies the line spacing, in lines.

### -field Percent:7
The line-spacing value specifies the line spacing by percent of line height. This option is not supported by Windows.UI.Xaml.Controls.RichEditBox. Setting it will always return an InvalidArgumentException. 


## -remarks

## -examples

## -see-also
[ITextParagraphFormat.LineSpacingRule](itextparagraphformat_linespacingrule.md)
