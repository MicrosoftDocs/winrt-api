---
-api-id: T:Windows.ApplicationModel.Contacts.KnownContactField
-api-type: winrt class
---

<!-- Class syntax.
public class KnownContactField 
-->

# Windows.ApplicationModel.Contacts.KnownContactField

## -description
> [!NOTE]
> [KnownContactField](knowncontactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), or [ContactEmail](contactemail.md).

A static class that contains the names of contact fields for storing commonly requested information like email address and phone numbers.

## -remarks
The [KnownContactField](knowncontactfield.md) class is designed for use as a parameter with the [DesiredFields](contactpicker_desiredfields.md) property of the [ContactPicker](contactpicker.md). It allows apps to clearly specify what fields to retrieve from contact providers.

## -examples
This example demonstrates how to use the [KnownContactField](knowncontactfield.md) class.



[!code-js[ContactsKnownFields](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields)]

## -see-also

## -capabilities
contactsSystem
