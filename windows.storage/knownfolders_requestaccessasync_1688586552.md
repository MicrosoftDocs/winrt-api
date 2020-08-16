---
-api-id: M:Windows.Storage.KnownFolders.RequestAccessAsync(Windows.Storage.KnownFolderId)
-api-type: winrt method
---

## -description
Requests access for the capability controlling access to the folder.

## -parameters

### -param folderId
The Id of the folder to be returned.

## -returns
Returns a [KnownFolderAccessStatus](knownfoldersaccessstatus.md) enum.

## -remarks
If the folder is controlled by a capability and is further controlled by privacy consent, this may present a prompt to the user for consent. Therefore, it should be called on the UI thread. (If not, and a prompt is required, then the result is a status indicating the prompt is needed and otherwise denied access. 

## -see-also
[KnownFolderAccessStatus](knownfoldersaccessstatus.md) 

## -examples

