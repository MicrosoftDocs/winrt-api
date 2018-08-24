---
-api-id: M:Windows.UI.Text.ITextDocument.BatchDisplayUpdates
-api-type: winrt method
---

<!-- Method syntax
public int BatchDisplayUpdates()
-->

# Windows.UI.Text.ITextDocument.BatchDisplayUpdates

## -description
Increments an internal counter that controls whether text updates are displayed immediately or batched.

## -returns
The value of the internal counter.

## -remarks
If the internal counter is nonzero, text updates are batched. This lets you perform a sequence of editing operations without the performance loss and flicker of screen updating.

To decrement the internal counter, call the [ITextDocument.ApplyDisplayUpdates](itextdocument_applydisplayupdates_1551145521.md) method.



> [!NOTE]
> If undo grouping is on (see [ITextDocument.BeginUndoGroup](itextdocument_beginundogroup_1705396921.md)), screen updating is suppressed regardless of the internal counter's value.

## -examples

## -see-also
[ITextDocument.ApplyDisplayUpdates](itextdocument_applydisplayupdates_1551145521.md)