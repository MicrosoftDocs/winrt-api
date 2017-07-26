---
-api-id: M:Windows.Data.Text.WordsSegmenter.GetTokenAt(System.String,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Data.Text.WordSegment GetTokenAt(System.String text, System.UInt32 startIndex)
-->

# Windows.Data.Text.WordsSegmenter.GetTokenAt

## -description
Determines and returns the word or word stem which contains or follows a specified index into the provided text.

## -parameters
### -param text
Provided text from which the word or word stem is to be returned.

### -param startIndex
A zero-based index into *text*. It must be less than the length of *text*.

## -returns
A [WordSegment](wordsegment.md) that represents the word or word stem.

## -remarks
Note that some languages do not use spaces (such as Japanese or Chinese) and some languages may return multiple word stems for compound words (such as German).

## -examples

## -see-also
