---
-api-id: M:Windows.ApplicationModel.Contacts.ContactStore.GetMeContactAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.Contact> GetMeContactAsync()
-->

# Windows.ApplicationModel.Contacts.ContactStore.GetMeContactAsync

## -description
Asynchronously gets the [Contact](contact.md) object that represents the current user.

## -returns
The [Contact](contact.md) object that represents the current user.

## -remarks

If the current user has not designated a contact as representing themselves,
the return value is an empty contact.
You can detect this case by checking whether the contact's [Id](contact_id.md) property is nonempty.

## -examples

## -see-also

## -capabilities
contactsSystem
