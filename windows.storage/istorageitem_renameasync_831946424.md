---
-api-id: M:Windows.Storage.IStorageItem.RenameAsync(System.String,Windows.Storage.NameCollisionOption)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RenameAsync(System.String desiredName, Windows.Storage.NameCollisionOption option)
-->

# Windows.Storage.IStorageItem.RenameAsync

## -description
Renames the current item. This method also specifies what to do if an existing item in the current item's location has the same name.

## -parameters
### -param desiredName
The desired, new name of the current item.

If there is an existing item in the current item's location that already has the specified *desiredName*, the specified [NameCollisionOption](namecollisionoption.md) determines how Windows responds to the conflict.

### -param option
The enum value that determines how Windows responds if the *desiredName* is the same as the name of an existing item in the current item's location.

## -returns
No object or value is returned by this method when it completes.

## -remarks

## -examples

## -see-also
[RenameAsync(String)](istorageitem_renameasync_247762898.md)