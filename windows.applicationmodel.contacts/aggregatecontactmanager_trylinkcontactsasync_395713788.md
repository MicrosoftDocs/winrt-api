---
-api-id: M:Windows.ApplicationModel.Contacts.AggregateContactManager.TryLinkContactsAsync(Windows.ApplicationModel.Contacts.Contact,Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.Contact> TryLinkContactsAsync(Windows.ApplicationModel.Contacts.Contact primaryContact, Windows.ApplicationModel.Contacts.Contact secondaryContact)
-->

# Windows.ApplicationModel.Contacts.AggregateContactManager.TryLinkContactsAsync

## -description
Asynchronously attempts to link contacts together to make an aggregate contact.

## -parameters
### -param primaryContact
The first contact to link.

### -param secondaryContact
The second contact to link to the *primaryContact*.

## -returns
The newly created aggregate contact.

## -remarks
The *primaryContact* and *secondaryContact* objects can be any combination of raw and aggregate contacts.

## -examples

## -see-also
