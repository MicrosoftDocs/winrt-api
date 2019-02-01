---
-api-id: T:Windows.ApplicationModel.Contacts.ContactPicker
-api-type: winrt class
---

<!-- Class syntax.
public class ContactPicker : Windows.ApplicationModel.Contacts.IContactPicker, Windows.ApplicationModel.Contacts.IContactPicker2, Windows.ApplicationModel.Contacts.IContactPicker3
-->

# Windows.ApplicationModel.Contacts.ContactPicker

## -description

Controls how the Contact Picker user interface opens and what information it shows.

## -remarks

The [ContactPicker](contactpicker.md) class enables users to select one or more contacts from any app that supports the Contact Picker contract. You can configure the [ContactPicker](contactpicker.md) class to accept only a single contact, or multiple contacts. In addition, you can request that the app providing the contact information return the entire set of data for each contact, or just specific fields.

> [!NOTE]
> Apps that were compiled for Windows 8 but running on Windows 8.1 may encounter runtime errors without compile-time errors.

For info about how to select contacts, see [Selecting contacts](https://msdn.microsoft.com/library/35fedee6-2b0e-4391-84ba-5e9191d4e442) and [Quickstart: Selecting user contacts](https://msdn.microsoft.com/library/1330470e-efd2-41e1-934e-08ec081ba3c2).

## -examples

This example demonstrates using the [ContactPicker](contactpicker.md) to get the name and email address of a single contact.

[!code-js[ContactsSinglePicker](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsSinglePicker)]

## -see-also

[Contact Picker app sample](https://go.microsoft.com/fwlink/p/?linkid=231575), [Contact picker sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624041), [My People Notifications sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MyPeopleNotifications)

## -capabilities

contactsSystem
