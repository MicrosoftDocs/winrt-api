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

No matter how you store contact information in your app, you must be able to put that information into a Contact object. This way, other apps that allow users to select contacts can use your app and process the contact information it provides.

For info about how to manage contacts, see [Managing contact cards](/previous-versions/windows/apps/dn518181(v=win.10)) and [Managing contact cards](/previous-versions/windows/apps/dn518237(v=win.10)).

## -examples

This code shows how your app can take an app-specific contact object and use it to create a Contact object. First, here's an example of an object that contains contact information.

[!code-js[AppContactExample](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetAppContactExample)]

[!code-js[ContactPickerBasketCreateForBasket](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contactpicker.js#SnippetContactPickerBasketCreateForBasket)]

## -see-also

[Contact manager API sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Contact%20manager%20API%20sample), [Contact Picker app sample](https://go.microsoft.com/fwlink/p/?linkid=231575), [Handling Contact Actions sample](https://go.microsoft.com/fwlink/p/?LinkID=320151), [Contact cards sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624040)

## -capabilities

contactsSystem
