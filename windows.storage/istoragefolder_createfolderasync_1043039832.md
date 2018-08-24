---
-api-id: M:Windows.Storage.IStorageFolder.CreateFolderAsync(System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFolder> CreateFolderAsync(System.String desiredName, Windows.Storage.CreationCollisionOption options)
-->

# Windows.Storage.IStorageFolder.CreateFolderAsync

## -description
Creates a new folder in the current folder, and specifies what to do if a folder with the same name already exists in the current folder.

## -parameters
### -param desiredName
The desired name of the folder to create.

If there is an existing folder in the current folder that already has the specified *desiredName*, the specified [CreationCollisionOption](creationcollisionoption.md) determines how Windows responds to the conflict.

### -param options
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing folder in the current folder.

## -returns
When this method completes, it returns the new folder as a [StorageFolder](storagefolder.md).

## -remarks

## -examples

## -see-also
[CreateFolderAsync(String)](istoragefolder_createfolderasync_660577586.md), [StorageFolder.CreateFolderAsync](/uwp/api/windows.storage.storagefolder.createfolderasync)