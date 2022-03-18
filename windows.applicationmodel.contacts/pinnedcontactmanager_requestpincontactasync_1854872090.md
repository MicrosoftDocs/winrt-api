---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.RequestPinContactAsync(Windows.ApplicationModel.Contacts.Contact,Windows.ApplicationModel.Contacts.PinnedContactSurface)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> PinnedContactManager.RequestPinContactAsync(Contact contact, PinnedContactSurface surface)
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.RequestPinContactAsync


## -description

Pins a contact to the taskbar or **Start** menu.

## -parameters

### -param contact

The contact to pin to the taskbar or **Start** menu.

### -param surface

A [pinnedContactSurface](pinnedcontactsurface.md) value that specifies where in the Windows UI you would like to pin the contact.

## -returns

An asynchronous operation that returns a Boolean value that indicates whether the contact was successfully pinned to the specified location.

## -remarks

This method must be called from the main UI thread.

## -see-also

## -examples

## -capabilities

contactsSystem

