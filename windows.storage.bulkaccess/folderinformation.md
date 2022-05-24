---
-api-id: T:Windows.Storage.BulkAccess.FolderInformation
-api-type: winrt class
---

<!-- Class syntax.
public class FolderInformation : Windows.Storage.BulkAccess.IStorageItemInformation, Windows.Storage.IStorageFolder, Windows.Storage.IStorageFolder2, Windows.Storage.IStorageItem, Windows.Storage.IStorageItem2, Windows.Storage.IStorageItemProperties, Windows.Storage.IStorageItemPropertiesWithProvider, Windows.Storage.Search.IStorageFolderQueryOperations
-->

# Windows.Storage.BulkAccess.FolderInformation

## -description
Provides synchronous access to the properties exposed off [StorageFolder](../windows.storage/storagefolder.md) and lets an app perform asynchronous management operations such as delete and rename.

## -remarks
> [!NOTE]
> Although it's not attributed with `marshalling_behavior(agile)`, this class can be treated as agile. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).
<!--W8B 988884 v2-->

You can retrieve a list of FolderInformation objects by calling one of the [FileInformationFactory.GetFoldersAsync](fileinformationfactory_getfoldersasync_1487375516.md) methods.

## -examples


## -see-also
[FileInformationFactory.GetFoldersAsync](fileinformationfactory_getfoldersasync_1487375516.md), [IStorageItemInformation](istorageiteminformation.md), [IStorageFolder](../windows.storage/istoragefolder.md), [IStorageItem](../windows.storage/istorageitem.md), [IStorageItemProperties](../windows.storage/istorageitemproperties.md), [IStorageFolderQueryOperations](../windows.storage.search/istoragefolderqueryoperations.md), [IStorageItem2](../windows.storage/istorageitem2.md), [IStorageFolder2](../windows.storage/istoragefolder2.md), [IStorageItemPropertiesWithProvider](../windows.storage/istorageitempropertieswithprovider.md)
