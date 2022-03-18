---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.RequestUnpinContactAsync(Windows.ApplicationModel.Contacts.Contact,Windows.ApplicationModel.Contacts.PinnedContactSurface)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> PinnedContactManager.RequestUnpinContactAsync(Contact contact, PinnedContactSurface surface)
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.RequestUnpinContactAsync


## -description

Unpins a contact from the taskbar or **Start** menu.

## -parameters

### -param contact

The contact to unpin from the taskbar or **Start** menu.

### -param surface

A [pinnedContactSurface](pinnedcontactsurface.md) value that specifies from which area in the Windows UI you would like to unpin the contact.

## -returns

An asynchronous operation that returns a Boolean value that indicates whether the contact was successfully unpinned from the specified location.

## -remarks

This method must be called from the main UI thread.

## -see-also

## -examples

## -capabilities

contactsSystem

