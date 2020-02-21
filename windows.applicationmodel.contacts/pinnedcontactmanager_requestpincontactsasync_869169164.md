---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.RequestPinContactsAsync(Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Contacts.Contact},Windows.ApplicationModel.Contacts.PinnedContactSurface)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> PinnedContactManager.RequestPinContactsAsync(IIterable<Contact> contacts, PinnedContactSurface surface)
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.RequestPinContactsAsync


## -description

Pins a collection of contacts to the taskbar or **Start** menu.

## -parameters

### -param contacts

The collection of contacts to pin to the taskbar or **Start** menu.

### -param surface

A [pinnedContactSurface](pinnedcontactsurface.md) value that specifies where in the Windows UI you would like to pin the contacts.

## -returns

An asynchronous operation that returns a Boolean value that indicates whether the contacts were successfully pinned to the specified location.

## -remarks

This method must be called from the main UI thread.

## -see-also

## -examples

## -capabilities

contactsSystem

