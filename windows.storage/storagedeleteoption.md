---
-api-id: T:Windows.Storage.StorageDeleteOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.StorageDeleteOption : int
-->

# StorageDeleteOption

## -description
Specifies whether a deleted item is moved to the Recycle Bin or permanently deleted.

## -enum-fields
### -field Default:0
Specifies the default behavior.


+ If the item is in an application storage location (that is, a location that can be accessed through the [ApplicationData](applicationdata.md) class), it's permanently deleted. It's not moved to the Recycle Bin.
+ If the item is in another location, the item is deleted according to the default behavior of File Explorer for that location. The item may be moved to the Recycle Bin, or it may be permanently deleted.


### -field PermanentDelete:1
Permanently deletes the item. The item is not moved to the Recycle Bin.


## -remarks

## -examples

## -see-also