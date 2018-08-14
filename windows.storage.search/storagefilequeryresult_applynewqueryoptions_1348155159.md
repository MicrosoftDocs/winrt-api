---
-api-id: M:Windows.Storage.Search.StorageFileQueryResult.ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public void ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions newQueryOptions)
-->

# Windows.Storage.Search.StorageFileQueryResult.ApplyNewQueryOptions

## -description
Modifies query results based on new [QueryOptions](queryoptions.md).

## -parameters
### -param newQueryOptions
The new query options.

## -remarks
This method causes the [OptionsChanged](storagefilequeryresult_optionschanged.md) event to fire.

When this method returns, subsequent calls to [GetFilesAsync](storagefilequeryresult_getfilesasync_1261374131.md) or [GetItemCountAsync](storagefilequeryresult_getitemcountasync_1115995255.md) will reflect the results of the new [QueryOptions](queryoptions.md).

## -examples

## -see-also
