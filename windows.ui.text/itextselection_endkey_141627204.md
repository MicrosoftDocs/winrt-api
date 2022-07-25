---
-api-id: M:Windows.UI.Text.ITextSelection.EndKey(Windows.UI.Text.TextRangeUnit,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int EndKey(Windows.UI.Text.TextRangeUnit unit, System.Boolean extend)
-->

# Windows.UI.Text.ITextSelection.EndKey

## -description
Moves the insertion point or the active end of the text selection to the end of the specified unit, mimicking the functionality of the End key.



## -parameters
### -param unit
The units by which to move the insertion point or active end. The following values are valid.

### -param extend
Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.

## -returns
The number of units that the insertion point or the active end is moved.

## -remarks
The EndKey method is a logical method rather than a directional method and so is dependent on the language that is involved. For example, in Arabic text, EndKey moves to the left end of a line, whereas in English text, it moves to the right. Thus EndKey is different from the [ITextSelection.MoveRight](itextselection_moveright_1427894299.md) or [ITextSelection.MoveLeft](itextselection_moveleft_1979591935.md) methods. Also, note that the EndKey method is quite different from the End property, which is the character position at the end of the selection. EndKey also differs from the [ITextRange.EndOf](itextrange_endof_428994747.md) method in that it extends from the active end, whereas [EndOf](itextrange_endof_428994747.md) extends from End.

## -examples

## -see-also
[ITextSelection.HomeKey](itextselection_homekey_234543261.md)
