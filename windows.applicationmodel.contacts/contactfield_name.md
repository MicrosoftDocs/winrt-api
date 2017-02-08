---
-api-id: P:Windows.ApplicationModel.Contacts.ContactField.Name
-api-type: winrt property
---

<!-- Property syntax
public string Name { get; }
-->

# Windows.ApplicationModel.Contacts.ContactField.Name

## -description
> [!NOTE]
> [ContactField](contactfield.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactAddress](contactaddress.md), [ContactPhone](contactphone.md), [ContactSignificantOther](contactsignificantother.md), [Contact](contact.md), [ContactEmail](contactemail.md), [ContactConnectedServiceAccount](contactconnectedserviceaccount.md), [ContactWebsite](contactwebsite.md), [ContactJobInfo](contactjobinfo.md), or [ContactDate](contactdate.md).

Gets the name of the field.

## -property-value
The name of the field.

## -remarks
If the [ContactField](contactfield.md) was created using a [ContactFieldType](contactfieldtype.md) enumeration, then the [Name](contactfield_name.md) property is the same as the [ContactFieldType](contactfieldtype.md) value (such as Email or PhoneNumber). If the [ContactField](contactfield.md) contains a custom field, the [Name](contactfield_name.md) property is the name of the field.

## -examples

## -see-also
