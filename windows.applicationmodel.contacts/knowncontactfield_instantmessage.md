---
-api-id: P:Windows.ApplicationModel.Contacts.KnownContactField.InstantMessage
-api-type: winrt property
---

<!-- Property syntax
public string InstantMessage { get; }
-->

# Windows.ApplicationModel.Contacts.KnownContactField.InstantMessage

## -description
> [!NOTE]
> [KnownContactField](knowncontactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), or [ContactEmail](contactemail.md).

Contains the name of the field used for instant messaging accounts.

## -property-value
The name of the field.

## -remarks
Use this property with the [ContactPicker.DesiredFields](contactpicker_desiredfields.md) property to specify that you want to get the instant messaging names that a contact uses.

## -examples
This code demonstrates how to get a contact's instant messaging information.



[!code-js[ContactsKnownFields_IM](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_IM)]

## -see-also

## -capabilities
contactsSystem
