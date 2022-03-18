---
-api-id: M:Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync(System.String,System.UInt32)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<string>> GetCandidatesAsync(System.String input, System.UInt32 maxCandidates)
-->

# Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync

## -description
Asynchronously retrieves a list of candidate words, up to a maximum count, based on the provided phonetic characters prefix.

## -parameters
### -param input
The beginning phonetic characters of the words to be returned.

### -param maxCandidates
The maximum number of predicted words to return.

## -returns
An asynchronous operation object which, when it completes, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of strings, which are the predicted words.

## -remarks

## -examples

## -see-also
[GetCandidatesAsync(String)](textpredictiongenerator_getcandidatesasync_1095978545.md)