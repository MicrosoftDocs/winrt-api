---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManager.RequestStoreAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.ContactStore> RequestStoreAsync()
-->

# Windows.ApplicationModel.Contacts.ContactManager.RequestStoreAsync

## -description
Retrieves a [ContactStore](contactstore.md) object that enables searching or retrieving contacts on the device.

## -returns
An asynchronous operation that returns a [ContactStore](contactstore.md) object on successful completion.

## -remarks
This method requests [AllContactsReadOnly](contactstoreaccesstype.md) access to the contact store. If you require a different level of access, call the [RequestStoreAsync(ContactStoreAccessType)](contactmanager_requeststoreasync_112705385.md) method instead.

## -examples

## -see-also
[RequestStoreAsync(ContactStoreAccessType)](contactmanager_requeststoreasync_112705385.md)
## -capabilities
contactsSystem
