---
-api-id: P:Windows.ApplicationModel.Contacts.ContactPicker.DesiredFields
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<string> DesiredFields { get; }
-->

# Windows.ApplicationModel.Contacts.ContactPicker.DesiredFields

## -description
Sets the contact fields your app is interested in.

> [!NOTE]
> This property is no longer available starting with Windows 10.

## -property-value
An array of strings that represent the field names your app is interested in.

## -remarks
If you choose only one field with this method, a contact is considered a match if it has that field. If you choose multiple fields, a contact is considered a match if it has any of the fields.

When selecting fields, list them in order of preference. For example, if you want both phone numbers and email addresses, but prefer phone numbers, put the PhoneNumber field before the Email field.

To specify a specific field, use the [KnownContactField](knowncontactfield.md) class.

## -examples

## -see-also

## -capabilities
contactsSystem
