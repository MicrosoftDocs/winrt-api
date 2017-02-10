---
-api-id: M:Windows.ApplicationModel.Contacts.ContactStore.GetContactListAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.ContactList> GetContactListAsync(System.String contactListId)
-->

# Windows.ApplicationModel.Contacts.ContactStore.GetContactListAsync

## -description
Asynchronously gets the [ContactList](contactlist.md) with the specified ID.

## -parameters
### -param contactListId
The ID of the [ContactList](contactlist.md) to retrieve.

## -returns
The [ContactList](contactlist.md) with the specified ID or null if the list is not found.

## -remarks
This method throws an invalid argument exception if the *contactListId* is malformed.

## -examples

## -see-also
