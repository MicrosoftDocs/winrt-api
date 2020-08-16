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

The ContactPicker class enables users to select one or more contacts from any app that supports the Contact Picker contract. You can configure the ContactPicker class to accept only a single contact, or multiple contacts. In addition, you can request that the app providing the contact information return the entire set of data for each contact, or just specific fields.

> [!NOTE]
> Apps that were compiled for Windows 8 but running on Windows 8.1 may encounter runtime errors without compile-time errors.

For info about how to select contacts, see [Selecting contacts](https://docs.microsoft.com/windows/uwp/contacts-and-calendar/selecting-contacts) and [Quickstart: Selecting user contacts](https://docs.microsoft.com/previous-versions/windows/apps/jj153343(v=win.10)).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CreateForUser |
| 1703 | 15063 | IsSupportedAsync |
| 1703 | 15063 | User |

## -examples

This example demonstrates using the ContactPicker to get the name and email address of a single contact.

[!code-js[ContactsSinglePicker](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsSinglePicker)]

## -see-also

[Contact Picker app sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker), [Contact picker sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624041), [My People Notifications sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MyPeopleNotifications)

## -capabilities

contactsSystem
