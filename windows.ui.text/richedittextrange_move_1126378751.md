---
-api-id: M:Windows.UI.Text.RichEditTextRange.Move(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax.
public int RichEditTextRange.Move(TextRangeUnit unit, Int32 count)
-->

# Windows.UI.Text.RichEditTextRange.Move

## -description

Moves the insertion point forward or backward by the specified number of _unit_s. If the text range is nondegenerate, it is collapsed to an insertion point at the start or end position of the text range, depending on _count_, and then is moved.



## -parameters
### -param unit

The units to move the insertion point. The default value is **Character**.

### -param count

The number of _unit_s to move the insertion point. The default value is 1. If _count_ is greater than zero, the insertion point moves forward, toward the end of the story. If _count_ is less than zero, the insertion point moves backward, toward the beginning of the story. If _count_ is zero, the range is unchanged.

## -returns

The actual number of units the insertion point moves.

## -remarks

## -see-also

## -examples

