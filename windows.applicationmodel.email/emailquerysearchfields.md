---
-api-id: T:Windows.ApplicationModel.Email.EmailQuerySearchFields
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailQuerySearchFields : uint
-->

# EmailQuerySearchFields

## -description
Defines the field(s) by which to search a collection of email messages. Use the OR operator to combine these values together into a single bit field.

## -enum-fields
### -field None:0
No search field defined.

### -field Subject:1
Search by subject field.

### -field Sender:2
Search by sender field.

### -field Preview:4
Search by preview text field.

### -field Recipients:8
Search by members of the recipient list.

### -field All:4294967295
Search by all searchable fields.


## -remarks

## -examples

## -see-also