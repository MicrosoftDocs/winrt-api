---
-api-id: P:Windows.ApplicationModel.Contacts.KnownContactField.Email
-api-type: winrt property
---

<!-- Property syntax
public string Email { get; }
-->

# Windows.ApplicationModel.Contacts.KnownContactField.Email

## -description
> [!NOTE]
> [KnownContactField](knowncontactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), or [ContactEmail](contactemail.md).

Contains the name of the field used for email addresses.

## -property-value
The name of the field.

## -remarks
Use this property with the [ContactPicker.DesiredFields](contactpicker_desiredfields.md) property to specify that you want to get the email addresses of a contact.

## -examples
This code demonstrates how to get an email address of a contact.



[!code-js[ContactsKnownFields_Email](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_Email)]

## -see-also
