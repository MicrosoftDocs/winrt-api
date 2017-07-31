---
-api-id: M:Windows.Data.Text.SelectableWordsSegmenter.GetTokenAt(System.String,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Data.Text.SelectableWordSegment GetTokenAt(System.String text, System.UInt32 startIndex)
-->

# Windows.Data.Text.SelectableWordsSegmenter.GetTokenAt

## -description
Determines and returns the selectable word or word stem which contains or follows a specified index into the provided text.

## -parameters
### -param text
Provided text in which a word or word stem is to be selected.

### -param startIndex
A zero-based index into *text*. It must be less than the length of *text*.

## -returns
A [SelectableWordSegment](selectablewordsegment.md) that represents the selected word or word stem.

## -remarks
Note that some languages do not use spaces (such as Japanese or Chinese) and some languages may return multiple word stems for compound words (such as German).

## -examples

## -see-also
