---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.CreateItemQueryWithOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageItemQueryResult CreateItemQueryWithOptions(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.CreateItemQueryWithOptions

## -description
Retrieves an object with the specified options for enumerating the files and folders in a storage location and subscribing to events that fire when the contents of the storage location change.

## -parameters
### -param queryOptions
The options for filtering the query results.

## -returns
An object for enumerating storage items and subscribing to events.

## -remarks
Don't set [QueryOptions.FolderDepth](queryoptions_folderdepth.md) to [FolderDepth.Deep](folderdepth.md); deep queries do not work if you are querying files in a Digital Living Network Alliance (DLNA) device.

## -examples

## -see-also
