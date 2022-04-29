---
-api-id: M:Windows.Storage.StorageFile.MoveAsync(Windows.Storage.IStorageFolder,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MoveAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName)
-->

# Windows.Storage.StorageFile.MoveAsync

## -description

Moves the current file to the specified folder and renames the file according to the desired name.

## -parameters

### -param destinationFolder

The destination folder where the file is moved.

This destination folder must be a physical location. Otherwise, if the destination folder exists only in memory, like a file group, this method fails and throws a **System.Exception** with the following message: **Value does not fall within the expected range.**

### -param desiredNewName

The desired name of the file after it is moved.

If there is an existing file in the destination folder that already has the specified *desiredNewName*, Windows generates a unique name for the file.

## -returns

No object or value is returned by this method.

## -remarks

## -examples

## -see-also

[MoveAsync(IStorageFolder)](storagefile_moveasync_2090099526.md), [MoveAsync(IStorageFolder, String, NameCollisionOption)](storagefile_moveasync_1322093618.md)
