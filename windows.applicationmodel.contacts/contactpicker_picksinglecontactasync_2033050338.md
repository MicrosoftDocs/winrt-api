---
-api-id: M:Windows.ApplicationModel.Contacts.ContactPicker.PickSingleContactAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.ContactInformation> PickSingleContactAsync()
-->

# Windows.ApplicationModel.Contacts.ContactPicker.PickSingleContactAsync

## -description
Launches the Contact Picker for selecting a single contact.

> [!NOTE]
> This method is no longer available starting with Windows 10.

## -returns
The operation that launches the Contact Picker.

## -remarks
To pick multiple contacts at once, use [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync.md).

Use the [SelectionMode](contactpicker_selectionmode.md) property to control whether your app receives all of a contact's information, or just specific fields.

## -examples


## -see-also
[PickContactAsync](contactpicker_pickcontactasync.md)
## -capabilities
contactsSystem
