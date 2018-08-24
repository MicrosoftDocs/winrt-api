---
-api-id: M:Windows.UI.Text.ITextDocument.ApplyDisplayUpdates
-api-type: winrt method
---

<!-- Method syntax
public int ApplyDisplayUpdates()
-->

# Windows.UI.Text.ITextDocument.ApplyDisplayUpdates

## -description
Decrements an internal counter that controls whether text updates are displayed immediately or batched.

## -returns
The value of the internal counter.

## -remarks
If the internal counter goes to zero, text updates are displayed immediately instead of batched.

This method cannot decrement the internal counter below zero, and no error occurs if it is called when the counter is already zero.

To increment the internal counter, call the [ITextDocument.BatchDisplayUpdates](itextdocument_batchdisplayupdates_505749236.md) method.



> [!NOTE]
> If undo grouping is on (see [ITextDocument.BeginUndoGroup](itextdocument_beginundogroup_1705396921.md)), screen updating is suppressed regardless of the internal counter's value.

## -examples

## -see-also
[ITextDocument.BatchDisplayUpdates](itextdocument_batchdisplayupdates_505749236.md)