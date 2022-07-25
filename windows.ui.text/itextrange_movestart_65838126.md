---
-api-id: M:Windows.UI.Text.ITextRange.MoveStart(Windows.UI.Text.TextRangeUnit,System.Int32)
-api-type: winrt method
---

<!-- Method syntax
public int MoveStart(Windows.UI.Text.TextRangeUnit unit, System.Int32 count)
-->

# Windows.UI.Text.ITextRange.MoveStart

## -description
Moves the start position of a text range.



## -parameters
### -param unit
The unit by which to move the start position of the text range. The default value is **Character**.

### -param count
The number of *unit*s to move the start position of the text range. The default value is 1. If *count* is greater than zero, the start position of the text range moves forward, toward the end of the story. If *count* is less than zero, the start position of the text range moves backward, toward the beginning of the story. If *count* is zero, the start position doesn't move.

## -returns
The actual number of *unit*s that the start position moved. The pointer can be **NULL**.

## -remarks
If you move the start position of the text range so that it follows the original end position, this method sets the end position to be equal to the new start position; that is, the text range becomes a degenerate range (insertion point).

This method moves the start position in a logical direction rather than a physical direction. That is, movement is toward the end or start of a story. Depending on the language, moving the start position toward the end of the story could result in the start position moving either left or right.

For more information, see the discussion in [ITextRange](itextrange.md) and the Remarks section of [ITextRange.Move](itextrange_move_1126378751.md).

## -examples

## -see-also
[ITextRange.Move](itextrange_move_1126378751.md), [ITextRange.MoveEnd](itextrange_moveend_1212634036.md)
