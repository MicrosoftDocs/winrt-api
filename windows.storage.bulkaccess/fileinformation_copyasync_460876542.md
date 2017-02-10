---
-api-id: M:Windows.Storage.BulkAccess.FileInformation.CopyAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CopyAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.BulkAccess.FileInformation.CopyAsync

## -description
Creates a copy of the [StorageFile](../windows.storage/storagefile.md), gives it the specified file name, and stores it in the specified [StorageFolder](../windows.storage/storagefolder.md). The method also specifies what to do if a file with the same name already exists in the specified folder.

## -parameters
### -param destinationFolder
The folder in which to store the copied file.

### -param desiredNewName
The name of the new copy.

### -param option
A value that indicates what to do if the file name already exists in the destination folder.

## -returns
When this method completes successfully, it returns the copy as a [StorageFile](../windows.storage/storagefile.md) object.

## -remarks

## -examples

## -see-also
[CopyAsync(IStorageFolder)](fileinformation_copyasync_690062730.md), [CopyAsync(IStorageFolder, String)](fileinformation_copyasync_1709017142.md)