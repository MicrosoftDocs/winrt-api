---
-api-id: M:Windows.UI.Text.RichEditTextRange.EndOf(Windows.UI.Text.TextRangeUnit,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public int RichEditTextRange.EndOf(TextRangeUnit unit, Boolean extend)
-->

# Windows.UI.Text.RichEditTextRange.EndOf

## -description

Moves or extends the text range to the end of the nearest specified text unit. The text range is moved or extended forward in the document.



## -parameters
### -param unit

The unit by which to move the end position of the text range.

### -param extend

**true** to extend the text range by moving just the end position of the range to the end of the specified unit. **false** to move both ends of the text range to the end of the specified unit. The default is **false**.

## -returns

The number of character positions that the range was moved or extended, plus 1 if the text range collapsed to the start of the range. If the text range includes the final carriage return (CR) at the end of the story, and extend is false, the return value is set to –1 to indicate that the collapse occurred before the end of the range. This is because an insertion point cannot exist beyond the final CR.

## -remarks

## -see-also

## -examples

