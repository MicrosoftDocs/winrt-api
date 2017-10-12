---
-api-id: M:Windows.Storage.BulkAccess.FolderInformation.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize)
-->

# Windows.Storage.BulkAccess.FolderInformation.GetThumbnailAsync

## -description
Retrieves the thumbnail that is associated with the [StorageFolder](../windows.storage/storagefolder.md), scaling it to the specified size.


## -parameters
### -param mode
The thumbnail mode to retrieve.

### -param requestedSize
The requested size in pixels of thumbnail to retrieve.

## -returns
When this method completes successfully, it returns the thumbnail image as a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) object.

## -remarks

## -examples

## -see-also
[GetThumbnailAsync(ThumbnailMode)](folderinformation_getthumbnailasync_1575071988.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](folderinformation_getthumbnailasync_91362086.md)