---
-api-id: M:Windows.Storage.IStorageFile.MoveAsync(Windows.Storage.IStorageFolder,System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MoveAsync(Windows.Storage.IStorageFolder destinationFolder, System.String desiredNewName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.IStorageFile.MoveAsync

## -description
Moves the current file to the specified folder and renames the file according to the desired name. This method also specifies what to do if a file with the same name already exists in the specified folder.

## -parameters
### -param destinationFolder
The destination folder where the file is moved.

This destination folder must be a physical location. Otherwise, if the destination folder exists only in memory, like a file group, this method fails and throws an exception.








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
[MoveAsync(IStorageFolder)](istoragefile_moveasync_2090099526.md), [MoveAsync(IStorageFolder, String)](istoragefile_moveasync_812150522.md), [MoveAsync](storagefile_moveasync.md)