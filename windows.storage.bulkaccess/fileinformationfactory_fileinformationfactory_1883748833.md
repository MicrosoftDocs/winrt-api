---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.#ctor(Windows.Storage.Search.IStorageQueryResultBase,Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions)
-api-type: winrt method
---

<!-- Method syntax
public FileInformationFactory(Windows.Storage.Search.IStorageQueryResultBase queryResult, Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedThumbnailSize, Windows.Storage.FileProperties.ThumbnailOptions thumbnailOptions)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.FileInformationFactory

## -description
Creates a new [FileInformationFactory](fileinformationfactory.md) object that retrieves information about the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects in the specified query result, and that specifies the requested size and options for thumbnails that are retrieved for the objects.

## -parameters
### -param queryResult
The result of a query of files and folders on the system.

To learn about query result objects, see [StorageFileQueryResult](../windows.storage.search/storagefilequeryresult.md), [StorageFolderQueryResult](../windows.storage.search/storagefolderqueryresult.md), and [StorageItemQueryResult](../windows.storage.search/storageitemqueryresult.md).

### -param mode
A value that indicates the type of thumbnail view to retrieve for the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md).

### -param requestedThumbnailSize
The requested minimum size, in pixels, of the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) thumbnails.

If thumbnails are not required for [IStorageItemInformation](istorageiteminformation.md) objects, set the *requestedSize* to 0.

### -param thumbnailOptions
The thumbnail retrieval options.

If you're using [FileInformationFactory](fileinformationfactory.md) with the JavaScript [ListView](/previous-versions/windows/apps/br211837(v=win.10)) or XAML [ListView](../windows.ui.xaml.controls/listview.md) and [GridView](../windows.ui.xaml.controls/gridview.md) controls, don't specify [ThumbnailOptions.ReturnOnlyIfCached](../windows.storage.fileproperties/thumbnailoptions.md) because this mode may prevent the control from being correctly populated with thumbnails.

## -remarks

## -examples

## -see-also
[FileInformationFactory(IStorageQueryResultBase, ThumbnailMode)](fileinformationfactory_fileinformationfactory_1050608051.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32)](fileinformationfactory_fileinformationfactory_829504087.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions, Boolean)](fileinformationfactory_fileinformationfactory_1666057761.md)