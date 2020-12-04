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
When you work with contacts, you must supply an ID property for each contact. The value of this property can be whatever makes the most sense for your app, but it must enable you to uniquely identify each contact. Actions like removing a contact depend on this ID value to ensure that the correct contact is removed. For a complete example, see our [code sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ContactPicker).

## -examples

## -see-also

## -capabilities
contactsSystem
