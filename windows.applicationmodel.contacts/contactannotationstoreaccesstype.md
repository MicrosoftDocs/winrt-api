---
-api-id: T:Windows.ApplicationModel.Contacts.ContactAnnotationStoreAccessType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactAnnotationStoreAccessType : int
-->

# ContactAnnotationStoreAccessType

## -description
Specifies if the app can read and write all annotations or only those belonging to the app itself.

## -enum-fields
### -field AppAnnotationsReadWrite:0
Only local app contact annotations.

### -field AllAnnotationsReadWrite:1
All contact annotations.


## -remarks
Use the OR operator to combine these values together into a single bit field.

## -examples

## -see-also
## -capabilities
contactsSystem
