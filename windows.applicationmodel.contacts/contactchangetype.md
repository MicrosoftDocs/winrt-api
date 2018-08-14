---
-api-id: T:Windows.ApplicationModel.Contacts.ContactChangeType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactChangeType : int
-->

# ContactChangeType

## -description
Specifies the type of change that occurred for a [ContactChanged](contactstore_contactchanged.md) event.

## -enum-fields
### -field Created:0
A contact was created.

### -field Modified:1
A contact was modified.

### -field Deleted:2
A contact was deleted.

### -field ChangeTrackingLost:3
Change tracking was lost. Call [Reset](contactchangetracker_reset_1636126115.md) to reestablish continuity with the [ContactStore](contactstore.md).


## -remarks

## -examples

## -see-also
## -capabilities
contactsSystem
