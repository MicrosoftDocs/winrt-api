---
-api-id: M:Windows.UI.Text.ITextSelection.MoveLeft(Windows.UI.Text.TextRangeUnit,System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int MoveLeft(Windows.UI.Text.TextRangeUnit unit, System.Int32 count, System.Boolean extend)
-->

# Windows.UI.Text.ITextSelection.MoveLeft

## -description
Moves the insertion point or the active end of the text selection to the left, mimicking the functionality of the Left Arrow key.



## -parameters
### -param unit
The units by which to move the insertion point or active end. The following values are valid. <table>
   <tr><th>Value</th><th>Corresponding key combination</th><th>Meaning</th></tr>
   <tr><td>Character</td><td>Left Arrow</td><td>Move one character position to the left. This is the default.</td></tr>
   <tr><td>Word</td><td>Ctrl+Left Arrow</td><td>Move one word to the left.</td></tr>
</table>

### -param count
The number of units to move. The default value is 1. If *count* is less than zero, movement is to the right.

### -param extend
Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.

## -returns
The number of units that the insertion point or active end moved. Collapsing the selection counts as one unit.

## -remarks
A nonzero *extend* value corresponds to the Shift key being pressed in addition to the key combination described in *unit*.

## -examples

## -see-also
[ITextSelection.MoveRight](itextselection_moveright_1427894299.md)
