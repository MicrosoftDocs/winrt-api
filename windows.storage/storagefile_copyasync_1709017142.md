---
-api-id: M:Windows.Storage.StorageFile.CopyAsync(Windows.Storage.IStorageFolder,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName)
-->

# Windows.Storage.StorageFile.CopyAsync

## -description
Creates a copy of the file in the specified folder and renames the copy.

## -parameters
### -param destinationFolder
The destination folder where the copy of the file is created.

### -param desiredNewName
The new name for the copy of the file created in the *destinationFolder*.

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
[CopyAsync(IStorageFolder)](storagefile_copyasync_690062730.md), [CopyAsync(IStorageFolder, String, NameCollisionOption)](storagefile_copyasync_460876542.md)