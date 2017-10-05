---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.TryMoveFolderAsync(System.String,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryMoveFolderAsync(System.String folderId, System.String newParentFolderId, System.String newFolderName)
-->

# Windows.ApplicationModel.Email.EmailMailbox.TryMoveFolderAsync

## -description
Asynchronously attempts to move the specified email folder and rename it in the process.

## -parameters
### -param folderId
The folder to move.

### -param newParentFolderId
The new parent for the folder specified in the *folderId* parameter.

### -param newFolderName
The name for the folder in the new location.

## -returns
A Boolean value indicating if the move was successful.

## -remarks

## -examples

## -see-also
[TryMoveFolderAsync(String, String)](emailmailbox_trymovefolderasync_2010564867.md)
## -capabilities
email, emailSystem
