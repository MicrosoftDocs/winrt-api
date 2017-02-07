---
-api-id: T:Windows.ApplicationModel.Contacts.ContactInformation
-api-type: winrt class
---

<!-- Class syntax.
public class ContactInformation : Windows.ApplicationModel.Contacts.IContactInformation
-->

# Windows.ApplicationModel.Contacts.ContactInformation

## -description
Contains the information about a contact.

## -remarks
> [!NOTE]
> Because you don't use [PickSingleContactAsync](contactpicker_picksinglecontactasync.md) and [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync.md) in your Windows 8.1 and later apps, you don't instantiate [ContactInformation](contactinformation.md) objects in your Windows 8.1 and later apps.This table shows existing Windows 8[ContactInformation](contactinformation.md) properties and their equivalent Windows 8.1[Contact](contact.md) properties.

<table>
   <tr><th>Windows 8[ContactInformation](contactinformation.md) property</th><th>Windows 8.1[Contact](contact.md) property</th></tr>
   <tr><td>Contact.Name</td><td>Contact.Name</td></tr>
   <tr><td>Contact.Thumbnail</td><td>Contact.Thumbnail</td></tr>
   <tr><td>Contact.Fields</td><td>Contact.Emails</td></tr>
   <tr><td>Contact.Fields where ContactField.Value = Address and ContactField.Category = ContactFieldCategory.Home or ContactFieldCategory.Other</td><td>Contact.Addresses</td></tr>
   <tr><td>Contact.Fields</td><td>Contact.Phones</td></tr>
   <tr><td>ContactField.Value</td><td>ContactEmail.Address</td></tr>
   <tr><td>ContactField.Category(Home,Work,Other)</td><td>ContactEmail.Kind(Personal,Work,Other)</td></tr>
   <tr><td>ContactField.Value</td><td>ContactPhone.Number</td></tr>
   <tr><td>ContactField.Category(Home, Work, Mobile, Other)</td><td>ContactPhone.Kind(Home,Work,Mobile,Other)</td></tr>
   <tr><td>Contact.Fields where ContactField.Value = CompanyAddress and ContactField.Category = ContactFieldCategory.Work</td><td>ContactJobInfo.CompanyAddress</td></tr>
</table>

Typically, you access [ContactInformation](contactinformation.md) objects as the result of asynchronous method and/or function calls. For example, both of the static methods [PickSingleContactAsync](contactpicker_picksinglecontactasync.md) and [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync.md) return [ContactInformation](contactinformation.md) objects that represent the selected contact.

When your app receives contact information from a contact provider, the data for each contact is returned in a [ContactInformation](contactinformation.md) object.

## -examples
This code demonstrates how a [ContactInformation](contactinformation.md) object is returned to an app after a user selects a contact.



[!code-js[ContactsSinglePicker](../windows.applicationmodel.contacts.provider/code/ContactsMain/javascript/js/contacts.js#SnippetContactsSinglePicker)]

## -see-also
