---
-api-id: M:Windows.Storage.IStorageFile.MoveAsync(Windows.Storage.IStorageFolder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MoveAsync(Windows.Storage.IStorageFolder destinationFolder)
-->

# Windows.Storage.IStorageFile.MoveAsync

## -description
Moves the current file to the specified folder.

## -parameters
### -param destinationFolder
The destination folder where the file is moved.

This destination folder must be a physical location. Otherwise, if the destination folder exists only in memory, like a file group, this method fails and throws an exception.


<!--{annotation author="miriamw" time="3/5/2012 3:45:21 PM"}Moving to a file group fails with E_INVALIDARG (as of Beta)-->

<!--{annotation author="miriamw" time="3/5/2012 3:33:48 PM"}TODO: Confirm that moving files into libraries (and creating files there) works as expected. Note, can def create in the Doc Lib folder, directly. Not *sure* about moving.-->

<!--{annotation author="miriamw" time="3/5/2012 3:33:48 PM"}TODO: Can it be a remote location? Or can it be a file-system location, only?-->

## -returns
No object or value is returned by this method.

## -remarks

## -examples

## -see-also
[MoveAsync(IStorageFolder, String)](istoragefile_moveasync_812150522.md), [MoveAsync(IStorageFolder, String, NameCollisionOption)](istoragefile_moveasync_1322093618.md), [StorageFile.MoveAsync](storagefile_moveasync.md)