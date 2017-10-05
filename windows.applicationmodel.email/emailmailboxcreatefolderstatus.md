---
-api-id: T:Windows.ApplicationModel.Email.EmailMailboxCreateFolderStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Email.EmailMailboxCreateFolderStatus : int
-->

# EmailMailboxCreateFolderStatus

## -description
Indicates the result of a call to [TryCreateFolderAsync](emailmailbox_trycreatefolderasync.md).

## -enum-fields
### -field Success:0
The folder was created successfully.

### -field NetworkError:1
There was a network error while trying to create the folder.

### -field PermissionsError:2
There was a permissions error while trying to create the folder.

### -field ServerError:3
There was a server error while trying to create the folder.

### -field UnknownFailure:4
Folder creation failed for an unknown reason.

### -field NameCollision:5
The folder already exists.

### -field ServerRejected:6
The server rejected the request to create a new folder.


## -remarks

## -examples

## -see-also
## -capabilities
email, emailSystem
