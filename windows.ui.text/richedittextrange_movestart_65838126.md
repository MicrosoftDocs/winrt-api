---
-api-id: M:Windows.UI.Text.RichEditTextRange.MoveStart(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public int RichEditTextRange.MoveStart(TextRangeUnit unit, Int32 count)
-->

# Windows.UI.Text.RichEditTextRange.MoveStart

## -description

Moves the start position of a text range.



## -parameters
### -param unit

The unit by which to move the start position of the text range. The default value is **Character**.

### -param count

The number of _unit_s to move the start position of the text range. The default value is 1. If _count_ is greater than zero, the start position of the text range moves forward, toward the end of the story. If _count_ is less than zero, the start position of the text range moves backward, toward the beginning of the story. If _count_ is zero, the start position doesn't move.

## -returns

The actual number of _unit_s that the start position moved. The pointer can be **null**.

## -remarks

## -see-also

## -examples

