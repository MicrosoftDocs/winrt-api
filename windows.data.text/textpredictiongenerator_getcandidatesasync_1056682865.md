---
-api-id: M:Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync(System.String,System.UInt32,Windows.Data.Text.TextPredictionOptions,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<IVectorView<string>> TextPredictionGenerator.GetCandidatesAsync(String input, UInt32 maxCandidates, TextPredictionOptions predictionOptions, IIterable<String> previousStrings)
-->

# Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync

## -description
Asynchronously retrieves a list of candidate words, up to a maximum count, based on the provided phonetic characters prefix and options.

## -parameters

### -param input
The beginning phonetic characters of the words to be returned.

### -param maxCandidates
The maximum number of predicted words to return.

### -param predictionOptions
A [TextPredictionOptions](textpredictionoptions.md) value containing prediction options.

### -param previousStrings
A collection of previously input words (to assist text prediction).

## -returns
An asynchronous operation object which, when it completes, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of strings, which are the predicted words.

## -remarks

## -see-also

## -examples

