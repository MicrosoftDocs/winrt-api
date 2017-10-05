---
-api-id: T:Windows.ApplicationModel.Email.EmailMailboxEmptyFolderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailMailboxEmptyFolderStatus : int
-->

# EmailMailboxEmptyFolderStatus

## -description
Indicates the result of a call to [TryEmptyFolderAsync](emailmailbox_tryemptyfolderasync.md).

## -enum-fields
### -field Success:0
The folder was successfully emptied.

### -field NetworkError:1
There was a network error while trying to empty the folder.

### -field PermissionsError:2
There was a permissions error while trying to empty the folder.

### -field ServerError:3
There was a server error while trying to empty the folder.

### -field UnknownFailure:4
There was an unknown error while trying to empty the folder.

### -field CouldNotDeleteEverything:5
An error occurred while deleting parts of the folder.


## -remarks

## -examples

## -see-also
## -capabilities
email, emailSystem
