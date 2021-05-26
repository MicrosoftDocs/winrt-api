---
-api-id: M:Windows.UI.Xaml.Controls.HandwritingView.SelectCandidate(System.UInt32,System.UInt32)
-api-type: winrt method
---

# Windows.UI.Xaml.Controls.HandwritingView.SelectCandidate(System.UInt32,System.UInt32)

<!--
public void SelectCandidate (uint candidatesSessionId, uint selectedCandidateIndex);
-->

## -description

Retrieves the auto-completion candidate selected by the user.

## -parameters

### -param candidatesSessionId

The current auto-completion [CandidatesSessionId](handwritingviewcandidateschangedeventargs_candidatessessionid.md).

### -param selectedCandidateIndex

The index of the auto-completion candidate selected by the user from the candidate collection.

## -remarks

A candidate is selected only if the [CandidatesSessionId](handwritingviewcandidateschangedeventargs_candidatessessionid.md) is current.

## -see-also

## -examples
