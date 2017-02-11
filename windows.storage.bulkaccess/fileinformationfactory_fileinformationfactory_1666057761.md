---
-api-id: M:Windows.Storage.BulkAccess.FileInformationFactory.#ctor(Windows.Storage.Search.IStorageQueryResultBase,Windows.Storage.FileProperties.ThumbnailMode,System.UInt32,Windows.Storage.FileProperties.ThumbnailOptions,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public FileInformationFactory(Windows.Storage.Search.IStorageQueryResultBase queryResult, Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedThumbnailSize, Windows.Storage.FileProperties.ThumbnailOptions thumbnailOptions, System.Boolean delayLoad)
-->

# Windows.Storage.BulkAccess.FileInformationFactory.FileInformationFactory

## -description
Creates a new [FileInformationFactory](fileinformationfactory.md) object that retrieves information about the [StorageFile](../windows.storage/storagefile.md) and [StorageFolder](../windows.storage/storagefolder.md) objects in the specified query result, specifies the requested size and options for thumbnails that are retrieved for the objects, and indicates whether to delay loading information.
<!--{annotation author="grerol" time="6/27/2011 2:23:27 PM"}TODO: What's the delay option for?-->

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

If you're using [FileInformationFactory](fileinformationfactory.md) with the JavaScript [ListView](http://msdn.microsoft.com/library/c58cccc9-7f85-4b13-a0d5-7f584f2ca4e6) or XAML [ListView](../windows.ui.xaml.controls/listview.md) and [GridView](../windows.ui.xaml.controls/gridview.md) controls, don't specify [ThumbnailOptions.ReturnOnlyIfCached](../windows.storage.fileproperties/thumbnailoptions.md) because this mode may prevent the control from being correctly populated with thumbnails.

### -param delayLoad
True to delay loading information; otherwise false. By default, this option is false and delay loading is not used.

If *delayLoad* is true, it authorizes the [FileInformationFactory](fileinformationfactory.md) to return [IStorageItemInformation](istorageiteminformation.md) objects before thumbnails are available. Subsequently, the system fires a [ThumbnailUpdated](istorageiteminformation_thumbnailupdated.md) event when thumbnails become available. Using delay loading is recommended because it makes apps seem more responsive.

If *delayLoad* is false (as it is by default), the system will require more time to retrieve [IStorageItemInformation](istorageiteminformation.md) objects, but after the objects are retrieved all cached thumbnails will be accessible synchronously. Thumbnails that are not cached must still be accessed asynchronously in response to the [ThumbnailUpdated](istorageiteminformation_thumbnailupdated.md) event.

## -remarks

## -examples

## -see-also
[FileInformationFactory(IStorageQueryResultBase, ThumbnailMode)](fileinformationfactory_fileinformationfactory_1050608051.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32)](fileinformationfactory_fileinformationfactory_829504087.md), [FileInformationFactory(IStorageQueryResultBase, ThumbnailMode, UInt32, ThumbnailOptions)](fileinformationfactory_fileinformationfactory_1883748833.md)