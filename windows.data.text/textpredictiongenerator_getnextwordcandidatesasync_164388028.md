---
-api-id: M:Windows.Data.Text.TextPredictionGenerator.GetNextWordCandidatesAsync(System.UInt32,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<IVectorView<string>> TextPredictionGenerator.GetNextWordCandidatesAsync(UInt32 maxCandidates, IIterable<String> previousStrings)
-->

# Windows.Data.Text.TextPredictionGenerator.GetNextWordCandidatesAsync

## -description
Asynchronously retrieves a collection of strings containing next-word-prediction candidates.

## -parameters

### -param maxCandidates
The maximum number of candidates to return.

### -param previousStrings
A collection of previously input words (to assist text prediction).

## -returns
An asynchronous operation object which, when it completes, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of strings, which are the next-word-prediction candidates.

## -remarks

## -see-also

## -examples

