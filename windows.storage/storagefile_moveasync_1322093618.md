---
-api-id: M:Windows.Storage.StorageFile.MoveAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MoveAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.StorageFile.MoveAsync

## -description
Moves the current file to the specified folder and renames the file according to the desired name. This method also specifies what to do if a file with the same name already exists in the specified folder.

## -parameters
### -param destinationFolder
The destination folder where the file is moved.

This destination folder must be a physical location. Otherwise, if the destination folder exists only in memory, like a file group, this method fails and throws an exception.


<!--{annotation author="miriamw" time="3/5/2012 3:45:21 PM"}Moving to a file group fails with E_INVALIDARG (as of Beta)-->

<!--{annotation author="miriamw" time="3/5/2012 3:33:48 PM"}TODO: Confirm that moving files into libraries (and creating files there) works as expected. Note, can def create in the Doc Lib folder, directly. Not *sure* about moving.-->

<!--{annotation author="miriamw" time="3/5/2012 3:33:48 PM"}TODO: Can it be a remote location? Or can it be a file-system location, only?-->

### -param desiredNewName
The desired name of the file after it is moved.

If there is an existing file in the destination folder that already has the specified *desiredNewName*, the specified [NameCollisionOption](namecollisionoption.md) determines how Windows responds to the conflict.

### -param option
An enum value that determines how Windows responds if the *desiredNewName* is the same as the name of an existing file in the destination folder.

## -returns
No object or value is returned by this method.

## -remarks

## -examples

## -see-also
[MoveAsync(IStorageFolder)](storagefile_moveasync_2090099526.md), [MoveAsync(IStorageFolder, String)](storagefile_moveasync_812150522.md)