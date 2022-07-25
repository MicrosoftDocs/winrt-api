---
-api-id: M:Windows.UI.Text.RichEditTextRange.SetIndex(Windows.UI.Text.TextRangeUnit,System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax.
public void RichEditTextRange.SetIndex(TextRangeUnit unit, Int32 index, Boolean extend)
-->

# Windows.UI.Text.RichEditTextRange.SetIndex

## -description

Moves the text range to the specified unit of the story.



## -parameters
### -param unit

The unit used to move the text range.

### -param index

The index of the specified unit. The text range is relocated to the unit that has this index. If unit is positive, the numbering of units begins at the start of the story and proceeds forward. If negative, the numbering begins at the end of the story and proceeds backward. The start of the story corresponds to index = 1 for all existing units, and the last unit in the story corresponds to index = – 1.

### -param extend

Indicates how to change the text range. True extends the text range to include the unit by moving only the end position of the text range. False collapses the text range to an insertion point and then moves the insertion point. The default value is false.

## -remarks

## -see-also

## -examples

