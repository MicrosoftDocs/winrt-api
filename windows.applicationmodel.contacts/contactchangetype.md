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
The system can't report the complete set of changes that have happened since the last time that your app accepted changes. Call the [Reset](contactchangetracker_reset.md) method. This clears any pending changes, and indicates that your app is up-to-date so that the  [ContactChangeType.ChangeTrackingLost](contactchangetype.md) event won't continue to be raised for previous changes. If your app maintains a list of contacts, that list will become stale. Re-read contacts into your list. That way, they are up-to-date.

## -remarks

## -examples

## -see-also
## -capabilities
contactsSystem
