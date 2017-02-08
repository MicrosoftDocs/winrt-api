---
-api-id: M:Windows.Storage.StorageFile.DeleteAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteAsync()
-->

# Windows.Storage.StorageFile.DeleteAsync

## -description
Deletes the current file.

## -returns
No object or value is returned by this method when it completes.

## -remarks
This method uses [StorageDeleteOption.default](storagedeleteoption.md) to determine whether the item is deleted permanently.

**FileNotFoundException** is thrown if the file does not exist..

## -examples

## -see-also
[DeleteAsync(StorageDeleteOption)](storagefile_deleteasync_175645079.md)