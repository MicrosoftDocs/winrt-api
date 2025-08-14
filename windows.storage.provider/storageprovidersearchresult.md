---
-api-id: T:Windows.Storage.Provider.StorageProviderSearchResult
-api-type: winrt class
---

# Windows.Storage.Provider.StorageProviderSearchResult

<!--
public sealed class StorageProviderSearchResult : Windows.Storage.Provider.IStorageProviderQueryResult
-->

## -description

The class that the storage provider will use to return an individual search result.

## -remarks

This object will implement marshal by value to optimize RPC calls.

Includes the local [FilePath](storageprovidersearchresult_filepath.md) of the search result and a [RemoteFileId](storageprovidersearchresult_remotefileid.md). Any properties requested in the query options are also included.

## -see-also

## -examples
