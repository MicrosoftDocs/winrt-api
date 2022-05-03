---
-api-id: M:Windows.Storage.StorageFile.MoveAsync(Windows.Storage.IStorageFolder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MoveAsync(Windows.Storage.IStorageFolder destinationFolder)
-->

# Windows.Storage.StorageFile.MoveAsync

## -description

Moves the current file to the specified folder.

## -parameters

### -param destinationFolder

The destination folder where the file is moved.

This destination folder must be a physical location. Otherwise, if the destination folder exists only in memory, like a file group, this method fails and throws a **System.Exception** with the following message: **Value does not fall within the expected range.**

## -returns

No object or value is returned by this method.

## -remarks

## -examples

## -see-also

[MoveAsync(IStorageFolder, String)](storagefile_moveasync_812150522.md), [MoveAsync(IStorageFolder, String, NameCollisionOption)](storagefile_moveasync_1322093618.md)
