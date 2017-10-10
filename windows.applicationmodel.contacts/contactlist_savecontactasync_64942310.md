---
-api-id: M:Windows.ApplicationModel.Contacts.ContactList.SaveContactAsync(Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SaveContactAsync(Windows.ApplicationModel.Contacts.Contact contact)
-->

# Windows.ApplicationModel.Contacts.ContactList.SaveContactAsync

## -description
Asynchronously saves the specified [Contact](contact.md) to the [ContactStore](contactstore.md).

## -parameters
### -param contact
The contact to save.

## -returns
An async action indicating that the method has completed.

## -remarks
Throws a System.ArgumentException: 'Value does not fall within the expected range.' when the contact passed as parameter has a RemoteID set which is identical to a contacts RemoteID already saved on this device.

## -examples

## -see-also

## -capabilities
contactsSystem
