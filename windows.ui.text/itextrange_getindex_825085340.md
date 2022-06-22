---
-api-id: M:Windows.UI.Text.ITextRange.GetIndex(Windows.UI.Text.TextRangeUnit)
-api-type: winrt method
---

<!-- Method syntax
public int GetIndex(Windows.UI.Text.TextRangeUnit unit)
-->

# Windows.UI.Text.ITextRange.GetIndex

## -description
Retrieves the story index of the text unit (word, line, sentence, paragraph, and so on) at the starting character position of the text range.



## -parameters
### -param unit
The text unit that is indexed.

## -returns
The index value. The value is zero if *unit* does not exist.

## -remarks
The first unit in a story has an index value of 1. The index of a unit is the same for all character positions from the position immediately preceding the unit, up to the last character in the unit.

For a text range at the end of a story, the index retrieved by GetIndex indicates the number of units in the story, such as the number of words, lines, objects, and so on.

The index value returned by the GetIndex method is not valid if the text is subsequently edited. Be careful when using retrieved index values, especially if you store the values for a significant length of time.

## -examples

## -see-also
[ITextRange.SetIndex](itextrange_setindex_1017096528.md)
