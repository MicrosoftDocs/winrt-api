---
-api-id: P:Windows.ApplicationModel.Contacts.Contact.Id
-api-type: winrt property
---

<!-- Property syntax
public string Id { get;  set; }
-->

# Windows.ApplicationModel.Contacts.Contact.Id

## -description
Gets or sets the identifier for a contact. The maximum string length for the identifier is 256 characters.

## -property-value
The identifier for a contact. The maximum string length for the identifier is 256 characters.

## -remarks

> [!NOTE]
> The `Id` property must be set when you call [AddContact](../windows.applicationmodel.contacts.provider/contactpickerui_addcontact_79336216.md), [ContainsContact](../windows.applicationmodel.contacts.provider/contactpickerui_containscontact_2082214775.md), or [RemoveContact](../windows.applicationmodel.contacts.provider/contactpickerui_removecontact_591776620.md). If `Id` isn't set when you call [AddContact](../windows.applicationmodel.contacts.provider/contactpickerui_addcontact_79336216.md), your app will fail. If `Id` isn't set when you call [ContainsContact](../windows.applicationmodel.contacts.provider/contactpickerui_containscontact_2082214775.md) or [RemoveContact](../windows.applicationmodel.contacts.provider/contactpickerui_removecontact_591776620.md), your app won't be able to find or remove the contact.

## -examples

## -see-also

## -capabilities
contactsSystem
