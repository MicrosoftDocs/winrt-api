---
-api-id: M:Windows.Storage.AccessCache.StorageApplicationPermissions.GetMostRecentlyUsedListForUser(Windows.System.User)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public StorageItemMostRecentlyUsedList StorageApplicationPermissions.GetMostRecentlyUsedListForUser(User user)
-->

# Windows.Storage.AccessCache.StorageApplicationPermissions.GetMostRecentlyUsedListForUser

## -description
Gets an object that an app can use to track the files and/or locations (like folders) that the app has accessed most recently. This method returns an object that is scoped to the specified user. Use this method for [multi-user applications](/windows/uwp/xbox-apps/multi-user-applications).

## -parameters
### -param user
The user for which to create the most recently used (MRU) list object.

## -returns
The most recently used (MRU) list object.

## -remarks
If you want to respond to [ItemRemoved](storageitemmostrecentlyusedlist_itemremoved.md) events, you must register your event handler every time you get a new reference to the [StorageItemMostRecentlyUsedList](storageitemmostrecentlyusedlist.md).

## -see-also
[Introduction to multi-user applications](/windows/uwp/xbox-apps/multi-user-applications)

## -examples

