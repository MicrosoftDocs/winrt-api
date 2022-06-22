---
-api-id: P:Windows.UI.Text.ITextRange.StartPosition
-api-type: winrt property
---

<!-- Property syntax
public int StartPosition { get;  set; }
-->

# Windows.UI.Text.ITextRange.StartPosition

## -description
Gets or sets the start position of the text range.



## -property-value
The character position to set as the start position of the text range.

## -remarks
If the start position is greater than the end position, this method sets the end position to be equal to the start position, resulting in a degenerate range (insertion point).

If this text range represents the active selection, the start position becomes the active end of the selection and is scrolled into view if the display is not frozen.

The following example shows how to convert a nondegenerate range into a degenerate range. `range.End = range.Start`

Similarly, the following example converts the text range into a degenerate range at the end of the range. `range.Start = range.End`

The following example adds 1 to end of the text range, if the range is not at the end of the story. `range.End = range.End + 1`

The preceding example also makes the end of the text range the active end, and can turn a degenerate range into a nondegenerate one.

## -examples

## -see-also
