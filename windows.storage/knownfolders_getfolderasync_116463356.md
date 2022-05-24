---
-api-id: M:Windows.Storage.KnownFolders.GetFolderAsync(Windows.Storage.KnownFolderId)
-api-type: winrt method
---

## -description
Retrieves the folder for the folderId specified.

## -parameters

### -param folderId
The Id of the folder to be returned.

## -returns
When this method completes, it returns the requested [StorageFolder](storagefolder.md) object.

## -remarks
This is a Single User Aware (SUA) method.

If the app does not have access because it isn’t manifested with the required capability, the user denied access from a prompt or the settings page, or a system administrator has disabled access, then this call will fail with access denied.

## -see-also
[KnownFolderId](knownfolderid.md), [StorageFolder](storagefolder.md), [GetFolderForUserAsync](knownfolders_getfolderforuserasync_705109113.md)

## -examples
