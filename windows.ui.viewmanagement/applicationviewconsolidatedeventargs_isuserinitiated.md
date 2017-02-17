---
-api-id: P:Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs.IsUserInitiated
-api-type: winrt property
---

<!-- Property syntax
public bool IsUserInitiated { get; }
-->

# Windows.UI.ViewManagement.ApplicationViewConsolidatedEventArgs.IsUserInitiated

## -description
Gets a value that indicates whether the window consolidation was user-initiated.

## -property-value
**true** if the window consolidation operation was user-initiated; otherwise, **false**.

## -remarks
This property is **true** if the window consolidation was due to the user performing a close gesture. Otherwise, windows consolidation could be system-initiated or app-initiated (by a call to [ApplicationView.TryConsolidateAsync](./applicationview_tryconsolidateasync_451004985.md)).

## -examples

## -see-also
