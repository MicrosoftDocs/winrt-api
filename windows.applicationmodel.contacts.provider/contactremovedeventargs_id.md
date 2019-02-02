---
-api-id: P:Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs.Id
-api-type: winrt property
---

<!-- Property syntax
public string Id { get; }
-->

# Windows.ApplicationModel.Contacts.Provider.ContactRemovedEventArgs.Id

## -description
Contains a unique identifier for the contact.

## -property-value
A unique identifier for the contact.

## -remarks
When you work with contacts, you must supply an ID property for each contact. The value of this property can be whatever makes the most sense for your app, but it must enable you to uniquely identify each contact. Actions like removing a contact depend on this ID value to ensure that the correct contact is removed. For a complete example, see our [code sample](https://go.microsoft.com/fwlink/p/?linkid=231575).

## -examples
The following example shows one way to use the [Id](contactremovedeventargs_id.md) property of the [ContactRemovedEventArgs](contactremovedeventargs.md) class.



[!code-js[ContactPickerBasketContactRemoved](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketContactRemoved)]

## -see-also

## -capabilities
contactsSystem
