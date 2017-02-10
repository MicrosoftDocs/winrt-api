---
-api-id: P:Windows.Storage.IStorageItem.Path
-api-type: winrt property
---

<!-- Property syntax
public string Path { get; }
-->

# Windows.Storage.IStorageItem.Path

## -description
Gets the full file-system path of the item, if the item has a path.

## -property-value
The full path of the item, if the item has a path in the user's file-system.

## -remarks
Do not rely on this property to access an item because some items may not have file-system paths. For example if the item is backed by a URI, or was picked using the file picker, the item is not guaranteed to have a file-system path.

## -examples

## -see-also
