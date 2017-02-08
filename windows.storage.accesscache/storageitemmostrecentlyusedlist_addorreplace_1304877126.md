---
-api-id: M:Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList.AddOrReplace(System.String,Windows.Storage.IStorageItem,System.String,Windows.Storage.AccessCache.RecentStorageItemVisibility)
-api-type: winrt method
---

<!-- Method syntax
public void AddOrReplace(System.String token, Windows.Storage.IStorageItem file, System.String metadata, Windows.Storage.AccessCache.RecentStorageItemVisibility visibility)
-->

# Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList.AddOrReplace

## -description
Adds a new storage item and accompanying metadata to the most recently used (MRU) list, or replaces the specified item if it already exists in the list. Also specifies the extent of its visibility in the list.

## -parameters
### -param token
The token associated with the new storage item. If the access list already contains a storage item that has this token, the new item replaces the existing one.

### -param file
The storage item to add or replace.

### -param metadata
Optional metadata to associate with the storage item.

### -param visibility
The extent of the visibility of the storage item in the list.

## -remarks

## -examples

## -see-also
[AddOrReplace(String, IStorageItem)](storageitemmostrecentlyusedlist_addorreplace_1991369802.md), [AddOrReplace(String, IStorageItem, String)](storageitemmostrecentlyusedlist_addorreplace_280363210.md)