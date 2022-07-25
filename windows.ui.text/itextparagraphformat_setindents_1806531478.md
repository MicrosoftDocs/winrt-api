---
-api-id: M:Windows.UI.Text.ITextParagraphFormat.SetIndents(System.Single,System.Single,System.Single)
-api-type: winrt method
---

<!-- Method syntax
public void SetIndents(System.Single start, System.Single left, System.Single right)
-->

# Windows.UI.Text.ITextParagraphFormat.SetIndents

## -description
Sets the first-line indent, the left indent, and the right indent for a paragraph.



## -parameters
### -param start
The indent of the first line in a paragraph, relative to the left indent. The value is in floating-point points and can be positive or negative.

### -param left
The left indent of all lines except the first line in a paragraph, relative to the left margin. The value is in floating-point points and can be positive or negative.

### -param right
The right indent of all lines in a paragraph, relative to the right margin. The value is in floating-point points and can be positive or negative. This value is optional.

## -remarks
Line indents cannot position text in the margins. If the first-line indent is set to a negative value, for an outdented paragraph, while the left indent is zero, the first-line indent is reset to zero. To avoid this problem while retaining property sets, explicitly set the first-line indent value equal to zero, and then call SetIndents to set a nonnegative, left-indent value and set the desired first-line indent.

## -examples

## -see-also
[ITextParagraphFormat.FirstLineIndent](itextparagraphformat_firstlineindent.md), [ITextParagraphFormat.LeftIndent](itextparagraphformat_leftindent.md), [ITextParagraphFormat.RightIndent](itextparagraphformat_rightindent.md)
