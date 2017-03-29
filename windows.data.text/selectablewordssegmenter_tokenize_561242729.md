---
-api-id: M:Windows.Data.Text.SelectableWordsSegmenter.Tokenize(System.String,System.UInt32,Windows.Data.Text.SelectableWordSegmentsTokenizingHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Tokenize(System.String text, System.UInt32 startIndex, Windows.Data.Text.SelectableWordSegmentsTokenizingHandler handler)
-->

# Windows.Data.Text.SelectableWordsSegmenter.Tokenize

## -description
Calls the provided handler with two iterators that iterate through the selectable words prior to and following a given index into the provided text.

## -parameters
### -param text
Provided text containing words to be selected.

### -param startIndex
A zero-based index into *text*. It must be less than the length of *text*.

### -param handler
The function that receives the iterators.

## -remarks
The iterators in [SelectableWordSegmentsTokenizingHandler](selectablewordsegmentstokenizinghandler.md) are lazy and evaluate small chunks of text at a time.

The handler is called at most once per call to [Tokenize](selectablewordssegmenter_tokenize.md). The handler is not called if there are no selectable words in *text*.

## -examples

## -see-also
[SelectableWordSegmentsTokenizingHandler](selectablewordsegmentstokenizinghandler.md)