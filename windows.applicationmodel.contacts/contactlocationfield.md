---
-api-id: T:Windows.ApplicationModel.Contacts.ContactLocationField
-api-type: winrt class
---

<!-- Class syntax.
public class ContactLocationField : Windows.ApplicationModel.Contacts.IContactField, Windows.ApplicationModel.Contacts.IContactLocationField
-->

# Windows.ApplicationModel.Contacts.ContactLocationField

## -description
Contains information about a user's location and address.

## -remarks
Your app receives a collection of [ContactLocationField](contactlocationfield.md) objects when a contact provider returns the requested contact information. You can access these objects through the [ContactInformation.Location](contactlocationfield.md) property.

## -examples
This code example demonstrates the use of the **ContactInstantMessageField**
<!--Is ContactInstantMessageField the right name to use here? It seems the example should be for ContactLocationField.-->
object.



[!code-js[ContactsKnownFields_location](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsKnownFields_location)]

## -see-also
