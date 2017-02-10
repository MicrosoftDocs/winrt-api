---
-api-id: M:Windows.Storage.IStorageFile.CopyAsync(Windows.Storage.IStorageFolder,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName)
-->

# Windows.Storage.IStorageFile.CopyAsync

## -description
Creates a copy of the file in the specified folder, using the desired name.

## -parameters
### -param destinationFolder
The destination folder where the copy is created.

### -param desiredNewName
The desired name of the copy.

If there is an existing file in the destination folder that already has the specified *desiredNewName*, Windows generates a unique name for the copy.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the copy.

## -remarks

## -examples

## -see-also
[CopyAsync(IStorageFolder)](istoragefile_copyasync_690062730.md), [CopyAsync(IStorageFolder, String, NameCollisionOption)](istoragefile_copyasync_460876542.md), [StorageFile.CopyAsync](storagefile_copyasync.md)