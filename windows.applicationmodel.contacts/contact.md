---
-api-id: T:Windows.ApplicationModel.Contacts.Contact
-api-type: winrt class
---

<!-- Class syntax.
public class Contact : Windows.ApplicationModel.Contacts.IContact, Windows.ApplicationModel.Contacts.IContact2, Windows.ApplicationModel.Contacts.IContact3, Windows.ApplicationModel.Contacts.IContactName
-->

# Windows.ApplicationModel.Contacts.Contact

## -description

Represents a contact.

## -remarks

No matter how you store contact information in your app, you must be able to put that information into a [Contact](contact.md) object. This way, other apps that allow users to select contacts can use your app and process the contact information it provides.

For info about how to manage contacts, see [Managing contact cards](https://msdn.microsoft.com/library/a0667d13-a274-4cb2-982a-5bfabb0488c2) and [Managing contact cards](https://msdn.microsoft.com/library/364d763b-adf6-410e-a892-ba4af3799b93).

## -examples

This code shows how your app can take an app-specific contact object and use it to create a [Contact](contact.md) object. First, here's an example of an object that contains contact information.

[!code-js[AppContactExample](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetAppContactExample)]

[!code-js[ContactPickerBasketCreateForBasket](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketCreateForBasket)]

## -see-also

[Contact manager API sample](https://go.microsoft.com/fwlink/p/?LinkID=310079), [Contact Picker app sample](https://go.microsoft.com/fwlink/p/?linkid=231575), [Handling Contact Actions sample](https://go.microsoft.com/fwlink/p/?LinkID=320151), [Contact cards sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624040)

## -capabilities

contactsSystem
