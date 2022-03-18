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

> [!NOTE]
> ContactInformation may be altered or unavailable for releases after Windows 8.1. Instead, use [Contact](contact.md).

## -remarks
> [!NOTE]
> Because you don't use [PickSingleContactAsync](contactpicker_picksinglecontactasync_2033050338.md) and [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync_1630502573.md) in your Windows 8.1 and later apps, you don't instantiate ContactInformation objects in your Windows 8.1 and later apps.This table shows existing Windows 8 ContactInformation properties and their equivalent Windows 8.1 [Contact](contact.md) properties.

<table>
   <tr><th>Windows 8 ContactInformation property</th><th>Windows 8.1 Contact property</th></tr>
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

Typically, you access ContactInformation objects as the result of asynchronous method and/or function calls. For example, both of the static methods [PickSingleContactAsync](contactpicker_picksinglecontactasync_2033050338.md) and [PickMultipleContactsAsync](contactpicker_pickmultiplecontactsasync_1630502573.md) return ContactInformation objects that represent the selected contact.

When your app receives contact information from a contact provider, the data for each contact is returned in a ContactInformation object.

## -examples

## -see-also

## -capabilities
contactsSystem
