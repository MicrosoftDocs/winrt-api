---
-api-id: T:Windows.Storage.AccessCache.AccessCacheOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.AccessCache.AccessCacheOptions : uint
-->

# AccessCacheOptions

## -description
Describes the behavior to use when the app accesses an item in a list.

## -enum-fields
### -field None:0
Default.

When the app accesses the item, the app retrieves the most current version of the item from any available location and, if necessary, the user can enter additional information.

### -field DisallowUserInput:1
When the app accesses the item, the user is prevented from entering information.

For example, if the app accesses a file that is stored using this option and the file normally triggers a request for the user to enter credentials, the request is suppressed.

### -field FastLocationsOnly:2
When the app accesses the item, it is retrieved from a fast location like the local file system.

For example, if the app accesses a file that is stored using this option and a version of the file is only available remotely, the file will not be accessed.

### -field UseReadOnlyCachedCopy:4
When the app accesses the item, the app retrieves a cached, read-only version of the file. This version of the file might not be the most recent.

### -field SuppressAccessTimeUpdate:8
When the app accesses the item in the [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md), Windows preserves the item's current position in the most recently used (MRU) and does not update the access time of the item.


## -remarks

## -examples

## -see-also