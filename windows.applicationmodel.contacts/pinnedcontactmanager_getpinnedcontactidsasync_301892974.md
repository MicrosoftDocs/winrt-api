---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.GetPinnedContactIdsAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PinnedContactIdsQueryResult> PinnedContactManager.GetPinnedContactIdsAsync()
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.GetPinnedContactIdsAsync


## -description

Gets the ID's of all contacts that are pinned to the taskbar or **Start** menu.

## -returns

An asynchronous operation that returns a [PinnedContactIdsQueryResult](pinnedcontactidsqueryresult.md) that you can use to get the ID's of all pinned contacts.

## -remarks

This method raises an **AccessDeniedException** if you have not enabled the *contactPanel* capability in your app manifest.

This method can be called from a background thread.

## -see-also

## -examples

## -capabilities

contactsSystem

