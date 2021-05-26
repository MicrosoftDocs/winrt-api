---
-api-id: M:Windows.UI.Xaml.Controls.HandwritingView.GetCandidates(System.UInt32)
-api-type: winrt method
---

# Windows.UI.Xaml.Controls.HandwritingView.GetCandidates(System.UInt32)

<!--
public System.Collections.Generic.IReadOnlyList<string> GetCandidates (uint candidatesSessionId);
-->

## -description

Retrieves the updated collection of auto-completion candidates after a [CandidatesChanged](handwritingview_candidateschanged.md) event.

## -parameters

### -param candidatesSessionId

[CandidatesSessionId](handwritingviewcandidateschangedeventargs_candidatessessionid.md)

## -returns

The updated collection of auto-completion candidates.

The candidate collection is returned only if the [CandidatesSessionId](handwritingviewcandidateschangedeventargs_candidatessessionid.md) is current.

## -remarks

## -see-also

## -examples
