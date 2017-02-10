---
-api-id: M:Windows.Storage.IStorageFile.CopyAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.IStorageFile.CopyAsync

## -description
Creates a copy of the file in the specified folder, using the desired name. This method also specifies what to do if an existing file in the specified folder has the same name.

## -parameters
### -param destinationFolder
The destination folder where the copy is created.

### -param desiredNewName
The desired name of the copy.

If there is an existing file in the destination folder that already has the specified *desiredNewName*, the specified [NameCollisionOption](namecollisionoption.md) determines how Windows responds to the conflict.

### -param option
An enum value that determines how Windows responds if the *desiredNewName* is the same as the name of an existing file in the destination folder.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the copy.

## -remarks

## -examples

## -see-also
[CopyAsync(IStorageFolder)](istoragefile_copyasync_690062730.md), [CopyAsync(IStorageFolder, String)](istoragefile_copyasync_1709017142.md), [StorageFile.CopyAsync](storagefile_copyasync.md)