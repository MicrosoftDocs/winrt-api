---
-api-id: M:Windows.UI.Text.ITextRange.StartOf(Windows.UI.Text.TextRangeUnit,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int StartOf(Windows.UI.Text.TextRangeUnit unit, System.Boolean extend)
-->

# Windows.UI.Text.ITextRange.StartOf

## -description
Moves or extends the text range to the start of the nearest specified text unit. The text range is moved or extended backward in the document.



## -parameters
### -param unit
The unit by which to move the start position of the text range. The default value is **Word**.

### -param extend
True extends the text range by moving just the start position of the range to the start of the specified *unit*. False moves both ends of the text range to the start of the specified *unit*. The default value is false.

## -returns
The number of characters the insertion point or start position is moved. Note that this value is always less than or equal to zero, since the motion is always toward the beginning of the story.

## -remarks
If the text range is an insertion point on a boundary between *unit* s, this method does not change the start position.

The start position does not change if *unit* is set to **Character**.

## -examples

## -see-also
[ITextRange.EndOf](itextrange_endof_428994747.md)
