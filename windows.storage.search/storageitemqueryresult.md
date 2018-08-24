---
-api-id: T:Windows.Storage.Search.StorageItemQueryResult
-api-type: winrt class
---

<!-- Class syntax.
public class StorageItemQueryResult : Windows.Storage.Search.IStorageItemQueryResult, Windows.Storage.Search.IStorageQueryResultBase
-->

# Windows.Storage.Search.StorageItemQueryResult

## -description
Provides access to the results of a query that lists all items including files and folders (or file groups) in the folder being queried (which is represented by a [storageFolder](../windows.storage/storagefolder.md)). You can use [storageItemQueryResult](storageitemqueryresult.md) to enumerate the files and folders in that [storageFolder](../windows.storage/storagefolder.md).

## -remarks
> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275).
<!--W8B 988884 v2-->

You can get a [storageItemQueryResult](storageitemqueryresult.md) object by calling the following methods from a [storageFolder](../windows.storage/storagefolder.md) or a [folderInformation](../windows.storage.bulkaccess/folderinformation.md) object:

+ [storageFolder.createItemQuery](../windows.storage/storagefolder_createitemquery_543424716.md) methods
+ [storageFolder.createItemQueryWithOptions](../windows.storage/storagefolder_createitemquerywithoptions_1519361285.md) method
+ [folderInformation.createItemQuery](../windows.storage.bulkaccess/folderinformation_createitemquery_543424716.md) methods
+ [folderInformation.createItemQueryWithOptions](../windows.storage.bulkaccess/folderinformation_createitemquerywithoptions_1519361285.md) method
For related code examples, see [storageFileQueryResult](storagefilequeryresult.md), [storageFolderQueryResult](storagefolderqueryresult.md), the [Folder enumeration sample](http://go.microsoft.com/fwlink/p/?linkid=231512), and the [File system search sample](http://go.microsoft.com/fwlink/p/?linkid=231532).

## -examples

## -see-also
[storageItemQueryResult class](storageitemqueryresult.md), [storageItemQueryResult.getItemsAsync methods](storageitemqueryresult_getitemsasync_1518547059.md), [Windows.Storage.storageFolder.createItemQuery methods](../windows.storage/storagefolder_createitemquery_543424716.md), [Windows.Storage.storageFolder.createItemQueryWithOptions method](../windows.storage/storagefolder_createitemquerywithoptions_1519361285.md), [Windows.Storage.BulkAccess.folderInformation.createItemQuery methods](../windows.storage.bulkaccess/folderinformation_createitemquery_543424716.md), [Windows.Storage.BulkAccess.folderInformation.createItemQueryWithOptions method](../windows.storage.bulkaccess/folderinformation_createitemquerywithoptions_1519361285.md)