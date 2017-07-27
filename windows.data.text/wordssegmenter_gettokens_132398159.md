---
-api-id: M:Windows.Data.Text.WordsSegmenter.GetTokens(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Data.Text.WordSegment> GetTokens(System.String text)
-->

# Windows.Data.Text.WordsSegmenter.GetTokens

## -description
Determines and returns all of the words or word stems in the provided text.

## -parameters
### -param text
Provided text containing words or word stems to be returned.

## -returns
A collection of [WordSegment](wordsegment.md) objects that represent the words or word stems.

## -remarks
Note that some languages do not use spaces (such as Japanese or Chinese) and some languages may return multiple word stems for compound words (such as German).

## -examples

## -see-also
