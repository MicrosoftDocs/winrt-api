---
-api-id: M:Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
ms.custom: RS5
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<string>> GetCandidatesAsync(System.String input)
-->

# Windows.Data.Text.TextPredictionGenerator.GetCandidatesAsync

## -description
Asynchronously retrieves a list of candidate words based on the provided phonetic characters prefix.

## -parameters
### -param input
The beginning phonetic characters of the words to be returned.

## -returns
An asynchronous operation object which, when it completes, contains an [IVectorView](/previous-versions/br224594(v=vs.85)) of strings, which are the predicted words.

## -remarks

## -examples

## -see-also
[GetCandidatesAsync(String, UInt32)](textpredictiongenerator_getcandidatesasync_1185174467.md)
