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

For more info about how to select contacts, see [Select contacts](/windows/uwp/contacts-and-calendar/selecting-contacts).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CreateForUser |
| 1703 | 15063 | IsSupportedAsync |
| 1703 | 15063 | User |

## -examples

## -see-also

[Contact Picker app sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker), [My People Notifications sample](https://github.com/microsoft/Windows-universal-samples/tree/dev/archived/MyPeopleNotifications)

## -capabilities

contactsSystem
