---
-api-id: P:Windows.UI.Xaml.Controls.HandwritingViewCandidatesChangedEventArgs.CandidatesSessionId
-api-type: winrt property
---

# Windows.UI.Xaml.Controls.HandwritingViewCandidatesChangedEventArgs.CandidatesSessionId

<!--
public uint CandidatesSessionId { get; }
-->

## -description

Gets the current auto-completion candidate session ID.

## -property-value

The session ID of the current auto-completion candidates.

## -remarks

Use the session ID to retrieve all auto-completion candidates in the session from the [HandwritingView](handwritingview.md), and notify the [HandwritingView](handwritingview.md) which candidate in the session was selected.

## -see-also

[GetCandidates(System.UInt32)](handwritingview_getcandidates_454088166.md), [SelectCandidate(System.UInt32,System.UInt32)](handwritingview_selectcandidate_1584727245.md)

## -examples
