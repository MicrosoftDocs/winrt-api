---
-api-id: M:Windows.ApplicationModel.Contacts.ContactList.GetMeContactAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.Contact> GetMeContactAsync()
-->

# Windows.ApplicationModel.Contacts.ContactList.GetMeContactAsync

## -description
Asynchronously gets the [Contact](contact.md) object that represents the current user.

## -returns
The [Contact](contact.md) object that represents the current user.

## -remarks

If no contact has been designated as representing the current user,
the return value is an empty contact.
You can detect this case by checking whether the contact's [Id](contact_id.md) property is nonempty.

## -examples

## -see-also

## -capabilities
contactsSystem
