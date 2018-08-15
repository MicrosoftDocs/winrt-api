---
-api-id: M:Windows.Data.Text.WordsSegmenter.Tokenize(System.String,System.UInt32,Windows.Data.Text.WordSegmentsTokenizingHandler)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Tokenize(System.String text, System.UInt32 startIndex, Windows.Data.Text.WordSegmentsTokenizingHandler handler)
-->

# Windows.Data.Text.WordsSegmenter.Tokenize

## -description
Calls the provided handler with two iterators that iterate through the words prior to and following a given index into the provided text.

## -parameters
### -param text
Provided text containing words to be returned.

### -param startIndex
A zero-based index into *text*. It must be less than the length of *text*.

### -param handler
The function that receives the iterators.

## -remarks
The iterators in [WordSegmentsTokenizingHandler](wordsegmentstokenizinghandler.md) are lazy and evaluate small chunks of text at a time.

The handler is called at most once per call to [Tokenize](wordssegmenter_tokenize_982453003.md). The handler is not called if there are no selectable words in *text*.

## -examples

## -see-also
[WordSegmentsTokenizingHandler](wordsegmentstokenizinghandler.md)