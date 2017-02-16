---
-api-id: M:Windows.Storage.BulkAccess.FileInformation.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode, System.UInt32 requestedSize)
-->

# Windows.Storage.BulkAccess.FileInformation.GetThumbnailAsync

## -description
Retrieves the thumbnail that is associated with the [StorageFile](../windows.storage/storagefile.md), scaling it to the specified size.

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
[GetThumbnailAsync(ThumbnailMode)](fileinformation_getthumbnailasync_1575071988.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](fileinformation_getthumbnailasync_91362086.md)