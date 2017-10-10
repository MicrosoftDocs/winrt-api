---
-api-id: P:Windows.ApplicationModel.Contacts.Contact.Fields
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.ApplicationModel.Contacts.IContactField> Fields { get; }
-->

# Windows.ApplicationModel.Contacts.Contact.Fields

## -description
> [!NOTE]
> [Fields](contact_fields.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [Phones](contact_phones.md), [Emails](contact_emails.md), [Addresses](contact_addresses.md), or [ConnectedServiceAccounts](contact_connectedserviceaccounts.md).

Sets the fields that contain information about a contact.

## -property-value
An array of fields containing information about a contact.

## -remarks
The [ContactFieldCategory](contactfieldcategory.md) and [ContactFieldType](contactfieldtype.md) classes provide information about what kind of information you can put into a field.

## -examples
These functions show how you can add different fields to a [Contact](contact.md) object.



[!code-js[ContactPickerBasketAppendField](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketAppendField)]

[!code-js[ContactPickerBasketAppendEmail](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketAppendEmail)]

[!code-js[ContactPickerBasketAppendPhoneNumber](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketAppendPhoneNumber)]

[!code-js[ContactPickerBasketAppendAddress](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketAppendAddress)]

## -see-also

## -capabilities
contactsSystem
