---
-api-id: M:Windows.UI.Text.ITextSelection.MoveUp(Windows.UI.Text.TextRangeUnit,System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int MoveUp(Windows.UI.Text.TextRangeUnit unit, System.Int32 count, System.Boolean extend)
-->

# Windows.UI.Text.ITextSelection.MoveUp

## -description
Moves the insertion point or the active end of the text selection up, mimicking the functionality of the Up Arrow or Page Up keys.



## -parameters
### -param unit
The units by which to move the insertion point or active end. The following values are valid.<table>
   <tr><th>Value</th><th>Corresponding key combination</th><th>Meaning</th></tr>
   <tr><td>Line</td><td>Up Arrow</td><td>Moves up one line. This is the default.</td></tr>
   <tr><td>Paragraph</td><td>Ctrl+Up Arrow</td><td>Moves up one paragraph.</td></tr>
   <tr><td>Screen</td><td>Page Up</td><td>Moves up one screen.</td></tr>
   <tr><td>Window</td><td>Ctrl+Page Up</td><td>Moves to the first character in the window.</td></tr>
</table>

### -param count
The number of units to move. The default value is 1.

### -param extend
Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.

## -returns
The number of units the insertion point or active end is moved down. Collapsing the selection counts as one unit.

## -remarks
A nonzero *extend* value corresponds to the Shift key being pressed in addition to the key combination described in *unit*.

## -examples

## -see-also
[ITextSelection.MoveDown](itextselection_movedown_1876359068.md)
