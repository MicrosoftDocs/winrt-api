---
-api-id: M:Windows.Storage.Search.IStorageQueryResultBase.ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public void ApplyNewQueryOptions(Windows.Storage.Search.QueryOptions newQueryOptions)
-->

# Windows.Storage.Search.IStorageQueryResultBase.ApplyNewQueryOptions

## -description
Applies new query options to the results retrieved by the [StorageFileQueryResult](storagefilequeryresult.md), [StorageFolderQueryResult](storagefolderqueryresult.md), or [StorageItemQueryResult](storageitemqueryresult.md) object.

## -parameters
### -param newQueryOptions
The new query options.

## -remarks
When this method returns, the contents of the query and the count of items reflect the new query options.

This method causes the [OptionsChanged](istoragequeryresultbase_optionschanged.md) event to fire.

## -examples

## -see-also
