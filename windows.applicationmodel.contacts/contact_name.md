---
-api-id: P:Windows.ApplicationModel.Contacts.Contact.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get;  set; }
-->

# Windows.ApplicationModel.Contacts.Contact.Name

## -description
> [!NOTE]
> [Name](contact_name.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [FirstName](contact_firstname.md).

Sets and gets the name of the contact.

## -property-value
The name of the contact.

## -remarks
An app can set the [name](contact_name.md) property to any value that matches the name of a contact. We recommend that you set this value to contain both the first and last names of the contact, if that information is available.

## -examples
This example shows a function taking the [name](contact_name.md) property and returning the first and last names of the contact.



[!code-js[ContactsNameProperty](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsNameProperty)]

## -see-also
