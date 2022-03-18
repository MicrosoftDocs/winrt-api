---
-api-id: M:Windows.ApplicationModel.Contacts.IContactFieldFactory.CreateField(System.String,Windows.ApplicationModel.Contacts.ContactFieldType,Windows.ApplicationModel.Contacts.ContactFieldCategory)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactField CreateField(System.String value, Windows.ApplicationModel.Contacts.ContactFieldType type, Windows.ApplicationModel.Contacts.ContactFieldCategory category)
-->

# Windows.ApplicationModel.Contacts.IContactFieldFactory.CreateField

## -description

Creates a field to contain information about a contact.

> [!NOTE]
> [IContactFieldFactory](icontactfieldfactory.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [ContactPhone](contactphone.md) or [ContactEmail](contactemail.md).

## -parameters
### -param value
The value of the field.

### -param type
The type of field.

### -param category
The category the field belongs to.

## -returns
A field that you can add to a [Contact](contact.md) object.

## -remarks

## -examples

## -see-also
[CreateField(String, ContactFieldType)](icontactfieldfactory_createfield_1723791966.md), [CreateField(String, String, ContactFieldType, ContactFieldCategory)](icontactfieldfactory_createfield_1958768016.md)
## -capabilities
contactsSystem
