---
-api-id: M:Windows.UI.Text.RichEditTextRange.MoveEnd(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public int RichEditTextRange.MoveEnd(TextRangeUnit unit, Int32 count)
-->

# Windows.UI.Text.RichEditTextRange.MoveEnd

## -description

Moves the end position of the text range.



## -parameters
### -param unit

The unit by which to move the end position of the text range. The default value is Character.

### -param count

The number of _unit_s to move the end position of the text range. The default value is 1. If _count_ is greater than zero, the end position moves forward, toward the end of the story. If _count_ is less than zero, the end position move backward, toward the beginning of the story. If _count_ is zero, the end position does not move.

## -returns

The actual number of _unit_s that the end position of the text range moved.

## -remarks

## -see-also

## -examples

