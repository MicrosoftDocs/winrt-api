---
-api-id: P:Windows.Storage.StorageFolder.FolderRelativeId
-api-type: winrt property
---

<!-- Property syntax
public string FolderRelativeId { get; }
-->

# Windows.Storage.StorageFolder.FolderRelativeId

## -description
Gets an identifier for the current folder. This ID is unique for the query result or [StorageFolder](storagefolder.md) that contains the current folder or file group, and can be used to distinguish between items that have the same name.

## -property-value
The identifier for the current folder or file group within a query result or [StorageFolder](storagefolder.md).

## -remarks
You create a query result object when you create a query using one of the methods on a [StorageFolder](storagefolder.md) object. Depending on the method you call, your query result object could be a [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), a [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), or a [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md) object.

## -examples

## -see-also
