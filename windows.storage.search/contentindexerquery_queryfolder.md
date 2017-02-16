---
-api-id: P:Windows.Storage.Search.ContentIndexerQuery.QueryFolder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder QueryFolder { get; }
-->

# Windows.Storage.Search.ContentIndexerQuery.QueryFolder

## -description
Gets the [StorageFolder](storagefolderqueryresult.md) representation of the app-provided items in the [ContentIndexer](contentindexer.md) query.

## -property-value
The folder that contains app-provided content.

## -remarks
The [StorageFolder](../windows.storage/storagefolder.md) returned by the [QueryFolder](contentindexerquery_queryfolder.md) property is read-only. You can't change the properties of the folder or of the files that it contains.

## -examples

## -see-also
[ContentIndexer](contentindexer.md), [StorageFolder](storagefolderqueryresult.md)