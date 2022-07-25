---
-api-id: M:Windows.UI.Text.ITextRange.EndOf(Windows.UI.Text.TextRangeUnit,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int EndOf(Windows.UI.Text.TextRangeUnit unit, System.Boolean extend)
-->

# Windows.UI.Text.ITextRange.EndOf

## -description
Moves or extends the text range to the end of the nearest specified text unit. The text range is moved or extended forward in the document.



## -parameters
### -param unit
The unit by which to move the end position of the text range.

### -param extend
True extends the text range by moving just the end position of the range to the end of the specified *unit*. False moves both ends of the text range to the end of the specified *unit*. The default value is false.

## -returns
The number of character positions that the range was moved or extended, plus 1 if the text range collapsed to the start of the range. If the text range includes the final carriage return (CR) at the end of the story, and *extend* is false, the return value is set to –1 to indicate that the collapse occurred before the end of the range. This is because an insertion point cannot exist beyond the final CR.

## -remarks
If the range is an insertion point on a boundary between units, the EndOf method does not change the end position of the range.

## -examples

## -see-also
