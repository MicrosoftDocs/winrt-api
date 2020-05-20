---
-api-id: T:Windows.ApplicationModel.Contacts.ContactListOtherAppReadAccess
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactListOtherAppReadAccess : int
-->

# ContactListOtherAppReadAccess

## -description
Specifies the level of contact read access granted to other apps.

## -enum-fields
### -field SystemOnly:0
Only apps specially provisioned by Microsoft can read these contacts.

### -field Limited:1
All apps can read the DisplayName and Picture properties, other properites are only available to specially provisioned apps.

### -field Full:2
All apps can read all properties.

### -field None:3
No other apps can read any of the contact information.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | None |

## -examples

## -see-also

## -capabilities
contactsSystem
