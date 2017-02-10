---
-api-id: P:Windows.UI.StartScreen.JumpListItem.RemovedByUser
-api-type: winrt property
---

<!-- Property syntax
public bool RemovedByUser { get; }
-->

# Windows.UI.StartScreen.JumpListItem.RemovedByUser

## -description
Gets a boolean indicating whether the jump list item was removed from the app's jump list by the user.

## -property-value
True when a user manually removed a jump list item from the app's jump list, otherwise False.

## -remarks
If the [RemovedByUser](jumplistitem_removedbyuser.md) property is True, then the item will not be saved to the jump list when the [SaveAsync](jumplist_saveasync.md) method is called.

## -examples

## -see-also
