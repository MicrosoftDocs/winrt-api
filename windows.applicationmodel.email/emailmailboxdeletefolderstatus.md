---
-api-id: T:Windows.ApplicationModel.Email.EmailMailboxDeleteFolderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailMailboxDeleteFolderStatus : int
-->

# EmailMailboxDeleteFolderStatus

## -description
Indicates the result of a call to [TryDeleteFolderAsync](emailmailbox_trydeletefolderasync_1435582098.md).

## -enum-fields
### -field Success:0
The folder was successfully deleted.

### -field NetworkError:1
There was a network error while trying to delete the folder.

### -field PermissionsError:2
There was a permissions error while trying to delete the folder.

### -field ServerError:3
There was a server error while trying to delete the folder.

### -field UnknownFailure:4
Folder deletion failed for an unknown reason.

### -field CouldNotDeleteEverything:5
An error occurred while deleting parts of the folder.


## -remarks

## -examples

## -see-also
## -capabilities
email, emailSystem
