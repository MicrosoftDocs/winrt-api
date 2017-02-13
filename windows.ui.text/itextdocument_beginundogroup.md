---
-api-id: M:Windows.UI.Text.ITextDocument.BeginUndoGroup
-api-type: winrt method
---

<!-- Method syntax
public void BeginUndoGroup()
-->

# Windows.UI.Text.ITextDocument.BeginUndoGroup

## -description
Turns on undo grouping.

## -remarks
An undo group collects undo anti-events for editing changes even when additional undo groups would normally be created. For example, typing anti-events are normally grouped into a single undo group that can be undone with a single Ctrl+Z key combination. A paste or change in insertion point terminates the current undo group and starts another. After you call [BeginUndoGroup](itextdocument_beginundogroup.md), such terminations do not occur; only one undo group is used until you call the [EndUndoGroup](itextdocument_endundogroup.md) method. The entire group is undone by a single Ctrl+Z key combination.

When undo grouping is on:
+ The undo manager adds undo anti-events for text changes to the current undo group.
+ A single undo command executes all of the undo anti-events in the undo group. This restores the text state to the one that was active when undo grouping was turned on.


## -examples

## -see-also
[ITextDocument.EndUndoGroup](itextdocument_endundogroup.md)