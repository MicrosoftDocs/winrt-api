---
-api-id: T:Windows.Media.Core.TimedTextLineAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Core.TimedTextLineAlignment : int
-->

# TimedTextLineAlignment

## -description
Specifies the alignment of a [TimedTextLine](timedtextline.md) relative to the [TimedTextRegion](timedtextregion.md) in which it is displayed.

## -enum-fields
### -field Start:0
The text line is aligned in the direction of the start of the text.

### -field End:1
The text line is aligned in the direction of the end of the text.

### -field Center:2
The text line is aligned in the center of the region.


## -remarks
The visual direction in which the text is aligned for each value depends on the [TimedTextFlowDirection](timedtextflowdirection.md) value of the text.

## -examples

## -see-also
[TimedTextLine](timedtextline.md), [TimedTextRegion](timedtextregion.md), [TimedTextFlowDirection](timedtextflowdirection.md)