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

> [!NOTE]
> The [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) property must be set when you call [ContainsContact](contactpickerui_containscontact_2082214775.md). If [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) isn't set, your app won't be able to find the contact.

## -parameters
### -param id
The ID of the contact.

## -returns
True if the contact has already been selected; otherwise, false.

## -remarks


## -examples

## -see-also
[Contact Picker app sample](http://go.microsoft.com/fwlink/p/?linkid=231575)
## -capabilities
contactsSystem
