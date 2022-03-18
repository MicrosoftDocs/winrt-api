---
-api-id: M:Windows.Storage.KnownFolders.RequestAccessForUserAsync(Windows.System.User,Windows.Storage.KnownFolderId)
-api-type: winrt method
---

## -description
Requests access for the user and folderId.

## -parameters

### -param user
The user property.

### -param folderId
The Id of the folder to be returned.

## -returns
Returns a [KnownFolderAccessStatus](knownfoldersaccessstatus.md) enum.

## -remarks
This method is Multi-User Aware (MUA).

Providing a null User will result in an Invalid argument exception as MUA apps should always provide a valid non-null User.

## -see-also
[RequestAccessAsync](knownfolders_requestaccessasync_1688586552.md)

## -examples

