---
-api-id: M:Windows.Storage.AccessCache.StorageItemAccessList.GetItemAsync(System.String,Windows.Storage.AccessCache.AccessCacheOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.IStorageItem> GetItemAsync(System.String token, Windows.Storage.AccessCache.AccessCacheOptions options)
-->

# Windows.Storage.AccessCache.StorageItemAccessList.GetItemAsync

## -description
Retrieves the specified item (like a file or folder) from the list using the specified options.

## -parameters
### -param token
The token of the item to retrieve.

### -param options
The enum value that describes the behavior to use when the app accesses the item.

## -returns
When this method completes successfully, it returns the item (type [IStorageItem](../windows.storage/istorageitem.md)) that is associated with the specified *token*.

## -remarks

## -examples

## -see-also
[GetItemAsync(String)](storageitemaccesslist_getitemasync_1847090456.md), [IStorageItem](../windows.storage/istorageitem.md)