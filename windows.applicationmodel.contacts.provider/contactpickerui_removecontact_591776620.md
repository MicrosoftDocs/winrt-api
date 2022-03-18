---
-api-id: M:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.RemoveContact(System.String)
-api-type: winrt method
---

<!-- Method syntax
public void RemoveContact(System.String id)
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.RemoveContact

## -description
Removes a contact.

## -parameters
### -param id
The ID of the contact to remove.

## -remarks

> [!NOTE]
> The [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) property must be set when you call RemoveContact. If [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) isn't set, your app won't be able to remove the contact.

## -examples

## -see-also
[Contact Picker app sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker)
## -capabilities
contactsSystem
