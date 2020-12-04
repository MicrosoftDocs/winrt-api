---
-api-id: M:Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.AddContact(Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.Provider.AddContactResult AddContact(Windows.ApplicationModel.Contacts.Contact contact)
-->

# Windows.ApplicationModel.Contacts.Provider.ContactPickerUI.AddContact

## -description
Adds a [Contact](../windows.applicationmodel.contacts/contact.md).

## -parameters
### -param contact
An object that contains the contact's information.

## -returns
An [AddContactResult](addcontactresult.md)-typed value that indicates whether the contact was added successfully.

## -remarks

> [!NOTE]
> The [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) property must be set when you call AddContact. If [Contact.Id](../windows.applicationmodel.contacts/contact_id.md) isn't set, your app will fail.

## -examples

## -see-also
[AddContact(String, Contact)](contactpickerui_addcontact_1063676932.md)
## -capabilities
contactsSystem
