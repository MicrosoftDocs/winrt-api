---
-api-id: P:Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax
public Windows.Storage.AccessCache.StorageItemMostRecentlyUsedList MostRecentlyUsedList { get; }
-->

# Windows.Storage.AccessCache.StorageApplicationPermissions.MostRecentlyUsedList

## -description
Gets an object that represents a list that an app can use to track the files and/or locations (like folders) that the app has accessed most recently.

## -property-value
The most recently used (MRU) list object.

## -remarks
If you want to respond to [ItemRemoved](storageitemmostrecentlyusedlist_itemremoved.md) events, you must register your event handler every time you get a new reference to the [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md).

## -examples

## -see-also
