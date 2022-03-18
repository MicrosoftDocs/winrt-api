---
-api-id: M:Windows.Storage.StorageFolder.IsEqual(Windows.Storage.IStorageItem)
-api-type: winrt method
---

<!-- Method syntax
public bool IsEqual(Windows.Storage.IStorageItem item)
-->

# Windows.Storage.StorageFolder.IsEqual

## -description
Indicates whether the current folder is equal to the specified folder.

## -parameters
### -param item
The [IStorageItem](istorageitem.md) object that represents the folder to compare against.

## -returns
Returns true if the current folder is equal to the specified folder; otherwise false.

## -remarks
Use the IsEqual method to determine whether two items represent the same folder.

This method compares the [Path](storagefolder_path.md) property of both items to determine if they are the same. If there is no [Path](storagefolder_path.md) (if the item is a library for example), or if the paths do not match the items are compared using [IShellItem.Compare](/windows/desktop/api/shobjidl_core/nf-shobjidl_core-ishellitem-compare).

## -examples

## -see-also
[StorageFile.IsEqual](storagefile_isequal_1221320574.md)
