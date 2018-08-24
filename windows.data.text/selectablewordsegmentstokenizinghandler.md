---
-api-id: T:Windows.Data.Text.SelectableWordSegmentsTokenizingHandler
-api-type: winrt delegate
-api-device-family-note: xbox
---
<!-- Delegate syntax.
public delegate void SelectableWordSegmentsTokenizingHandler(Windows.Foundation.Collections.IIterable<Windows.Data.Text.SelectableWordSegment> precedingWords, Windows.Foundation.Collections.IIterable<Windows.Data.Text.SelectableWordSegment> words)
-->
# Windows.Data.Text.SelectableWordSegmentsTokenizingHandler

## -description
Defines the signature of a function that is provided to [SelectableWordsSegmenter.Tokenize](selectablewordssegmenter_tokenize_561242729.md).

## -parameters
### -param precedingWords
Contains the selectable words, in reverse order, that precede the parameter *startIndex* that is provided to [SelectableWordsSegmenter.Tokenize](selectablewordssegmenter_tokenize_561242729.md).

### -param words
Contains the selectable words that contain or follow the parameter *startIndex* that is provided to [SelectableWordsSegmenter.Tokenize](selectablewordssegmenter_tokenize_561242729.md).


## -remarks
One iterator passed to the handler iterates through all the selectable words in the provided text that occur prior to *startIndex* (passed to [Tokenize](selectablewordssegmenter_tokenize_561242729.md)), in reverse order. The other iterator iterates through all the selectable words in the provided text that contain or follow *startIndex*.

**Example**: If you provide [Tokenize](selectablewordssegmenter_tokenize_561242729.md) with "this is a simple example" and *startIndex* within the word "simple", *precedingWords* iterates through the words "a ", "is ", "this ", and *words* iterates through the words "simple ", "example".

*precedingWords* and *words* are valid only during the lifetime of the handler.

## -examples

## -see-also
[SelectableWordsSegmenter.Tokenize](selectablewordssegmenter_tokenize_561242729.md)