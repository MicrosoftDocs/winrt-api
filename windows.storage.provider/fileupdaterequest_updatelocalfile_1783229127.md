---
-api-id: M:Windows.Storage.Provider.FileUpdateRequest.UpdateLocalFile(Windows.Storage.IStorageFile)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void UpdateLocalFile(Windows.Storage.IStorageFile value)
-->

# Windows.Storage.Provider.FileUpdateRequest.UpdateLocalFile

## -description
Provide a new version of the local file to represent the remote file.

## -parameters
### -param value
The new version of the local file that will represent remote file.

This file can be different from the original local file that was associated with the [FileUpdateRequest.ContentId](fileupdaterequest_contentid.md).

## -remarks
Use this method to associate a new version of the local file with the existing [ContentId](fileupdaterequest_contentid.md). You need to use this method whenever you create a new version of the local file. For example, you would call this method if you used [ReplaceWithStreamedFileAsync](../windows.storage/storagefile_replacewithstreamedfileasync_1583738949.md) or [ReplaceWithStreamedFileFromUriAsync](../windows.storage/storagefile_replacewithstreamedfilefromuriasync_341848393.md) to download the latest version of the file, or if the remote version of the file was renamed.

## -examples

## -see-also
