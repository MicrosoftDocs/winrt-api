---
-api-id: M:Windows.UI.Text.ITextRange.MoveEnd(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public int MoveEnd(Windows.UI.Text.TextRangeUnit unit, System.Int32 count)
-->

# Windows.UI.Text.ITextRange.MoveEnd

## -description
Moves the end position of the text range.



## -parameters
### -param unit
The unit by which to move the end position of the text range. The default value is **Character**.

### -param count
The number of *unit*s to move the end position of the text range. The default value is 1. If *count* is greater than zero, the end position moves forward, toward the end of the story. If *count* is less than zero, the end position move backward, toward the beginning of the story. If *count* is zero, the end position does not move.

## -returns
The actual number of *unit*s that the end position of the text range moved.

## -remarks
If you move the end position of the text range so that it precedes the original start position, this method sets the start position to be equal to the new end position; that is, the text range becomes a degenerate range (insertion point).

This method moves the end position in a logical direction rather than a physical direction. That is, movement is toward the end or start of a story. Depending on the language, moving the end position toward the end of the story could result in the end position moving either left or right.

For more information, see the discussion in [ITextRange](itextrange.md) and the Remarks section of [ITextRange.Move](itextrange_move_1126378751.md).

## -examples

## -see-also
[ITextRange.Move](itextrange_move_1126378751.md), [ITextRange.MoveStart](itextrange_movestart_65838126.md)
