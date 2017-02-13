---
-api-id: M:Windows.Storage.StorageFolder.RenameAsync(System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenameAsync(System.String desiredName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.StorageFolder.RenameAsync

## -description
Renames the current folder and specifies what to do if a folder with the same name already exists.

## -parameters
### -param desiredName
The desired, new name for the current folder.

If there is an existing item in the current folder's location that already has the specified *desiredName*, the specified [NameCollisionOption](namecollisionoption.md) determines how Windows responds to the conflict.

### -param option
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing item in the current folder's location.

## -returns
No object or value is returned by this method when it completes.

## -remarks

## -examples

## -see-also
[RenameAsync(String)](storagefolder_renameasync_247762898.md)