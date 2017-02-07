---
-api-id: T:Windows.ApplicationModel.Email.EmailMailboxSyncStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailMailboxSyncStatus : int
-->

# EmailMailboxSyncStatus

## -description
Defines the sync status of the mailbox.

## -enum-fields
### -field Idle:0
The mailbox is idle.

### -field Syncing:1
The mailbox is currently syncing.

### -field UpToDate:2
The mailbox is up to date.

### -field AuthenticationError:3
The mailbox has encountered an authentication error and cannot sync.

### -field PolicyError:4
The mailbox has encountered a policy error and cannot sync.

### -field UnknownError:5
The mailbox has encountered an unknown error and cannot sync.

### -field ManualAccountRemovalRequired:6
The account must be manually removed.


## -remarks

## -examples

## -see-also