---
-api-id: M:Windows.UI.Text.ITextSelection.MoveDown(Windows.UI.Text.TextRangeUnit,System.Int32,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public int MoveDown(Windows.UI.Text.TextRangeUnit unit, System.Int32 count, System.Boolean extend)
-->

# Windows.UI.Text.ITextSelection.MoveDown

## -description
Moves the insertion point or the active end of the text selection down, mimicking the functionality of the Down Arrow or Page Down key.



## -parameters
### -param unit
The units by which to move the insertion point or active end. The following values are valid.<table>
   <tr><th>Value</th><th>Corresponding key combination</th><th>Meaning</th></tr>
   <tr><td>Line</td><td>Down Arrow</td><td>Moves down one line. This is the default.</td></tr>
   <tr><td>Paragraph</td><td>Ctrl+Down Arrow</td><td>Moves down one paragraph.</td></tr>
   <tr><td>Screen</td><td>Page Down</td><td>Moves down one screen.</td></tr>
   <tr><td>Window</td><td>Ctrl+Page Down</td><td>Moves to the last character in the window.</td></tr>
</table>

### -param count
The number of units to move. The default value is 1.

### -param extend
Indicates how to change the selection. True extends the selection by moving only the active end. False collapses the selection to an insertion point and then moves the insertion point. The default value is false.

## -returns
The number of units that the insertion point or active end moved down. Collapsing the selection counts as one unit.

## -remarks
A nonzero *extend* value corresponds to the Shift key being pressed in addition to the key combination described in *unit*.

## -examples

## -see-also
[ITextSelection.MoveUp](itextselection_moveup_1557792442.md)
