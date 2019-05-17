---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.#ctor(Windows.Storage.Search.IStorageQueryResultBase,Windows.Storage.FileProperties.ThumbnailMode)
-api-type: winrt method
---

<!-- Method syntax
public FileInformationFactory(Windows.Storage.Search.IStorageQueryResultBase queryResult, Windows.Storage.FileProperties.ThumbnailMode mode)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.FileInformationFactory

## -description
Creates a new [FileInformationFactory](fileinformationfactory.md) object that retrieves information about the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects in the specified query result.

## -parameters
### -param queryResult
The result of a query of files and folders on the system.

To learn about query result objects, see [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), and [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md).

### -param mode
A value that indicates the type of thumbnail view to retrieve for the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md).

## -remarks
If the query specified [SetThumbnailPrefetch](../windows.storage.search/queryoptions_setthumbnailprefetch_2085714012.md) options, those options are overridden by options requested in any of the FileInformationFactory constructors.

## -examples

## -see-also
[FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32)](fileinformationfactory_fileinformationfactory_829504087.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions)](fileinformationfactory_fileinformationfactory_1883748833.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions, Boolean)](fileinformationfactory_fileinformationfactory_1666057761.md)
