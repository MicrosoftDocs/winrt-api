---
-api-id: P:Windows.Storage.StorageFile.FolderRelativeId
-api-type: winrt property
---

<!-- Property syntax
public string FolderRelativeId { get; }
-->

# Windows.Storage.StorageFile.FolderRelativeId

## -description
Gets an identifier for the file. This ID is unique for the query result or [StorageFolder](storagefolder.md) that contains the file and can be used to distinguish between items that have the same name.

## -property-value
The identifier for the file.

## -remarks
You create a query result object when you create a query using one of the methods on a [StorageFolder](storagefolder.md) object. Depending on the method you call, your query result object could be a [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), a [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), or a [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md) object.

## -examples

## -see-also
