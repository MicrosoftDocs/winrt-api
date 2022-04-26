---
-api-id: P:Windows.UI.StartScreen.JumpList.Items
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.StartScreen.JumpListItem> Items { get; }
-->

# Windows.UI.StartScreen.JumpList.Items

## -description
Gets the list of [JumpListItem](jumplistitem.md)'s for the jump list.  Items is of type [IVector(JumpListItem)](../windows.foundation.collections/ivector_1.md).

## -property-value
The list of [JumpListItem](jumplistitem.md)'s for the jump list.

## -remarks
Apps may modify the collection by adding items, removing items, or modifying existing items. After the app saves the jump list using [SaveAsync](jumplist_saveasync_2143735121.md), the changes to the collection will be reflected in the jump list shown to the user.

## -examples

## -see-also
