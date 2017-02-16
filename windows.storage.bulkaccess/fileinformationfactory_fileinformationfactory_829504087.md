---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.#ctor(Windows.Storage.Search.IStorageQueryResultBase,Windows.Storage.FileProperties.ThumbnailMode,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public FileInformationFactory(Windows.Storage.Search.IStorageQueryResultBase queryResult, Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedThumbnailSize)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.FileInformationFactory

## -description
Creates a new [FileInformationFactory](fileinformationfactory.md) object that retrieves information about the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects in the specified query result and that specifies the requested size for thumbnails that are retrieved for the objects.

## -parameters
### -param queryResult
The result of a query of files and folders on the system.

To learn about query result objects, see [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), and [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md).

### -param mode
A value that indicates the type of thumbnail view to retrieve for the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md).

### -param requestedThumbnailSize
The requested minimum size, in pixels, of the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) thumbnails.

If thumbnails are not required for [IStorageItemInformation](istorageiteminformation.md) objects, set the *requestedSize* to 0.

## -remarks

## -examples

## -see-also
[FileInformationFactory(IStorageQueryResultBase, ThumbnailMode)](fileinformationfactory_fileinformationfactory_1050608051.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions)](fileinformationfactory_fileinformationfactory_1883748833.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions, Boolean)](fileinformationfactory_fileinformationfactory_1666057761.md)