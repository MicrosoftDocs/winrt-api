---
-api-id: M:Windows.Storage.Search.StorageItemQueryResult.ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public void ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions newQueryOptions)
-->

# Windows.Storage.Search.StorageItemQueryResult.ApplyNewQueryOptions

## -description
Modifies query results based on new [QueryOptions](queryoptions.md).

## -parameters
### -param newQueryOptions
The new query options.

## -remarks
This method causes the [OptionsChanged](storagefilequeryresult_optionschanged.md) event to fire.

When this method returns, subsequent calls to [GetItemsAsync](storageitemqueryresult_getitemsasync_1518547059.md) or [GetItemCountAsync](storagefolderqueryresult_getitemcountasync_1115995255.md) will reflect the results of the new [QueryOptions](queryoptions.md).

## -examples

## -see-also
