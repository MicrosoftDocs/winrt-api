---
-api-id: M:Windows.UI.Text.ITextRange.Expand(Windows.UI.Text.TextRangeUnit)
-api-type: winrt method
---

<!-- Method syntax
public int Expand(Windows.UI.Text.TextRangeUnit unit)
-->

# Windows.UI.Text.ITextRange.Expand

## -description
Expands a text range to completely contain any partial text units.



## -parameters
### -param unit
The text unit to use to expand the range. The default value is **Word**.

## -returns
The number of characters added to the text range, if the range was expanded to include a partially contained *unit*.

## -remarks
For example, if the insertion point is at the beginning, the end, or inside a word, the Expand method expands the range to include that word. If the range already includes one word and part of another, Expand expands the range to include both words.

## -examples

## -see-also
