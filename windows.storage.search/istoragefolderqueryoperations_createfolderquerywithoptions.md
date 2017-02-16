---
-api-id: M:Windows.Storage.Search.IStorageFolderQueryOperations.CreateFolderQueryWithOptions(Windows.Storage.Search.QueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Search.StorageFolderQueryResult CreateFolderQueryWithOptions(Windows.Storage.Search.QueryOptions queryOptions)
-->

# Windows.Storage.Search.IStorageFolderQueryOperations.CreateFolderQueryWithOptions

## -description
Retrieves an object with the specified options for enumerating folders in a storage location and subscribing to events that fire when the contents of the storage location change.

## -parameters
### -param queryOptions
The options for filtering the query results.

## -returns
An object for enumerating folders and subscribing to events.

## -remarks
You can use [QueryOptions](queryoptions.md) and [CreateFileQueryWithOptions](istoragefolderqueryoperations_createfilequerywithoptions.md) to create an indexed backed file query that lets you get properties that rely on another app's property handler. For more information see [QueryOptions](queryoptions.md).

## -examples

## -see-also
