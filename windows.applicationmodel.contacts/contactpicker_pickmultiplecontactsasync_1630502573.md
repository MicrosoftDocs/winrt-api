---
-api-id: M:Windows.ApplicationModel.Contacts.ContactPicker.PickMultipleContactsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Contacts.ContactInformation>> PickMultipleContactsAsync()
-->

# Windows.ApplicationModel.Contacts.ContactPicker.PickMultipleContactsAsync

## -description
Launches the Contact Picker for selecting multiple contacts.

> [!NOTE]
> This method is no longer available starting with Windows 10.

## -returns
The operation that launches the contact picker.

## -remarks
To pick only a single contact, use [PickSingleContactAsync](contactpicker_picksinglecontactasync.md).

Use the [SelectionMode](contactpicker_selectionmode.md) property to control whether your app receives all of a contact's information, or just specific fields.

## -examples
This example demonstrates how to use [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync.md) to get multiple contacts.



[!code-js[ContactsMultiPicker](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsMultiPicker)]

## -see-also
[PickContactsAsync](contactpicker_pickcontactsasync.md)
