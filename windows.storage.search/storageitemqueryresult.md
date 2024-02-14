---
-api-id: T:Windows.Storage.Search.StorageItemQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemQueryResult : Windows.Storage.Search.IStorageItemQueryResult, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageItemQueryResult

## -description
Provides access to the results of a query that lists all items including files and folders (or file groups) in the folder being queried (which is represented by a [StorageFolder](../windows.storage/storagefolder.md)). You can use storageItemQueryResult to enumerate the files and folders in that [StorageFolder](../windows.storage/storagefolder.md).

## -remarks
> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).
<!--W8B 988884 v2-->

You can get a storageItemQueryResult object by calling the following methods from a [StorageFolder](../windows.storage/storagefolder.md) or a [FolderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [StorageFolder.CreateItemQuery](../windows.storage/storagefolder_createitemquery_543424716.md) methods
+ [StorageFolder.CreateItemQueryWithOptions](../windows.storage/storagefolder_createitemquerywithoptions_1519361285.md) method
+ [FolderInformation.CreateItemQuery](../windows.storage.bulkaccess/folderinformation_createitemquery_543424716.md) methods
+ [FolderInformation.CreateItemQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createitemquerywithoptions_1519361285.md) method
For related code examples, see [storageFileQueryResult](storagefilequeryresult.md), [storageFolderQueryResult](storagefolderqueryresult.md), the [Folder enumeration sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/FolderEnumeration), and the [File search sample](https://github.com/microsoft/Windows-universal-samples/tree/main/Samples/FileSearch).

## -examples

## -see-also

[StorageItemQueryResult.GetItemsAsync methods](storageitemqueryresult_getitemsasync_1518547059.md), [Windows.Storage.StorageFolder.CreateItemQuery methods](../windows.storage/storagefolder_createitemquery_543424716.md), [Windows.Storage.StorageFolder.CreateItemQueryWithOptions method](../windows.storage/storagefolder_createitemquerywithoptions_1519361285.md), [Windows.Storage.BulkAccess.FolderInformation.CreateItemQuery methods](../windows.storage.bulkaccess/folderinformation_createitemquery_543424716.md), [Windows.Storage.BulkAccess.FolderInformation.CreateItemQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createitemquerywithoptions_1519361285.md)