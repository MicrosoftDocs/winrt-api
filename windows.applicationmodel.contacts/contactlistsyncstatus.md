---
-api-id: T:Windows.ApplicationModel.Contacts.ContactListSyncStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Contacts.ContactListSyncStatus : int
-->

# ContactListSyncStatus

## -description
Defines the [ContactList](contactlist.md) sync status.

## -enum-fields
### -field Idle:0
Idle.

### -field Syncing:1
Currently syncing.

### -field UpToDate:2
The contact list is up-to-date.

### -field AuthenticationError:3
There was an authentication error.

### -field PolicyError:4
There was a policy error.

### -field UnknownError:5
An unknown error occurred.

### -field ManualAccountRemovalRequired:6
The account must be manually removed.


## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | ManualAccountRemovalRequired |

## -examples

## -see-also
## -capabilities
contactsSystem
