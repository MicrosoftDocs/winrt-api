---
-api-id: T:Windows.ApplicationModel.Contacts.ContactQueryDesiredFields
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactQueryDesiredFields : uint
-->

# ContactQueryDesiredFields

## -description
Defines which fields must exist on a contact in order to match a search operation.

## -enum-fields
### -field None:0
No required fields

### -field PhoneNumber:1
The contact must have a phone number.

### -field EmailAddress:2
The contact must have an email address.

### -field PostalAddress:4
The contact must have a postal address.


## -remarks
Use the OR operator to combine these values together into a single bit field.

## -examples

## -see-also