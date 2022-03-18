---
-api-id: T:Windows.ApplicationModel.Contacts.ContactField
-api-type: winrt class
---

<!-- Class syntax.
public class ContactField : Windows.ApplicationModel.Contacts.IContactField
-->

# Windows.ApplicationModel.Contacts.ContactField

## -description
Describes a piece of contact data.

## -remarks
Each time you create a [Contact](contact.md) object, you get a [Fields](contact_fields.md) property. This property contains the data that relates to the contact. To populate a [Contact](contact.md) object with data, you append the [Fields](contact_fields.md) object with one or more instances of **ContactField**.

At a minimum, a **ContactField** object must contain a string value and a [ContactFieldType](contactfieldtype.md), which specifies whether the data is a phone number, email address, physical address, or something else. You can also add a [ContactFieldCategory](contactfieldcategory.md) to differentiate between home, work, personal, or other data. You can also use a **ContactField** object to add custom fields to a [Contact](contact.md).

## -examples

## -see-also

## -capabilities
contactsSystem
