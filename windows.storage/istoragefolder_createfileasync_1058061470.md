---
-api-id: M:Windows.Storage.IStorageFolder.CreateFileAsync(System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileAsync(System.String desiredName, Windows.Storage.CreationCollisionOption options)
-->

# Windows.Storage.IStorageFolder.CreateFileAsync

## -description
Creates a new file in the current folder, and specifies what to do if a file with the same name already exists in the current folder.

## -parameters
### -param desiredName
The desired name of the file to create.

If there is an existing file in the current folder that already has the specified *desiredName*, the specified [CreationCollisionOption](creationcollisionoption.md) determines how Windows responds to the conflict.

### -param options
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing file in the current folder.

## -returns
When this method completes, it returns the new file as a [StorageFile](storagefile.md).

## -remarks

## -examples

## -see-also
[CreateFileAsync(String)](istoragefolder_createfileasync_644130808.md), [StorageFolder.CreateFileAsync](/uwp/api/windows.storage.storagefolder.createfileasync)