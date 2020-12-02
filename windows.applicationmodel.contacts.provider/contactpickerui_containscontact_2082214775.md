---
-api-id: M:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContainsContact(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool ContainsContact(System.String id)
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.ContainsContact

## -description
Checks to see whether the contact was already selected by the user.

## -parameters
### -param id
The ID of the contact.

## -returns
`true` if the contact has already been selected; otherwise, `false`.

## -remarks

> [!NOTE]
> The [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) property must be set when you call ContainsContact. If [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) isn't set, your app won't be able to find the contact.

## -examples

## -see-also
[Contact Picker app sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker)
## -capabilities
contactsSystem
