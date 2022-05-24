---
-api-id: M:Windows.Storage.StorageFile.CopyAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.StorageFile.CopyAsync

## -description
Creates a copy of the file in the specified folder and renames the copy. This method also specifies what to do if a file with the same name already exists in the destination folder.

## -parameters
### -param destinationFolder
The destination folder where the copy of the file is created.

### -param desiredNewName
The new name for the copy of the file created in the *destinationFolder*.

### -param option
One of the enumeration values that determines how to handle the collision if a file with the specified *desiredNewName* already exists in the destination folder.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the copy of the file created in the *destinationFolder*.

> [!NOTE]
> When StorageFile.CopyAsync is used to copy a file that is encrypted to a destination that is not encrypted, the call will fail with the following exception: `System.UnauthorizedAccessException: Access is denied. (Excep_FromHResult 0x80070005)`

## -exceptions
### T:System.UnauthorizedAccessException

You don't have permission to copy a file into the destination folder.

## -remarks

## -examples

## -see-also
[CopyAsync(IStorageFolder)](storagefile_copyasync_690062730.md), [CopyAsync(IStorageFolder, String)](storagefile_copyasync_1709017142.md)