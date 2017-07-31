---
-api-id: M:Windows.Data.Text.SelectableWordsSegmenter.GetTokens(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Data.Text.SelectableWordSegment> GetTokens(System.String text)
-->

# Windows.Data.Text.SelectableWordsSegmenter.GetTokens

## -description
Determines and returns all of the selectable words or word stems in the provided text.

## -parameters
### -param text
Provided text containing words or word stems to be selected.

## -returns
A collection of [SelectableWordSegment](selectablewordsegment.md) objects that represent the selectable words or word stems.

## -remarks
Note that some languages do not use spaces (such as Japanese or Chinese) and some languages may return multiple word stems for compound words (such as German).

## -examples

## -see-also
