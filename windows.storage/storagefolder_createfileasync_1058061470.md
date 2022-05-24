---
-api-id: M:Windows.Storage.StorageFolder.CreateFileAsync(System.String,Windows.Storage.CreationCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> CreateFileAsync(System.String desiredName, Windows.Storage.CreationCollisionOption options)
-->

# Windows.Storage.StorageFolder.CreateFileAsync

## -description
Creates a new file in the current folder. This method also specifies what to do if a file with the same name already exists in the current folder.

## -parameters
### -param desiredName
The name of the new file to create in the current folder.

### -param options
One of the enumeration values that determines how to handle the collision if a file with the specified *desiredName* already exists in the current folder.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) that represents the new file.

## -exceptions
### T:System.Exception

You specified **CreationCollisionOption.FailIfExists** and a file with the specified *desiredName* already exists in the current folder.

### T:System.IO.FileNotFoundException

The format of the filename is incorrect. Check the value of *desiredName*.

### T:System.UnauthorizedAccessException

You don't have permission to create a file in the current folder.

## -remarks

## -examples

## -see-also
[CreateFileAsync(String)](storagefolder_createfileasync_644130808.md)